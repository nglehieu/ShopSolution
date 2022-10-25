using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Data.Migrations
{
    public partial class DbECommerce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ddd9758b-9327-44bc-a66e-9e9c4fdff512");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("92a170c6-118c-45c9-053a-08d83b9c9ecb"),
                column: "ConcurrencyStamp",
                value: "0aa43a52-d088-49b3-b8a2-32803aec8123");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("939528cd-a6f3-450b-053b-08d83b9c9ecb"),
                column: "ConcurrencyStamp",
                value: "4234280d-00c3-4902-bba2-b34efb9b7eed");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("aa6f243a-5cbc-42d5-a432-08d83b5447b1"),
                column: "ConcurrencyStamp",
                value: "1472339a-d4a6-471a-8e8b-6799260c467d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5028d464-401f-4d7b-b87e-8da6a1285acd", "AQAAAAEAACcQAAAAEOoXz3H2GcmYkPRW3ku6J+VWVtUBZ7ySrCxRj9OlbQdqGBsKuU5oOA+3kklD4Sn7/g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a972a81f-1051-4613-920b-24d0a370ecfc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("92a170c6-118c-45c9-053a-08d83b9c9ecb"),
                column: "ConcurrencyStamp",
                value: "99aad336-4ee4-48fd-8b9e-87d1ce28d1d1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("939528cd-a6f3-450b-053b-08d83b9c9ecb"),
                column: "ConcurrencyStamp",
                value: "be4425cb-68ee-4f17-b38f-8916d38fabfe");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("aa6f243a-5cbc-42d5-a432-08d83b5447b1"),
                column: "ConcurrencyStamp",
                value: "5c6c1f6b-8c65-4d53-99bb-15d7d51b5451");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6272e0ee-7a59-4ecf-b872-acce4ec73e58", "AQAAAAEAACcQAAAAEE9D3bHJYjAsleGM8POhQUCGJccC+r35i7INCX//xHTzyas+xsvZxAGXwf9mEjUtvA==" });
        }
    }
}
