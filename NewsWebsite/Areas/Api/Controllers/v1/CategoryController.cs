using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Areas.Admin;
using NewsWebsite.Common.Api.Attributes;
using NewsWebsite.Data.Contracts;
using System.Threading.Tasks;

namespace NewsWebsite.Areas.Api.Controllers.v1
{
	[Area(AreaConstants.adminArea)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiResultFilter]
	
	public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _uw;
        public CategoryController(IUnitOfWork uw)
        {
            _uw = uw;
        }
		
		[HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {
            var Categories = await _uw.CategoryRepository.GetAllCategoriesAsync();

            return Ok(Categories );
        }

		[HttpGet("GetCategoriesByName")]
		public async Task<IActionResult> GetCategoriesByName(string categoryId)
		{
			var Categories = await _uw.CategoryRepository.GetAllCategoriesAsync(categoryId);

			return Ok(Categories);
		}


		[HttpGet("GetBreadCrumbByCategory")]
		public async Task<IActionResult> GetBreadCrumbByCategory(string articleId)
		{
			var Categories = await _uw.CategoryRepository.GetBreadCrumbByArticleAsync(articleId);

			return Ok(Categories);
		}
	}
}
