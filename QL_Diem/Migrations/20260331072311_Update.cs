using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_Diem.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangDiems");

            migrationBuilder.CreateTable(
                name: "QLDiems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocSinhID = table.Column<int>(type: "int", nullable: false),
                    MonHocID = table.Column<int>(type: "int", nullable: false),
                    DiemGiuaKy = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiKy = table.Column<double>(type: "float", nullable: true),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanhGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLDiems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QLDiems_HocSinhs_HocSinhID",
                        column: x => x.HocSinhID,
                        principalTable: "HocSinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QLDiems_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QLDiems_HocSinhID",
                table: "QLDiems",
                column: "HocSinhID");

            migrationBuilder.CreateIndex(
                name: "IX_QLDiems_MonHocID",
                table: "QLDiems",
                column: "MonHocID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QLDiems");

            migrationBuilder.CreateTable(
                name: "BangDiems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocSinhID = table.Column<int>(type: "int", nullable: false),
                    MonHocID = table.Column<int>(type: "int", nullable: false),
                    DanhGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemCuoiKy = table.Column<double>(type: "float", nullable: true),
                    DiemGiuaKy = table.Column<double>(type: "float", nullable: true),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLock = table.Column<bool>(type: "bit", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BangDiems_HocSinhs_HocSinhID",
                        column: x => x.HocSinhID,
                        principalTable: "HocSinhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangDiems_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_HocSinhID",
                table: "BangDiems",
                column: "HocSinhID");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_MonHocID",
                table: "BangDiems",
                column: "MonHocID");
        }
    }
}
