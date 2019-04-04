using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repository;

        public AdminController(IRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Recipes);

        public ViewResult Update(int recipeID) =>
            View(repository.Recipes
            .FirstOrDefault(r => r.RecipeID == recipeID));

        [HttpPost]
        public IActionResult Update(AddedRecipes recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.recipename} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }
        public ViewResult Create() => View("Update", new AddedRecipes());

        [HttpPost]
        public IActionResult Delete(int recipeID)
        {
            AddedRecipes deletedRecipe = repository.DeleteRecipe(recipeID);
            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.recipename} was deleted";
            }
            return RedirectToAction("Index");
        }

        public ViewResult insertpage()
        {
            return View("insertpage");
        }

        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View(new AddedRecipes());
        }
        [HttpPost]
        public IActionResult AddRecipe(AddedRecipes r)
        {
            //repository.insertpage(r);
            repository.SaveRecipe(r);
            return View("RecipeAdded", r);
        }
    }
}