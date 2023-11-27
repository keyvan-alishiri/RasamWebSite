﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Common;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Category;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Repositories
{
   public class CategoryRepository : ICategoryRepository
    {
        private readonly NewsDBContext _context;
        private readonly IMapper _mapper;
		private int _categoryItemCount = 0;

		List<BreadCrumbViewModel> breadCrumbViews = new List<BreadCrumbViewModel>();
		public CategoryRepository(NewsDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _context.CheckArgumentIsNull(nameof(_context));
        }
      public async Task<List<CategoryViewModel>> GetPaginateCategoriesAsync(int offset, int limit, string orderBy, string searchText)
      {
         List<CategoryViewModel> categories = await _context.Categories.GroupJoin(_context.Categories,
             (cl => cl.ParentCategoryId),
             (or => or.CategoryId),
             ((cl, or) => new { CategoryInfo = cl, ParentInfo = or }))
             .SelectMany(p => p.ParentInfo.DefaultIfEmpty(), (x, y) => new { x.CategoryInfo, ParentInfo = y })
             .OrderBy(orderBy)
             .Skip(offset).Take(limit)
             .Select(c => new CategoryViewModel { CategoryId = c.CategoryInfo.CategoryId, CategoryName = c.CategoryInfo.CategoryName, ParentCategoryId = c.ParentInfo.CategoryId, ParentCategoryName = c.ParentInfo.CategoryName }).AsNoTracking().ToListAsync();

         foreach (var item in categories)
            item.Row = ++offset;

         return categories;
      }



      public async Task<List<TreeViewCategory>>GetAllCategoriesAsync()
        {
            var Categories =await (from c in _context.Categories
                              where (c.ParentCategoryId == null)
                              select new TreeViewCategory { id = c.CategoryId, title = c.CategoryName,url=c.Url }).ToListAsync();
            foreach (var item in Categories)
            {
                BindSubCategories(item);
               
            }

            return Categories;
        }

		public async Task<List<TreeViewCategory>> GetAllCategoriesAsync(string categoryId)
		{
            if (!string.IsNullOrEmpty(categoryId))
            {
                
				var Categories = await (from c in _context.Categories
										where (c.ParentCategoryId == null && c.CategoryId.Equals(categoryId))
										select new TreeViewCategory { id = c.CategoryId, title = c.CategoryName, url = c.Url }).ToListAsync();
               
				foreach (var item in Categories)
				{
					BindSubCategories(item);
                    

                    item.CategoryItemCount = _categoryItemCount + _context.NewsCategories.Where(x => x.CategoryId == item.id).Count();
					_categoryItemCount = 0;

				}

				return Categories;
			}
            return new List<TreeViewCategory>();
		
		}

		public async Task<List<BreadCrumbViewModel>> GetBreadCrumbByArticleAsync(string articleId)
		{
           
			if (!string.IsNullOrEmpty(articleId))
			{
                var newsCategories =await _context.NewsCategories.FirstOrDefaultAsync(x => x.NewsId == articleId);
                if (newsCategories != null)
                {
				 await BindSubCategoriesForBreadCrumb(newsCategories.CategoryId);

				}
			}

			return breadCrumbViews;
		}
		private async Task<List<BreadCrumbViewModel>> BindSubCategoriesForBreadCrumb(string categoryId)
		{
			
			var Category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId.Equals(categoryId));
            if(Category != null)
            {
               breadCrumbViews.Add(new BreadCrumbViewModel { Id = Category.CategoryId, CategoryName = Category.CategoryName }) ;
                if(!string.IsNullOrEmpty(Category.ParentCategoryId))
					 await  BindSubCategoriesForBreadCrumb(Category.ParentCategoryId);

			}

			return breadCrumbViews;
		}
		public void BindSubCategories(TreeViewCategory category)
        {
            var SubCategories = (from c in _context.Categories
                                 where (c.ParentCategoryId == category.id)
                                 select new TreeViewCategory { id = c.CategoryId, title = c.CategoryName ,url=c.Url  }).ToList();
            foreach (var item in SubCategories)
            {
                item.CategoryItemCount =   _context.NewsCategories.Where(x => x.CategoryId == item.id).Count() ;
				_categoryItemCount += item.CategoryItemCount;
				BindSubCategories(item);
                category.subs.Add(item);
            }
        }

        public Category FindByCategoryName(string categoryName)
        {
           return  _context.Categories.Where(c => c.CategoryName == categoryName.TrimStart().TrimEnd()).FirstOrDefault();
        }

        public bool IsExistCategory(string categoryName, string recentCategoryId = null)
        {
            if (!recentCategoryId.HasValue())
                return _context.Categories.Any(c => c.CategoryName.Trim().Replace(" ", "") == categoryName.Trim().Replace(" ", ""));
            else
            {
                var category = _context.Categories.Where(c => c.CategoryName.Trim().Replace(" ", "") == categoryName.Trim().Replace(" ", "")).FirstOrDefault();
                if (category == null)
                    return false;
                else
                {
                    if (category.CategoryId != recentCategoryId)
                        return true;
                    else
                        return false;
                }
            }
        }


    }
}
