using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDetails1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Asqi",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Boru",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoruQapagi",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Etek",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EtekRezini",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Mator",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MatorunQisaQolu",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MatorunUzunQolu",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Pult",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Qutu",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Rolik",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tapa",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tuk",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YanDirekler",
                table: "Detallars",
                type: "decimal(10,1)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asqi",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Boru",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "BoruQapagi",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Etek",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "EtekRezini",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Mator",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "MatorunQisaQolu",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "MatorunUzunQolu",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Pult",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Qutu",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Rolik",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Tapa",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "Tuk",
                table: "Detallars");

            migrationBuilder.DropColumn(
                name: "YanDirekler",
                table: "Detallars");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Detallars",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,1)");
        }
    }
}
