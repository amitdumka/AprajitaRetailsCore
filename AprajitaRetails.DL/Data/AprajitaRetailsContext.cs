using AprajitaRetails.Shared.Models;
using AprajitaRetails.Shared.Models.Accounts.Banking;
using AprajitaRetails.Shared.Models.Accounts.Expenses;
using AprajitaRetails.Shared.Models.Indentity;
using AprajitaRetails.Shared.Models.Payrolls;
using AprajitaRetails.Shared.Models.Sales;
using AprajitaRetails.Shared.Models.Stores;
using AprajitaRetails.Shared.Models.Tailorings;
using AprajitaRetails.Shared.Models.ToDos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

/// <summary>
/// @Version: 5.0
/// </summary>

namespace AprajitaRetails.DL.Data
{
    public class AprajitaRetailsContext : IdentityDbContext<AppUser>
    {
        public AprajitaRetailsContext(DbContextOptions<AprajitaRetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<TranscationMode> TranscationModes { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }

        //Banking
        public DbSet<Bank> Banks { get; set; }

        //TODO
        public DbSet<ToDoMessage> ToDoMessages { get; set; }

        public DbSet<TodoItem> Todos { get; set; }
        public DbSet<FileInfo> Files { get; set; }
        public DbSet<SaleTaxType> SaleTaxTypes { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<AppInfo> Apps { get; set; }

        //Payrolls
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        //Tailoring
        public DbSet<TalioringBooking> TalioringBookings { get; set; }

        public DbSet<TalioringDelivery> TailoringDeliveries { get; set; }

        //End of Day
        public DbSet<EndOfDay> EndOfDays { get; set; }

        public DbSet<CashDetail> CashDetail { get; set; }

        //Rent and Electricity
        public DbSet<RentedLocation> RentedLocations { get; set; }

        public DbSet<Rent> Rents { get; set; }
        public DbSet<ElectricityConnection> ElectricityConnections { get; set; }
        public DbSet<EletricityBill> EletricityBills { get; set; }
        public DbSet<EBillPayment> BillPayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>().ToTable("Todo");
            modelBuilder.Entity<FileInfo>().ToTable("File");
            modelBuilder.Entity<TodoItem>()
                .Property(e => e.Tags)
                .HasConversion(v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            modelBuilder.Entity<TranscationMode>()
              .HasIndex(b => b.Transcation)
              .IsUnique();


            modelBuilder.Entity<Store>().HasData(new Store { StoreId=1, StoreCode="JH0006", Address="Bhagalpur Road Dumka", City="Dumka", GSTNO="20AJHPA739P1zv", 
            NoOfEmployees=9, OpeningDate= new DateTime(2016,2,17).Date, PanNo="AJHPA7396P", StoreName="Aprajita Retails", PinCode="814101", 
            Status=true, PhoneNo="06434-224461", StoreManagerName="Alok Kumar", StoreManagerPhoneNo=""            });

            modelBuilder.Entity<Salesman>().HasData(new Salesman { SalesmanId = 1, SalesmanName = "Sanjeev Mishra", StoreId = 1 });
            modelBuilder.Entity<Salesman>().HasData(new Salesman { SalesmanId = 2, SalesmanName = "Mukesh Mandal", StoreId = 1 });
            modelBuilder.Entity<Salesman>().HasData(new Salesman { SalesmanId = 3, SalesmanName = "Manager", StoreId = 1 });
            modelBuilder.Entity<Salesman>().HasData(new Salesman { SalesmanId = 4, SalesmanName = "Bikash Kumar Sah", StoreId = 1 });

            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 1, BankName = "State Bank of India" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 2, BankName = "ICICI Bank" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 3, BankName = "Bandhan Bank" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 4, BankName = "Punjab National Bank" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 5, BankName = "Bank of Baroda" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 6, BankName = "Axis Bank" });
            modelBuilder.Entity<Bank>().HasData(new Bank() { BankId = 7, BankName = "HDFC Bank" });

            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 1, Transcation = "Home Expenses" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 2, Transcation = "Other Home Expenses" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 3, Transcation = "Mukesh(Home Staff)" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 4, Transcation = "Amit Kumar" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 5, Transcation = "Amit Kumar Expenses" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 6, Transcation = "CashIn" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 7, Transcation = "CashOut" });
            modelBuilder.Entity<TranscationMode>().HasData(new TranscationMode { TranscationModeId = 8, Transcation = "Regular" });

            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 1, CompositeRate = 5, TaxName = "Local Output GST@ 5%  ", TaxType = TaxType.GST });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 2, CompositeRate = 12, TaxName = "Local Output GST@ 12%  ", TaxType = TaxType.GST });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 3, CompositeRate = 5, TaxName = "Output IGST@ 5%  ", TaxType = TaxType.IGST });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 4, CompositeRate = 12, TaxName = "Output IGST@ 12%  ", TaxType = TaxType.IGST });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 5, CompositeRate = 5, TaxName = "Output Vat@ 12%  ", TaxType = TaxType.VAT });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 6, CompositeRate = 12, TaxName = "Output VAT@ 5%  ", TaxType = TaxType.VAT });
            modelBuilder.Entity<SaleTaxType>().HasData(new SaleTaxType { SaleTaxTypeId = 7, CompositeRate = 5, TaxName = "Output Vat Free  ", TaxType = TaxType.VAT });
        }

        public void ApplyMigrations(AprajitaRetailsContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
}