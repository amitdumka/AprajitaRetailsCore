using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class DailySales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CouponPayment_DailySale_DailySaleId",
                table: "CouponPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySale_EDCTranscation_EDCTranscationId",
                table: "DailySale");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySale_MixAndCouponPayment_MixAndCouponPaymentId",
                table: "DailySale");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySale_Salesmen_SalesmanId",
                table: "DailySale");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySale_Stores_StoreId",
                table: "DailySale");

            migrationBuilder.DropForeignKey(
                name: "FK_PointRedeemed_DailySale_DailySaleId",
                table: "PointRedeemed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailySale",
                table: "DailySale");

            migrationBuilder.RenameTable(
                name: "DailySale",
                newName: "DailySales");

            migrationBuilder.RenameIndex(
                name: "IX_DailySale_StoreId",
                table: "DailySales",
                newName: "IX_DailySales_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySale_SalesmanId",
                table: "DailySales",
                newName: "IX_DailySales_SalesmanId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySale_MixAndCouponPaymentId",
                table: "DailySales",
                newName: "IX_DailySales_MixAndCouponPaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySale_EDCTranscationId",
                table: "DailySales",
                newName: "IX_DailySales_EDCTranscationId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsTailoring",
                table: "Attendances",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailySales",
                table: "DailySales",
                column: "DailySaleId");

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
                name: "FK_DailySales_Salesmen_SalesmanId",
                table: "DailySales",
                column: "SalesmanId",
                principalTable: "Salesmen",
                principalColumn: "SalesmanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySales_Stores_StoreId",
                table: "DailySales",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PointRedeemed_DailySales_DailySaleId",
                table: "PointRedeemed",
                column: "DailySaleId",
                principalTable: "DailySales",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_DailySales_Salesmen_SalesmanId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_DailySales_Stores_StoreId",
                table: "DailySales");

            migrationBuilder.DropForeignKey(
                name: "FK_PointRedeemed_DailySales_DailySaleId",
                table: "PointRedeemed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailySales",
                table: "DailySales");

            migrationBuilder.RenameTable(
                name: "DailySales",
                newName: "DailySale");

            migrationBuilder.RenameIndex(
                name: "IX_DailySales_StoreId",
                table: "DailySale",
                newName: "IX_DailySale_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySales_SalesmanId",
                table: "DailySale",
                newName: "IX_DailySale_SalesmanId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySales_MixAndCouponPaymentId",
                table: "DailySale",
                newName: "IX_DailySale_MixAndCouponPaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_DailySales_EDCTranscationId",
                table: "DailySale",
                newName: "IX_DailySale_EDCTranscationId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsTailoring",
                table: "Attendances",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailySale",
                table: "DailySale",
                column: "DailySaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CouponPayment_DailySale_DailySaleId",
                table: "CouponPayment",
                column: "DailySaleId",
                principalTable: "DailySale",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySale_EDCTranscation_EDCTranscationId",
                table: "DailySale",
                column: "EDCTranscationId",
                principalTable: "EDCTranscation",
                principalColumn: "EDCTranscationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySale_MixAndCouponPayment_MixAndCouponPaymentId",
                table: "DailySale",
                column: "MixAndCouponPaymentId",
                principalTable: "MixAndCouponPayment",
                principalColumn: "MixAndCouponPaymentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySale_Salesmen_SalesmanId",
                table: "DailySale",
                column: "SalesmanId",
                principalTable: "Salesmen",
                principalColumn: "SalesmanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySale_Stores_StoreId",
                table: "DailySale",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointRedeemed_DailySale_DailySaleId",
                table: "PointRedeemed",
                column: "DailySaleId",
                principalTable: "DailySale",
                principalColumn: "DailySaleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
