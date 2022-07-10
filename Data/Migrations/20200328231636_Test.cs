﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Manufacturers_Manufacturers",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Release Date",
                table: "Games",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "Manufacturers",
                table: "Games",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_Manufacturers",
                table: "Games",
                newName: "IX_Games_ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Manufacturers_ManufacturerId",
                table: "Games",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Manufacturers_ManufacturerId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Games",
                newName: "Release Date");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Games",
                newName: "Manufacturers");

            migrationBuilder.RenameIndex(
                name: "IX_Games_ManufacturerId",
                table: "Games",
                newName: "IX_Games_Manufacturers");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Manufacturers_Manufacturers",
                table: "Games",
                column: "Manufacturers",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
