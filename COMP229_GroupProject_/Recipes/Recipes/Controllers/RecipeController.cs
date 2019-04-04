using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using System.Linq;
using Recipes.Models.ViewModels;

namespace SportsStore.Controllers
{

    public class RecipesController : Controller
    {
        private  EFRecipeRepository repository;
        public int PageSize = 4;
        

        public RecipesController(EFRecipeRepository repo) => repository = repo;

        public ViewResult List(int RecipePage = 1)
            => View(new RecipesListViewModel
            {
                Recipes = repository.Recipes
                    .OrderBy(p => p.RecipeID)
                    .Skip((RecipePage - 1) * PageSize)
                    .Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = RecipePage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Recipes.Count()
                }
            });
    }
}
