using AprajitaRetails.DL.Data;
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
    }
}
