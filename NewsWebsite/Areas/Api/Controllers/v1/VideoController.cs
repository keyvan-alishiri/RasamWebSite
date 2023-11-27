using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Common;
using NewsWebsite.Common.Api.Attributes;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.Video;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebsite.Areas.Api.Controllers.v1
{
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiResultFilter]
	[ApiVersion("1")]
	public class VideoController : ControllerBase
	{

		private readonly IUnitOfWork _uw;
		private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _env;
		private const string VideoNotFound = "ویدیو درخواستی یافت نشد.";


		public VideoController(IUnitOfWork uw, IMapper mapper, IWebHostEnvironment env)
        {
			_uw = uw;
			_uw.CheckArgumentIsNull(nameof(_uw));

			_mapper = mapper;
			_mapper.CheckArgumentIsNull(nameof(_mapper));

			_env = env;
			_env.CheckArgumentIsNull(nameof(_env));
		}


		[HttpPost("UploadImage")]
		public IActionResult UploadImage()
		{
			return  Ok();
		}

        [HttpGet]
		public async Task<IActionResult> GetVideos(string search, string order, int offset, int limit, string sort)
		{
			List<VideoViewModel> videos;
			int total = _uw.BaseRepository<Video>().CountEntities();
			if (!search.HasValue())
				search = "";

			if (limit == 0)
				limit = total;

			if (sort == "عنوان ویدیو")
			{
				if (order == "asc")
					videos = await _uw.VideoRepository.GetPaginateVideosAsync(offset, limit, "Title", search);
				else
					videos = await _uw.VideoRepository.GetPaginateVideosAsync(offset, limit, "Title desc", search);
			}

			else if (sort == "تاریخ انتشار")
			{
				if (order == "asc")
					videos = await _uw.VideoRepository.GetPaginateVideosAsync(offset, limit, "PublishDateTime", search);
				else
					videos = await _uw.VideoRepository.GetPaginateVideosAsync(offset, limit, "PublishDateTime desc", search);
			}

			else
				videos = await _uw.VideoRepository.GetPaginateVideosAsync(offset, limit, "PublishDateTime desc", search);

			if (search != "")
				total = videos.Count();

			return Ok(new { total = total, rows = videos });
		}

	}
}
