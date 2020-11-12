﻿using AprajitaRetails.Shared.Models.Indentity;
using AprajitaRetails.Shared.Models.Payrolls;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AprajitaRetails.DL.Data;

namespace AprajitaRetails.BL.Admin
{
    public static class UserAdmin
    {
        public static string RemoveWhiteSpace(string data)
        {
            return data.Replace(" ", "").Trim();
        }

        public static async Task<int> AddEmployeeUserAsync(AprajitaRetailsContext db, string UserName, int EmployeeId)
        {
          //  UserName = RemoveWhiteSpace(UserName);

            EmployeeUser user = new EmployeeUser { EmployeeId = EmployeeId, IsWorking = true/*, UserName = UserName*/ };
            await db.EmployeeUsers.AddAsync(user);
            return await db.SaveChangesAsync();


        }


        public static async Task<bool> AddUserAsync(UserManager<AppUser> userManager, string UserName, bool isPowerUser, int EmployeeId)
        {
            UserName = RemoveWhiteSpace(UserName);
            var user = new AppUser { UserName = UserName, Email = UserName + "@aprajitaretails.in" };
            var result = await userManager.CreateAsync(user, UserName + "@1234").ConfigureAwait(true);
            if (result.Succeeded)
            {
                //here we tie the new user to the "Admin" role
                if (isPowerUser)
                    await userManager.AddToRoleAsync(user, "StoreManager").ConfigureAwait(true);
                else
                    await userManager.AddToRoleAsync(user, "Salesman").ConfigureAwait(true);

                //TODO: Need to Update Confirmed Email.

                _ = await userManager.GetUserIdAsync(user).ConfigureAwait(true);
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user).ConfigureAwait(true);

                _ = await userManager.ConfirmEmailAsync(user, code).ConfigureAwait(true);
                return true;
            }

            return false;
        }
        public static async Task<bool> AddUserAsync(UserManager<AppUser> userManager, string UserName, bool isPowerUser, string EmailId, int EmployeeId)
        {
            UserName = RemoveWhiteSpace(UserName);
            var user = new AppUser { UserName = UserName, Email = EmailId };
            var result = await userManager.CreateAsync(user, UserName + "@1234").ConfigureAwait(true);
            if (result.Succeeded)
            {
                //here we tie the new user to the "Admin" role
                if (isPowerUser)
                    await userManager.AddToRoleAsync(user, "StoreManager").ConfigureAwait(true);
                else
                    await userManager.AddToRoleAsync(user, "Salesman").ConfigureAwait(true);

                //TODO: Need to Update Confirmed Email.

                _ = await userManager.GetUserIdAsync(user).ConfigureAwait(true);
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user).ConfigureAwait(true);

                _ = await userManager.ConfirmEmailAsync(user, code).ConfigureAwait(true);
                return true;
            }

            return false;
        }

        public static async Task<bool> AddUserAsync(UserManager<AppUser> userManager, string UserName, string Passwrd, bool isPowerUser, string EmailId, int EmployeeId)
        {
            UserName = RemoveWhiteSpace(UserName);
            var user = new AppUser { UserName = UserName, Email = EmailId };
            var result = await userManager.CreateAsync(user, Passwrd).ConfigureAwait(true);
            if (result.Succeeded)
            {
                //here we tie the new user to the "Admin" role
                if (isPowerUser)
                    await userManager.AddToRoleAsync(user, "StoreManager").ConfigureAwait(true);
                else
                    await userManager.AddToRoleAsync(user, "Salesman").ConfigureAwait(true);

                //TODO: Need to Update Confirmed Email.

                _ = await userManager.GetUserIdAsync(user).ConfigureAwait(true);
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user).ConfigureAwait(true);

                _ = await userManager.ConfirmEmailAsync(user, code).ConfigureAwait(true);
                return true;
            }

            return false;
        }


    }
}
