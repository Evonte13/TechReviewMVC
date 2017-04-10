using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechReviewMVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }   //set ID for Reviews

        //Model attributes
        [Display(Name = "Title")]                   //set reviewtitle to be named title
        public string ReviewTitle { get; set; }
        [Display(Name = "Review")]                  //set reviewbody to be named review
        public string ReviewBody { get; set; }
        [Display(Name = "Publish Date")]             //set Date to be named "Publish Date: "
        public DateTime Date { get; set; }
        public Review()                             //Set date to be assigned upon review publication
        {
            Date = DateTime.Now;

        }
        public string Author { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]            //call in ID for Categories
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}