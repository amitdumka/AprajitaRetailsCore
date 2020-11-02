using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apps",
                columns: table => new
                {
                    AppInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    UpdateOn = table.Column<DateTime>(nullable: false),
                    DatabaseVersion = table.Column<string>(nullable: true),
                    IsEffective = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apps", x => x.AppInfoId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IsEmployee = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    IsWorking = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    BCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    IsPrimaryCategory = table.Column<bool>(nullable: false),
                    IsSecondaryCategory = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    NoOfBills = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    TodoId = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(maxLength: 500, nullable: true),
                    Size = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.TodoId);
                });

            migrationBuilder.CreateTable(
                name: "HSN",
                columns: table => new
                {
                    HSNCode = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    EffectiveDate = table.Column<DateTime>(nullable: false),
                    CESS = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSN", x => x.HSNCode);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTaxType",
                columns: table => new
                {
                    PurchaseTaxTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxName = table.Column<string>(nullable: true),
                    TaxType = table.Column<int>(nullable: false),
                    CompositeRate = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTaxType", x => x.PurchaseTaxTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredUsers",
                columns: table => new
                {
                    RegisteredUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailId = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastLoggedIn = table.Column<DateTime>(nullable: false),
                    IsUserLoggedIn = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredUsers", x => x.RegisteredUserId);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoice",
                columns: table => new
                {
                    SaleInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    TotalItems = table.Column<int>(nullable: false),
                    TotalQty = table.Column<double>(nullable: false),
                    TotalBillAmount = table.Column<decimal>(type: "money", nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(type: "money", nullable: false),
                    RoundOffAmount = table.Column<decimal>(type: "money", nullable: false),
                    TotalTaxAmount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoice", x => x.SaleInvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "SalesPerson",
                columns: table => new
                {
                    SalesPersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesmanName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPerson", x => x.SalesPersonId);
                });

            migrationBuilder.CreateTable(
                name: "SaleTaxTypes",
                columns: table => new
                {
                    SaleTaxTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxName = table.Column<string>(nullable: true),
                    TaxType = table.Column<int>(nullable: false),
                    CompositeRate = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleTaxTypes", x => x.SaleTaxTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreCode = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    StoreManagerName = table.Column<string>(nullable: true),
                    StoreManagerPhoneNo = table.Column<string>(nullable: true),
                    PanNo = table.Column<string>(nullable: true),
                    GSTNO = table.Column<string>(nullable: true),
                    NoOfEmployees = table.Column<int>(nullable: false),
                    OpeningDate = table.Column<DateTime>(nullable: false),
                    ClosingDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuppilerName = table.Column<string>(nullable: true),
                    Warehouse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "ToDoMessages",
                columns: table => new
                {
                    ToDoMessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    OnDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    OverDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    IsOver = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoMessages", x => x.ToDoMessageId);
                });

            migrationBuilder.CreateTable(
                name: "TranscationModes",
                columns: table => new
                {
                    TranscationModeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transcation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranscationModes", x => x.TranscationModeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductItem",
                columns: table => new
                {
                    ProductItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    StyleCode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ItemDesc = table.Column<string>(nullable: true),
                    Categorys = table.Column<int>(nullable: false),
                    MainCategoryCategoryId = table.Column<int>(nullable: true),
                    ProductCategoryCategoryId = table.Column<int>(nullable: true),
                    ProductTypeCategoryId = table.Column<int>(nullable: true),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false),
                    HSNCode = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Units = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItem", x => x.ProductItemId);
                    table.ForeignKey(
                        name: "FK_ProductItem_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductItem_Category_MainCategoryCategoryId",
                        column: x => x.MainCategoryCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductItem_Category_ProductCategoryCategoryId",
                        column: x => x.ProductCategoryCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductItem_Category_ProductTypeCategoryId",
                        column: x => x.ProductTypeCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(maxLength: 200, nullable: true),
                    Done = table.Column<bool>(nullable: false),
                    Added = table.Column<DateTime>(nullable: false),
                    DueTo = table.Column<DateTime>(nullable: false),
                    FileTodoId = table.Column<Guid>(nullable: true),
                    Tags = table.Column<string>(maxLength: 10, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todo_File_FileTodoId",
                        column: x => x.FileTodoId,
                        principalTable: "File",
                        principalColumn: "TodoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalePaymentDetail",
                columns: table => new
                {
                    SalePaymentDetailId = table.Column<int>(nullable: false),
                    PayMode = table.Column<int>(nullable: false),
                    CashAmount = table.Column<decimal>(type: "money", nullable: false),
                    CardAmount = table.Column<decimal>(type: "money", nullable: false),
                    MixAmount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePaymentDetail", x => x.SalePaymentDetailId);
                    table.ForeignKey(
                        name: "FK_SalePaymentDetail_SaleInvoice_SalePaymentDetailId",
                        column: x => x.SalePaymentDetailId,
                        principalTable: "SaleInvoice",
                        principalColumn: "SaleInvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashDetail",
                columns: table => new
                {
                    CashDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    C2000 = table.Column<int>(nullable: false),
                    C1000 = table.Column<int>(nullable: false),
                    C500 = table.Column<int>(nullable: false),
                    C100 = table.Column<int>(nullable: false),
                    C50 = table.Column<int>(nullable: false),
                    C20 = table.Column<int>(nullable: false),
                    C10 = table.Column<int>(nullable: false),
                    C5 = table.Column<int>(nullable: false),
                    Coin10 = table.Column<int>(nullable: false),
                    Coin5 = table.Column<int>(nullable: false),
                    Coin2 = table.Column<int>(nullable: false),
                    Coin1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashDetail", x => x.CashDetailId);
                    table.ForeignKey(
                        name: "FK_CashDetail_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashInBank",
                columns: table => new
                {
                    CashInBankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIBDate = table.Column<DateTime>(nullable: false),
                    OpenningBalance = table.Column<decimal>(type: "money", nullable: false),
                    ClosingBalance = table.Column<decimal>(type: "money", nullable: false),
                    CashIn = table.Column<decimal>(type: "money", nullable: false),
                    CashOut = table.Column<decimal>(type: "money", nullable: false),
                    StoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInBank", x => x.CashInBankId);
                    table.ForeignKey(
                        name: "FK_CashInBank_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CashInHand",
                columns: table => new
                {
                    CashInHandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIHDate = table.Column<DateTime>(nullable: false),
                    OpenningBalance = table.Column<decimal>(type: "money", nullable: false),
                    ClosingBalance = table.Column<decimal>(type: "money", nullable: false),
                    CashIn = table.Column<decimal>(type: "money", nullable: false),
                    CashOut = table.Column<decimal>(type: "money", nullable: false),
                    StoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInHand", x => x.CashInHandId);
                    table.ForeignKey(
                        name: "FK_CashInHand_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EDC",
                columns: table => new
                {
                    EDCId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    TID = table.Column<int>(nullable: false),
                    EDCName = table.Column<string>(nullable: true),
                    AccountNumberId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    MID = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDC", x => x.EDCId);
                    table.ForeignKey(
                        name: "FK_EDC_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityConnections",
                columns: table => new
                {
                    ElectricityConnectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    ConnectioName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    ConsumerNumber = table.Column<string>(nullable: true),
                    ConusumerId = table.Column<string>(nullable: true),
                    Connection = table.Column<int>(nullable: false),
                    ConnectinDate = table.Column<DateTime>(nullable: false),
                    DisconnectionDate = table.Column<DateTime>(nullable: true),
                    KVLoad = table.Column<int>(nullable: false),
                    OwnedMetter = table.Column<bool>(nullable: false),
                    TotalConnectionCharges = table.Column<decimal>(type: "money", nullable: false),
                    SecurityDeposit = table.Column<decimal>(type: "money", nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityConnections", x => x.ElectricityConnectionId);
                    table.ForeignKey(
                        name: "FK_ElectricityConnections_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    StaffName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: true),
                    IsWorking = table.Column<bool>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    IsTailors = table.Column<bool>(nullable: false),
                    EMail = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    AdharNumber = table.Column<string>(nullable: true),
                    PanNo = table.Column<string>(nullable: true),
                    OtherIdDetails = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    HighestQualification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EndOfDays",
                columns: table => new
                {
                    EndOfDayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EOD_Date = table.Column<DateTime>(nullable: false),
                    Shirting = table.Column<float>(nullable: false),
                    Suiting = table.Column<float>(nullable: false),
                    USPA = table.Column<int>(nullable: false),
                    FM_Arrow = table.Column<int>(nullable: false),
                    RWT = table.Column<int>(nullable: false),
                    Access = table.Column<int>(nullable: false),
                    CashInHand = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndOfDays", x => x.EndOfDayId);
                    table.ForeignKey(
                        name: "FK_EndOfDays_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportInWard",
                columns: table => new
                {
                    ImportInWardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InWardNo = table.Column<string>(nullable: true),
                    InWardDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    PartyName = table.Column<string>(nullable: true),
                    TotalQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalMRPValue = table.Column<decimal>(type: "money", nullable: false),
                    TotalCost = table.Column<decimal>(type: "money", nullable: false),
                    IsDataConsumed = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportInWard", x => x.ImportInWardId);
                    table.ForeignKey(
                        name: "FK_ImportInWard_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportPurchase",
                columns: table => new
                {
                    ImportPurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRNNo = table.Column<string>(nullable: true),
                    GRNDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    StyleCode = table.Column<string>(nullable: true),
                    ItemDesc = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    MRPValue = table.Column<decimal>(type: "money", nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false),
                    CostValue = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmt = table.Column<decimal>(type: "money", nullable: false),
                    IsVatBill = table.Column<bool>(nullable: false),
                    IsLocal = table.Column<bool>(nullable: false),
                    IsDataConsumed = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportPurchase", x => x.ImportPurchaseId);
                    table.ForeignKey(
                        name: "FK_ImportPurchase_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportSaleItemWise",
                columns: table => new
                {
                    ImportSaleItemWiseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ItemDesc = table.Column<string>(nullable: true),
                    HSNCode = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    StyleCode = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    BasicRate = table.Column<decimal>(type: "money", nullable: false),
                    Tax = table.Column<decimal>(type: "money", nullable: false),
                    SGST = table.Column<decimal>(type: "money", nullable: false),
                    CGST = table.Column<decimal>(type: "money", nullable: false),
                    LineTotal = table.Column<decimal>(type: "money", nullable: false),
                    RoundOff = table.Column<decimal>(type: "money", nullable: false),
                    BillAmnt = table.Column<decimal>(type: "money", nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    Saleman = table.Column<string>(nullable: true),
                    IsDataConsumed = table.Column<bool>(nullable: false),
                    IsVatBill = table.Column<bool>(nullable: false),
                    IsLocal = table.Column<bool>(nullable: false),
                    LP = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportSaleItemWise", x => x.ImportSaleItemWiseId);
                    table.ForeignKey(
                        name: "FK_ImportSaleItemWise_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportSaleRegister",
                columns: table => new
                {
                    ImportSaleRegisterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    BasicRate = table.Column<decimal>(type: "money", nullable: false),
                    Tax = table.Column<decimal>(type: "money", nullable: false),
                    RoundOff = table.Column<decimal>(type: "money", nullable: false),
                    BillAmnt = table.Column<decimal>(type: "money", nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    IsConsumed = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportSaleRegister", x => x.ImportSaleRegisterId);
                    table.ForeignKey(
                        name: "FK_ImportSaleRegister_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixAndCouponPayment",
                columns: table => new
                {
                    MixAndCouponPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    OnDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    ModeMixAndCouponPaymentId = table.Column<int>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixAndCouponPayment", x => x.MixAndCouponPaymentId);
                    table.ForeignKey(
                        name: "FK_MixAndCouponPayment_MixAndCouponPayment_ModeMixAndCouponPaymentId",
                        column: x => x.ModeMixAndCouponPaymentId,
                        principalTable: "MixAndCouponPayment",
                        principalColumn: "MixAndCouponPaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MixAndCouponPayment_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegularInvoice",
                columns: table => new
                {
                    InvoiceNo = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    TotalItems = table.Column<int>(nullable: false),
                    TotalQty = table.Column<double>(nullable: false),
                    TotalBillAmount = table.Column<decimal>(type: "money", nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(type: "money", nullable: false),
                    RoundOffAmount = table.Column<decimal>(type: "money", nullable: false),
                    TotalTaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    RegularInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsManualBill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularInvoice", x => x.InvoiceNo);
                    table.ForeignKey(
                        name: "FK_RegularInvoice_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegularInvoice_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentedLocations",
                columns: table => new
                {
                    RentedLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    PlaceName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OnDate = table.Column<DateTime>(nullable: false),
                    VacatedDate = table.Column<DateTime>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    RentAmount = table.Column<decimal>(nullable: false),
                    AdvanceAmount = table.Column<decimal>(nullable: false),
                    IsRented = table.Column<bool>(nullable: false),
                    RentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedLocations", x => x.RentedLocationId);
                    table.ForeignKey(
                        name: "FK_RentedLocations_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalioringBookings",
                columns: table => new
                {
                    TalioringBookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    CustName = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    TryDate = table.Column<DateTime>(nullable: false),
                    BookingSlipNo = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    TotalQty = table.Column<int>(nullable: false),
                    ShirtQty = table.Column<int>(nullable: false),
                    ShirtPrice = table.Column<decimal>(type: "money", nullable: false),
                    PantQty = table.Column<int>(nullable: false),
                    PantPrice = table.Column<decimal>(type: "money", nullable: false),
                    CoatQty = table.Column<int>(nullable: false),
                    CoatPrice = table.Column<decimal>(type: "money", nullable: false),
                    KurtaQty = table.Column<int>(nullable: false),
                    KurtaPrice = table.Column<decimal>(type: "money", nullable: false),
                    BundiQty = table.Column<int>(nullable: false),
                    BundiPrice = table.Column<decimal>(type: "money", nullable: false),
                    Others = table.Column<int>(nullable: false),
                    OthersPrice = table.Column<decimal>(type: "money", nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalioringBookings", x => x.TalioringBookingId);
                    table.ForeignKey(
                        name: "FK_TalioringBookings_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPurchase",
                columns: table => new
                {
                    ProductPurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    InWardNo = table.Column<string>(nullable: true),
                    InWardDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    TotalQty = table.Column<double>(nullable: false),
                    TotalBasicAmount = table.Column<decimal>(type: "money", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "money", nullable: false),
                    TotalTax = table.Column<decimal>(type: "money", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPurchase", x => x.ProductPurchaseId);
                    table.ForeignKey(
                        name: "FK_ProductPurchase_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPurchase_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashPayment",
                columns: table => new
                {
                    CashPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    TranscationModeId = table.Column<int>(nullable: false),
                    PaidTo = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    SlipNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPayment", x => x.CashPaymentId);
                    table.ForeignKey(
                        name: "FK_CashPayment_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashPayment_TranscationModes_TranscationModeId",
                        column: x => x.TranscationModeId,
                        principalTable: "TranscationModes",
                        principalColumn: "TranscationModeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CashReceipt",
                columns: table => new
                {
                    CashReceiptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    InwardDate = table.Column<DateTime>(nullable: false),
                    TranscationModeId = table.Column<int>(nullable: false),
                    ReceiptFrom = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    SlipNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashReceipt", x => x.CashReceiptId);
                    table.ForeignKey(
                        name: "FK_CashReceipt_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CashReceipt_TranscationModes_TranscationModeId",
                        column: x => x.TranscationModeId,
                        principalTable: "TranscationModes",
                        principalColumn: "TranscationModeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
                columns: table => new
                {
                    SaleItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleInvoiceId = table.Column<int>(nullable: false),
                    ProductItemId = table.Column<int>(nullable: false),
                    BarCode = table.Column<string>(nullable: true),
                    Qty = table.Column<double>(nullable: false),
                    Units = table.Column<int>(nullable: false),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    BasicAmount = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    SaleTaxTypeId = table.Column<int>(nullable: true),
                    BillAmount = table.Column<decimal>(type: "money", nullable: false),
                    SalesPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItem", x => x.SaleItemId);
                    table.ForeignKey(
                        name: "FK_SaleItem_ProductItem_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItem",
                        principalColumn: "ProductItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItem_SaleInvoice_SaleInvoiceId",
                        column: x => x.SaleInvoiceId,
                        principalTable: "SaleInvoice",
                        principalColumn: "SaleInvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItem_SaleTaxTypes_SaleTaxTypeId",
                        column: x => x.SaleTaxTypeId,
                        principalTable: "SaleTaxTypes",
                        principalColumn: "SaleTaxTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleItem_SalesPerson_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPerson",
                        principalColumn: "SalesPersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    ProductItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    SaleQty = table.Column<double>(nullable: false),
                    PurchaseQty = table.Column<double>(nullable: false),
                    Units = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_ProductItem_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItem",
                        principalColumn: "ProductItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardPaymentDetail",
                columns: table => new
                {
                    CardPaymentDetailId = table.Column<int>(nullable: false),
                    SaleInvoiceId = table.Column<int>(nullable: false),
                    CardType = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    AuthCode = table.Column<int>(nullable: false),
                    LastDigit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPaymentDetail", x => x.CardPaymentDetailId);
                    table.ForeignKey(
                        name: "FK_CardPaymentDetail_SalePaymentDetail_CardPaymentDetailId",
                        column: x => x.CardPaymentDetailId,
                        principalTable: "SalePaymentDetail",
                        principalColumn: "SalePaymentDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EDCTranscation",
                columns: table => new
                {
                    EDCTranscationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EDCId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    CardEndingNumber = table.Column<string>(nullable: true),
                    CardTypes = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDCTranscation", x => x.EDCTranscationId);
                    table.ForeignKey(
                        name: "FK_EDCTranscation_EDC_EDCId",
                        column: x => x.EDCId,
                        principalTable: "EDC",
                        principalColumn: "EDCId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EDCTranscation_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EletricityBills",
                columns: table => new
                {
                    EletricityBillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    ElectricityConnectionId = table.Column<int>(nullable: false),
                    BillNumber = table.Column<string>(nullable: true),
                    BillDate = table.Column<DateTime>(nullable: false),
                    MeterReadingDate = table.Column<DateTime>(nullable: false),
                    CurrentMeterReading = table.Column<double>(nullable: false),
                    TotalUnit = table.Column<double>(nullable: false),
                    CurrentAmount = table.Column<decimal>(type: "money", nullable: false),
                    ArrearAmount = table.Column<decimal>(type: "money", nullable: false),
                    NetDemand = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EletricityBills", x => x.EletricityBillId);
                    table.ForeignKey(
                        name: "FK_EletricityBills_ElectricityConnections_ElectricityConnectionId",
                        column: x => x.ElectricityConnectionId,
                        principalTable: "ElectricityConnections",
                        principalColumn: "ElectricityConnectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EletricityBills_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    AttDate = table.Column<DateTime>(nullable: false),
                    EntryTime = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    IsTailoring = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    IsWorking = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salesmen",
                columns: table => new
                {
                    SalesmanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    SalesmanName = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesmen", x => x.SalesmanId);
                    table.ForeignKey(
                        name: "FK_Salesmen_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salesmen_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetail",
                columns: table => new
                {
                    InvoiceNo = table.Column<string>(nullable: false),
                    PaymentDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayMode = table.Column<int>(nullable: false),
                    CashAmount = table.Column<decimal>(type: "money", nullable: false),
                    CardAmount = table.Column<decimal>(type: "money", nullable: false),
                    MixAmount = table.Column<decimal>(type: "money", nullable: false),
                    IsManualBill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.InvoiceNo);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_RegularInvoice_InvoiceNo",
                        column: x => x.InvoiceNo,
                        principalTable: "RegularInvoice",
                        principalColumn: "InvoiceNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    RentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    RentedLocationId = table.Column<int>(nullable: false),
                    RentType = table.Column<int>(nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    Period = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    PaymentDetails = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_Rents_RentedLocations_RentedLocationId",
                        column: x => x.RentedLocationId,
                        principalTable: "RentedLocations",
                        principalColumn: "RentedLocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TailoringDeliveries",
                columns: table => new
                {
                    TalioringDeliveryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    TalioringBookingId = table.Column<int>(nullable: false),
                    InvNo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TailoringDeliveries", x => x.TalioringDeliveryId);
                    table.ForeignKey(
                        name: "FK_TailoringDeliveries_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TailoringDeliveries_TalioringBookings_TalioringBookingId",
                        column: x => x.TalioringBookingId,
                        principalTable: "TalioringBookings",
                        principalColumn: "TalioringBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItem",
                columns: table => new
                {
                    PurchaseItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPurchaseId = table.Column<int>(nullable: false),
                    ProductItemId = table.Column<int>(nullable: false),
                    Barcode = table.Column<string>(nullable: true),
                    Qty = table.Column<double>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmout = table.Column<decimal>(type: "money", nullable: false),
                    PurchaseTaxTypeId = table.Column<int>(nullable: true),
                    CostValue = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItem", x => x.PurchaseItemId);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_ProductItem_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItem",
                        principalColumn: "ProductItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_ProductPurchase_ProductPurchaseId",
                        column: x => x.ProductPurchaseId,
                        principalTable: "ProductPurchase",
                        principalColumn: "ProductPurchaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItem_PurchaseTaxType_PurchaseTaxTypeId",
                        column: x => x.PurchaseTaxTypeId,
                        principalTable: "PurchaseTaxType",
                        principalColumn: "PurchaseTaxTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillPayments",
                columns: table => new
                {
                    EBillPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    EletricityBillId = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    PaymentDetails = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    IsPartialPayment = table.Column<bool>(nullable: false),
                    IsBillCleared = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayments", x => x.EBillPaymentId);
                    table.ForeignKey(
                        name: "FK_BillPayments_EletricityBills_EletricityBillId",
                        column: x => x.EletricityBillId,
                        principalTable: "EletricityBills",
                        principalColumn: "EletricityBillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillPayments_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DailySale",
                columns: table => new
                {
                    DailySaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    InvNo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    PayMode = table.Column<int>(nullable: false),
                    CashAmount = table.Column<decimal>(type: "money", nullable: false),
                    SalesmanId = table.Column<int>(nullable: false),
                    IsDue = table.Column<bool>(nullable: false),
                    IsManualBill = table.Column<bool>(nullable: false),
                    IsTailoringBill = table.Column<bool>(nullable: false),
                    IsSaleReturn = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    IsMatchedWithVOy = table.Column<bool>(nullable: false),
                    EDCTranscationId = table.Column<int>(nullable: true),
                    MixAndCouponPaymentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailySale", x => x.DailySaleId);
                    table.ForeignKey(
                        name: "FK_DailySale_EDCTranscation_EDCTranscationId",
                        column: x => x.EDCTranscationId,
                        principalTable: "EDCTranscation",
                        principalColumn: "EDCTranscationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailySale_MixAndCouponPayment_MixAndCouponPaymentId",
                        column: x => x.MixAndCouponPaymentId,
                        principalTable: "MixAndCouponPayment",
                        principalColumn: "MixAndCouponPaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailySale_Salesmen_SalesmanId",
                        column: x => x.SalesmanId,
                        principalTable: "Salesmen",
                        principalColumn: "SalesmanId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DailySale_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegularSaleItem",
                columns: table => new
                {
                    RegularSaleItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductItemId = table.Column<int>(nullable: false),
                    BarCode = table.Column<string>(nullable: true),
                    Qty = table.Column<double>(nullable: false),
                    Units = table.Column<int>(nullable: false),
                    MRP = table.Column<decimal>(type: "money", nullable: false),
                    BasicAmount = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    SaleTaxTypeId = table.Column<int>(nullable: true),
                    BillAmount = table.Column<decimal>(type: "money", nullable: false),
                    SalesmanId = table.Column<int>(nullable: false),
                    HSNCode = table.Column<long>(nullable: true),
                    HSNCode1 = table.Column<long>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceNo1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularSaleItem", x => x.RegularSaleItemId);
                    table.ForeignKey(
                        name: "FK_RegularSaleItem_HSN_HSNCode1",
                        column: x => x.HSNCode1,
                        principalTable: "HSN",
                        principalColumn: "HSNCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegularSaleItem_RegularInvoice_InvoiceNo1",
                        column: x => x.InvoiceNo1,
                        principalTable: "RegularInvoice",
                        principalColumn: "InvoiceNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegularSaleItem_ProductItem_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItem",
                        principalColumn: "ProductItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegularSaleItem_SaleTaxTypes_SaleTaxTypeId",
                        column: x => x.SaleTaxTypeId,
                        principalTable: "SaleTaxTypes",
                        principalColumn: "SaleTaxTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegularSaleItem_Salesmen_SalesmanId",
                        column: x => x.SalesmanId,
                        principalTable: "Salesmen",
                        principalColumn: "SalesmanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardDetail",
                columns: table => new
                {
                    CardDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardType = table.Column<int>(nullable: false),
                    CardCode = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    AuthCode = table.Column<int>(nullable: false),
                    LastDigit = table.Column<int>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDetail", x => x.CardDetailId);
                    table.ForeignKey(
                        name: "FK_CardDetail_PaymentDetail_InvoiceNo",
                        column: x => x.InvoiceNo,
                        principalTable: "PaymentDetail",
                        principalColumn: "InvoiceNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CouponPayment",
                columns: table => new
                {
                    CouponPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponNumber = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    DailySaleId = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponPayment", x => x.CouponPaymentId);
                    table.ForeignKey(
                        name: "FK_CouponPayment_DailySale_DailySaleId",
                        column: x => x.DailySaleId,
                        principalTable: "DailySale",
                        principalColumn: "DailySaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointRedeemed",
                columns: table => new
                {
                    PointRedeemedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerMobileNumber = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    OnDate = table.Column<DateTime>(nullable: false),
                    DailySaleId = table.Column<int>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointRedeemed", x => x.PointRedeemedId);
                    table.ForeignKey(
                        name: "FK_PointRedeemed_DailySale_DailySaleId",
                        column: x => x.DailySaleId,
                        principalTable: "DailySale",
                        principalColumn: "DailySaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "BankId", "BankName" },
                values: new object[,]
                {
                    { 1, "State Bank of India" },
                    { 2, "ICICI Bank" },
                    { 3, "Bandhan Bank" },
                    { 4, "Punjab National Bank" },
                    { 5, "Bank of Baroda" },
                    { 6, "Axis Bank" },
                    { 7, "HDFC Bank" }
                });

            migrationBuilder.InsertData(
                table: "SaleTaxTypes",
                columns: new[] { "SaleTaxTypeId", "CompositeRate", "TaxName", "TaxType" },
                values: new object[,]
                {
                    { 7, 5m, "Output Vat Free  ", 4 },
                    { 6, 12m, "Output VAT@ 5%  ", 4 },
                    { 4, 12m, "Output IGST@ 12%  ", 3 },
                    { 5, 5m, "Output Vat@ 12%  ", 4 },
                    { 2, 12m, "Local Output GST@ 12%  ", 0 },
                    { 1, 5m, "Local Output GST@ 5%  ", 0 },
                    { 3, 5m, "Output IGST@ 5%  ", 3 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "City", "ClosingDate", "EntryStatus", "GSTNO", "IsReadOnly", "NoOfEmployees", "OpeningDate", "PanNo", "PhoneNo", "PinCode", "Status", "StoreCode", "StoreManagerName", "StoreManagerPhoneNo", "StoreName", "UserId" },
                values: new object[] { 1, "Bhagalpur Road Dumka", "Dumka", null, 0, "20AJHPA739P1zv", false, 9, new DateTime(2016, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AJHPA7396P", "06434-224461", "814101", true, "JH0006", "Alok Kumar", "", "Aprajita Retails", null });

            migrationBuilder.InsertData(
                table: "TranscationModes",
                columns: new[] { "TranscationModeId", "Transcation" },
                values: new object[,]
                {
                    { 7, "CashOut" },
                    { 1, "Home Expenses" },
                    { 2, "Other Home Expenses" },
                    { 3, "Mukesh(Home Staff)" },
                    { 4, "Amit Kumar" },
                    { 5, "Amit Kumar Expenses" },
                    { 6, "CashIn" },
                    { 8, "Regular" }
                });

            migrationBuilder.InsertData(
                table: "Salesmen",
                columns: new[] { "SalesmanId", "EmployeeId", "EntryStatus", "IsReadOnly", "SalesmanName", "StoreId", "UserId" },
                values: new object[,]
                {
                    { 1, null, 0, false, "Sanjeev Mishra", 1, null },
                    { 2, null, 0, false, "Mukesh Mandal", 1, null },
                    { 3, null, 0, false, "Manager", 1, null },
                    { 4, null, 0, false, "Bikash Kumar Sah", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_EmployeeId",
                table: "Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StoreId",
                table: "Attendances",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayments_EletricityBillId",
                table: "BillPayments",
                column: "EletricityBillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayments_StoreId",
                table: "BillPayments",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CardDetail_InvoiceNo",
                table: "CardDetail",
                column: "InvoiceNo",
                unique: true,
                filter: "[InvoiceNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CashDetail_StoreId",
                table: "CashDetail",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CashInBank_StoreId",
                table: "CashInBank",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CashInHand_StoreId",
                table: "CashInHand",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CashPayment_StoreId",
                table: "CashPayment",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CashPayment_TranscationModeId",
                table: "CashPayment",
                column: "TranscationModeId");

            migrationBuilder.CreateIndex(
                name: "IX_CashReceipt_StoreId",
                table: "CashReceipt",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CashReceipt_TranscationModeId",
                table: "CashReceipt",
                column: "TranscationModeId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponPayment_DailySaleId",
                table: "CouponPayment",
                column: "DailySaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailySale_EDCTranscationId",
                table: "DailySale",
                column: "EDCTranscationId");

            migrationBuilder.CreateIndex(
                name: "IX_DailySale_MixAndCouponPaymentId",
                table: "DailySale",
                column: "MixAndCouponPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_DailySale_SalesmanId",
                table: "DailySale",
                column: "SalesmanId");

            migrationBuilder.CreateIndex(
                name: "IX_DailySale_StoreId",
                table: "DailySale",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_EDC_StoreId",
                table: "EDC",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_EDCTranscation_EDCId",
                table: "EDCTranscation",
                column: "EDCId");

            migrationBuilder.CreateIndex(
                name: "IX_EDCTranscation_StoreId",
                table: "EDCTranscation",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityConnections_StoreId",
                table: "ElectricityConnections",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_EletricityBills_ElectricityConnectionId",
                table: "EletricityBills",
                column: "ElectricityConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EletricityBills_StoreId",
                table: "EletricityBills",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StoreId",
                table: "Employees",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUsers_EmployeeId",
                table: "EmployeeUsers",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EndOfDays_StoreId",
                table: "EndOfDays",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportInWard_StoreId",
                table: "ImportInWard",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportPurchase_StoreId",
                table: "ImportPurchase",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportSaleItemWise_StoreId",
                table: "ImportSaleItemWise",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportSaleRegister_StoreId",
                table: "ImportSaleRegister",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_MixAndCouponPayment_ModeMixAndCouponPaymentId",
                table: "MixAndCouponPayment",
                column: "ModeMixAndCouponPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_MixAndCouponPayment_StoreId",
                table: "MixAndCouponPayment",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_PointRedeemed_DailySaleId",
                table: "PointRedeemed",
                column: "DailySaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_BrandId",
                table: "ProductItem",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_MainCategoryCategoryId",
                table: "ProductItem",
                column: "MainCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_ProductCategoryCategoryId",
                table: "ProductItem",
                column: "ProductCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_ProductTypeCategoryId",
                table: "ProductItem",
                column: "ProductTypeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchase_StoreId",
                table: "ProductPurchase",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchase_SupplierID",
                table: "ProductPurchase",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_ProductItemId",
                table: "PurchaseItem",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_ProductPurchaseId",
                table: "PurchaseItem",
                column: "ProductPurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_PurchaseTaxTypeId",
                table: "PurchaseItem",
                column: "PurchaseTaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularInvoice_CustomerId",
                table: "RegularInvoice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularInvoice_StoreId",
                table: "RegularInvoice",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularSaleItem_HSNCode1",
                table: "RegularSaleItem",
                column: "HSNCode1");

            migrationBuilder.CreateIndex(
                name: "IX_RegularSaleItem_InvoiceNo1",
                table: "RegularSaleItem",
                column: "InvoiceNo1");

            migrationBuilder.CreateIndex(
                name: "IX_RegularSaleItem_ProductItemId",
                table: "RegularSaleItem",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularSaleItem_SaleTaxTypeId",
                table: "RegularSaleItem",
                column: "SaleTaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularSaleItem_SalesmanId",
                table: "RegularSaleItem",
                column: "SalesmanId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedLocations_StoreId",
                table: "RentedLocations",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_RentedLocationId",
                table: "Rents",
                column: "RentedLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_StoreId",
                table: "Rents",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_ProductItemId",
                table: "SaleItem",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SaleInvoiceId",
                table: "SaleItem",
                column: "SaleInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SaleTaxTypeId",
                table: "SaleItem",
                column: "SaleTaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SalesPersonId",
                table: "SaleItem",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Salesmen_EmployeeId",
                table: "Salesmen",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salesmen_StoreId",
                table: "Salesmen",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductItemId",
                table: "Stock",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_StoreId",
                table: "Stock",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TailoringDeliveries_StoreId",
                table: "TailoringDeliveries",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TailoringDeliveries_TalioringBookingId",
                table: "TailoringDeliveries",
                column: "TalioringBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_TalioringBookings_StoreId",
                table: "TalioringBookings",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Todo_FileTodoId",
                table: "Todo",
                column: "FileTodoId");

            migrationBuilder.CreateIndex(
                name: "IX_TranscationModes_Transcation",
                table: "TranscationModes",
                column: "Transcation",
                unique: true,
                filter: "[Transcation] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apps");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "BillPayments");

            migrationBuilder.DropTable(
                name: "CardDetail");

            migrationBuilder.DropTable(
                name: "CardPaymentDetail");

            migrationBuilder.DropTable(
                name: "CashDetail");

            migrationBuilder.DropTable(
                name: "CashInBank");

            migrationBuilder.DropTable(
                name: "CashInHand");

            migrationBuilder.DropTable(
                name: "CashPayment");

            migrationBuilder.DropTable(
                name: "CashReceipt");

            migrationBuilder.DropTable(
                name: "CouponPayment");

            migrationBuilder.DropTable(
                name: "EmployeeUsers");

            migrationBuilder.DropTable(
                name: "EndOfDays");

            migrationBuilder.DropTable(
                name: "ImportInWard");

            migrationBuilder.DropTable(
                name: "ImportPurchase");

            migrationBuilder.DropTable(
                name: "ImportSaleItemWise");

            migrationBuilder.DropTable(
                name: "ImportSaleRegister");

            migrationBuilder.DropTable(
                name: "PointRedeemed");

            migrationBuilder.DropTable(
                name: "PurchaseItem");

            migrationBuilder.DropTable(
                name: "RegisteredUsers");

            migrationBuilder.DropTable(
                name: "RegularSaleItem");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "TailoringDeliveries");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "ToDoMessages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EletricityBills");

            migrationBuilder.DropTable(
                name: "PaymentDetail");

            migrationBuilder.DropTable(
                name: "SalePaymentDetail");

            migrationBuilder.DropTable(
                name: "TranscationModes");

            migrationBuilder.DropTable(
                name: "DailySale");

            migrationBuilder.DropTable(
                name: "ProductPurchase");

            migrationBuilder.DropTable(
                name: "PurchaseTaxType");

            migrationBuilder.DropTable(
                name: "HSN");

            migrationBuilder.DropTable(
                name: "RentedLocations");

            migrationBuilder.DropTable(
                name: "SaleTaxTypes");

            migrationBuilder.DropTable(
                name: "SalesPerson");

            migrationBuilder.DropTable(
                name: "ProductItem");

            migrationBuilder.DropTable(
                name: "TalioringBookings");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "ElectricityConnections");

            migrationBuilder.DropTable(
                name: "RegularInvoice");

            migrationBuilder.DropTable(
                name: "SaleInvoice");

            migrationBuilder.DropTable(
                name: "EDCTranscation");

            migrationBuilder.DropTable(
                name: "MixAndCouponPayment");

            migrationBuilder.DropTable(
                name: "Salesmen");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "EDC");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
