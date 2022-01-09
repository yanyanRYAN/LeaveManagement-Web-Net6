using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e8ea000-b102-408a-8596-96b2684395ca", "695fef3f-3975-4a01-bf95-863425e49c9b", "Administrator", "ADMINISTRATOR" },
                    { "7e8ea000-b102-668a-8596-96b2686666ca", "f02bb5ac-0134-44f8-be8a-59cfd9671a78", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dd910685-0f1c-426e-931d-f68fc8e95122", 0, "13f4f937-f60f-4eda-9443-8ed7d01d47a4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJ5joHeIldV5dhXfJGYrMLqFjgMWrHwi9lSt3/DwUKu/kZPcutrJHS2D2nYhQZ7waw==", null, false, "81f66ffb-61a6-4cdf-8a8f-a8f2e5f7b1a6", null, false, null },
                    { "ee910685-0f1c-426e-931d-f68fc8e50125", 0, "b2c200d7-76bd-4863-ae7e-907a3cd1898c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHuIUrDtXucryi6cxTtTNTyTKukpm8/56iFgWUPq5oTyi2Qs1ndPYUW8ST5dCpohGw==", null, false, "e342712e-93b8-40ff-9595-308f8dfd3260", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7e8ea000-b102-408a-8596-96b2684395ca", "dd910685-0f1c-426e-931d-f68fc8e95122" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7e8ea000-b102-668a-8596-96b2686666ca", "ee910685-0f1c-426e-931d-f68fc8e50125" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e8ea000-b102-408a-8596-96b2684395ca", "dd910685-0f1c-426e-931d-f68fc8e95122" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e8ea000-b102-668a-8596-96b2686666ca", "ee910685-0f1c-426e-931d-f68fc8e50125" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-408a-8596-96b2684395ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-668a-8596-96b2686666ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd910685-0f1c-426e-931d-f68fc8e95122");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee910685-0f1c-426e-931d-f68fc8e50125");
        }
    }
}
