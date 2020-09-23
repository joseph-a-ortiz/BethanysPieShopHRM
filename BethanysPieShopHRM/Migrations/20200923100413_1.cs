using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShopHRM.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "JoinedDate", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "Smoker", "Street", "Zip" },
                values: new object[] { 2, new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerp", "Lorem Ipsum", 2, "gill@bethanyspieshop.com", null, "Gill", 1, 1, new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleeren", 50.850299999999997, 4.3517000000000001, 0, "33999909923", false, "New Street", "2000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
