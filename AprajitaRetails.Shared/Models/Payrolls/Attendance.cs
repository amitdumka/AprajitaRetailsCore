using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AprajitaRetails.Shared.Models.Stores;

namespace AprajitaRetails.Shared.Models.Payrolls
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>

    public class Attendance:BaseST
    {
        public int AttendanceId { get; set; }

        [Display(Name = "Staff Name")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Attendance Date")]
        public DateTime AttDate { get; set; }

        [Display(Name = "Entry Time")]
        public string EntryTime { get; set; }

        public AttUnit Status { get; set; }
        public string Remarks { get; set; }
        [Display(Name = "Tailor")]
        public bool IsTailoring { get; set; }
      
    }

    //public class AttendanceVM
    //{
    //    public int AttendanceVMId { get; set; }
    //    [Display(Name = "Staff Name")]
    //    public string EmployeeName { get; set; }

    //    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    //    [Display(Name = "Attendance Date")]
    //    public DateTime AttDate { get; set; }

    //    [Display(Name = "Entry Time")]
    //    public string EntryTime { get; set; }

    //    public int Status { get; set; }
    //    public string Remarks { get; set; }
    //    public bool? IsTailoring { get; set; }
    //    public int StoreCode { get; set; }
    //    public bool? IsDataConsumed { get; set; }
    //}
}