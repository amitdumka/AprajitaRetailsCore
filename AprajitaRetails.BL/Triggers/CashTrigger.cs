using AprajitaRetails.DL.Data;
using System;

namespace AprajitaRetails.BL.Triggers
{
    public class CashTrigger : ITrigger
    {
        void ITrigger.OnChange<T>(AprajitaRetailsContext db, T objectValue)
        {
            throw new NotImplementedException();
        }

        void ITrigger.OnDelete<T>(AprajitaRetailsContext db, T objectValue)
        {
            throw new NotImplementedException();
        }

        void ITrigger.OnInsert<T>(AprajitaRetailsContext db, T objectValue)
        {
            throw new NotImplementedException();
        }

        void ITrigger.OnInsertOrUpdate<T>(AprajitaRetailsContext db, T objectValue, bool isUpdate)
        {
            throw new NotImplementedException();
        }

        void ITrigger.OnUpdate<T>(AprajitaRetailsContext db, T objectValue)
        {
            throw new NotImplementedException();
        }
    }
}
