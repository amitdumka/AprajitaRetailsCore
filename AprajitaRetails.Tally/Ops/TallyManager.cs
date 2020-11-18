using AprajitaRetails.DL.Data;
using System;
using System.Collections.Generic;
using System.Text;
using AprajitaRetails.Shared.Models.Payrolls;

namespace AprajitaRetails.Tally.Ops
{
    public interface ITallyManager<T>
    {
        public bool Add(AprajitaRetailsContext db , T objectValue);
        public bool Delete(AprajitaRetailsContext db, T objectValue);
        public bool Update(AprajitaRetailsContext db, T objectValue);
        public bool AddOrUpdate(AprajitaRetailsContext db, T objectValue);
    }

    public class PayrollManager : ITallyManager<Attendance>
    {
        public bool Add(AprajitaRetailsContext db, Attendance objectValue)
        {
            throw new NotImplementedException();
        }

        public bool AddOrUpdate(AprajitaRetailsContext db, Attendance objectValue)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AprajitaRetailsContext db, Attendance objectValue)
        {
            throw new NotImplementedException();
        }

        public bool Update(AprajitaRetailsContext db, Attendance objectValue)
        {
            throw new NotImplementedException();
        }
    }
}
