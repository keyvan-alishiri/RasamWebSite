using NewsWebsite.Common.Attributes;
using NewsWebsite.Entities;
using NewsWebsite.Entities.identity;
using NewsWebsite.ViewModels.UserManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsWebsite.ViewModels.News
{
    public class NewsViewModel
    {
        [JsonPropertyName("Id")]
        public string NewsId { get; set; }

        [JsonPropertyName("Row")]
        public int Row { get; set; }

        [JsonPropertyName("Title"), Display(Name = "Title")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string Title { get; set; }

        [JsonPropertyName("ShortTitle")]
        public string ShortTitle { get; set; }

        [JsonIgnore]
        public bool FuturePublish { get; set; }

       
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است."),Display(Name ="چکیده")]
        public string Abstract { get; set; }

        [JsonIgnore]
        public DateTime? PublishDateTime { get; set; }

        [Display(Name = "تاریخ انتشار"), JsonPropertyName("PersianPublishDate")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string PersianPublishDate { get; set; }

        [Display(Name = "زمان انتشار")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        public string PersianPublishTime { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        [JsonPropertyName("AuthorName")]
        public string AuthorName { get; set; }

        [JsonIgnore]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "انتخاب {0} الزامی است.")]
        [Display(Name ="تصویر شاخص")]
        public string ImageFile {get;set;}

       
        public bool IsPublish { get; set; }

        [Required(ErrorMessage = "انتخاب {0} الزامی است.")]
        [Display(Name = "نوع مقاله"),JsonIgnore()]
        public bool? IsInternal { get; set; }

        [JsonPropertyName("NameOfTags")]
        public string NameOfTags { get; set; }


        [JsonPropertyName("NewsType")]
        public string NewsType { get; set; }

        [JsonPropertyName("NumberOfVisit")]
        public int NumberOfVisit { get; set; }

        [JsonPropertyName("NumberOfLike")]
        public int NumberOfLike { get; set; }

        [JsonPropertyName("NumberOfDisLike")]
        public int NumberOfDisLike { get; set; }

        [JsonPropertyName("NumberOfComments")]
        public int NumberOfComments { get; set; }

        [JsonPropertyName("NameOfCategories")]
        public string NameOfCategories { get; set; }
		[JsonPropertyName("CategoryId")]
		public string CategoryId { get; set; }

        [Required(ErrorMessage = "وارد نمودن {0} الزامی است.")]
        [Display(Name = "آدرس مقاله"), JsonPropertyName("Url")]
        [UrlValidate("/", @"\", " ")]
        public string Url { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }


        [JsonPropertyName("Description")]
        public string Description { get; set; }

     
        public  bool IsBookmarked { get; set; }


       
        public string[] CategoryIds { get; set; }


     
        public string IdOfTags { get; set; }

       
        public string IdOfCategories { get; set; }

      
        public List<string> TagIdsList { get; set; }

       
        public List<string> TagNamesList { get; set; }

       
        public UsersViewModel AuthorInfo { get; set; }

      
        public NewsCategoriesViewModel NewsCategoriesViewModel { get; set; }

      
        public virtual ICollection<NewsCategory> NewsCategories { get; set; }

       
        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}
