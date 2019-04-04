﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{

    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";

        private const string adminUser1 = "Admin1";
        private const string adminPassword = "Secret123$";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, adminPassword);
            }
            IdentityUser user1 = await userManager.FindByIdAsync(adminUser);
            if (user1 == null)
            {
                user1 = new IdentityUser("Admin1");
                await userManager.CreateAsync(user1, adminPassword);
            }
        }
       

        
    }
}
