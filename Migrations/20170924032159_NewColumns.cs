using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BrahmaServer.Migrations
{
    public partial class NewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Certification",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Employee",
                table: "Certification",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Certification");

            migrationBuilder.DropColumn(
                name: "Employee",
                table: "Certification");
        }
    }
}
