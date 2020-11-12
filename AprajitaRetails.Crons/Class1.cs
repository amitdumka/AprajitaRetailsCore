namespace AprajitaRetails.Crons.Payrolls
{
    public sealed class ErrorMessage
    {
        public const string AttendanceRecordNotFound = "Attendance Record Not Found";
        public const string NoofDaysNotMatched = "No of Day Not Matched#";
        public const string PaySlipAlreadyGenerated = "Payslip already Generated!";
        public const string SalaryHeadNotFound = "Salary Head Not Found";
    }

    public class SalaryHead
    {
        public decimal BasicSalary { get; set; }
        public int EmpId { get; set; }
        public EmpType EmpType { get; set; }
        public string ErrMsg { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal Incentive { get; set; }
        public bool IsError { get; set; }
        public bool IsTailoring { get; set; }
        public decimal LastPcs { get; set; }
        public int Month { get; set; }
        public double NoOfDaysPresent { get; set; }
        public int SalaryId { get; set; }
        public string StaffName { get; set; }
        public decimal TotalLastPcsValue { get; set; }
        public decimal TotalSale { get; set; }
        public decimal TotalWOWBillSaleAmount { get; set; }
        public int WorkingDays { get; set; }
        public decimal WowBill { get; set; }
        public int Year { get; set; }
    }

}

