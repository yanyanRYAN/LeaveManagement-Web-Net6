using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-408a-8596-96b2684395ca",
                column: "ConcurrencyStamp",
                value: "a5dc03b1-e33e-4b5b-9cd2-f8109f0724ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-668a-8596-96b2686666ca",
                column: "ConcurrencyStamp",
                value: "c192abc0-1b79-4cab-94d4-19254351832e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd910685-0f1c-426e-931d-f68fc8e95122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b0847c-56e3-42b4-8d87-428dd0e5d5c3", "AQAAAAEAACcQAAAAEHF1Byd+kRvDa04yCwbAsB6Zg1hOi10wXmqMtDfebXfSIcIp12wOugsb+B+YUEx0Aw==", "ca518c57-54a0-458f-90c1-a456892e4687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee910685-0f1c-426e-931d-f68fc8e50125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57c7ff23-c20a-45c5-8d95-f0b5055a0d0e", "AQAAAAEAACcQAAAAEDELpGBD1sRodfRffPSvqaeIMKkYhCgzWClk4ZZj/g8kAAzYYpg92KVVmIXl/mcJiw==", "306aba19-12dd-4bb2-96f8-80055748da5f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-408a-8596-96b2684395ca",
                column: "ConcurrencyStamp",
                value: "8f88258f-b342-4a4a-b9c7-3cde01d2f985");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-668a-8596-96b2686666ca",
                column: "ConcurrencyStamp",
                value: "2ba54c59-b650-46d6-9f6a-ace762ef97eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd910685-0f1c-426e-931d-f68fc8e95122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d15a4864-f2ff-4872-b3bb-781697d959fd", "AQAAAAEAACcQAAAAEDwaxOUEwgzdaUjTdXTNVaIuHvHvhiwkCMFRczXby6LqPLP55EsgkzbVfs3uJFWQhA==", "7c91172e-a423-48a9-94c5-c12e37c26e9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee910685-0f1c-426e-931d-f68fc8e50125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31b5231-a0fd-4a70-87fc-3522e4a9fb45", "AQAAAAEAACcQAAAAEK+oy4B2Sl8U5y9gmhsv0Nj8iReHcm6NNuqowhTBORZtp9PlVF2+vVslJOSf9MrRyA==", "3d125566-1061-4b8e-84a3-67cb064a22a5" });
        }
    }
}
