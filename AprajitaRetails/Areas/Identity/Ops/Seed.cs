using AprajitaRetails.Shared.Models.Indentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace AprajitaRetails.Areas.Identity.Ops
{
    public static class Seeder
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //adding custom roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            
            string[] roleNames = { "Admin", "StoreManager", "Salesman", "Accountant", "RemoteAccountant", "Member", "PowerUser", "GuestUsers","GuestPowerUsers" };
            
            IdentityResult roleResult;
            
            foreach (var roleName in roleNames)
            {
                //creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            //creating a super user who could maintain the web app
            var poweruser = new AppUser
            {
                UserName = "Admin",
                Email = "Admin@AprajitaRetails.In", EmployeeId=0, IsEmployee=false, IsWorking=false, 
                FirstName="Admin", LastName="User"

            };
            string UserPassword = "Admin@1234";
            var _user = await UserManager.FindByEmailAsync("Admin@AprajitaRetails.In");
            if (_user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(poweruser, UserPassword);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the "Admin" role 
                    await UserManager.AddToRoleAsync(poweruser, "Admin");

                    //Need to Update Confirmed Email. 

                    _ = await UserManager.GetUserIdAsync(poweruser);
                    var code = await UserManager.GenerateEmailConfirmationTokenAsync(poweruser);
                    _ = await UserManager.ConfirmEmailAsync(poweruser, code);
                }
            }
        }

    }
}
