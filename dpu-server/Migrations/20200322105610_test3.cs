using Microsoft.EntityFrameworkCore.Migrations;

namespace dpu_server.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReferencepointID",
                table: "Referencepoints",
                newName: "ReferencepointId");

            migrationBuilder.RenameColumn(
                name: "HeatmapID",
                table: "Heatmaps",
                newName: "HeatmapId");

            migrationBuilder.InsertData(
                table: "Heatmaps",
                columns: new[] { "HeatmapId", "Strength" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 9, 4 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Referencepoints",
                columns: new[] { "ReferencepointId", "Category", "HeatmapId", "RSSI1", "RSSI2", "RSSI3", "X", "Y" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 5, 1, 1 },
                    { 2, 2, 2, 2, 2, 3, 2, 2 },
                    { 3, 3, 3, 3, 3, 5, 3, 3 },
                    { 4, 4, 4, 4, 2, 3, 4, 4 },
                    { 5, 5, 5, 5, 6, 3, 5, 5 },
                    { 6, 1, 6, 1, 2, 1, 6, 6 },
                    { 7, 2, 7, 2, 5, 3, 7, 7 },
                    { 8, 3, 8, 3, 2, 3, 8, 8 },
                    { 9, 2, 9, 2, 4, 3, 9, 9 },
                    { 10, 2, 10, 2, 3, 2, 10, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Referencepoints",
                keyColumn: "ReferencepointId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "ReferencepointId",
                table: "Referencepoints",
                newName: "ReferencepointID");

            migrationBuilder.RenameColumn(
                name: "HeatmapId",
                table: "Heatmaps",
                newName: "HeatmapID");
        }
    }
}
