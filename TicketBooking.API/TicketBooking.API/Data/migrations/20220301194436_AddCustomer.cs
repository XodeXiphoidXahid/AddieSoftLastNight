using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketBooking.API.Data.migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Age", "Name", "Salary" },
                values: new object[,]
                {
                    { new Guid("73155700-71c1-46c6-ae99-aea5525d549d"), "Kolabagan", 26, "Zahid", 20000 },
                    { new Guid("92ec8722-3419-48bc-b39e-4f46df8ce4d4"), "Khulna", 15, "Jui", 1500 },
                    { new Guid("38f90328-b1ae-4ce8-b4b2-634e7acb56db"), "BUET", 20, "Rafsan", 30000 },
                    { new Guid("31f58393-2120-48cb-9196-c29bc21567d7"), "Comila", 40, "Habib", 50000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
