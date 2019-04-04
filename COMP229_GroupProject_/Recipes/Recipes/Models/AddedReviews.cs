using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class AddedReviews
    {
        [Key] [BindNever]
        public int ReviewID { get; set; }

        [Required(ErrorMessage = "Please, type your review.")]
        public string addreview { get; set; }
        [Required(ErrorMessage = "You need to rating the recipe.")]
        [Range(0, 5, ErrorMessage = "The rating must be between 0 to 5")]
        public double Rating { get; set; }

        public AddedRecipes Recipe { get; set; }
    }
}
