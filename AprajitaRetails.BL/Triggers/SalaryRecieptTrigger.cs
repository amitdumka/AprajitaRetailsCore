using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Payrolls;

namespace AprajitaRetails.BL.Triggers
{
    public class StaffAdvanceReceiptTrigger : ITrigger
    {

        public void OnChange<StaffAdvanceReceipt>(AprajitaRetailsContext db, StaffAdvanceReceipt salary)
        {
            
            throw new System.NotImplementedException();
        }

        public void OnDelete<StaffAdvanceReceipt>(AprajitaRetailsContext db, StaffAdvanceReceipt salary)
        {
            throw new System.NotImplementedException();
        }

        public void OnInsert<StaffAdvanceReceipt>(AprajitaRetailsContext db, StaffAdvanceReceipt salary)
        {
            throw new System.NotImplementedException();
        }

        public void OnInsertOrUpdate<StaffAdvanceReceipt>(AprajitaRetailsContext db, StaffAdvanceReceipt salary, bool isUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void OnUpdate<StaffAdvanceReceipt>(AprajitaRetailsContext db, StaffAdvanceReceipt salary)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
