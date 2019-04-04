using Recipes.Models.ViewModels;
using System.Collections.Generic;

namespace Recipes.Models.ViewModels
{
    public class RecipesListViewModel
    {
        public IEnumerable<AddedRecipes> Recipes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}