using System.Linq;
using System.Threading.Tasks;
using Apartment.App.Domain.Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity;
namespace Apartment.App.DataAccess.EntityFramework
{
    public class ContextSeed
    {
        public static async Task SeedRoleAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("superadmin"));
            await roleManager.CreateAsync(new IdentityRole("admin"));
            await roleManager.CreateAsync(new IdentityRole("user"));

        }
        public static async Task SeedSuperAdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new User
            {
                UserName = "superadmin",
                Email = "superadmin@superadmin.com",
                FirstName = "super",
                LastName = "admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Asd123.");
                    await userManager.AddToRoleAsync(defaultUser, "superadmin");
                    await userManager.AddToRoleAsync(defaultUser, "admin");
                    await userManager.AddToRoleAsync(defaultUser, "user");
                }
            }
        }

    }
}
