using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Recipes.Models;
using Microsoft.AspNetCore.Identity;

namespace Recipes
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
            Configuration["Data:RecipesIngredients:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options =>
                            options.UseSqlServer(
                                Configuration["Data:RecipesIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IRepository, EFRecipeRepository>();
            services.AddTransient<IReviewRepository, EFReviewRepository>();
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "",
                    template: "{controller}/{action}");
                routes.MapRoute(
                   name: "",
                   template: "{controller=Home}/{action=datapage}");
                routes.MapRoute(
                    name: "pagination",
                    template: "AddedRecipes/Page{RecipePage}",
                    defaults: new { Controller = "Recipe", action = "List" });

            });
            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}

