using AprajitaRetails.BL.Accounts;
using AprajitaRetails.BL.Admin;
using AprajitaRetails.BL.DataHelpers;
using AprajitaRetails.BL.Services;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Indentity;
using AprajitaRetails.Shared.Models.Payrolls;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprajitaRetails.BL.Payrolls
{
    public class EmployeeManager
    {
        public static async System.Threading.Tasks.Task AddEmployeeLoginAsync(AprajitaRetailsContext db, Employee employee, UserManager<AppUser> userManager)
        {
            if (employee != null && employee.IsWorking)
            {
                await UserAdmin.AddUserAsync(userManager, employee);

                //if (employee.IsWorking)
                //{

                //    await UserAdmin.AddEmployeeUserAsync(db, employee.StaffName, employee.EmployeeId);
                //}
            }
            else
            {
                throw new Exception();
            }



        }
    }

    public class PayrollManager
    {
        public void ONInsertOrUpdate(AprajitaRetailsContext db, Attendance attendance, bool isDeleted, bool isUpdated)
        {
            try
            {
                if (!isDeleted && !isUpdated)
                {
                    var sName = db.Employees.Find(attendance.EmployeeId).StaffName;
                    if (attendance.Status != AttUnit.Present && attendance.Status != AttUnit.Sunday && attendance.Status != AttUnit.SundayHoliday)
                    {
                        MyMail.SendEmail("Att(+):\t" + sName + " Attendance Report status.", sName + " is not present and current status is " + attendance.Status + " on date " + attendance.AttDate, "amitnarayansah@gmail.com");
                    }

                    // HRMBot.NotifyStaffAttandance(db, sName, attendance.AttendanceId, attendance.Status, attendance.EntryTime);
                }
                else if (isDeleted)
                {
                    var sName = db.Employees.Find(attendance.EmployeeId).StaffName;
                    MyMail.SendEmail(sName + " Attendance Report status for delete.", sName + " is deleted and current status was " + attendance.Status + " on date " + attendance.AttDate, "amitnarayansah@gmail.com");
                }
                else if (isUpdated)
                {
                    var sName = db.Employees.Find(attendance.EmployeeId).StaffName;
                    var before = db.Attendances.Where(c => c.AttendanceId == attendance.AttendanceId).Select(c => c.Status).FirstOrDefault();
                    MyMail.SendEmail(sName + " Attendance Report  status for Updated Record. It was " + before, sName + " is updated and current status is " + attendance.Status + " on date " + attendance.AttDate, "amitnarayansah@gmail.com");
                    //  HRMBot.NotifyStaffAttandance(db, sName, attendance.AttendanceId, attendance.Status, attendance.EntryTime);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
        }

        public void OnInsert(AprajitaRetailsContext db, StaffAdvanceReceipt salPayment)
        {
            UpdateInAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.ReceiptDate, false);
            // HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Advance Receipt: " + salPayment.Details, true);
        }

        //public void OnInsert(AprajitaRetailsContext db, StaffAdvancePayment salPayment)
        //{
        //    UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, false);
        //    HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Advance Payment: " + salPayment.Details);
        //}

        public void OnInsert(AprajitaRetailsContext db, SalaryPayment salPayment)
        {
            UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, false);
            // HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Salary payment for month of " + salPayment.SalaryMonth + "  details: " + salPayment.Details);
            ;
        }

        public void OnDelete(AprajitaRetailsContext db, SalaryPayment salPayment)
        {
            UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, true);
        }

        public void OnDelete(AprajitaRetailsContext db, StaffAdvanceReceipt salPayment)
        {
            UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.ReceiptDate, true);
        }

        //public void OnDelete(AprajitaRetailsContext db, StaffAdvancePayment salPayment)
        //{
        //    UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, true);
        //}

        public void OnUpdate(AprajitaRetailsContext db, SalaryPayment salPayment)
        {
            //    var old = db.SalaryPayments.Where(c => c.SalaryPaymentId == salPayment.SalaryPaymentId).Select(d => new { d.Amount, d.PaymentDate, d.PayMode }).FirstOrDefault();
            //    if (old != null)
            //    {
            //        UpdateOutAmount(db, old.Amount, old.PayMode, old.PaymentDate, true);
            //    }
            //    UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, false);
            //    HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Salary payment for month of " + salPayment.SalaryMonth + "  details: " + salPayment.Details);
        }

        //public void OnUpdate(AprajitaRetailsContext db, StaffAdvancePayment salPayment)
        //{
        //    var old = db.StaffAdvancePayments.Where(c => c.StaffAdvancePaymentId == salPayment.StaffAdvancePaymentId).Select(d => new { d.Amount, d.PaymentDate, d.PayMode }).FirstOrDefault();
        //    if (old != null)
        //    {
        //        UpdateOutAmount(db, old.Amount, old.PayMode, old.PaymentDate, true);
        //    }
        //    UpdateOutAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.PaymentDate, false);
        //    HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Advance Payment: " + salPayment.Details);
        //}

        public void OnUpdate(AprajitaRetailsContext db, StaffAdvanceReceipt salPayment)
        {
            //var old = db.StaffAdvanceReceipts.Where(c => c.StaffAdvanceReceiptId == salPayment.StaffAdvanceReceiptId).Select(d => new { d.Amount, d.ReceiptDate, d.PayMode }).FirstOrDefault();
            //if (old != null)
            //{
            //    UpdateInAmount(db, old.Amount, old.PayMode, old.ReceiptDate, true);
            //}
            //UpdateInAmount(db, salPayment.Amount, salPayment.PayMode, salPayment.ReceiptDate, false);
            //HRMBot.NotifyStaffPayment(db, "", salPayment.EmployeeId, salPayment.Amount, "Advance Receipt: " + salPayment.Details, true);
        }

        //private void UpDateSalaryAmount(AprajitaRetailsContext db, SalaryPayment salPayment, bool IsEdit)
        //{
        //    if (IsEdit)
        //    {
        //        if (salPayment.PayMode == PayMode.Cash)
        //        {
        //            CashTrigger.UpDateCashOutHand(db, salPayment.PaymentDate, 0 - salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpDateCashOutBank(db, salPayment.PaymentDate, 0 - (salPayment.Amount - salPayment.Amount));
        //        }
        //    }
        //    else
        //    {
        //        if (salPayment.PayMode == PayMode.Cash )
        //        {
        //            CashTrigger.UpDateCashOutHand(db, salPayment.PaymentDate, salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpDateCashOutBank(db, salPayment.PaymentDate, salPayment.Amount - salPayment.Amount);
        //        }
        //    }

        //}
        //private void UpDateStaffPaymentAmount(AprajitaRetailsContext db, StaffAdvancePayment salPayment, bool IsEdit)
        //{
        //    if (IsEdit)
        //    {
        //        if (salPayment.PayMode == PayMode.Cash)
        //        {
        //            CashTrigger.UpDateCashOutHand(db, salPayment.PaymentDate, 0 - salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpDateCashOutBank(db, salPayment.PaymentDate, 0 - (salPayment.Amount - salPayment.Amount));
        //        }
        //    }
        //    else
        //    {
        //        if (salPayment.PayMode == PayMode.Cash)
        //        {
        //            CashTrigger.UpDateCashOutHand(db, salPayment.PaymentDate, salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpDateCashOutBank(db, salPayment.PaymentDate, salPayment.Amount - salPayment.Amount);
        //        }
        //    }

        //}
        //private void UpDateStaffReciptAmount(AprajitaRetailsContext db, StaffAdvanceReceipt salPayment, bool IsEdit)
        //{
        //    if (IsEdit)
        //    {
        //        if (salPayment.PayMode == PayMode.Cash)
        //        {
        //            CashTrigger.UpdateCashInHand(db, salPayment.ReceiptDate, 0 - salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpdateCashInBank(db, salPayment.ReceiptDate, 0 - (salPayment.Amount - salPayment.Amount));
        //        }
        //    }
        //    else
        //    {
        //        if (salPayment.PayMode == PayMode.Cash)
        //        {
        //            CashTrigger.UpdateCashInHand(db, salPayment.ReceiptDate, salPayment.Amount);

        //        }
        //        //TODO: in future make it more robust
        //        if (salPayment.PayMode != PayMode.Cash && salPayment.PayMode != PayMode.Coupons && salPayment.PayMode != PayMode.Points)
        //        {
        //            CashTrigger.UpdateCashInBank(db, salPayment.ReceiptDate, salPayment.Amount - salPayment.Amount);
        //        }
        //    }

        //}

        private void UpdateOutAmount(AprajitaRetailsContext db, decimal Amount, PayMode PayMode, DateTime PaymentDate, bool IsEdit)
        {
            if (IsEdit)
            {
                if (PayMode == PayMode.Cash)
                {
                    CashTrigger.UpDateCashOutHand(db, PaymentDate, 0 - Amount);
                }
                //TODO: in future make it more robust
                if (PayMode != PayMode.Cash && PayMode != PayMode.Coupons && PayMode != PayMode.Points)
                {
                    CashTrigger.UpDateCashOutBank(db, PaymentDate, 0 - (Amount - Amount));
                }
            }
            else
            {
                if (PayMode == PayMode.Cash)
                {
                    CashTrigger.UpDateCashOutHand(db, PaymentDate, Amount);
                }
                //TODO: in future make it more robust
                if (PayMode != PayMode.Cash && PayMode != PayMode.Coupons && PayMode != PayMode.Points)
                {
                    CashTrigger.UpDateCashOutBank(db, PaymentDate, Amount - Amount);
                }
            }
        }

        private void UpdateInAmount(AprajitaRetailsContext db, decimal Amount, PayMode PayMode, DateTime PaymentDate, bool IsEdit)
        {
            if (IsEdit)
            {
                if (PayMode == PayMode.Cash)
                {
                    CashTrigger.UpdateCashInHand(db, PaymentDate, 0 - Amount);
                }
                //TODO: in future make it more robust
                if (PayMode != PayMode.Cash && PayMode != PayMode.Coupons && PayMode != PayMode.Points)
                {
                    CashTrigger.UpdateCashInBank(db, PaymentDate, 0 - (Amount - Amount));
                }
            }
            else
            {
                if (PayMode == PayMode.Cash)
                {
                    CashTrigger.UpdateCashInHand(db, PaymentDate, Amount);
                }
                //TODO: in future make it more robust
                if (PayMode != PayMode.Cash && PayMode != PayMode.Coupons && PayMode != PayMode.Points)
                {
                    CashTrigger.UpdateCashInBank(db, PaymentDate, Amount - Amount);
                }
            }
        }
    }

    /// <summary>
    /// Client based Speical Ops.
    /// </summary>
    public class PayrollSpecialOps
    {
        /// <summary>
        /// Marked Attendance for Store Closed; Store Based Special Function;
        /// </summary>
        /// <param name="db"></param>
        /// <param name="StoreId">Store Id for Employee </param>
        /// <param name="onDate">Date when store is closed</param>
        /// <param name="isHoliday">Is it general holiday or store closed due to some other reason</param>
        /// <param name="Reason">Mention the reason store is closed.</param>
        /// <returns>return true when success; false when error occured.</returns>
        public static async Task<bool> StoreClosedAsync(AprajitaRetailsContext db, int StoreId, DateTime onDate, bool isHoliday, string Reason)
        {
            var empId = await db.Employees.Where(c => c.StoreId == StoreId && c.IsWorking && !c.IsTailors).Select(c => c.EmployeeId).ToListAsync();
            List<Attendance> closedAtt = new List<Attendance>();
            foreach (var emp in empId)
            {
                Attendance newAtt = new Attendance
                {
                    AttDate = onDate.Date,
                    EmployeeId = emp,
                    EntryTime = String.Empty,
                    IsReadOnly = false,
                    IsTailoring = false,
                    Remarks = Reason,
                    StoreId = StoreId,
                    UserId = "AutoAdded",
                    EntryStatus = EntryStatus.Added
                };
                if (isHoliday)
                    newAtt.Status = AttUnit.Holiday;
                else
                    newAtt.Status = AttUnit.StoreClosed;
                closedAtt.Add(newAtt);

            }

            db.Attendances.AddRange(closedAtt);
            if (await db.SaveChangesAsync() > 0) return true; else return false;
        }

        /// <summary>
        /// Get Employee Attendance Report;
        /// </summary>
        /// <param name="db"></param>
        /// <param name="EmpId"></param>
        /// <param name="ondate"></param>
        /// <returns></returns>
        public static async Task<EmployeeAttendaceInfo> EmployeeAttendaceListAsync(AprajitaRetailsContext db, int EmpId, DateTime? ondate)
        {

            var emp = db.Employees.Find(EmpId);
            if (emp == null) return null;

            var empid = emp.EmployeeId;

            DateTime ValidDate = ondate.HasValue ? (DateTime)ondate : DateTime.Today;

            var attList = await db.Attendances
                            .Where(c => c.EmployeeId == empid && c.AttDate.Month == ValidDate.Month && c.AttDate.Year == ValidDate.Year)
                            .OrderBy(c => c.AttDate).ToListAsync();

            if (attList != null)
            {

                var p = attList.Where(c => c.Status == AttUnit.Present).Count();
                var a = attList.Where(c => c.Status == AttUnit.Absent).Count();
                int noofdays = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                int noofsunday = DateHelper.CountDays(DayOfWeek.Sunday, DateTime.Today);
                int sunPresent = attList.Where(c => c.Status == AttUnit.Sunday).Count();
                int halfDays = attList.Where(c => c.Status == AttUnit.HalfDay).Count();
                int totalAtt = p + sunPresent + (halfDays / 2);
                EmployeeAttendaceInfo info = new EmployeeAttendaceInfo
                {
                    EmpId = EmpId, 
                    StaffName=emp.StaffName,
                    Present = p,
                    Absent = a,
                    WorkingDays = noofdays,
                    Sundays = noofsunday,
                    SundayPresent = sunPresent,
                    HalfDays = halfDays,
                    Total = totalAtt, 
                    Attendances= attList

                };
                return info;

            }
            else { return null; }

        }
    }
    /// <summary>
    /// Move to Model Section
    /// </summary>
    public class EmployeeAttendaceInfo
    {
        public int EmpId { get; set;}
        public string StaffName { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; } // a;
        public int WorkingDays { get; set; } // noofdays;
        public int Sundays { get; set; } // noofsunday;
        public int SundayPresent { get; set; } // sunPresent;
        public int HalfDays { get; set; } // halfDays;
        public int Total { get; set; } // totalAtt;
        public List<Attendance> Attendances { get; set; }
    }

}