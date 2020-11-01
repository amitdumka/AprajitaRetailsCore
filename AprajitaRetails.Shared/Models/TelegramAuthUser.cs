using System.ComponentModel.DataAnnotations;

namespace AprajitaRetails.Models
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>

    public class TelegramAuthUser
    {
        public int TelegramAuthUserId { get; set; }
        public long TelegramChatId { get; set; }
        public string TelegramUserName { get; set; }
        [Phone]
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public EmpType EmpType { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}