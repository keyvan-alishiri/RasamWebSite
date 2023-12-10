using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Common;
using NewsWebsite.Common.Api.Attributes;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Image;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebsite.Areas.Api.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiResultFilter]
    [ApiVersion("1")]
    public class ImageController : ControllerBase
    {

        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;


        public ImageController(IUnitOfWork uw, IMapper mapper, IWebHostEnvironment env)
        {
            _uw = uw;
            _uw.CheckArgumentIsNull(nameof(_uw));

            _mapper = mapper;
            _mapper.CheckArgumentIsNull(nameof(_mapper));

            _env = env;
            _env.CheckArgumentIsNull(nameof(_env));
        }

        [HttpGet(nameof(GetAllImage))]
        public async Task<IActionResult> GetAllImage(string search, string order, int offset, int limit, string sort)
        {
            List<ImageViewModel> images = new List<ImageViewModel>();
            int total = _uw.BaseRepository<Image>().CountEntities();
            if(total >  0)
            {
				if (!search.HasValue())
					search = "";

				if (limit == 0)
					limit = total;

				if (sort == "عنوان تصاویر")
				{
					if (order == "asc")
						images = await _uw.ImageRepository.GetPaginateImageAsync(offset, limit, "Title", search);
					else
						images = await _uw.ImageRepository.GetPaginateImageAsync(offset, limit, "Title desc", search);
				}

				else if (sort == "تاریخ انتشار")
				{
					if (order == "asc")
						images = await _uw.ImageRepository.GetPaginateImageAsync(offset, limit, "PublishDateTime", search);
					else
						images = await _uw.ImageRepository.GetPaginateImageAsync(offset, limit, "PublishDateTime desc", search);
				}

				else
					images = await _uw.ImageRepository.GetPaginateImageAsync(offset, limit, "PublishDateTime desc", search);

				if (search != "")
					total = images.Count();
			}
           

            return Ok(new { total = total, rows = images });
        }
    }
}
