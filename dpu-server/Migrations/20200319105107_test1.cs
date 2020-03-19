﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace dpu_server.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heatmaps",
                columns: table => new
                {
                    HeatmapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<int>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heatmaps", x => x.HeatmapID);
                });

            migrationBuilder.CreateTable(
                name: "Referencepoints",
                columns: table => new
                {
                    ReferencepointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(nullable: false),
                    RSSI1 = table.Column<int>(nullable: false),
                    RSSI2 = table.Column<int>(nullable: false),
                    RSSI3 = table.Column<int>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencepoints", x => x.ReferencepointID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heatmaps");

            migrationBuilder.DropTable(
                name: "Referencepoints");
        }
    }
}
