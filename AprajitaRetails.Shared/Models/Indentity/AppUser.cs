﻿using Microsoft.AspNetCore.Identity;
using System;

namespace AprajitaRetails.Shared.Models.Indentity
{
    /// <summary>
    /// Customised User for App
    /// </summary>
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public bool IsEmployee { get; set; }
        [PersonalData]
        public int EmployeeId { get; set; }
        [PersonalData]
        public bool IsWorking { get; set; }
    }
    public class RegisteredUser
    {
        public int RegisteredUserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public bool IsUserLoggedIn { get; set; }
    }
    public class RoleUserView
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}