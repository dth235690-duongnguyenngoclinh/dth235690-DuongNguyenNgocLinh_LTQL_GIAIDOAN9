using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_Diem.Migrations
{
    /// <inheritdoc />
    public partial class TaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaoVienChuNhiem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mamon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenMon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHocSinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LopHocID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HocSinh_LopHoc_LopHocID",
                        column: x => x.LopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangDiem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocSinhID = table.Column<int>(type: "int", nullable: false),
                    MonHocID = table.Column<int>(type: "int", nullable: false),
                    DiemGiuaKy = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiKy = table.Column<double>(type: "float", nullable: true),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanhGia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BangDiem_HocSinh_HocSinhID",
                        column: x => x.HocSinhID,
                        principalTable: "HocSinh",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangDiem_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_HocSinhID",
                table: "BangDiem",
                column: "HocSinhID");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiem_MonHocID",
                table: "BangDiem",
                column: "MonHocID");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_LopHocID",
                table: "HocSinh",
                column: "LopHocID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangDiem");

            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "LopHoc");
        }
    }
}
