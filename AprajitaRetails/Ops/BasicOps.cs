using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Indentity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprajitaRetails.Ops
{
    public class BasicOps
    {
        public static int GetCurrentStoreCode(AprajitaRetailsContext db)
        {
            //TODO: Make use of Session and Cookies
            return db.Stores.First().StoreId;
        }

        public static async Task<string> GetCurrentUserIdAsync(UserManager<AppUser> user ,string UserName)
        {
            var usr = await user.FindByNameAsync(UserName);
            return usr.Id;
            
        }
        
    }
    public class StoreInfo
    {
        public string UserName { get; set; }
        public int StoreId { get; set; }
        public bool IsAdmin { get; set; }

    }
    public  class PostLogin
    {
        public string UserName { get; set; }
        public int StoreId { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public string StoreCity { get; set; }
        public string LastLoginTime { get; set; }
        public bool IsAdmin { get; set; }


        public static void ReadCookieData() { }
        public static void WriteCookieData(PostLogin loginData) { }
        public static StoreInfo ReadStoreInfo() { return null; }


    }
}
