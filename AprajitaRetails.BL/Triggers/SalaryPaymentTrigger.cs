using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Payrolls;

namespace AprajitaRetails.BL.Triggers
{
    public class SalaryPaymentTrigger : ITrigger
    {
        public void OnChange<SalaryPayment>(AprajitaRetailsContext db, SalaryPayment salary)
        {
            throw new System.NotImplementedException();
        }

        public void OnDelete<SalaryPayment>(AprajitaRetailsContext db, SalaryPayment salary)
        {
            throw new System.NotImplementedException();
        }

        public void OnInsert<SalaryPayment>(AprajitaRetailsContext db, SalaryPayment salary)
        {
            throw new System.NotImplementedException();
        }

        public void OnInsertOrUpdate<SalaryPayment>(AprajitaRetailsContext db, SalaryPayment salary, bool isUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void OnUpdate<SalaryPayment>(AprajitaRetailsContext db, SalaryPayment salary)
        {
            throw new System.NotImplementedException();
        }
    }
}
