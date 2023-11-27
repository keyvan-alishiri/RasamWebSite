using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Areas.Admin;
using NewsWebsite.Common.Api;
using NewsWebsite.Common.Api.Attributes;
using NewsWebsite.Data.Contracts;
using NewsWebsite.ViewModels.News;
using NewsWebsite.ViewModels.DynamicAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using NewsWebsite.Common;
using NewsWebsite.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace NewsWebsite.Areas.Api.Controllers.v1
{
	[Area(AreaConstants.adminArea)]
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiVersion("1")]
	[ApiResultFilter]
	public class ArticlesController : ControllerBase
	{
		public readonly IUnitOfWork _uw;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IHttpContextAccessor _accessor;
        public ArticlesController(IUnitOfWork uw , IWebHostEnvironment hostingEnvironment , IHttpContextAccessor accessor)
		{
			_uw = uw;
			_hostingEnvironment = hostingEnvironment;
            _accessor = accessor;


        }


		[HttpGet("GetLatestArticles")]
		//[JwtAuthentication(Policy = ConstantPolicies.DynamicPermissionClaimType)]
		public async Task<ApiResult<List<NewsViewModel>>> GetLatestArticles()
		{
            string webRootPath = _hostingEnvironment.WebRootPath;
           
            var result = await _uw.NewsRepository.GetPaginateNewsAsync(0, 10, "PublishDateTime desc", "", true, null);
			for (int i = 0; i < result.Count; i++)
			{
                string imagePath = Path.Combine(webRootPath, "newsImage", result.ElementAt(i).ImageName);

                byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
                string base64String = Convert.ToBase64String(imageBytes);
				result.ElementAt(i).ImageFile = base64String;
                

            }

            return Ok(result);
		}

		[HttpGet("GetArticleInCategoryAndTag")]
		public async Task<ApiResult<List<NewsInCategoriesAndTagsViewModel>>> GetArticleInCategoryAndTag(int pageIndex, int pageSize, string categoryId, string tagId)
		{
			string webRootPath = _hostingEnvironment.WebRootPath;
			if (categoryId.HasValue())
            {
				var result = await _uw.NewsRepository.GetNewsInCategoryAsync(categoryId, pageIndex, pageSize);
                for (int i = 0; i < result.Count; i++)
                {
					string imagePath = Path.Combine(webRootPath, "newsImage", result.ElementAt(i).ImageName);
					if (System.IO.File.Exists(imagePath))
					{
                        byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
                        string base64String = Convert.ToBase64String(imageBytes);
                        result.ElementAt(i).ImageFile = base64String;
                    }
					else
					{
						result.ElementAt(i).ImageFile = string.Empty;
					}

					
				

				}
                return Ok(  result );
			}
				

			else
				return await _uw.NewsRepository.GetNewsInTagAsync(tagId, pageIndex, pageSize);
		}

		[HttpGet("GetArticleDetails")]
        public async Task<IActionResult> GetArticleDetails(string articleId)
        {
            if (!articleId.HasValue())
                return NotFound();
            else
            {
                int userId = User.Identity.GetUserId<int>();
                var news = await _uw.NewsRepository.GetNewsByIdAsync(articleId, userId);

                if (news == null)
                    return NotFound();
                else
                {
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string imagePath = Path.Combine(webRootPath, "newsImage", news.ImageName);
                    if(System.IO.File.Exists(imagePath))
                    {
						byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
						string base64String = Convert.ToBase64String(imageBytes);
						news.ImageFile = base64String;
					}
                    
                    string ipAddress = _accessor.HttpContext?.Connection?.RemoteIpAddress.ToString();
                    await _uw.NewsRepository.InsertVisitOfUserAsync(articleId, ipAddress);
                    var newsComments = await _uw.NewsRepository.GetNewsCommentsAsync(articleId);
                    var nextAndPreviousNews = await _uw.NewsRepository.GetNextAndPreviousNews(news.PublishDateTime);
                    var newsRelated = await _uw.NewsRepository.GetRelatedNewsAsync(2, news.TagIdsList, articleId);
                    var newsDetailsViewModel = new NewsDetailsViewModel(news, newsComments, newsRelated, nextAndPreviousNews);
                    return Ok(newsDetailsViewModel);
                }
            }
        }
    }
}
