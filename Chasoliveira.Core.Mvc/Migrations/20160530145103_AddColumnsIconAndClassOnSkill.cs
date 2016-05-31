using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chasoliveira.Core.Mvc.Migrations
{
    public partial class AddColumnsIconAndClassOnSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Skills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Skills");
        }
    }
}
