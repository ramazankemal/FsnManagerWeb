using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.ComponentId);
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "ComponentId", "Code", "Description", "IsDeleted" },
                values: new object[] { new Guid("b65631e9-5a58-4108-8905-65aa08939387"), "F-EN-E23-01", "PASIFIC KAĞIT HAVLU - FASON", false });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "ComponentId", "Code", "Description", "IsDeleted" },
                values: new object[] { new Guid("f94d9fca-f2c7-46c9-8a78-e71d532281a3"), "F-EN-E77-02", "35 LT KOVA ÇEMBER", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");
        }
    }
}
