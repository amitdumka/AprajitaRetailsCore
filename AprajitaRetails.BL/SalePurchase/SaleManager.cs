using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace AprajitaRetails.BL.SalePurchase
{
    public class SaleManager
    {
    }
    public class PurchaseManager { }

    public class SaleHelper
    {
        public static InvoiceDetails GetInvoiceData(AprajitaRetailsContext db, int id)
        {
            var inv = db.RegularInvoices.Include(c => c.Customer).Include(c => c.PaymentDetail).ThenInclude(c => c.CardDetail).Where(c => c.RegularInvoiceId == id).FirstOrDefault();
            if (inv == null) { return null; }
            var saleitem = db.RegularSaleItems.Include(c => c.Salesman).Include(c => c.ProductItem).Where(c => c.InvoiceNo == inv.InvoiceNo).ToList();

            InvoiceDetails iDetails = new InvoiceDetails
            {
                Invoice = SaleInvoiceView.CopyTo(inv, saleitem),
                Error = "OK",
                Msg = "Data Present"
            };

            if (iDetails.Invoice.PaymentMode == "Card") iDetails.IsCardPayment = true; else iDetails.IsCardPayment = false;

            return iDetails;

        }


    }
}
