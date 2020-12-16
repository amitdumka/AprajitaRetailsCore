using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class DueList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetail_PaymentDetail_InvoiceNo",
                table: "CardDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CashInBank_Stores_StoreId",
                table: "CashInBank");

            migrationBuilder.DropForeignKey(
                name: "FK_CashInHand_Stores_StoreId",
                table: "CashInHand");

            migrationBuilder.DropForeignKey(
                name: "FK_CouponPayment_DailySales_DailySaleId",
                table: "CouponPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySales_EDCTranscation_EDCTranscationId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySales_MixAndCouponPayment_MixAndCouponPaymentId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_EDC_Stores_StoreId",
                table: "EDC");

            migrationBuilder.DropForeignKey(
                name: "FK_EDCTranscation_EDC_EDCId",
                table: "EDCTranscation");

            migrationBuilder.DropForeignKey(
                name: "FK_EDCTranscation_Stores_StoreId",
                table: "EDCTranscation");

            migrationBuilder.DropForeignKey(
                name: "FK_MixAndCouponPayment_MixAndCouponPayment_ModeMixAndCouponPaymentId",
                table: "MixAndCouponPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_MixAndCouponPayment_Stores_StoreId",
                table: "MixAndCouponPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetail_RegularInvoice_InvoiceNo",
                table: "PaymentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PointRedeemed_DailySales_DailySaleId",
                table: "PointRedeemed");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoice_Customer_CustomerId",
                table: "RegularInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoice_Stores_StoreId",
                table: "RegularInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItem_HSN_HSNCode1",
                table: "RegularSaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItem_RegularInvoice_InvoiceNo1",
                table: "RegularSaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItem_ProductItem_ProductItemId",
                table: "RegularSaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItem_SaleTaxTypes_SaleTaxTypeId",
                table: "RegularSaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItem_Salesmen_SalesmanId",
                table: "RegularSaleItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegularSaleItem",
                table: "RegularSaleItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegularInvoice",
                table: "RegularInvoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointRedeemed",
                table: "PointRedeemed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetail",
                table: "PaymentDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MixAndCouponPayment",
                table: "MixAndCouponPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EDCTranscation",
                table: "EDCTranscation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EDC",
                table: "EDC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CouponPayment",
                table: "CouponPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CashInHand",
                table: "CashInHand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CashInBank",
                table: "CashInBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardDetail",
                table: "CardDetail");

            migrationBuilder.RenameTable(
                name: "RegularSaleItem",
                newName: "RegularSaleItems");

            migrationBuilder.RenameTable(
                name: "RegularInvoice",
                newName: "RegularInvoices");

            migrationBuilder.RenameTable(
                name: "PointRedeemed",
                newName: "PointRedeemeds");

            migrationBuilder.RenameTable(
                name: "PaymentDetail",
                newName: "PaymentDetails");

            migrationBuilder.RenameTable(
                name: "MixAndCouponPayment",
                newName: "MixPayments");

            migrationBuilder.RenameTable(
                name: "EDCTranscation",
                newName: "CardTranscations");

            migrationBuilder.RenameTable(
                name: "EDC",
                newName: "CardMachine");

            migrationBuilder.RenameTable(
                name: "CouponPayment",
                newName: "CouponPayments");

            migrationBuilder.RenameTable(
                name: "CashInHand",
                newName: "CashInHands");

            migrationBuilder.RenameTable(
                name: "CashInBank",
                newName: "CashInBanks");

            migrationBuilder.RenameTable(
                name: "CardDetail",
                newName: "CardDetails");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItem_SalesmanId",
                table: "RegularSaleItems",
                newName: "IX_RegularSaleItems_SalesmanId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItem_SaleTaxTypeId",
                table: "RegularSaleItems",
                newName: "IX_RegularSaleItems_SaleTaxTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItem_ProductItemId",
                table: "RegularSaleItems",
                newName: "IX_RegularSaleItems_ProductItemId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItem_InvoiceNo1",
                table: "RegularSaleItems",
                newName: "IX_RegularSaleItems_InvoiceNo1");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItem_HSNCode1",
                table: "RegularSaleItems",
                newName: "IX_RegularSaleItems_HSNCode1");

            migrationBuilder.RenameIndex(
                name: "IX_RegularInvoice_StoreId",
                table: "RegularInvoices",
                newName: "IX_RegularInvoices_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularInvoice_CustomerId",
                table: "RegularInvoices",
                newName: "IX_RegularInvoices_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_PointRedeemed_DailySaleId",
                table: "PointRedeemeds",
                newName: "IX_PointRedeemeds_DailySaleId");

            migrationBuilder.RenameIndex(
                name: "IX_MixAndCouponPayment_StoreId",
                table: "MixPayments",
                newName: "IX_MixPayments_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_MixAndCouponPayment_ModeMixAndCouponPaymentId",
                table: "MixPayments",
                newName: "IX_MixPayments_ModeMixAndCouponPaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_EDCTranscation_StoreId",
                table: "CardTranscations",
                newName: "IX_CardTranscations_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_EDCTranscation_EDCId",
                table: "CardTranscations",
                newName: "IX_CardTranscations_EDCId");

            migrationBuilder.RenameIndex(
                name: "IX_EDC_StoreId",
                table: "CardMachine",
                newName: "IX_CardMachine_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CouponPayment_DailySaleId",
                table: "CouponPayments",
                newName: "IX_CouponPayments_DailySaleId");

            migrationBuilder.RenameIndex(
                name: "IX_CashInHand_StoreId",
                table: "CashInHands",
                newName: "IX_CashInHands_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CashInBank_StoreId",
                table: "CashInBanks",
                newName: "IX_CashInBanks_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CardDetail_InvoiceNo",
                table: "CardDetails",
                newName: "IX_CardDetails_InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegularSaleItems",
                table: "RegularSaleItems",
                column: "RegularSaleItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegularInvoices",
                table: "RegularInvoices",
                column: "InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointRedeemeds",
                table: "PointRedeemeds",
                column: "PointRedeemedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails",
                column: "InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MixPayments",
                table: "MixPayments",
                column: "MixAndCouponPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardTranscations",
                table: "CardTranscations",
                column: "EDCTranscationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardMachine",
                table: "CardMachine",
                column: "EDCId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CouponPayments",
                table: "CouponPayments",
                column: "CouponPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CashInHands",
                table: "CashInHands",
                column: "CashInHandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CashInBanks",
                table: "CashInBanks",
                column: "CashInBankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardDetails",
                table: "CardDetails",
                column: "CardDetailId");

            migrationBuilder.CreateTable(
                name: "DuesLists",
                columns: table => new
                {
                    DuesListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    IsRecovered = table.Column<bool>(nullable: false),
                    RecoveryDate = table.Column<DateTime>(nullable: true),
                    DailySaleId = table.Column<int>(nullable: false),
                    IsPartialRecovery = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuesLists", x => x.DuesListId);
                    table.ForeignKey(
                        name: "FK_DuesLists_DailySales_DailySaleId",
                        column: x => x.DailySaleId,
                        principalTable: "DailySales",
                        principalColumn: "DailySaleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DuesLists_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OnlineVendors",
                columns: table => new
                {
                    OnlineVendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(nullable: true),
                    OnDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    OffDate = table.Column<DateTime>(nullable: true),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineVendors", x => x.OnlineVendorId);
                });

            migrationBuilder.CreateTable(
                name: "DueRecoverds",
                columns: table => new
                {
                    DueRecoverdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaidDate = table.Column<DateTime>(nullable: false),
                    DuesListId = table.Column<int>(nullable: false),
                    AmountPaid = table.Column<decimal>(type: "money", nullable: false),
                    IsPartialPayment = table.Column<bool>(nullable: false),
                    Modes = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DueRecoverds", x => x.DueRecoverdId);
                    table.ForeignKey(
                        name: "FK_DueRecoverds_DuesLists_DuesListId",
                        column: x => x.DuesListId,
                        principalTable: "DuesLists",
                        principalColumn: "DuesListId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DueRecoverds_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OnlineSales",
                columns: table => new
                {
                    OnlineSaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    InvNo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    VoyagerInvoiceNo = table.Column<string>(nullable: true),
                    VoygerDate = table.Column<DateTime>(nullable: false),
                    VoyagerAmount = table.Column<decimal>(type: "money", nullable: false),
                    ShippingMode = table.Column<string>(nullable: true),
                    VendorFee = table.Column<decimal>(type: "money", nullable: false),
                    ProfitValue = table.Column<decimal>(type: "money", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    OnlineVendorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineSales", x => x.OnlineSaleId);
                    table.ForeignKey(
                        name: "FK_OnlineSales_OnlineVendors_OnlineVendorId",
                        column: x => x.OnlineVendorId,
                        principalTable: "OnlineVendors",
                        principalColumn: "OnlineVendorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineSales_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineSaleReturns",
                columns: table => new
                {
                    OnlineSaleReturnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    EntryStatus = table.Column<int>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    OnlineSaleId = table.Column<int>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    InvNo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    VoyagerInvoiceNo = table.Column<string>(nullable: true),
                    VoygerDate = table.Column<DateTime>(nullable: false),
                    VoyagerAmount = table.Column<decimal>(type: "money", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    IsRecived = table.Column<bool>(nullable: false),
                    RecivedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineSaleReturns", x => x.OnlineSaleReturnId);
                    table.ForeignKey(
                        name: "FK_OnlineSaleReturns_OnlineSales_OnlineSaleId",
                        column: x => x.OnlineSaleId,
                        principalTable: "OnlineSales",
                        principalColumn: "OnlineSaleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineSaleReturns_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DueRecoverds_DuesListId",
                table: "DueRecoverds",
                column: "DuesListId");

            migrationBuilder.CreateIndex(
                name: "IX_DueRecoverds_StoreId",
                table: "DueRecoverds",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_DuesLists_DailySaleId",
                table: "DuesLists",
                column: "DailySaleId");

            migrationBuilder.CreateIndex(
                name: "IX_DuesLists_StoreId",
                table: "DuesLists",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSaleReturns_OnlineSaleId",
                table: "OnlineSaleReturns",
                column: "OnlineSaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSaleReturns_StoreId",
                table: "OnlineSaleReturns",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSales_OnlineVendorId",
                table: "OnlineSales",
                column: "OnlineVendorId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSales_StoreId",
                table: "OnlineSales",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetails_PaymentDetails_InvoiceNo",
                table: "CardDetails",
                column: "InvoiceNo",
                principalTable: "PaymentDetails",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CardMachine_Stores_StoreId",
                table: "CardMachine",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardTranscations_CardMachine_EDCId",
                table: "CardTranscations",
                column: "EDCId",
                principalTable: "CardMachine",
                principalColumn: "EDCId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardTranscations_Stores_StoreId",
                table: "CardTranscations",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CashInBanks_Stores_StoreId",
                table: "CashInBanks",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CashInHands_Stores_StoreId",
                table: "CashInHands",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CouponPayments_DailySales_DailySaleId",
                table: "CouponPayments",
                column: "DailySaleId",
                principalTable: "DailySales",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySales_CardTranscations_EDCTranscationId",
                table: "DailySales",
                column: "EDCTranscationId",
                principalTable: "CardTranscations",
                principalColumn: "EDCTranscationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySales_MixPayments_MixAndCouponPaymentId",
                table: "DailySales",
                column: "MixAndCouponPaymentId",
                principalTable: "MixPayments",
                principalColumn: "MixAndCouponPaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MixPayments_MixPayments_ModeMixAndCouponPaymentId",
                table: "MixPayments",
                column: "ModeMixAndCouponPaymentId",
                principalTable: "MixPayments",
                principalColumn: "MixAndCouponPaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MixPayments_Stores_StoreId",
                table: "MixPayments",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_RegularInvoices_InvoiceNo",
                table: "PaymentDetails",
                column: "InvoiceNo",
                principalTable: "RegularInvoices",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointRedeemeds_DailySales_DailySaleId",
                table: "PointRedeemeds",
                column: "DailySaleId",
                principalTable: "DailySales",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoices_Customer_CustomerId",
                table: "RegularInvoices",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoices_Stores_StoreId",
                table: "RegularInvoices",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_HSN_HSNCode1",
                table: "RegularSaleItems",
                column: "HSNCode1",
                principalTable: "HSN",
                principalColumn: "HSNCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_RegularInvoices_InvoiceNo1",
                table: "RegularSaleItems",
                column: "InvoiceNo1",
                principalTable: "RegularInvoices",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_ProductItem_ProductItemId",
                table: "RegularSaleItems",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_SaleTaxTypes_SaleTaxTypeId",
                table: "RegularSaleItems",
                column: "SaleTaxTypeId",
                principalTable: "SaleTaxTypes",
                principalColumn: "SaleTaxTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_Salesmen_SalesmanId",
                table: "RegularSaleItems",
                column: "SalesmanId",
                principalTable: "Salesmen",
                principalColumn: "SalesmanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetails_PaymentDetails_InvoiceNo",
                table: "CardDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CardMachine_Stores_StoreId",
                table: "CardMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_CardTranscations_CardMachine_EDCId",
                table: "CardTranscations");

            migrationBuilder.DropForeignKey(
                name: "FK_CardTranscations_Stores_StoreId",
                table: "CardTranscations");

            migrationBuilder.DropForeignKey(
                name: "FK_CashInBanks_Stores_StoreId",
                table: "CashInBanks");

            migrationBuilder.DropForeignKey(
                name: "FK_CashInHands_Stores_StoreId",
                table: "CashInHands");

            migrationBuilder.DropForeignKey(
                name: "FK_CouponPayments_DailySales_DailySaleId",
                table: "CouponPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySales_CardTranscations_EDCTranscationId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySales_MixPayments_MixAndCouponPaymentId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPayments_MixPayments_ModeMixAndCouponPaymentId",
                table: "MixPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_MixPayments_Stores_StoreId",
                table: "MixPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_RegularInvoices_InvoiceNo",
                table: "PaymentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PointRedeemeds_DailySales_DailySaleId",
                table: "PointRedeemeds");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoices_Customer_CustomerId",
                table: "RegularInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoices_Stores_StoreId",
                table: "RegularInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_HSN_HSNCode1",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_RegularInvoices_InvoiceNo1",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_ProductItem_ProductItemId",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_SaleTaxTypes_SaleTaxTypeId",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_Salesmen_SalesmanId",
                table: "RegularSaleItems");

            migrationBuilder.DropTable(
                name: "DueRecoverds");

            migrationBuilder.DropTable(
                name: "OnlineSaleReturns");

            migrationBuilder.DropTable(
                name: "DuesLists");

            migrationBuilder.DropTable(
                name: "OnlineSales");

            migrationBuilder.DropTable(
                name: "OnlineVendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegularSaleItems",
                table: "RegularSaleItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegularInvoices",
                table: "RegularInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointRedeemeds",
                table: "PointRedeemeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MixPayments",
                table: "MixPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CouponPayments",
                table: "CouponPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CashInHands",
                table: "CashInHands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CashInBanks",
                table: "CashInBanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardTranscations",
                table: "CardTranscations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardMachine",
                table: "CardMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardDetails",
                table: "CardDetails");

            migrationBuilder.RenameTable(
                name: "RegularSaleItems",
                newName: "RegularSaleItem");

            migrationBuilder.RenameTable(
                name: "RegularInvoices",
                newName: "RegularInvoice");

            migrationBuilder.RenameTable(
                name: "PointRedeemeds",
                newName: "PointRedeemed");

            migrationBuilder.RenameTable(
                name: "PaymentDetails",
                newName: "PaymentDetail");

            migrationBuilder.RenameTable(
                name: "MixPayments",
                newName: "MixAndCouponPayment");

            migrationBuilder.RenameTable(
                name: "CouponPayments",
                newName: "CouponPayment");

            migrationBuilder.RenameTable(
                name: "CashInHands",
                newName: "CashInHand");

            migrationBuilder.RenameTable(
                name: "CashInBanks",
                newName: "CashInBank");

            migrationBuilder.RenameTable(
                name: "CardTranscations",
                newName: "EDCTranscation");

            migrationBuilder.RenameTable(
                name: "CardMachine",
                newName: "EDC");

            migrationBuilder.RenameTable(
                name: "CardDetails",
                newName: "CardDetail");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItems_SalesmanId",
                table: "RegularSaleItem",
                newName: "IX_RegularSaleItem_SalesmanId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItems_SaleTaxTypeId",
                table: "RegularSaleItem",
                newName: "IX_RegularSaleItem_SaleTaxTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItems_ProductItemId",
                table: "RegularSaleItem",
                newName: "IX_RegularSaleItem_ProductItemId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItems_InvoiceNo1",
                table: "RegularSaleItem",
                newName: "IX_RegularSaleItem_InvoiceNo1");

            migrationBuilder.RenameIndex(
                name: "IX_RegularSaleItems_HSNCode1",
                table: "RegularSaleItem",
                newName: "IX_RegularSaleItem_HSNCode1");

            migrationBuilder.RenameIndex(
                name: "IX_RegularInvoices_StoreId",
                table: "RegularInvoice",
                newName: "IX_RegularInvoice_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_RegularInvoices_CustomerId",
                table: "RegularInvoice",
                newName: "IX_RegularInvoice_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_PointRedeemeds_DailySaleId",
                table: "PointRedeemed",
                newName: "IX_PointRedeemed_DailySaleId");

            migrationBuilder.RenameIndex(
                name: "IX_MixPayments_StoreId",
                table: "MixAndCouponPayment",
                newName: "IX_MixAndCouponPayment_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_MixPayments_ModeMixAndCouponPaymentId",
                table: "MixAndCouponPayment",
                newName: "IX_MixAndCouponPayment_ModeMixAndCouponPaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_CouponPayments_DailySaleId",
                table: "CouponPayment",
                newName: "IX_CouponPayment_DailySaleId");

            migrationBuilder.RenameIndex(
                name: "IX_CashInHands_StoreId",
                table: "CashInHand",
                newName: "IX_CashInHand_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CashInBanks_StoreId",
                table: "CashInBank",
                newName: "IX_CashInBank_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CardTranscations_StoreId",
                table: "EDCTranscation",
                newName: "IX_EDCTranscation_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CardTranscations_EDCId",
                table: "EDCTranscation",
                newName: "IX_EDCTranscation_EDCId");

            migrationBuilder.RenameIndex(
                name: "IX_CardMachine_StoreId",
                table: "EDC",
                newName: "IX_EDC_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_CardDetails_InvoiceNo",
                table: "CardDetail",
                newName: "IX_CardDetail_InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegularSaleItem",
                table: "RegularSaleItem",
                column: "RegularSaleItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegularInvoice",
                table: "RegularInvoice",
                column: "InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointRedeemed",
                table: "PointRedeemed",
                column: "PointRedeemedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetail",
                table: "PaymentDetail",
                column: "InvoiceNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MixAndCouponPayment",
                table: "MixAndCouponPayment",
                column: "MixAndCouponPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CouponPayment",
                table: "CouponPayment",
                column: "CouponPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CashInHand",
                table: "CashInHand",
                column: "CashInHandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CashInBank",
                table: "CashInBank",
                column: "CashInBankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EDCTranscation",
                table: "EDCTranscation",
                column: "EDCTranscationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EDC",
                table: "EDC",
                column: "EDCId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardDetail",
                table: "CardDetail",
                column: "CardDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetail_PaymentDetail_InvoiceNo",
                table: "CardDetail",
                column: "InvoiceNo",
                principalTable: "PaymentDetail",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CashInBank_Stores_StoreId",
                table: "CashInBank",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CashInHand_Stores_StoreId",
                table: "CashInHand",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CouponPayment_DailySales_DailySaleId",
                table: "CouponPayment",
                column: "DailySaleId",
                principalTable: "DailySales",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySales_EDCTranscation_EDCTranscationId",
                table: "DailySales",
                column: "EDCTranscationId",
                principalTable: "EDCTranscation",
                principalColumn: "EDCTranscationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySales_MixAndCouponPayment_MixAndCouponPaymentId",
                table: "DailySales",
                column: "MixAndCouponPaymentId",
                principalTable: "MixAndCouponPayment",
                principalColumn: "MixAndCouponPaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EDC_Stores_StoreId",
                table: "EDC",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EDCTranscation_EDC_EDCId",
                table: "EDCTranscation",
                column: "EDCId",
                principalTable: "EDC",
                principalColumn: "EDCId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EDCTranscation_Stores_StoreId",
                table: "EDCTranscation",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MixAndCouponPayment_MixAndCouponPayment_ModeMixAndCouponPaymentId",
                table: "MixAndCouponPayment",
                column: "ModeMixAndCouponPaymentId",
                principalTable: "MixAndCouponPayment",
                principalColumn: "MixAndCouponPaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MixAndCouponPayment_Stores_StoreId",
                table: "MixAndCouponPayment",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetail_RegularInvoice_InvoiceNo",
                table: "PaymentDetail",
                column: "InvoiceNo",
                principalTable: "RegularInvoice",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointRedeemed_DailySales_DailySaleId",
                table: "PointRedeemed",
                column: "DailySaleId",
                principalTable: "DailySales",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoice_Customer_CustomerId",
                table: "RegularInvoice",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoice_Stores_StoreId",
                table: "RegularInvoice",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItem_HSN_HSNCode1",
                table: "RegularSaleItem",
                column: "HSNCode1",
                principalTable: "HSN",
                principalColumn: "HSNCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItem_RegularInvoice_InvoiceNo1",
                table: "RegularSaleItem",
                column: "InvoiceNo1",
                principalTable: "RegularInvoice",
                principalColumn: "InvoiceNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItem_ProductItem_ProductItemId",
                table: "RegularSaleItem",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItem_SaleTaxTypes_SaleTaxTypeId",
                table: "RegularSaleItem",
                column: "SaleTaxTypeId",
                principalTable: "SaleTaxTypes",
                principalColumn: "SaleTaxTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItem_Salesmen_SalesmanId",
                table: "RegularSaleItem",
                column: "SalesmanId",
                principalTable: "Salesmen",
                principalColumn: "SalesmanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
