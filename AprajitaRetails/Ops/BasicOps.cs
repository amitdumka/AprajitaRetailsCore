﻿using AprajitaRetails.DL.Data;
using AprajitaRetails.Ops.Sessions;
using AprajitaRetails.Shared.Models.Indentity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        public static async Task<string> GetCurrentUserIdAsync(UserManager<AppUser> user, string UserName)
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

    public class PostLogin
    {
        public string UserName { get; set; }
        public int StoreId { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public string StoreCity { get; set; }
        public string LastLoginTime { get; set; }
        public bool IsAdmin { get; set; }

        public static PostLogin ReadCookieData(ISession session)
        {
            return new PostLogin
            {
                StoreId = SessionOps.Read<int>(session, SessionName.StoreId),
                IsAdmin = SessionOps.Read<bool>(session, SessionName.AdminAccess),
                LastLoginTime = SessionOps.Read<string>(session, SessionName.LastLoginTime),
                StoreCity = SessionOps.Read<string>(session, SessionName.StoreCity),
                StoreCode = SessionOps.Read<string>(session, SessionName.StoreCode),
                StoreName = SessionOps.Read<string>(session, SessionName.StoreName),
                UserName = SessionOps.Read<string>(session, SessionName.UserName),
            };
        }

        public static void WriteCookieData(ISession session, PostLogin loginData)
        {
            SessionOps.Write(session, SessionName.StoreId, loginData.StoreId);
            SessionOps.Write(session, SessionName.AdminAccess, loginData.IsAdmin);
            SessionOps.Write(session, SessionName.LastLoginTime, loginData.LastLoginTime);
            SessionOps.Write(session, SessionName.StoreCity, loginData.StoreCity);
            SessionOps.Write(session, SessionName.StoreCode, loginData.StoreCode);
            SessionOps.Write(session, SessionName.StoreName, loginData.StoreName);
            SessionOps.Write(session, SessionName.UserName, loginData.UserName);
        }

        public static StoreInfo ReadStoreInfo(ISession session)
        {
            return new StoreInfo
            {
                StoreId = SessionOps.Read<int>(session, SessionName.StoreId),
                IsAdmin = SessionOps.Read<bool>(session, SessionName.AdminAccess),
                UserName = SessionOps.Read<string>(session, SessionName.UserName),
            };
        }
        public static void WriteLogOut(ISession session)
        {
            SessionOps.Write(session, SessionName.StoreId, 0);
            SessionOps.Write(session, SessionName.AdminAccess, false);
            SessionOps.Write(session, SessionName.UserName, "");
        }
        public static void WriteLoggIn(ISession session, StoreInfo info)
        {
            SessionOps.Write(session, SessionName.StoreId, info.StoreId);
            SessionOps.Write(session, SessionName.AdminAccess, info.IsAdmin);
            SessionOps.Write(session, SessionName.UserName, info.UserName);
        }


        public static void SetUserSession(ISession session, AprajitaRetailsContext db, string UserName)
        {
            StoreInfo sInfo = new StoreInfo { StoreId = db.Stores.First().StoreId, UserName = UserName, IsAdmin = false };
            WriteLoggIn(session, sInfo);

        }
    }
}