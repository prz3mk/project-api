using Ecom.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    public class IdentitySeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                //create new user
                var user = new AppUser
                {
                    DisplayName = "admin",
                    Email = "admin@admin.com",
                    UserName = "admin@admin.com",
                    Address = new Address
                    {
                        FirstName = "admin",
                        LastName = "admin",
                        City = "admin",
                        State = "admin",
                        Street = "admin",
                        ZipCode = "666"

                    }
                };
                await userManager.CreateAsync(user, "Admin1!");
            }
        }
    }
}
