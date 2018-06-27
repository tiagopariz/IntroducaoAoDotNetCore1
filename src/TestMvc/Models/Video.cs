using System;
using  System.ComponentModel.DataAnnotations;

namespace TestMvc.Models
{
    public class Video
    {
        public Video(string title,
                     DateTime publishDate)
        {
            Title = title;
            PublishDate = publishDate;
        }
        
        [Required]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy")]
        public DateTime PublishDate { get; set; }

        [Url]
        public string Url { get; set; }
    }
}