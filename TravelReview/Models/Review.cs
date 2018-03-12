using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Review")]
        public string Comments { get; set; }
        [Display(Name = "Rating")]
        public int Ratings { get; set; }

       



        //Foreign Key Navigation Properties
        [ForeignKey("Category")]
        [Display(Name = "Location")]
        public int CategoryID { get; set; }
        [Display(Name = "Location Type")]
        public virtual Category Category { get; set; }
        


    }
}