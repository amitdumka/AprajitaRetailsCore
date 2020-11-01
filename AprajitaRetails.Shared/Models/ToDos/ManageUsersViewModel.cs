using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AprajitaRetails.Shared.Models.ToDos
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class ManageUsersViewModel
    {
        public IEnumerable<IdentityUser> Administrators { get; set; }
        public IEnumerable<IdentityUser> Users { get; set; }
    }
}