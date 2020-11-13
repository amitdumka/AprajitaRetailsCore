using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class NextStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportInWard_Stores_StoreId",
                table: "ImportInWard");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportPurchase_Stores_StoreId",
                table: "ImportPurchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportSaleItemWise_Stores_StoreId",
                table: "ImportSaleItemWise");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportSaleRegister_Stores_StoreId",
                table: "ImportSaleRegister");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItem_PurchaseTaxType_PurchaseTaxTypeId",
                table: "PurchaseItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseTaxType",
                table: "PurchaseTaxType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportSaleRegister",
                table: "ImportSaleRegister");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportSaleItemWise",
                table: "ImportSaleItemWise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportPurchase",
                table: "ImportPurchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportInWard",
                table: "ImportInWard");

            migrationBuilder.RenameTable(
                name: "PurchaseTaxType",
                newName: "PurchaseTaxTypes");

            migrationBuilder.RenameTable(
                name: "ImportSaleRegister",
                newName: "ImportSaleRegisters");

            migrationBuilder.RenameTable(
                name: "ImportSaleItemWise",
                newName: "ImportSaleItemWises");

            migrationBuilder.RenameTable(
                name: "ImportPurchase",
                newName: "ImportPurchases");

            migrationBuilder.RenameTable(
                name: "ImportInWard",
                newName: "ImportInWards");

            migrationBuilder.RenameIndex(
                name: "IX_ImportSaleRegister_StoreId",
                table: "ImportSaleRegisters",
                newName: "IX_ImportSaleRegisters_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportSaleItemWise_StoreId",
                table: "ImportSaleItemWises",
                newName: "IX_ImportSaleItemWises_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportPurchase_StoreId",
                table: "ImportPurchases",
                newName: "IX_ImportPurchases_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportInWard_StoreId",
                table: "ImportInWards",
                newName: "IX_ImportInWards_StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseTaxTypes",
                table: "PurchaseTaxTypes",
                column: "PurchaseTaxTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportSaleRegisters",
                table: "ImportSaleRegisters",
                column: "ImportSaleRegisterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportSaleItemWises",
                table: "ImportSaleItemWises",
                column: "ImportSaleItemWiseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportPurchases",
                table: "ImportPurchases",
                column: "ImportPurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportInWards",
                table: "ImportInWards",
                column: "ImportInWardId");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    EMailAddress = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "ImportBookEntries",
                columns: table => new
                {
                    BookEntryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    LedgerBy = table.Column<int>(nullable: false),
                    LedgerTo = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    VoucherType = table.Column<int>(nullable: false),
                    Naration = table.Column<string>(nullable: true),
                    IsConsumed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportBookEntries", x => x.BookEntryId);
                });

            migrationBuilder.CreateTable(
                name: "ImportSearches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    OnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportSearches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelegramAuthUsers",
                columns: table => new
                {
                    TelegramAuthUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelegramChatId = table.Column<long>(nullable: false),
                    TelegramUserName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EmpType = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramAuthUsers", x => x.TelegramAuthUserId);
                    table.ForeignKey(
                        name: "FK_TelegramAuthUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TelegramAuthUsers_EmployeeId",
                table: "TelegramAuthUsers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportInWards_Stores_StoreId",
                table: "ImportInWards",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportPurchases_Stores_StoreId",
                table: "ImportPurchases",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportSaleItemWises_Stores_StoreId",
                table: "ImportSaleItemWises",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportSaleRegisters_Stores_StoreId",
                table: "ImportSaleRegisters",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItem_PurchaseTaxTypes_PurchaseTaxTypeId",
                table: "PurchaseItem",
                column: "PurchaseTaxTypeId",
                principalTable: "PurchaseTaxTypes",
                principalColumn: "PurchaseTaxTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImportInWards_Stores_StoreId",
                table: "ImportInWards");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportPurchases_Stores_StoreId",
                table: "ImportPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportSaleItemWises_Stores_StoreId",
                table: "ImportSaleItemWises");

            migrationBuilder.DropForeignKey(
                name: "FK_ImportSaleRegisters_Stores_StoreId",
                table: "ImportSaleRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItem_PurchaseTaxTypes_PurchaseTaxTypeId",
                table: "PurchaseItem");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ImportBookEntries");

            migrationBuilder.DropTable(
                name: "ImportSearches");

            migrationBuilder.DropTable(
                name: "TelegramAuthUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseTaxTypes",
                table: "PurchaseTaxTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportSaleRegisters",
                table: "ImportSaleRegisters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportSaleItemWises",
                table: "ImportSaleItemWises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportPurchases",
                table: "ImportPurchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImportInWards",
                table: "ImportInWards");

            migrationBuilder.RenameTable(
                name: "PurchaseTaxTypes",
                newName: "PurchaseTaxType");

            migrationBuilder.RenameTable(
                name: "ImportSaleRegisters",
                newName: "ImportSaleRegister");

            migrationBuilder.RenameTable(
                name: "ImportSaleItemWises",
                newName: "ImportSaleItemWise");

            migrationBuilder.RenameTable(
                name: "ImportPurchases",
                newName: "ImportPurchase");

            migrationBuilder.RenameTable(
                name: "ImportInWards",
                newName: "ImportInWard");

            migrationBuilder.RenameIndex(
                name: "IX_ImportSaleRegisters_StoreId",
                table: "ImportSaleRegister",
                newName: "IX_ImportSaleRegister_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportSaleItemWises_StoreId",
                table: "ImportSaleItemWise",
                newName: "IX_ImportSaleItemWise_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportPurchases_StoreId",
                table: "ImportPurchase",
                newName: "IX_ImportPurchase_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ImportInWards_StoreId",
                table: "ImportInWard",
                newName: "IX_ImportInWard_StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseTaxType",
                table: "PurchaseTaxType",
                column: "PurchaseTaxTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportSaleRegister",
                table: "ImportSaleRegister",
                column: "ImportSaleRegisterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportSaleItemWise",
                table: "ImportSaleItemWise",
                column: "ImportSaleItemWiseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportPurchase",
                table: "ImportPurchase",
                column: "ImportPurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImportInWard",
                table: "ImportInWard",
                column: "ImportInWardId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImportInWard_Stores_StoreId",
                table: "ImportInWard",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportPurchase_Stores_StoreId",
                table: "ImportPurchase",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportSaleItemWise_Stores_StoreId",
                table: "ImportSaleItemWise",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImportSaleRegister_Stores_StoreId",
                table: "ImportSaleRegister",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItem_PurchaseTaxType_PurchaseTaxTypeId",
                table: "PurchaseItem",
                column: "PurchaseTaxTypeId",
                principalTable: "PurchaseTaxType",
                principalColumn: "PurchaseTaxTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
