using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Recipes.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)

        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new AddedRecipes
                    {
                        recipename = "Lettuce Wrap",
                        ingredient1 = "Lettuce",
                        ingredient2 = "1 Large Chopped Onion",
                        ingredient3 = "2 Cloves Fresh Garlic",
                        ingredient4 = "1 Tablespoon Soy Sauce",
                        ingredient5 = "1/4 cup Hoisin Sauce",
                        description = "Chop onion and garlic. Mix sauces with onion and garlic. Combine into lettuce leaves."
                    },
                    new AddedRecipes
                    {
                        recipename = "Spaghetti",
                        ingredient1 = "1 Can of Diced Tomatoes",
                        ingredient2 = "1 Large Chopped Onion",
                        ingredient3 = "2 Cloves Fresh Garlic",
                        ingredient4 = "1 Package of Spaghetti Noodles",
                        ingredient5 = "1 Cup of Shredded Cheese",
                        description = "Chop onion and garlic. Cook in pan until translucent. Add diced tomatoes to pan. Boil noodles. Combine"
                    },
                    new AddedRecipes
                    {
                        recipename = "Roasted Vegetables",
                        ingredient1 = "1 Pound of Potatoes",
                        ingredient2 = "1 Large Quartered Onion",
                        ingredient3 = "1 Butternut Squash",
                        ingredient4 = "2 Chopped Peppers",
                        ingredient5 = "1 Tablespoon of Olive Oil",
                        description = "Preheat oven to 400 degrees Fahrenheit. Chop all vegetables. Place on baking pan. Roast for 1 hour."
                    },
                    new AddedRecipes
                    {
                         recipename = "Hot Dogs",
                         ingredient1 = "1 Package of Hot Dogs",
                         ingredient2 = "1 Package of Hot Dog Buns",
                         ingredient3 = "Mustard",
                         ingredient4 = "Relish",
                         ingredient5 = "Ketchup",
                         description = "BBQ or boil hot dogs. Add to buns. Add desired condiments."
                    },
                    new AddedRecipes
                    {
                         recipename = "Lemonade",
                         ingredient1 = "1 3/4 White Sugar",
                         ingredient2 = "1 1/2 Lemon Juice",
                         ingredient3 = "8 Cups of Water",
                         ingredient4 = "Optional: Ice Cubes",
                         ingredient5 = "Lemon Slices",
                         description = "In a saucepan combine sugar and 1 cup of water. Bring to boil. Let cool and regrigerate until cold. Combine with rest of water and lemon juice."
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
