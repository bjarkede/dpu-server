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
                    ReferencepointId = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Referencepoints",
                columns: new[] { "ReferencepointId", "Category", "RSSI1", "RSSI2", "RSSI3", "X", "Y" },
                values: new object[,]
                {
                    { 1, 9, 14, 98, 20, 70, 7 },
                    { 158, 7, 99, 56, 8, 95, 73 },
                    { 159, 6, 60, 57, 37, 8, 30 },
                    { 160, 6, 1, 34, 22, 61, 1 },
                    { 161, 5, 43, 41, 4, 36, 19 },
                    { 162, 6, 45, 3, 61, 69, 13 },
                    { 163, 4, 65, 57, 21, 36, 75 },
                    { 164, 4, 69, 37, 78, 61, 2 },
                    { 165, 9, 13, 62, 84, 80, 64 },
                    { 166, 4, 74, 47, 17, 48, 96 },
                    { 167, 4, 64, 63, 37, 45, 51 },
                    { 168, 7, 1, 90, 44, 94, 42 },
                    { 169, 7, 40, 64, 58, 81, 91 },
                    { 170, 6, 72, 81, 40, 13, 24 },
                    { 171, 6, 77, 65, 38, 25, 95 },
                    { 172, 6, 26, 18, 61, 77, 71 },
                    { 173, 2, 3, 24, 86, 8, 60 },
                    { 174, 1, 47, 18, 21, 12, 40 },
                    { 175, 9, 78, 92, 56, 54, 75 },
                    { 176, 2, 5, 51, 40, 81, 68 },
                    { 177, 8, 33, 76, 95, 79, 69 },
                    { 178, 3, 12, 63, 93, 46, 78 },
                    { 179, 7, 76, 64, 21, 29, 65 },
                    { 180, 1, 36, 65, 25, 38, 47 },
                    { 181, 1, 10, 71, 42, 46, 73 },
                    { 182, 2, 72, 22, 56, 2, 75 },
                    { 183, 8, 16, 68, 49, 96, 1 },
                    { 184, 7, 7, 33, 14, 88, 77 },
                    { 157, 9, 9, 18, 98, 39, 84 },
                    { 185, 2, 94, 75, 86, 35, 46 },
                    { 156, 5, 69, 15, 40, 65, 70 },
                    { 154, 6, 96, 6, 4, 75, 96 },
                    { 127, 7, 79, 94, 48, 11, 74 },
                    { 128, 7, 37, 25, 64, 73, 78 },
                    { 129, 8, 49, 91, 42, 2, 26 },
                    { 130, 5, 80, 51, 50, 3, 80 },
                    { 131, 8, 26, 8, 56, 49, 54 },
                    { 132, 2, 96, 11, 24, 52, 45 },
                    { 133, 7, 59, 31, 60, 96, 76 },
                    { 134, 5, 85, 7, 84, 54, 32 },
                    { 135, 5, 47, 10, 6, 60, 84 },
                    { 136, 6, 24, 77, 15, 61, 84 },
                    { 137, 6, 16, 87, 71, 53, 77 },
                    { 138, 7, 63, 96, 47, 70, 43 },
                    { 139, 9, 94, 84, 75, 99, 17 },
                    { 140, 7, 2, 71, 75, 1, 2 },
                    { 141, 4, 7, 37, 26, 57, 28 },
                    { 142, 7, 58, 97, 46, 93, 80 },
                    { 143, 8, 79, 32, 29, 18, 91 },
                    { 144, 4, 9, 77, 66, 10, 65 },
                    { 145, 1, 91, 25, 60, 41, 60 },
                    { 146, 2, 91, 15, 86, 27, 46 },
                    { 147, 4, 41, 6, 68, 78, 13 },
                    { 148, 5, 50, 2, 5, 86, 21 },
                    { 149, 8, 45, 84, 80, 40, 92 },
                    { 150, 3, 78, 96, 71, 26, 65 },
                    { 151, 1, 9, 18, 37, 33, 3 },
                    { 152, 6, 3, 53, 85, 88, 76 },
                    { 153, 8, 67, 31, 64, 21, 60 },
                    { 155, 7, 33, 51, 23, 61, 49 },
                    { 186, 1, 61, 94, 29, 92, 69 },
                    { 187, 9, 82, 65, 89, 73, 73 },
                    { 188, 6, 12, 75, 89, 36, 14 },
                    { 221, 6, 37, 42, 24, 82, 76 },
                    { 222, 8, 51, 92, 76, 98, 69 },
                    { 223, 6, 50, 19, 25, 22, 77 },
                    { 224, 2, 28, 29, 16, 59, 29 },
                    { 225, 5, 52, 11, 82, 18, 74 },
                    { 226, 7, 99, 71, 38, 20, 58 },
                    { 227, 1, 43, 89, 5, 79, 59 },
                    { 228, 8, 90, 7, 14, 26, 1 },
                    { 229, 2, 52, 27, 92, 83, 23 },
                    { 230, 4, 46, 77, 14, 69, 30 },
                    { 231, 6, 2, 34, 18, 2, 99 },
                    { 232, 9, 24, 31, 61, 17, 78 },
                    { 233, 8, 15, 49, 70, 36, 68 },
                    { 234, 2, 41, 27, 10, 63, 65 },
                    { 235, 5, 82, 17, 49, 4, 73 },
                    { 236, 8, 94, 73, 59, 39, 77 },
                    { 237, 3, 63, 89, 8, 16, 2 },
                    { 238, 7, 58, 36, 48, 5, 68 },
                    { 239, 7, 64, 10, 10, 91, 29 },
                    { 240, 1, 56, 38, 68, 70, 20 },
                    { 241, 8, 48, 21, 57, 81, 23 },
                    { 242, 1, 28, 76, 72, 45, 73 },
                    { 243, 8, 15, 25, 25, 40, 6 },
                    { 244, 3, 99, 77, 48, 76, 40 },
                    { 245, 6, 70, 3, 44, 56, 83 },
                    { 246, 4, 56, 92, 69, 25, 68 },
                    { 247, 8, 13, 76, 14, 43, 77 },
                    { 220, 7, 48, 69, 4, 51, 63 },
                    { 219, 7, 6, 82, 87, 50, 37 },
                    { 218, 6, 72, 81, 62, 10, 72 },
                    { 217, 1, 22, 2, 80, 94, 50 },
                    { 189, 9, 56, 39, 65, 47, 31 },
                    { 190, 2, 89, 22, 94, 31, 52 },
                    { 191, 9, 34, 38, 76, 54, 40 },
                    { 192, 8, 55, 24, 99, 51, 15 },
                    { 193, 4, 87, 34, 59, 57, 76 },
                    { 194, 1, 23, 58, 61, 88, 78 },
                    { 195, 1, 38, 14, 63, 15, 3 },
                    { 196, 5, 4, 52, 13, 91, 39 },
                    { 197, 4, 81, 58, 35, 9, 81 },
                    { 198, 9, 97, 6, 25, 30, 59 },
                    { 199, 9, 55, 33, 46, 91, 9 },
                    { 200, 9, 37, 46, 60, 69, 16 },
                    { 201, 3, 17, 41, 21, 53, 47 },
                    { 126, 9, 12, 32, 15, 65, 18 },
                    { 202, 6, 23, 96, 94, 25, 75 },
                    { 204, 7, 82, 9, 54, 66, 60 },
                    { 205, 7, 2, 12, 44, 19, 55 },
                    { 206, 9, 75, 13, 42, 9, 91 },
                    { 207, 4, 69, 45, 58, 62, 7 },
                    { 208, 6, 3, 30, 57, 27, 25 },
                    { 209, 9, 18, 65, 55, 87, 86 },
                    { 210, 1, 73, 51, 80, 50, 51 },
                    { 211, 4, 19, 5, 41, 2, 49 },
                    { 212, 6, 77, 59, 23, 37, 3 },
                    { 213, 5, 15, 20, 2, 90, 63 },
                    { 214, 3, 14, 74, 87, 49, 1 },
                    { 215, 9, 39, 88, 26, 35, 36 },
                    { 216, 4, 60, 19, 94, 23, 44 },
                    { 203, 2, 67, 14, 77, 71, 90 },
                    { 248, 9, 2, 19, 37, 30, 77 },
                    { 125, 5, 80, 62, 41, 81, 47 },
                    { 123, 2, 76, 41, 27, 25, 66 },
                    { 33, 9, 33, 87, 7, 50, 39 },
                    { 34, 1, 55, 4, 55, 90, 64 },
                    { 35, 4, 29, 72, 48, 87, 48 },
                    { 36, 5, 95, 97, 29, 25, 85 },
                    { 37, 8, 61, 14, 11, 97, 95 },
                    { 38, 3, 53, 27, 33, 58, 60 },
                    { 39, 4, 25, 60, 8, 33, 54 },
                    { 40, 4, 9, 55, 3, 8, 99 },
                    { 41, 6, 38, 14, 50, 58, 22 },
                    { 42, 9, 67, 8, 2, 27, 89 },
                    { 43, 3, 90, 58, 9, 23, 37 },
                    { 44, 4, 3, 71, 13, 12, 63 },
                    { 45, 8, 45, 62, 44, 88, 16 },
                    { 46, 3, 77, 53, 15, 53, 59 },
                    { 47, 8, 82, 95, 5, 37, 90 },
                    { 48, 5, 35, 97, 71, 82, 42 },
                    { 49, 9, 33, 86, 19, 65, 5 },
                    { 50, 3, 45, 26, 51, 61, 13 },
                    { 51, 6, 52, 79, 91, 71, 50 },
                    { 52, 4, 11, 38, 98, 26, 41 },
                    { 53, 4, 33, 66, 80, 60, 76 },
                    { 54, 6, 18, 62, 21, 47, 55 },
                    { 55, 3, 13, 12, 49, 86, 8 },
                    { 56, 4, 31, 21, 82, 46, 84 },
                    { 57, 2, 61, 64, 48, 35, 72 },
                    { 58, 1, 97, 7, 46, 77, 33 },
                    { 59, 4, 47, 85, 50, 86, 44 },
                    { 32, 8, 2, 98, 10, 17, 93 },
                    { 60, 5, 39, 6, 24, 61, 59 },
                    { 31, 6, 46, 66, 44, 28, 31 },
                    { 29, 6, 43, 27, 54, 92, 24 },
                    { 2, 8, 90, 93, 16, 98, 55 },
                    { 3, 5, 18, 17, 59, 53, 13 },
                    { 4, 6, 36, 27, 79, 77, 32 },
                    { 5, 2, 25, 29, 72, 17, 3 },
                    { 6, 6, 69, 98, 95, 92, 54 },
                    { 7, 4, 30, 43, 66, 20, 52 },
                    { 8, 1, 56, 52, 81, 69, 77 },
                    { 9, 8, 58, 54, 89, 5, 67 },
                    { 10, 2, 15, 37, 66, 5, 46 },
                    { 11, 7, 14, 73, 91, 55, 30 },
                    { 12, 6, 60, 25, 63, 21, 24 },
                    { 13, 7, 94, 17, 75, 73, 21 },
                    { 14, 8, 33, 56, 52, 89, 59 },
                    { 15, 5, 71, 65, 31, 81, 78 },
                    { 16, 2, 72, 25, 97, 88, 7 },
                    { 17, 8, 15, 2, 23, 25, 9 },
                    { 18, 5, 20, 38, 30, 20, 11 },
                    { 19, 5, 38, 41, 16, 86, 71 },
                    { 20, 9, 26, 24, 14, 43, 83 },
                    { 21, 6, 26, 78, 46, 46, 49 },
                    { 22, 9, 73, 6, 10, 96, 58 },
                    { 23, 2, 57, 9, 47, 99, 70 },
                    { 24, 2, 19, 52, 54, 79, 44 },
                    { 25, 4, 1, 85, 53, 7, 62 },
                    { 26, 8, 65, 72, 19, 58, 98 },
                    { 27, 3, 6, 74, 88, 31, 46 },
                    { 28, 1, 41, 42, 83, 96, 30 },
                    { 30, 3, 10, 46, 35, 9, 45 },
                    { 61, 4, 86, 25, 31, 65, 95 },
                    { 62, 2, 59, 86, 81, 69, 99 },
                    { 63, 2, 17, 82, 89, 17, 49 },
                    { 96, 3, 50, 73, 51, 96, 15 },
                    { 97, 3, 68, 30, 81, 70, 1 },
                    { 98, 3, 72, 1, 59, 8, 97 },
                    { 99, 8, 85, 79, 17, 55, 71 },
                    { 100, 8, 66, 11, 44, 71, 91 },
                    { 101, 7, 6, 41, 5, 15, 66 },
                    { 102, 3, 76, 15, 91, 79, 47 },
                    { 103, 3, 16, 91, 26, 54, 3 },
                    { 104, 1, 62, 17, 25, 6, 96 },
                    { 105, 5, 15, 94, 2, 64, 30 },
                    { 106, 1, 86, 96, 39, 7, 65 },
                    { 107, 6, 19, 57, 35, 27, 32 },
                    { 108, 8, 90, 7, 32, 88, 40 },
                    { 109, 8, 61, 13, 8, 42, 10 },
                    { 110, 7, 50, 1, 44, 50, 1 },
                    { 111, 7, 30, 12, 84, 86, 92 },
                    { 112, 5, 89, 9, 26, 65, 35 },
                    { 113, 5, 67, 35, 84, 42, 15 },
                    { 114, 9, 23, 26, 55, 22, 3 },
                    { 115, 2, 97, 44, 87, 64, 57 },
                    { 116, 6, 17, 68, 56, 63, 97 },
                    { 117, 2, 98, 4, 14, 81, 99 },
                    { 118, 3, 55, 96, 77, 63, 75 },
                    { 119, 7, 89, 8, 85, 54, 28 },
                    { 120, 7, 17, 9, 9, 67, 89 },
                    { 121, 5, 64, 25, 52, 60, 49 },
                    { 122, 6, 88, 4, 38, 65, 43 },
                    { 95, 2, 25, 23, 86, 82, 33 },
                    { 94, 9, 61, 26, 77, 75, 2 },
                    { 93, 3, 11, 7, 9, 15, 58 },
                    { 92, 9, 23, 38, 46, 16, 6 },
                    { 64, 5, 84, 36, 78, 11, 39 },
                    { 65, 3, 83, 45, 77, 31, 8 },
                    { 66, 8, 87, 99, 5, 10, 48 },
                    { 67, 5, 73, 33, 12, 26, 18 },
                    { 68, 5, 57, 78, 85, 37, 70 },
                    { 69, 6, 61, 22, 56, 75, 77 },
                    { 70, 3, 59, 76, 85, 9, 81 },
                    { 71, 5, 42, 28, 79, 3, 81 },
                    { 72, 1, 8, 7, 35, 42, 43 },
                    { 73, 2, 38, 58, 18, 33, 54 },
                    { 74, 6, 37, 47, 75, 17, 69 },
                    { 75, 8, 24, 13, 22, 81, 50 },
                    { 76, 7, 62, 65, 52, 60, 84 },
                    { 124, 1, 41, 34, 68, 13, 75 },
                    { 77, 9, 67, 55, 96, 84, 29 },
                    { 79, 2, 6, 27, 23, 25, 71 },
                    { 80, 4, 76, 25, 58, 93, 78 },
                    { 81, 7, 78, 27, 56, 62, 80 },
                    { 82, 8, 64, 77, 74, 28, 65 },
                    { 83, 9, 64, 53, 18, 12, 90 },
                    { 84, 5, 7, 84, 75, 4, 75 },
                    { 85, 3, 50, 37, 93, 19, 84 },
                    { 86, 6, 31, 73, 76, 27, 7 },
                    { 87, 1, 7, 64, 39, 1, 75 },
                    { 88, 6, 45, 78, 62, 24, 60 },
                    { 89, 2, 17, 64, 35, 9, 87 },
                    { 90, 9, 94, 75, 52, 33, 13 },
                    { 91, 4, 85, 46, 92, 16, 96 },
                    { 78, 6, 26, 20, 79, 40, 37 },
                    { 249, 1, 78, 16, 33, 39, 71 }
                });

            migrationBuilder.InsertData(
                table: "Heatmaps",
                columns: new[] { "HeatmapID", "ReferencepointId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 158, 158 },
                    { 159, 159 },
                    { 160, 160 },
                    { 161, 161 },
                    { 162, 162 },
                    { 163, 163 },
                    { 164, 164 },
                    { 165, 165 },
                    { 166, 166 },
                    { 167, 167 },
                    { 168, 168 },
                    { 169, 169 },
                    { 170, 170 },
                    { 171, 171 },
                    { 172, 172 },
                    { 173, 173 },
                    { 174, 174 },
                    { 175, 175 },
                    { 176, 176 },
                    { 177, 177 },
                    { 178, 178 },
                    { 179, 179 },
                    { 180, 180 },
                    { 181, 181 },
                    { 182, 182 },
                    { 183, 183 },
                    { 184, 184 },
                    { 157, 157 },
                    { 185, 185 },
                    { 156, 156 },
                    { 154, 154 },
                    { 127, 127 },
                    { 128, 128 },
                    { 129, 129 },
                    { 130, 130 },
                    { 131, 131 },
                    { 132, 132 },
                    { 133, 133 },
                    { 134, 134 },
                    { 135, 135 },
                    { 136, 136 },
                    { 137, 137 },
                    { 138, 138 },
                    { 139, 139 },
                    { 140, 140 },
                    { 141, 141 },
                    { 142, 142 },
                    { 143, 143 },
                    { 144, 144 },
                    { 145, 145 },
                    { 146, 146 },
                    { 147, 147 },
                    { 148, 148 },
                    { 149, 149 },
                    { 150, 150 },
                    { 151, 151 },
                    { 152, 152 },
                    { 153, 153 },
                    { 155, 155 },
                    { 186, 186 },
                    { 187, 187 },
                    { 188, 188 },
                    { 221, 221 },
                    { 222, 222 },
                    { 223, 223 },
                    { 224, 224 },
                    { 225, 225 },
                    { 226, 226 },
                    { 227, 227 },
                    { 228, 228 },
                    { 229, 229 },
                    { 230, 230 },
                    { 231, 231 },
                    { 232, 232 },
                    { 233, 233 },
                    { 234, 234 },
                    { 235, 235 },
                    { 236, 236 },
                    { 237, 237 },
                    { 238, 238 },
                    { 239, 239 },
                    { 240, 240 },
                    { 241, 241 },
                    { 242, 242 },
                    { 243, 243 },
                    { 244, 244 },
                    { 245, 245 },
                    { 246, 246 },
                    { 247, 247 },
                    { 220, 220 },
                    { 219, 219 },
                    { 218, 218 },
                    { 217, 217 },
                    { 189, 189 },
                    { 190, 190 },
                    { 191, 191 },
                    { 192, 192 },
                    { 193, 193 },
                    { 194, 194 },
                    { 195, 195 },
                    { 196, 196 },
                    { 197, 197 },
                    { 198, 198 },
                    { 199, 199 },
                    { 200, 200 },
                    { 201, 201 },
                    { 126, 126 },
                    { 202, 202 },
                    { 204, 204 },
                    { 205, 205 },
                    { 206, 206 },
                    { 207, 207 },
                    { 208, 208 },
                    { 209, 209 },
                    { 210, 210 },
                    { 211, 211 },
                    { 212, 212 },
                    { 213, 213 },
                    { 214, 214 },
                    { 215, 215 },
                    { 216, 216 },
                    { 203, 203 },
                    { 248, 248 },
                    { 125, 125 },
                    { 123, 123 },
                    { 33, 33 },
                    { 34, 34 },
                    { 35, 35 },
                    { 36, 36 },
                    { 37, 37 },
                    { 38, 38 },
                    { 39, 39 },
                    { 40, 40 },
                    { 41, 41 },
                    { 42, 42 },
                    { 43, 43 },
                    { 44, 44 },
                    { 45, 45 },
                    { 46, 46 },
                    { 47, 47 },
                    { 48, 48 },
                    { 49, 49 },
                    { 50, 50 },
                    { 51, 51 },
                    { 52, 52 },
                    { 53, 53 },
                    { 54, 54 },
                    { 55, 55 },
                    { 56, 56 },
                    { 57, 57 },
                    { 58, 58 },
                    { 59, 59 },
                    { 32, 32 },
                    { 60, 60 },
                    { 31, 31 },
                    { 29, 29 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 },
                    { 17, 17 },
                    { 18, 18 },
                    { 19, 19 },
                    { 20, 20 },
                    { 21, 21 },
                    { 22, 22 },
                    { 23, 23 },
                    { 24, 24 },
                    { 25, 25 },
                    { 26, 26 },
                    { 27, 27 },
                    { 28, 28 },
                    { 30, 30 },
                    { 61, 61 },
                    { 62, 62 },
                    { 63, 63 },
                    { 96, 96 },
                    { 97, 97 },
                    { 98, 98 },
                    { 99, 99 },
                    { 100, 100 },
                    { 101, 101 },
                    { 102, 102 },
                    { 103, 103 },
                    { 104, 104 },
                    { 105, 105 },
                    { 106, 106 },
                    { 107, 107 },
                    { 108, 108 },
                    { 109, 109 },
                    { 110, 110 },
                    { 111, 111 },
                    { 112, 112 },
                    { 113, 113 },
                    { 114, 114 },
                    { 115, 115 },
                    { 116, 116 },
                    { 117, 117 },
                    { 118, 118 },
                    { 119, 119 },
                    { 120, 120 },
                    { 121, 121 },
                    { 122, 122 },
                    { 95, 95 },
                    { 94, 94 },
                    { 93, 93 },
                    { 92, 92 },
                    { 64, 64 },
                    { 65, 65 },
                    { 66, 66 },
                    { 67, 67 },
                    { 68, 68 },
                    { 69, 69 },
                    { 70, 70 },
                    { 71, 71 },
                    { 72, 72 },
                    { 73, 73 },
                    { 74, 74 },
                    { 75, 75 },
                    { 76, 76 },
                    { 124, 124 },
                    { 77, 77 },
                    { 79, 79 },
                    { 80, 80 },
                    { 81, 81 },
                    { 82, 82 },
                    { 83, 83 },
                    { 84, 84 },
                    { 85, 85 },
                    { 86, 86 },
                    { 87, 87 },
                    { 88, 88 },
                    { 89, 89 },
                    { 90, 90 },
                    { 91, 91 },
                    { 78, 78 },
                    { 249, 249 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId",
                table: "Heatmaps",
                column: "ReferencepointId",
                unique: true);
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
