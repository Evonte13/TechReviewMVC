using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechReviewMVC.Models
{
    public class Category
    {
        [Key, Display(Name = "Category")]       //set categoryId to be named category
        public int CategoryID { get; set; }     //set Category ID

        [Display(Name = "Category")]            //Set Category name to display as Category
        public string CategoryName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}