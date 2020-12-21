using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class NewAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Brand_BrandId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Category_MainCategoryCategoryId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Category_ProductCategoryCategoryId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Category_ProductTypeCategoryId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItem_ProductItem_ProductItemId",
                table: "PurchaseItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoices_Customer_CustomerId",
                table: "RegularInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_ProductItem_ProductItemId",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleItem_ProductItem_ProductItemId",
                table: "SaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_ProductItem_ProductItemId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Stores_StoreId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "ProductItem",
                newName: "ProductItems");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_StoreId",
                table: "Stocks",
                newName: "IX_Stocks_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_ProductItemId",
                table: "Stocks",
                newName: "IX_Stocks_ProductItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_ProductTypeCategoryId",
                table: "ProductItems",
                newName: "IX_ProductItems_ProductTypeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_ProductCategoryCategoryId",
                table: "ProductItems",
                newName: "IX_ProductItems_ProductCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_MainCategoryCategoryId",
                table: "ProductItems",
                newName: "IX_ProductItems_MainCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_BrandId",
                table: "ProductItems",
                newName: "IX_ProductItems_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductItems",
                table: "ProductItems",
                column: "ProductItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Brand_BrandId",
                table: "ProductItems",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Category_MainCategoryCategoryId",
                table: "ProductItems",
                column: "MainCategoryCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Category_ProductCategoryCategoryId",
                table: "ProductItems",
                column: "ProductCategoryCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Category_ProductTypeCategoryId",
                table: "ProductItems",
                column: "ProductTypeCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItem_ProductItems_ProductItemId",
                table: "PurchaseItem",
                column: "ProductItemId",
                principalTable: "ProductItems",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoices_Customers_CustomerId",
                table: "RegularInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_ProductItems_ProductItemId",
                table: "RegularSaleItems",
                column: "ProductItemId",
                principalTable: "ProductItems",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItem_ProductItems_ProductItemId",
                table: "SaleItem",
                column: "ProductItemId",
                principalTable: "ProductItems",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_ProductItems_ProductItemId",
                table: "Stocks",
                column: "ProductItemId",
                principalTable: "ProductItems",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Stores_StoreId",
                table: "Stocks",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Brand_BrandId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Category_MainCategoryCategoryId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Category_ProductCategoryCategoryId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Category_ProductTypeCategoryId",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseItem_ProductItems_ProductItemId",
                table: "PurchaseItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularInvoices_Customers_CustomerId",
                table: "RegularInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularSaleItems_ProductItems_ProductItemId",
                table: "RegularSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleItem_ProductItems_ProductItemId",
                table: "SaleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_ProductItems_ProductItemId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Stores_StoreId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductItems",
                table: "ProductItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.RenameTable(
                name: "ProductItems",
                newName: "ProductItem");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_StoreId",
                table: "Stock",
                newName: "IX_Stock_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_ProductItemId",
                table: "Stock",
                newName: "IX_Stock_ProductItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_ProductTypeCategoryId",
                table: "ProductItem",
                newName: "IX_ProductItem_ProductTypeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_ProductCategoryCategoryId",
                table: "ProductItem",
                newName: "IX_ProductItem_ProductCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_MainCategoryCategoryId",
                table: "ProductItem",
                newName: "IX_ProductItem_MainCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItems_BrandId",
                table: "ProductItem",
                newName: "IX_ProductItem_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem",
                column: "ProductItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Brand_BrandId",
                table: "ProductItem",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Category_MainCategoryCategoryId",
                table: "ProductItem",
                column: "MainCategoryCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Category_ProductCategoryCategoryId",
                table: "ProductItem",
                column: "ProductCategoryCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Category_ProductTypeCategoryId",
                table: "ProductItem",
                column: "ProductTypeCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseItem_ProductItem_ProductItemId",
                table: "PurchaseItem",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularInvoices_Customer_CustomerId",
                table: "RegularInvoices",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularSaleItems_ProductItem_ProductItemId",
                table: "RegularSaleItems",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItem_ProductItem_ProductItemId",
                table: "SaleItem",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_ProductItem_ProductItemId",
                table: "Stock",
                column: "ProductItemId",
                principalTable: "ProductItem",
                principalColumn: "ProductItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Stores_StoreId",
                table: "Stock",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
