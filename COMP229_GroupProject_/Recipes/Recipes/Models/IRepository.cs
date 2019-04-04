﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public interface IRepository
    {
        IQueryable<AddedRecipes> Recipes { get; }
        //void insertpage(AddedRecipes recipe);

        void SaveRecipe(AddedRecipes recipe);

        AddedRecipes DeleteRecipe(int recipeID);

    }
}
