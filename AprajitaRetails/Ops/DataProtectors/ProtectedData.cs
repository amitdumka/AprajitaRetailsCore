using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprajitaRetails.Ops.DataProtectors
{
    //Protect The Data 
    public class ProtectedData
    {
        private const string _Pid = "AprajitaRetails.Protection";
        IDataProtector _protector;

        // the 'provider' parameter is provided by DI
        public ProtectedData(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector(_Pid);
        }

        public string Protect(string inputData)
        {

            // protect the payload
         return _protector.Protect(inputData);
        }
        public string UnProtect(string protectedData) 
        { 

            // unprotect the payload
            return _protector.Unprotect(protectedData);
            
        }
    }
}
