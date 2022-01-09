using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d15a4864-f2ff-4872-b3bb-781697d959fd", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDwaxOUEwgzdaUjTdXTNVaIuHvHvhiwkCMFRczXby6LqPLP55EsgkzbVfs3uJFWQhA==", "7c91172e-a423-48a9-94c5-c12e37c26e9c", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee910685-0f1c-426e-931d-f68fc8e50125",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d31b5231-a0fd-4a70-87fc-3522e4a9fb45", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEK+oy4B2Sl8U5y9gmhsv0Nj8iReHcm6NNuqowhTBORZtp9PlVF2+vVslJOSf9MrRyA==", "3d125566-1061-4b8e-84a3-67cb064a22a5", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-408a-8596-96b2684395ca",
                column: "ConcurrencyStamp",
                value: "695fef3f-3975-4a01-bf95-863425e49c9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ea000-b102-668a-8596-96b2686666ca",
                column: "ConcurrencyStamp",
                value: "f02bb5ac-0134-44f8-be8a-59cfd9671a78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd910685-0f1c-426e-931d-f68fc8e95122",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "13f4f937-f60f-4eda-9443-8ed7d01d47a4", false, null, "AQAAAAEAACcQAAAAEJ5joHeIldV5dhXfJGYrMLqFjgMWrHwi9lSt3/DwUKu/kZPcutrJHS2D2nYhQZ7waw==", "81f66ffb-61a6-4cdf-8a8f-a8f2e5f7b1a6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee910685-0f1c-426e-931d-f68fc8e50125",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b2c200d7-76bd-4863-ae7e-907a3cd1898c", false, null, "AQAAAAEAACcQAAAAEHuIUrDtXucryi6cxTtTNTyTKukpm8/56iFgWUPq5oTyi2Qs1ndPYUW8ST5dCpohGw==", "e342712e-93b8-40ff-9595-308f8dfd3260", null });
        }
    }
}
