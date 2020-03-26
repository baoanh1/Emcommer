using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Data.Migrations
{
    public partial class editfilesize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("18c1f2b1-07ba-4f77-b440-f42203788da8"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c42b5b2c-f7cc-4ef1-ae54-8b286e75bb9a"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("af66380f-a899-4a20-ac55-077ffe0ef848"), new Guid("c42b5b2c-f7cc-4ef1-ae54-8b286e75bb9a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af66380f-a899-4a20-ac55-077ffe0ef848"));

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: new Guid("2b5a7ce1-1381-4a75-820e-095cf1a417ea"));

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: new Guid("0381ca26-30eb-42da-a241-1b542983e9a6"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2b5a7ce1-1381-4a75-820e-095cf1a417ea"), "31ae0753-388e-4213-bdbf-0d22dfc7140a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("0381ca26-30eb-42da-a241-1b542983e9a6"), "16c65d1f-426a-4630-a40c-6dc8a9efa1dd", "member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("55c7b5e2-30e2-418d-ace1-51912fa343d7"), new Guid("2b5a7ce1-1381-4a75-820e-095cf1a417ea") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("55c7b5e2-30e2-418d-ace1-51912fa343d7"), 0, "72ee75c9-e1fd-4597-9915-a5f97ca3dbdf", "phungnhatphu4@gmail.com", true, null, null, false, null, "phungnhatphu4@gmail.com", "admin", "AQAAAAEAACcQAAAAEORQgJb3mu3q2UqvVQpHw7OwvnYLuF1W89EIWiIjNO9WV4MzhYtmglaVc+S9ihll4Q==", null, false, "f952ccc0-dee7-48c2-8590-898d2516020e", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "categoryID",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "categoryID",
                value: 2L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0381ca26-30eb-42da-a241-1b542983e9a6"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2b5a7ce1-1381-4a75-820e-095cf1a417ea"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("55c7b5e2-30e2-418d-ace1-51912fa343d7"), new Guid("2b5a7ce1-1381-4a75-820e-095cf1a417ea") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("55c7b5e2-30e2-418d-ace1-51912fa343d7"));

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: new Guid("c42b5b2c-f7cc-4ef1-ae54-8b286e75bb9a"));

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: new Guid("18c1f2b1-07ba-4f77-b440-f42203788da8"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("c42b5b2c-f7cc-4ef1-ae54-8b286e75bb9a"), "a348fee6-0997-4131-883e-662d1f034cea", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("18c1f2b1-07ba-4f77-b440-f42203788da8"), "1fb8706c-4e27-4001-9264-bd59376c5dbe", "member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("af66380f-a899-4a20-ac55-077ffe0ef848"), new Guid("c42b5b2c-f7cc-4ef1-ae54-8b286e75bb9a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("af66380f-a899-4a20-ac55-077ffe0ef848"), 0, "9acbbd39-b0da-4efd-8d29-7f5b82ccf73d", "phungnhatphu4@gmail.com", true, null, null, false, null, "phungnhatphu4@gmail.com", "admin", "AQAAAAEAACcQAAAAEJuBB/Po1XlnLlG/x9aDoIKgo8JI0XYD9PN0sli06dJxzEEFTsAmri1gdmSO84d5+Q==", null, false, "6a546e9c-dd0e-4753-9a64-c06acc601436", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "categoryID",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "categoryID",
                value: 2L);
        }
    }
}
