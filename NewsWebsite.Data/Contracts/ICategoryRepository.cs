﻿using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Contracts
{
    public interface ICategoryRepository
    {
        Category FindByCategoryName(string categoryName);
        Task<List<TreeViewCategory>> GetAllCategoriesAsync();
        bool IsExistCategory(string categoryName, string recentCategoryId = null);
       // Task<List<CategoryViewModel>> GetPaginateCategoriesAsync(int offset, int limit, bool? categoryNameSortAsc, bool? parentCategoryNameSortAsc, string searchText);
       Task<List<CategoryViewModel>> GetPaginateCategoriesAsync(int offset, int limit, string orderBy, string searchText);
        Task<List<TreeViewCategory>> GetAllCategoriesAsync(string categoryName);
        Task<List<BreadCrumbViewModel>> GetBreadCrumbByArticleAsync(string articleId);
   }
}
