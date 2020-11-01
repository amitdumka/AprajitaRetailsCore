using System;

/// <summary>
/// Version 3.0
/// </summary>
namespace AprajitaRetails.Shared.Models.Accountings.Models
{
    public class AppInfo
    {
        public int AppInfoId { get; set; }
        public string Version { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateOn { get; set; }
        public string DatabaseVersion { get; set; }
        public bool IsEffective { get; set; }
    }


}



