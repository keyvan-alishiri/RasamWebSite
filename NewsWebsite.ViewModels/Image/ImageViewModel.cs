using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System;

namespace NewsWebsite.ViewModels.Image
{
    public class ImageViewModel
    {
        [JsonPropertyName("Id")]
        public string ImageId { get; set; }

        [JsonPropertyName("ردیف")]
        public int Row { get; set; }

        [JsonPropertyName("عنوان تصویر"), Display(Name = "عنوان تصویر")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string Title { get; set; }

        [Display(Name = "آدرس تصویر")]

        public string Url { get; set; }


        [Display(Name = "تصویر"), JsonIgnore]
        //[Required(ErrorMessage = "انتخاب {0} الزامی است.")]
        public IFormFile ImageFile { get; set; }

        public string Poster { get; set; }

        [JsonIgnore]
        public DateTime? PublishDateTime { get; set; }

        [JsonPropertyName("تاریخ انتشار")]
        public string PersianPublishDateTime { get; set; }
    }
}
