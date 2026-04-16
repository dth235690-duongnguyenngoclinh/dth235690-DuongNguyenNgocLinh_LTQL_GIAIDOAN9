using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_Diem.Migrations
{
    /// <inheritdoc />
    public partial class AddNamHocAndGVCN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GiaoVienChuNhiem",
                table: "HocSinhs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NamHoc",
                table: "HocSinhs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaoVienChuNhiem",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "NamHoc",
                table: "HocSinhs");
        }
    }
}
