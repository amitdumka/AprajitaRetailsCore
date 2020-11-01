
using AprajitaRetails.Shared.Models.Payrolls;
using AprajitaRetails.Shared.Models.Sales;
using AprajitaRetails.Shared.Models.Sales.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AprajitaRetails.Shared.Models.Stores
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class Salesman:BaseST
    {
        public int SalesmanId { get; set; }
        [Display(Name = "Salesman")]
        public string SalesmanName { get; set; }

        public virtual ICollection<DailySale> DailySales { get; set; }
        public virtual ICollection<RegularSaleItem> SaleItems { get; set; }
      
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }



}
