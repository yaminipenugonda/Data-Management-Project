using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCDHProject2.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Custid = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Balance = table.Column<decimal>(type: "Money", nullable: true),
                    City = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Custid);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Custid", "Balance", "City", "Name", "Status" },
                values: new object[,]
                {
                    { 101, 50000.00m, "Delhi", "Sai", true },
                    { 102, 40000.00m, "Mumbai", "Sonia", true },
                    { 103, 30000.00m, "Chennai", "Pankaj", true },
                    { 104, 25000.00m, "Bengaluru", "Samuels", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
