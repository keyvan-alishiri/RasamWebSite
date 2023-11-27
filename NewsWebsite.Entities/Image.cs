using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsWebsite.Entities
{
    public class Image
    {
        [Key]
        public string ImageId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Poster { get; set; }
        public string EmbeddedUrl { get; set; }
        public DateTime? PublishDateTime { get; set; }
    }
}
