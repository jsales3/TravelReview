using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display (Name = "Location")]
        public string CategoryName { get; set; }
        [Display(Name = "Location Type")]
        public string CategoryType { get; set; }

        //Navingation Property
        public virtual ICollection<Review> Reviews { get; set; }

    }
}