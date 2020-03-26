using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Data.Migrations
{
    public partial class newseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "ProductID", "ProductCategoryID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "ProductID", "ProductCategoryID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleId",
                value: new Guid("b8826aca-3e3f-40de-b7e6-3a7bd2418d9a"));

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoleId",
                value: new Guid("5886c464-caa9-456e-887c-a9d61b72a2d8"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b8826aca-3e3f-40de-b7e6-3a7bd2418d9a"), "8831506b-c767-4028-b640-929f77ffeeeb", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("5886c464-caa9-456e-887c-a9d61b72a2d8"), "46ff2a4f-7468-46ec-8f27-db531f241f39", "member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("5401c1c4-ba89-4090-a015-a5ee27da0c56"), new Guid("b8826aca-3e3f-40de-b7e6-3a7bd2418d9a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5401c1c4-ba89-4090-a015-a5ee27da0c56"), 0, "c94c5188-bb8f-4c65-bd26-92475ec2dce1", "phungnhatphu4@gmail.com", true, null, null, false, null, "phungnhatphu4@gmail.com", "admin", "AQAAAAEAACcQAAAAEPWxZrz79BszhvUxMT9IDtzQ1owMb+LWNdUuUtS3OM+cAUdngqyp94wCttLNpmWL9A==", null, false, "664cbf9d-13d6-405c-a975-3a2b0809d634", false, "admin" });

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
                keyValue: new Guid("5886c464-caa9-456e-887c-a9d61b72a2d8"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8826aca-3e3f-40de-b7e6-3a7bd2418d9a"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("5401c1c4-ba89-4090-a015-a5ee27da0c56"), new Guid("b8826aca-3e3f-40de-b7e6-3a7bd2418d9a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5401c1c4-ba89-4090-a015-a5ee27da0c56"));

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

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "ProductID", "ProductCategoryID" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "ProductID", "ProductCategoryID" },
                values: new object[] { 2, 1 });

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
