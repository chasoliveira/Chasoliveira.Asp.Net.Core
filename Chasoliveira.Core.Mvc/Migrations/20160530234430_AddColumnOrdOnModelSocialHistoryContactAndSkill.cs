using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chasoliveira.Core.Mvc.Migrations
{
    public partial class AddColumnOrdOnModelSocialHistoryContactAndSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "Socials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "Histories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ord",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ord",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "Ord",
                table: "Contacts");
        }
    }
}
