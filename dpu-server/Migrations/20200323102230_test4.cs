using Microsoft.EntityFrameworkCore.Migrations;

namespace dpu_server.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HeatmapId",
                table: "Heatmaps",
                newName: "HeatmapID");

            migrationBuilder.AlterColumn<float>(
                name: "Strength",
                table: "Heatmaps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 1,
                column: "Strength",
                value: 1f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 2,
                column: "Strength",
                value: 2f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 3,
                column: "Strength",
                value: 3f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 4,
                column: "Strength",
                value: 4f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 5,
                column: "Strength",
                value: 2f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 6,
                column: "Strength",
                value: 2f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 7,
                column: "Strength",
                value: 3f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 8,
                column: "Strength",
                value: 1f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 9,
                column: "Strength",
                value: 4f);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapID",
                keyValue: 10,
                column: "Strength",
                value: 1f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HeatmapID",
                table: "Heatmaps",
                newName: "HeatmapId");

            migrationBuilder.AlterColumn<int>(
                name: "Strength",
                table: "Heatmaps",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 1,
                column: "Strength",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 2,
                column: "Strength",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 3,
                column: "Strength",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 4,
                column: "Strength",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 5,
                column: "Strength",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 6,
                column: "Strength",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 7,
                column: "Strength",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 8,
                column: "Strength",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 9,
                column: "Strength",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Heatmaps",
                keyColumn: "HeatmapId",
                keyValue: 10,
                column: "Strength",
                value: 1);
        }
    }
}
