using AprajitaRetails.Shared.Models.Payrolls;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AprajitaRetails.Shared.Models.Reports
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    
    //Can be Used at DailySale or any place to reduce no of different function
    public class SaleReportInfo
    {
        public decimal LastMonthSale { get; set; }
        public decimal CurrentMonthSale { get; set; }
        public decimal ManualSale { get; set; }
        public decimal TodaySale { get; set; }
        public decimal CashInHand { get; set; }
        public decimal TotalDues { get; set; }
        public decimal AdjustedAmount { get; set; }
    }

    public class EmpAttReport
    {
        public int EmpAttReportId { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string EmployeeName { get; set; }

        public EmpType Type { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Joinning Date")]
        public DateTime JoinningDate { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Leaving Date")]
        public DateTime? LeavingDate { get; set; }
        public bool IsWorking { get; set; }

        public decimal TotalDaysPresent { get; set; }

        public decimal TotalDaysAbsent { get; set; }

        public decimal TotalDaysHalfDay { get; set; }

        public decimal TotalSundayPresent { get; set; }

        public decimal TotalFinalPresent { get; set; }

        public int NoOfWorkingDays { get; set; }
    }
    public class EmpFinReport
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string EmployeeName { get; set; }
        public EmpType Type { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Joinning Date")]
        public DateTime JoinningDate { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Leaving Date")]
        public DateTime? LeavingDate { get; set; }
        public bool IsWorking { get; set; }

        public int EmpFinReportId { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal? TotalSale { get; set; }
        public int? NoOfBill { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal? AverageSale { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal? TotalLastPcIncentive { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal? TotalWowBillIncentive { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal? TotalSaleIncentive { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal TotalSalaryPaid { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal TotalSalaryAdvancePaid { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal TotalAdvancePaidOff { get; set; }
        [DataType(DataType.Currency), Column(TypeName = "money")]
        public decimal TotalBalance { get; set; }
    }

    public class EmpReport
    {
        public int EmpReportId { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public EmpAttReport? AttReport { get; set; }
        public EmpFinReport? FinReport { get; set; }
    }

    
}