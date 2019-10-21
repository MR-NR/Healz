using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Healz.Models
{
    public class BlogPost
    {
        
        public int BlogPostId { get; set; }
        [Display(Name = "Post Title")]
        public string postTitle { get; set; }
        [Display(Name = "Description")]
        public string postDesc { get; set; }
        [Display(Name  = "Image")]
        
        public string postImgUrl { get; set; }
        [Display(Name  = "Dated")]
        public DateTime postDate { get; set; }
        [Display(Name  = "Posted By")]
        public string postedBy { get; set; }

    }
}
