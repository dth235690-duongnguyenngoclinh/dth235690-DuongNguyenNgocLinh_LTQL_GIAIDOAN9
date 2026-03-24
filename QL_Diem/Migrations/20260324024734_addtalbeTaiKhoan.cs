using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_Diem.Migrations
{
    /// <inheritdoc />
    public partial class addtalbeTaiKhoan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangDiem_HocSinh_HocSinhID",
                table: "BangDiem");

            migrationBuilder.DropForeignKey(
                name: "FK_BangDiem_MonHoc_MonHocID",
                table: "BangDiem");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinh_LopHoc_LopHocID",
                table: "HocSinh");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HocSinh",
                table: "HocSinh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangDiem",
                table: "BangDiem");

            migrationBuilder.RenameTable(
                name: "HocSinh",
                newName: "HocSinhs");

            migrationBuilder.RenameTable(
                name: "BangDiem",
                newName: "BangDiems");

            migrationBuilder.RenameColumn(
                name: "Mamon",
                table: "MonHoc",
                newName: "MaMon");

            migrationBuilder.RenameColumn(
                name: "LopHocID",
                table: "HocSinhs",
                newName: "LopID");

            migrationBuilder.RenameIndex(
                name: "IX_HocSinh_LopHocID",
                table: "HocSinhs",
                newName: "IX_HocSinhs_LopID");

            migrationBuilder.RenameIndex(
                name: "IX_BangDiem_MonHocID",
                table: "BangDiems",
                newName: "IX_BangDiems_MonHocID");

            migrationBuilder.RenameIndex(
                name: "IX_BangDiem_HocSinhID",
                table: "BangDiems",
                newName: "IX_BangDiems_HocSinhID");

            migrationBuilder.AddColumn<int>(
                name: "KhoiLop",
                table: "MonHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LoaiMon",
                table: "MonHoc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SoTiet",
                table: "MonHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "MonHoc",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "HocSinhs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsLock",
                table: "BangDiems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NamHoc",
                table: "BangDiems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "BangDiems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HocSinhs",
                table: "HocSinhs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangDiems",
                table: "BangDiems",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "LopHocs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoiLop = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaoVienChuNhiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaKetThuc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BangDiems_HocSinhs_HocSinhID",
                table: "BangDiems",
                column: "HocSinhID",
                principalTable: "HocSinhs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BangDiems_MonHoc_MonHocID",
                table: "BangDiems",
                column: "MonHocID",
                principalTable: "MonHoc",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_LopHocs_LopID",
                table: "HocSinhs",
                column: "LopID",
                principalTable: "LopHocs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangDiems_HocSinhs_HocSinhID",
                table: "BangDiems");

            migrationBuilder.DropForeignKey(
                name: "FK_BangDiems_MonHoc_MonHocID",
                table: "BangDiems");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_LopHocs_LopID",
                table: "HocSinhs");

            migrationBuilder.DropTable(
                name: "LopHocs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HocSinhs",
                table: "HocSinhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangDiems",
                table: "BangDiems");

            migrationBuilder.DropColumn(
                name: "KhoiLop",
                table: "MonHoc");

            migrationBuilder.DropColumn(
                name: "LoaiMon",
                table: "MonHoc");

            migrationBuilder.DropColumn(
                name: "SoTiet",
                table: "MonHoc");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "MonHoc");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "IsLock",
                table: "BangDiems");

            migrationBuilder.DropColumn(
                name: "NamHoc",
                table: "BangDiems");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "BangDiems");

            migrationBuilder.RenameTable(
                name: "HocSinhs",
                newName: "HocSinh");

            migrationBuilder.RenameTable(
                name: "BangDiems",
                newName: "BangDiem");

            migrationBuilder.RenameColumn(
                name: "MaMon",
                table: "MonHoc",
                newName: "Mamon");

            migrationBuilder.RenameColumn(
                name: "LopID",
                table: "HocSinh",
                newName: "LopHocID");

            migrationBuilder.RenameIndex(
                name: "IX_HocSinhs_LopID",
                table: "HocSinh",
                newName: "IX_HocSinh_LopHocID");

            migrationBuilder.RenameIndex(
                name: "IX_BangDiems_MonHocID",
                table: "BangDiem",
                newName: "IX_BangDiem_MonHocID");

            migrationBuilder.RenameIndex(
                name: "IX_BangDiems_HocSinhID",
                table: "BangDiem",
                newName: "IX_BangDiem_HocSinhID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HocSinh",
                table: "HocSinh",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangDiem",
                table: "BangDiem",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaoVienChuNhiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BangDiem_HocSinh_HocSinhID",
                table: "BangDiem",
                column: "HocSinhID",
                principalTable: "HocSinh",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BangDiem_MonHoc_MonHocID",
                table: "BangDiem",
                column: "MonHocID",
                principalTable: "MonHoc",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinh_LopHoc_LopHocID",
                table: "HocSinh",
                column: "LopHocID",
                principalTable: "LopHoc",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
