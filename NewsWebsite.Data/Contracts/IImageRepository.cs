using NewsWebsite.ViewModels.Image;
using NewsWebsite.ViewModels.Video;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Contracts
{
    public interface IImageRepository
    {
        string CheckImageFileName(string fileName);

        // List<VideoViewModel> GetPaginateVideos(int offset, int limit, Func<VideoViewModel, object> orderByAcsFunc, Func<VideoViewModel, object> orderByDescFunc, string searchText);
        Task<List<ImageViewModel>> GetPaginateImageAsync(int offset, int limit, string orderBy, string searchText);
    }
}
