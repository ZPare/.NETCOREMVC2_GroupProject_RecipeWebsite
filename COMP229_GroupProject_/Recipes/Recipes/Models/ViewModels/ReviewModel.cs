using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models.ViewModels
{
    public class ReviewModel
    {
        public int RecipeID { get; set; }
        public AddedReviews Review { get; set; }
    }
}
