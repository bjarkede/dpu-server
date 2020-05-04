﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace dpu_server.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referencepoints",
                columns: table => new
                {
                    ReferencepointId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Referencepoints", x => x.ReferencepointId);
                });

            migrationBuilder.CreateTable(
                name: "Heatmaps",
                columns: table => new
                {
                    HeatmapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferencepointId = table.Column<int>(nullable: false),
                    ReferencepointId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heatmaps", x => x.HeatmapID);
                    table.ForeignKey(
                        name: "FK_Heatmaps_Referencepoints_ReferencepointId",
                        column: x => x.ReferencepointId,
                        principalTable: "Referencepoints",
                        principalColumn: "ReferencepointId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heatmaps_Referencepoints_ReferencepointId1",
                        column: x => x.ReferencepointId1,
                        principalTable: "Referencepoints",
                        principalColumn: "ReferencepointId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Referencepoints",
                columns: new[] { "ReferencepointId", "Category", "RSSI1", "RSSI2", "RSSI3", "X", "Y" },
                values: new object[,]
                {
                    { 1, 3, 78, 24, 37, 30, 29 },
                    { 158, 4, 64, 31, 34, 43, 43 },
                    { 159, 9, 52, 12, 18, 13, 42 },
                    { 160, 7, 41, 87, 76, 8, 67 },
                    { 161, 1, 31, 46, 99, 79, 24 },
                    { 162, 8, 76, 5, 55, 19, 6 },
                    { 163, 1, 94, 51, 58, 90, 71 },
                    { 164, 4, 22, 49, 98, 96, 56 },
                    { 165, 5, 65, 99, 94, 26, 65 },
                    { 166, 6, 57, 54, 81, 42, 79 },
                    { 167, 3, 44, 84, 8, 50, 67 },
                    { 168, 4, 41, 33, 6, 8, 19 },
                    { 169, 9, 13, 51, 16, 41, 85 },
                    { 170, 2, 4, 34, 90, 54, 14 },
                    { 171, 3, 89, 51, 40, 91, 62 },
                    { 172, 5, 30, 52, 71, 28, 46 },
                    { 173, 8, 28, 72, 82, 59, 56 },
                    { 174, 3, 40, 58, 80, 4, 13 },
                    { 175, 2, 47, 16, 69, 63, 38 },
                    { 176, 5, 40, 90, 71, 83, 60 },
                    { 177, 2, 99, 49, 71, 53, 77 },
                    { 178, 6, 19, 84, 5, 29, 14 },
                    { 179, 2, 35, 45, 78, 66, 14 },
                    { 180, 6, 44, 85, 38, 26, 45 },
                    { 181, 5, 83, 66, 15, 27, 88 },
                    { 182, 6, 16, 44, 12, 67, 60 },
                    { 183, 1, 53, 87, 80, 15, 84 },
                    { 184, 3, 10, 19, 3, 55, 28 },
                    { 157, 4, 61, 48, 44, 11, 76 },
                    { 185, 9, 67, 73, 76, 16, 40 },
                    { 156, 8, 12, 37, 96, 6, 51 },
                    { 154, 4, 61, 34, 35, 36, 66 },
                    { 127, 3, 85, 98, 42, 31, 74 },
                    { 128, 9, 54, 70, 89, 64, 81 },
                    { 129, 9, 36, 54, 22, 1, 44 },
                    { 130, 1, 42, 4, 94, 75, 1 },
                    { 131, 2, 32, 33, 20, 11, 62 },
                    { 132, 8, 27, 43, 26, 42, 95 },
                    { 133, 7, 2, 67, 79, 92, 9 },
                    { 134, 1, 26, 36, 99, 42, 87 },
                    { 135, 4, 78, 91, 43, 51, 45 },
                    { 136, 6, 30, 11, 97, 27, 99 },
                    { 137, 4, 75, 44, 8, 4, 38 },
                    { 138, 4, 68, 94, 59, 50, 99 },
                    { 139, 7, 26, 50, 94, 94, 49 },
                    { 140, 6, 16, 90, 46, 81, 32 },
                    { 141, 7, 43, 75, 98, 67, 12 },
                    { 142, 8, 74, 74, 68, 39, 17 },
                    { 143, 6, 93, 23, 98, 61, 74 },
                    { 144, 9, 80, 28, 92, 66, 25 },
                    { 145, 9, 63, 36, 62, 33, 11 },
                    { 146, 1, 95, 93, 12, 36, 60 },
                    { 147, 6, 40, 1, 82, 74, 75 },
                    { 148, 3, 8, 87, 33, 30, 2 },
                    { 149, 3, 66, 55, 17, 54, 2 },
                    { 150, 1, 79, 77, 51, 4, 5 },
                    { 151, 7, 23, 42, 63, 60, 44 },
                    { 152, 3, 54, 57, 62, 36, 21 },
                    { 153, 7, 11, 6, 52, 67, 59 },
                    { 155, 6, 92, 41, 92, 8, 57 },
                    { 186, 7, 77, 73, 5, 25, 70 },
                    { 187, 2, 51, 92, 96, 48, 14 },
                    { 188, 7, 2, 68, 84, 71, 14 },
                    { 221, 1, 78, 79, 97, 94, 9 },
                    { 222, 7, 73, 17, 96, 53, 57 },
                    { 223, 4, 38, 82, 84, 17, 51 },
                    { 224, 8, 94, 58, 27, 81, 26 },
                    { 225, 5, 67, 37, 14, 9, 99 },
                    { 226, 2, 10, 21, 92, 79, 67 },
                    { 227, 2, 79, 67, 42, 77, 16 },
                    { 228, 8, 42, 28, 16, 37, 1 },
                    { 229, 7, 37, 91, 53, 68, 88 },
                    { 230, 5, 84, 96, 53, 46, 28 },
                    { 231, 7, 58, 64, 18, 85, 43 },
                    { 232, 4, 50, 59, 15, 64, 38 },
                    { 233, 8, 42, 17, 43, 42, 40 },
                    { 234, 9, 36, 31, 36, 46, 71 },
                    { 235, 1, 58, 42, 33, 40, 94 },
                    { 236, 7, 67, 34, 40, 70, 19 },
                    { 237, 5, 66, 56, 84, 79, 86 },
                    { 238, 4, 52, 73, 54, 69, 27 },
                    { 239, 7, 11, 43, 57, 54, 11 },
                    { 240, 9, 36, 13, 93, 10, 27 },
                    { 241, 1, 5, 11, 64, 45, 97 },
                    { 242, 1, 44, 71, 98, 91, 75 },
                    { 243, 8, 14, 56, 44, 93, 93 },
                    { 244, 9, 54, 89, 16, 61, 30 },
                    { 245, 5, 14, 13, 23, 42, 35 },
                    { 246, 1, 58, 56, 30, 82, 75 },
                    { 247, 7, 77, 8, 75, 50, 25 },
                    { 220, 2, 9, 4, 53, 82, 11 },
                    { 219, 4, 80, 73, 78, 39, 50 },
                    { 218, 7, 62, 51, 48, 88, 2 },
                    { 217, 6, 4, 3, 90, 45, 99 },
                    { 189, 3, 75, 29, 1, 11, 16 },
                    { 190, 3, 44, 28, 39, 22, 59 },
                    { 191, 2, 80, 1, 5, 37, 89 },
                    { 192, 8, 3, 28, 17, 69, 63 },
                    { 193, 9, 32, 62, 6, 33, 54 },
                    { 194, 6, 9, 96, 59, 49, 40 },
                    { 195, 1, 74, 67, 58, 78, 81 },
                    { 196, 4, 73, 30, 34, 81, 68 },
                    { 197, 2, 64, 65, 79, 98, 68 },
                    { 198, 8, 11, 7, 66, 9, 78 },
                    { 199, 5, 21, 11, 74, 79, 14 },
                    { 200, 6, 56, 31, 60, 94, 62 },
                    { 201, 2, 29, 25, 47, 74, 96 },
                    { 126, 1, 91, 86, 56, 87, 62 },
                    { 202, 4, 58, 50, 94, 92, 68 },
                    { 204, 4, 44, 66, 88, 5, 57 },
                    { 205, 7, 68, 93, 17, 70, 25 },
                    { 206, 4, 53, 70, 3, 58, 69 },
                    { 207, 4, 39, 36, 10, 33, 50 },
                    { 208, 3, 59, 29, 43, 85, 99 },
                    { 209, 1, 35, 82, 91, 26, 50 },
                    { 210, 9, 33, 24, 67, 76, 6 },
                    { 211, 1, 18, 87, 25, 57, 39 },
                    { 212, 9, 85, 22, 41, 84, 34 },
                    { 213, 1, 25, 12, 16, 60, 45 },
                    { 214, 3, 27, 83, 94, 14, 35 },
                    { 215, 4, 46, 28, 20, 7, 25 },
                    { 216, 5, 76, 63, 31, 8, 16 },
                    { 203, 8, 80, 11, 28, 73, 39 },
                    { 248, 5, 73, 19, 67, 73, 41 },
                    { 125, 2, 1, 80, 36, 23, 92 },
                    { 123, 8, 30, 87, 66, 81, 70 },
                    { 33, 4, 14, 75, 17, 97, 23 },
                    { 34, 4, 67, 31, 76, 94, 70 },
                    { 35, 5, 40, 74, 78, 25, 76 },
                    { 36, 7, 63, 76, 16, 68, 65 },
                    { 37, 2, 84, 15, 94, 12, 27 },
                    { 38, 6, 38, 76, 1, 87, 57 },
                    { 39, 5, 24, 83, 54, 3, 30 },
                    { 40, 9, 88, 67, 27, 84, 10 },
                    { 41, 3, 53, 13, 68, 93, 50 },
                    { 42, 6, 29, 45, 10, 95, 14 },
                    { 43, 1, 48, 56, 5, 11, 56 },
                    { 44, 9, 47, 52, 18, 31, 1 },
                    { 45, 9, 21, 60, 46, 24, 79 },
                    { 46, 9, 94, 1, 6, 61, 58 },
                    { 47, 2, 97, 45, 26, 37, 59 },
                    { 48, 2, 38, 29, 70, 46, 55 },
                    { 49, 7, 87, 78, 11, 32, 37 },
                    { 50, 6, 16, 23, 12, 75, 72 },
                    { 51, 9, 18, 5, 66, 12, 1 },
                    { 52, 2, 3, 86, 98, 90, 14 },
                    { 53, 2, 69, 10, 92, 6, 93 },
                    { 54, 7, 23, 74, 6, 72, 37 },
                    { 55, 1, 87, 62, 63, 47, 46 },
                    { 56, 4, 3, 23, 72, 36, 20 },
                    { 57, 5, 46, 26, 28, 57, 44 },
                    { 58, 7, 76, 96, 65, 98, 63 },
                    { 59, 3, 65, 10, 30, 39, 52 },
                    { 32, 3, 37, 45, 67, 14, 40 },
                    { 60, 9, 84, 45, 68, 64, 24 },
                    { 31, 6, 62, 97, 32, 50, 7 },
                    { 29, 1, 89, 41, 32, 70, 23 },
                    { 2, 2, 10, 77, 98, 96, 99 },
                    { 3, 5, 15, 49, 18, 62, 32 },
                    { 4, 6, 41, 24, 96, 68, 55 },
                    { 5, 8, 99, 76, 70, 63, 63 },
                    { 6, 2, 51, 63, 64, 20, 70 },
                    { 7, 7, 77, 3, 97, 35, 10 },
                    { 8, 4, 25, 98, 50, 81, 78 },
                    { 9, 3, 33, 72, 5, 2, 90 },
                    { 10, 7, 33, 10, 69, 55, 31 },
                    { 11, 5, 50, 47, 15, 84, 45 },
                    { 12, 4, 84, 95, 78, 50, 84 },
                    { 13, 3, 65, 6, 15, 57, 43 },
                    { 14, 6, 32, 19, 97, 37, 30 },
                    { 15, 9, 10, 50, 72, 96, 86 },
                    { 16, 6, 98, 23, 72, 44, 84 },
                    { 17, 6, 25, 41, 53, 14, 96 },
                    { 18, 8, 55, 83, 88, 75, 37 },
                    { 19, 8, 53, 75, 66, 13, 23 },
                    { 20, 2, 56, 14, 17, 25, 75 },
                    { 21, 9, 64, 88, 9, 17, 51 },
                    { 22, 6, 57, 21, 21, 52, 33 },
                    { 23, 1, 3, 18, 22, 15, 82 },
                    { 24, 5, 2, 35, 14, 87, 43 },
                    { 25, 1, 94, 86, 99, 60, 88 },
                    { 26, 7, 45, 1, 65, 58, 50 },
                    { 27, 1, 74, 38, 33, 27, 18 },
                    { 28, 2, 64, 1, 43, 63, 10 },
                    { 30, 4, 81, 76, 45, 97, 23 },
                    { 61, 4, 50, 55, 40, 63, 88 },
                    { 62, 9, 39, 34, 90, 38, 59 },
                    { 63, 7, 44, 65, 31, 38, 96 },
                    { 96, 1, 56, 11, 66, 64, 73 },
                    { 97, 5, 24, 65, 76, 92, 95 },
                    { 98, 5, 39, 16, 37, 87, 90 },
                    { 99, 9, 11, 15, 10, 54, 91 },
                    { 100, 6, 82, 76, 10, 28, 59 },
                    { 101, 4, 1, 47, 37, 56, 94 },
                    { 102, 8, 29, 22, 41, 68, 91 },
                    { 103, 6, 10, 42, 37, 99, 64 },
                    { 104, 6, 59, 47, 71, 56, 88 },
                    { 105, 4, 99, 2, 20, 6, 81 },
                    { 106, 9, 44, 96, 6, 42, 91 },
                    { 107, 5, 15, 82, 21, 55, 58 },
                    { 108, 7, 58, 42, 24, 46, 45 },
                    { 109, 5, 25, 83, 13, 48, 68 },
                    { 110, 2, 64, 44, 58, 97, 56 },
                    { 111, 9, 62, 24, 40, 44, 25 },
                    { 112, 9, 58, 68, 50, 87, 84 },
                    { 113, 8, 40, 4, 88, 2, 97 },
                    { 114, 5, 17, 54, 57, 70, 80 },
                    { 115, 9, 84, 95, 28, 93, 77 },
                    { 116, 5, 91, 17, 26, 28, 92 },
                    { 117, 4, 29, 15, 17, 29, 88 },
                    { 118, 7, 99, 38, 98, 31, 8 },
                    { 119, 6, 24, 62, 47, 11, 81 },
                    { 120, 1, 35, 92, 43, 43, 59 },
                    { 121, 3, 67, 64, 90, 2, 95 },
                    { 122, 7, 56, 13, 11, 54, 72 },
                    { 95, 9, 34, 62, 55, 99, 55 },
                    { 94, 8, 34, 33, 51, 3, 76 },
                    { 93, 9, 85, 14, 21, 15, 29 },
                    { 92, 5, 46, 92, 66, 51, 92 },
                    { 64, 4, 36, 88, 99, 35, 81 },
                    { 65, 4, 6, 63, 70, 74, 51 },
                    { 66, 7, 86, 81, 2, 89, 7 },
                    { 67, 8, 28, 13, 9, 74, 60 },
                    { 68, 3, 38, 28, 50, 62, 95 },
                    { 69, 8, 67, 47, 49, 28, 29 },
                    { 70, 4, 39, 16, 74, 4, 57 },
                    { 71, 3, 21, 65, 82, 16, 51 },
                    { 72, 8, 66, 55, 59, 42, 10 },
                    { 73, 8, 32, 62, 29, 69, 97 },
                    { 74, 5, 86, 44, 68, 83, 7 },
                    { 75, 1, 25, 59, 53, 66, 50 },
                    { 76, 9, 15, 24, 56, 83, 53 },
                    { 124, 4, 98, 54, 87, 63, 70 },
                    { 77, 9, 47, 22, 77, 72, 96 },
                    { 79, 6, 7, 69, 18, 21, 18 },
                    { 80, 2, 57, 38, 58, 79, 91 },
                    { 81, 9, 25, 99, 5, 67, 28 },
                    { 82, 8, 28, 49, 9, 34, 23 },
                    { 83, 7, 76, 14, 47, 28, 55 },
                    { 84, 8, 66, 59, 62, 86, 59 },
                    { 85, 8, 74, 94, 7, 42, 26 },
                    { 86, 2, 37, 68, 31, 84, 48 },
                    { 87, 9, 35, 60, 97, 52, 38 },
                    { 88, 5, 58, 73, 47, 41, 44 },
                    { 89, 1, 66, 30, 82, 75, 13 },
                    { 90, 3, 30, 38, 41, 25, 93 },
                    { 91, 4, 79, 85, 24, 92, 96 },
                    { 78, 4, 28, 25, 38, 66, 96 },
                    { 249, 5, 53, 42, 19, 94, 56 }
                });

            migrationBuilder.InsertData(
                table: "Heatmaps",
                columns: new[] { "HeatmapID", "ReferencepointId", "ReferencepointId1" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 158, 158, null },
                    { 159, 159, null },
                    { 160, 160, null },
                    { 161, 161, null },
                    { 162, 162, null },
                    { 163, 163, null },
                    { 164, 164, null },
                    { 165, 165, null },
                    { 166, 166, null },
                    { 167, 167, null },
                    { 168, 168, null },
                    { 169, 169, null },
                    { 170, 170, null },
                    { 171, 171, null },
                    { 172, 172, null },
                    { 173, 173, null },
                    { 174, 174, null },
                    { 175, 175, null },
                    { 176, 176, null },
                    { 177, 177, null },
                    { 178, 178, null },
                    { 179, 179, null },
                    { 180, 180, null },
                    { 181, 181, null },
                    { 182, 182, null },
                    { 183, 183, null },
                    { 184, 184, null },
                    { 157, 157, null },
                    { 185, 185, null },
                    { 156, 156, null },
                    { 154, 154, null },
                    { 127, 127, null },
                    { 128, 128, null },
                    { 129, 129, null },
                    { 130, 130, null },
                    { 131, 131, null },
                    { 132, 132, null },
                    { 133, 133, null },
                    { 134, 134, null },
                    { 135, 135, null },
                    { 136, 136, null },
                    { 137, 137, null },
                    { 138, 138, null },
                    { 139, 139, null },
                    { 140, 140, null },
                    { 141, 141, null },
                    { 142, 142, null },
                    { 143, 143, null },
                    { 144, 144, null },
                    { 145, 145, null },
                    { 146, 146, null },
                    { 147, 147, null },
                    { 148, 148, null },
                    { 149, 149, null },
                    { 150, 150, null },
                    { 151, 151, null },
                    { 152, 152, null },
                    { 153, 153, null },
                    { 155, 155, null },
                    { 186, 186, null },
                    { 187, 187, null },
                    { 188, 188, null },
                    { 221, 221, null },
                    { 222, 222, null },
                    { 223, 223, null },
                    { 224, 224, null },
                    { 225, 225, null },
                    { 226, 226, null },
                    { 227, 227, null },
                    { 228, 228, null },
                    { 229, 229, null },
                    { 230, 230, null },
                    { 231, 231, null },
                    { 232, 232, null },
                    { 233, 233, null },
                    { 234, 234, null },
                    { 235, 235, null },
                    { 236, 236, null },
                    { 237, 237, null },
                    { 238, 238, null },
                    { 239, 239, null },
                    { 240, 240, null },
                    { 241, 241, null },
                    { 242, 242, null },
                    { 243, 243, null },
                    { 244, 244, null },
                    { 245, 245, null },
                    { 246, 246, null },
                    { 247, 247, null },
                    { 220, 220, null },
                    { 219, 219, null },
                    { 218, 218, null },
                    { 217, 217, null },
                    { 189, 189, null },
                    { 190, 190, null },
                    { 191, 191, null },
                    { 192, 192, null },
                    { 193, 193, null },
                    { 194, 194, null },
                    { 195, 195, null },
                    { 196, 196, null },
                    { 197, 197, null },
                    { 198, 198, null },
                    { 199, 199, null },
                    { 200, 200, null },
                    { 201, 201, null },
                    { 126, 126, null },
                    { 202, 202, null },
                    { 204, 204, null },
                    { 205, 205, null },
                    { 206, 206, null },
                    { 207, 207, null },
                    { 208, 208, null },
                    { 209, 209, null },
                    { 210, 210, null },
                    { 211, 211, null },
                    { 212, 212, null },
                    { 213, 213, null },
                    { 214, 214, null },
                    { 215, 215, null },
                    { 216, 216, null },
                    { 203, 203, null },
                    { 248, 248, null },
                    { 125, 125, null },
                    { 123, 123, null },
                    { 33, 33, null },
                    { 34, 34, null },
                    { 35, 35, null },
                    { 36, 36, null },
                    { 37, 37, null },
                    { 38, 38, null },
                    { 39, 39, null },
                    { 40, 40, null },
                    { 41, 41, null },
                    { 42, 42, null },
                    { 43, 43, null },
                    { 44, 44, null },
                    { 45, 45, null },
                    { 46, 46, null },
                    { 47, 47, null },
                    { 48, 48, null },
                    { 49, 49, null },
                    { 50, 50, null },
                    { 51, 51, null },
                    { 52, 52, null },
                    { 53, 53, null },
                    { 54, 54, null },
                    { 55, 55, null },
                    { 56, 56, null },
                    { 57, 57, null },
                    { 58, 58, null },
                    { 59, 59, null },
                    { 32, 32, null },
                    { 60, 60, null },
                    { 31, 31, null },
                    { 29, 29, null },
                    { 2, 2, null },
                    { 3, 3, null },
                    { 4, 4, null },
                    { 5, 5, null },
                    { 6, 6, null },
                    { 7, 7, null },
                    { 8, 8, null },
                    { 9, 9, null },
                    { 10, 10, null },
                    { 11, 11, null },
                    { 12, 12, null },
                    { 13, 13, null },
                    { 14, 14, null },
                    { 15, 15, null },
                    { 16, 16, null },
                    { 17, 17, null },
                    { 18, 18, null },
                    { 19, 19, null },
                    { 20, 20, null },
                    { 21, 21, null },
                    { 22, 22, null },
                    { 23, 23, null },
                    { 24, 24, null },
                    { 25, 25, null },
                    { 26, 26, null },
                    { 27, 27, null },
                    { 28, 28, null },
                    { 30, 30, null },
                    { 61, 61, null },
                    { 62, 62, null },
                    { 63, 63, null },
                    { 96, 96, null },
                    { 97, 97, null },
                    { 98, 98, null },
                    { 99, 99, null },
                    { 100, 100, null },
                    { 101, 101, null },
                    { 102, 102, null },
                    { 103, 103, null },
                    { 104, 104, null },
                    { 105, 105, null },
                    { 106, 106, null },
                    { 107, 107, null },
                    { 108, 108, null },
                    { 109, 109, null },
                    { 110, 110, null },
                    { 111, 111, null },
                    { 112, 112, null },
                    { 113, 113, null },
                    { 114, 114, null },
                    { 115, 115, null },
                    { 116, 116, null },
                    { 117, 117, null },
                    { 118, 118, null },
                    { 119, 119, null },
                    { 120, 120, null },
                    { 121, 121, null },
                    { 122, 122, null },
                    { 95, 95, null },
                    { 94, 94, null },
                    { 93, 93, null },
                    { 92, 92, null },
                    { 64, 64, null },
                    { 65, 65, null },
                    { 66, 66, null },
                    { 67, 67, null },
                    { 68, 68, null },
                    { 69, 69, null },
                    { 70, 70, null },
                    { 71, 71, null },
                    { 72, 72, null },
                    { 73, 73, null },
                    { 74, 74, null },
                    { 75, 75, null },
                    { 76, 76, null },
                    { 124, 124, null },
                    { 77, 77, null },
                    { 79, 79, null },
                    { 80, 80, null },
                    { 81, 81, null },
                    { 82, 82, null },
                    { 83, 83, null },
                    { 84, 84, null },
                    { 85, 85, null },
                    { 86, 86, null },
                    { 87, 87, null },
                    { 88, 88, null },
                    { 89, 89, null },
                    { 90, 90, null },
                    { 91, 91, null },
                    { 78, 78, null },
                    { 249, 249, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId",
                table: "Heatmaps",
                column: "ReferencepointId");

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId1",
                table: "Heatmaps",
                column: "ReferencepointId1",
                unique: true,
                filter: "[ReferencepointId1] IS NOT NULL");
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
