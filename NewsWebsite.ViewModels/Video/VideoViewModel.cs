using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsWebsite.ViewModels.Video
{
   public class VideoViewModel
    {
        [JsonPropertyName("Id")]
        public string VideoId { get; set; }

       
        public int Row { get; set; }

        [JsonPropertyName("Title"),Display(Name ="عنوان ویدیو")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string Title { get; set; }

        [Display(Name = "آدرس ویدیو"),Url(ErrorMessage ="آدرس وارد شده نا معتبر است.")]
       
        public string Url { get; set; }

        [Display(Name = "آدرس ویدیو تعبیه شده")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string EmbeddedUrl { get; set; }

        [Display(Name = "پوستر ویدیو"),JsonIgnore]
        //[Required(ErrorMessage = "انتخاب {0} الزامی است.")]
        public IFormFile PosterFile { get; set; }
        
        public string Poster { get; set; }

        [JsonIgnore]
        public DateTime? PublishDateTime { get; set; }

        [JsonPropertyName("تاریخ انتشار")]
        public string PersianPublishDateTime { get; set; }
    }
}
