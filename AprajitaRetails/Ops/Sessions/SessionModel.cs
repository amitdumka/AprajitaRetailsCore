using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AprajitaRetails.Ops.Extensions;
using System.Text.Json;

namespace AprajitaRetails.Ops.Sessions
{
    public static class SessionName
    {
        public const string UserName = "UserName";
        public const string StoreId = "StoreId";
        public const string StoreCode = "StoreCode";
        public const string StoreName = "StoreName";
        public const string StoreCity = "StoreCity";
        public const string LastLoginTime = "LastLogin";
        public const string AdminAccess = "AdminAccess";

    }
    public static class SessionOps
    {
        public static void Write<T>(ISession session, string KeyName, T ValueData)
        {
            session.Set<T>(KeyName, ValueData);
        }
        public static T Read<T>( ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
