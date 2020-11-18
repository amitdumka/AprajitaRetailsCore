using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Payrolls;
using System.Collections.Generic;
using System.Text;

namespace AprajitaRetails.BL.Triggers
{
    /// <summary>
    /// Base of Trigger
    /// Need to Move to Data Management Layer All Classes in Trigger NameSpace.
    /// </summary>
    public interface ITrigger
    {
        public void OnInsert<T>(AprajitaRetailsContext db, T objectValue);
        public void OnUpdate<T>(AprajitaRetailsContext db, T objectValue);
        public void OnDelete<T>(AprajitaRetailsContext db, T objectValue);
        public void OnInsertOrUpdate<T>(AprajitaRetailsContext db, T objectValue, bool isUpdate);
        public void OnChange<T>(AprajitaRetailsContext db, T objectValue);
    }
}
