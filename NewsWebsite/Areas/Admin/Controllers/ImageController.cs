using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsWebsite.Common.Attributes;
using NewsWebsite.Common;
using NewsWebsite.Entities;
using NewsWebsite.ViewModels.DynamicAccess;
using NewsWebsite.ViewModels.Video;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using NewsWebsite.Data.Contracts;
using NewsWebsite.ViewModels.Image;

namespace NewsWebsite.Areas.Admin.Controllers
{
    [DisplayName("مدیریت گالری")]
    public class ImageController : BaseController
    {
        private readonly IUnitOfWork _uw;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        private const string ImageNotFound = "ویدیو درخواستی یافت نشد.";

        public ImageController(IUnitOfWork uw, IMapper mapper, IWebHostEnvironment env)
        {
            _uw = uw;
            _uw.CheckArgumentIsNull(nameof(_uw));

            _mapper = mapper;
            _mapper.CheckArgumentIsNull(nameof(_mapper));

            _env = env;
            _env.CheckArgumentIsNull(nameof(_env));
        }
        [HttpGet, DisplayName("مشاهده")]
        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetImages(string search, string order, int offset, int limit, string sort)
        {
            List<ImageViewModel> images;
            int total = _uw.BaseRepository<Image>().CountEntities();
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

            return Json(new { total = total, rows = images });
        }


        [HttpGet, AjaxOnly(), DisplayName("درج و ویرایش")]
        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        public async Task<IActionResult> RenderImage(string imageId)
        {
            var imageViewModel = new ImageViewModel();
            if (imageId.HasValue())
            {
                var image = await _uw.BaseRepository<Image>().FindByIdAsync(imageId);
                if (image != null)
                {
                    imageViewModel = _mapper.Map<ImageViewModel>(image);
                    imageViewModel.Url = $"/posters/{image.Poster}";
                }
                    
                else
                    ModelState.AddModelError(string.Empty, ImageNotFound);
            }
            return PartialView("_RenderImage", imageViewModel);
        }

        [HttpPost, AjaxOnly()]
        public async Task<IActionResult> CreateOrUpdate(ImageViewModel viewModel)
        {
            if (viewModel.ImageId.HasValue())
                ModelState.Remove("PosterFile");

            if (ModelState.IsValid)
            {
                if (viewModel.ImageFile != null)
                {
                    viewModel.Poster = _uw.VideoRepository.CheckVideoFileName(viewModel.ImageFile.FileName);
                    await viewModel.ImageFile.UploadFileAsync($"{_env.WebRootPath}/posters/{viewModel.Poster}");
                }

                if (viewModel.ImageId.HasValue())
                {
                    var image = await _uw.BaseRepository<Image>().FindByIdAsync(viewModel.ImageId);

                    if (image != null)
                    {
                        if (viewModel.Poster != null)
                            FileExtensions.DeleteFile($"{_env.WebRootPath}/posters/{image.Poster}");
                        else
                            viewModel.Poster = image.Poster;

                        viewModel.PublishDateTime = image.PublishDateTime;
                        _uw.BaseRepository<Image>().Update(_mapper.Map(viewModel, image));
                        await _uw.Commit();
                        TempData["notification"] = EditSuccess;
                    }
                    else
                        ModelState.AddModelError(string.Empty, ImageNotFound);
                }

                else
                {
                    viewModel.ImageId = StringExtensions.GenerateId(10);
                    var resultMap = _mapper.Map<Image>(viewModel);
                    await _uw.BaseRepository<Image>().CreateAsync(resultMap);
                    await _uw.Commit();
                    TempData["notification"] = InsertSuccess;
                }
            }

            return PartialView("_RenderImage", viewModel);
        }


        [HttpGet, AjaxOnly(), DisplayName("حذف")]
        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        public async Task<IActionResult> Delete(string imageId)
        {
            if (!imageId.HasValue())
                ModelState.AddModelError(string.Empty, ImageNotFound);
            else
            {
                var image = await _uw.BaseRepository<Image>().FindByIdAsync(imageId);
                if (image == null)
                    ModelState.AddModelError(string.Empty, ImageNotFound);
                else
                    return PartialView("_DeleteConfirmation", image);
            }
            return PartialView("_DeleteConfirmation");
        }


        [HttpPost, ActionName("Delete"), AjaxOnly()]
        public async Task<IActionResult> DeleteConfirmed(Image model)
        {
            if (model.ImageId == null)
                ModelState.AddModelError(string.Empty, ImageNotFound);
            else
            {
                var image = await _uw.BaseRepository<Image>().FindByIdAsync(model.ImageId);
                if (image == null)
                    ModelState.AddModelError(string.Empty, ImageNotFound);
                else
                {
                    FileExtensions.DeleteFile($"{_env.WebRootPath}/posters/{image.Poster}");
                    _uw.BaseRepository<Image>().Delete(image);
                    await _uw.Commit();
                    TempData["notification"] = DeleteSuccess;
                    return PartialView("_DeleteConfirmation", image);
                }
            }
            return PartialView("_DeleteConfirmation");
        }


        [HttpPost, ActionName("DeleteGroup"), AjaxOnly(), DisplayName("حذف گروهی")]
        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        public async Task<IActionResult> DeleteGroupConfirmed(string[] btSelectItem)
        {
            if (btSelectItem.Count() == 0)
                ModelState.AddModelError(string.Empty, "هیچ ویدیویی برای حذف انتخاب نشده است.");
            else
            {
                foreach (var item in btSelectItem)
                {
                    var image = await _uw.BaseRepository<Image>().FindByIdAsync(item);
                    _uw.BaseRepository<Image>().Delete(image);
                    await _uw.Commit();
                    FileExtensions.DeleteFile($"{_env.WebRootPath}/posters/{image.Poster}");
                }
                TempData["notification"] = "حذف گروهی اطلاعات با موفقیت انجام شد.";
            }

            return PartialView("_DeleteGroup");
        }
    }
}
