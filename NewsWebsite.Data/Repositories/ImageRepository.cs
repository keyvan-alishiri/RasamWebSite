using AutoMapper.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewsWebsite.Common;
using NewsWebsite.Data.Contracts;
using NewsWebsite.ViewModels.Image;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace NewsWebsite.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly NewsDBContext _context;
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;
        public ImageRepository(NewsDBContext context, Microsoft.Extensions.Configuration.IConfiguration configuration )
        {
            _context = context;
            _configuration = configuration;
           
        }


        public async Task<List<ImageViewModel>> GetPaginateImageAsync(int offset, int limit, string orderBy, string searchText)
        {
            var getDateTimesForSearch = searchText.GetDateTimeForSearch();
            List<ImageViewModel> images = await _context.Images.Where(c => c.Title.Contains(searchText) || (c.PublishDateTime >= getDateTimesForSearch.First() && c.PublishDateTime <= getDateTimesForSearch.Last()))
                                    .OrderBy(orderBy).Skip(offset).Take(limit)
                                    .Select(c => new ImageViewModel { ImageId = c.ImageId, Title = c.Title, Url = $"../posters/{c.Poster}" ,Poster = c.Poster, PersianPublishDateTime = c.PublishDateTime.ConvertMiladiToShamsi("yyyy/MM/dd ساعت HH:mm:ss"), PublishDateTime = c.PublishDateTime }).AsNoTracking().ToListAsync();

            foreach (var item in images)
                item.Row = ++offset;

            return images;
        }

        public string CheckImageFileName(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            int fileNameCount = _context.Images.Where(f => f.Poster == fileName).Count();
            int j = 1;
            while (fileNameCount != 0)
            {
                fileName = fileName.Replace(fileExtension, "") + j + fileExtension;
                fileNameCount = _context.Videos.Where(f => f.Poster == fileName).Count();
                j++;
            }

            return fileName;
        }
    }
}
