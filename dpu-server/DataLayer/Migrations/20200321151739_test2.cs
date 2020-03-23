using Microsoft.EntityFrameworkCore.Migrations;

namespace dpu_server.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referencepoints_Heatmaps_HeatmapFK",
                table: "Referencepoints");

            migrationBuilder.DropIndex(
                name: "IX_Referencepoints_HeatmapFK",
                table: "Referencepoints");

            migrationBuilder.DropColumn(
                name: "HeatmapFK",
                table: "Referencepoints");

            migrationBuilder.AddColumn<int>(
                name: "HeatmapId",
                table: "Referencepoints",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Referencepoints_HeatmapId",
                table: "Referencepoints",
                column: "HeatmapId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Referencepoints_Heatmaps_HeatmapId",
                table: "Referencepoints",
                column: "HeatmapId",
                principalTable: "Heatmaps",
                principalColumn: "HeatmapID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referencepoints_Heatmaps_HeatmapId",
                table: "Referencepoints");

            migrationBuilder.DropIndex(
                name: "IX_Referencepoints_HeatmapId",
                table: "Referencepoints");

            migrationBuilder.DropColumn(
                name: "HeatmapId",
                table: "Referencepoints");

            migrationBuilder.AddColumn<int>(
                name: "HeatmapFK",
                table: "Referencepoints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Referencepoints_HeatmapFK",
                table: "Referencepoints",
                column: "HeatmapFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Referencepoints_Heatmaps_HeatmapFK",
                table: "Referencepoints",
                column: "HeatmapFK",
                principalTable: "Heatmaps",
                principalColumn: "HeatmapID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
