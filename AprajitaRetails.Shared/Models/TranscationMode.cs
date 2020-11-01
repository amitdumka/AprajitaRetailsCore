using AprajitaRetails.Shared.Models.Accounts;
using AprajitaRetails.Shared.Models.Accounts.Expenses;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AprajitaRetails.Shared.Models
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class TranscationMode
    {
        [Display(Name = "Mode")]
        public int TranscationModeId { get; set; }

        //[Index(IsUnique = true)]
        [Display(Name = "Transaction Mode")]
        public string Transcation { get; set; }

        public virtual ICollection<CashReceipt> CashReceipts { get; set; }
        public virtual ICollection<CashPayment> CashPayments { get; set; }
    }
}