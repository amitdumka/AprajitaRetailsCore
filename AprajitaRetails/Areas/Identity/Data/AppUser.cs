using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprajitaRetails.Areas.Identity.Data
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
}
