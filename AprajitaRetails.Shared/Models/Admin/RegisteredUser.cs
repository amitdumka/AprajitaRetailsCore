using System;

namespace AprajitaRetails.Shared.Models.Admin
{
    /// <summary>
    /// Version 5.0
    /// </summary>
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



}
