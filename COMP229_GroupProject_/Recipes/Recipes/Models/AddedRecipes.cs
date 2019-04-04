using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class AddedRecipes
    {
        [Key]
        public int RecipeID { get; set; }

        public double Rating { get; private set; }

        [Required(ErrorMessage = "Please Name The Recipe")]
        public string recipename { get; set; }

        [Required(ErrorMessage = "Please Add An Ingredient")]
        public string ingredient1 { get; set; }

        [Required(ErrorMessage = "Please Add An Ingredient")]
        public string ingredient2 { get; set; }

        [Required(ErrorMessage = "Please Add An Ingredient")]
        public string ingredient3 { get; set; }

        [Required(ErrorMessage = "Please Add An Ingredient")]
        public string ingredient4 { get; set; }

        [Required(ErrorMessage = "Please Add An Ingredient")]
        public string ingredient5 { get; set; }

        [Required(ErrorMessage = "Please Add A Description")]
        public string description { get; set; }

        public List<AddedReviews> Reviews { get; set; }

        public virtual void AddedReviews(AddedReviews review)
        {
            review.Recipe = this;
            Reviews.Add(review);

            double totalStars = 0;
            foreach (var r in Reviews)
            {
                totalStars += r.Rating;
            }
            Rating = (totalStars / Reviews.Count);
        }
    }
}
