using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;
using Recipes.Models.ViewModels;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 4;
        private int RecipePage=1;

        IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index()
        {
            return View("Index");
        }
       
        public ViewResult UserPage()
        {
            return View("userpage");
        }
        // public ViewResult datapage() => View(repository.Recipes);
        public ViewResult datapage(int productPage = 1)
                    => View(new RecipesListViewModel
                    {
                        Recipes = repository.Recipes
                            .OrderBy(p => p.RecipeID)
                            .Skip((RecipePage - 1) * PageSize)
                            .Take(PageSize).ToList(),
                        PagingInfo = new PagingInfo
                        {
                            CurrentPage = productPage,
                            ItemsPerPage = PageSize,
                            TotalItems = repository.Recipes.Count()
                        }
                    });

        public ViewResult displaypage(int id)
        {
            AddedRecipes recipe = repository.Recipes.First(r => r.RecipeID == id);
            return View(recipe);
        }
      
        public ViewResult AddReview(int id)
        {
            ReviewModel reviewModel = new ReviewModel { RecipeID=id};
            return View(reviewModel);
        }
        [HttpPost]
        public IActionResult AddReview(ReviewModel reviewModel)
        {
            if (ModelState.IsValid)
            {
                AddedRecipes recipe = repository.Recipes.FirstOrDefault(r => r.RecipeID == reviewModel.RecipeID);
                recipe.AddedReviews(reviewModel.Review);

                repository.SaveRecipe(recipe);
                return View("displaypage", recipe);
            }
            else
            {
                //there is something wrong in data
                return View(reviewModel);
            }
        }

    }
}
