using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_Diem.Migrations
{
    /// <inheritdoc />
    public partial class AddKTThuongXuyenColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "KTThuongXuyen1",
                table: "QLDiems",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KTThuongXuyen2",
                table: "QLDiems",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KTThuongXuyen3",
                table: "QLDiems",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KTThuongXuyen1",
                table: "QLDiems");

            migrationBuilder.DropColumn(
                name: "KTThuongXuyen2",
                table: "QLDiems");

            migrationBuilder.DropColumn(
                name: "KTThuongXuyen3",
                table: "QLDiems");
        }
    }
}
