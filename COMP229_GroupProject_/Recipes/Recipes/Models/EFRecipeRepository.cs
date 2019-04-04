using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<AddedRecipes> Recipes => context.Recipes
            .Include(r => r.Reviews);
        //public void insertpage(AddedRecipes recipe)
        //{

        //}

        public void SaveRecipe(AddedRecipes recipe)
        {
            if (recipe.RecipeID == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                AddedRecipes dbEntry = context.Recipes
                    .FirstOrDefault(r => r.RecipeID == recipe.RecipeID);
                if(dbEntry != null)
                {
                    dbEntry.recipename = recipe.recipename;
                    dbEntry.ingredient1 = recipe.ingredient1;
                    dbEntry.ingredient2 = recipe.ingredient2;
                    dbEntry.ingredient3 = recipe.ingredient3;
                    dbEntry.ingredient4 = recipe.ingredient4;
                    dbEntry.ingredient5 = recipe.ingredient5;
                    dbEntry.description = recipe.description;
                }
            }
            context.SaveChanges();
        }

        public AddedRecipes DeleteRecipe (int recipeID)
        {
            AddedRecipes dbEntry = context.Recipes
                .FirstOrDefault(p => p.RecipeID == recipeID);
            if (dbEntry != null)
            {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
