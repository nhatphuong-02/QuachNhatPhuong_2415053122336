using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    MaDG = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenDG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.MaDG);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuons",
                columns: table => new
                {
                    MaPM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaDG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocGiaMaDG = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuons", x => x.MaPM);
                    table.ForeignKey(
                        name: "FK_PhieuMuons_DocGias_DocGiaMaDG",
                        column: x => x.DocGiaMaDG,
                        principalTable: "DocGias",
                        principalColumn: "MaDG");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuons",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    PhieuMuonMaPM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SachMaSach = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuons", x => x.MaCT);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonMaPM",
                        column: x => x.PhieuMuonMaPM,
                        principalTable: "PhieuMuons",
                        principalColumn: "MaPM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuons_Sachs_SachMaSach",
                        column: x => x.SachMaSach,
                        principalTable: "Sachs",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuons_PhieuMuonMaPM",
                table: "ChiTietPhieuMuons",
                column: "PhieuMuonMaPM");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuons_SachMaSach",
                table: "ChiTietPhieuMuons",
                column: "SachMaSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuons_DocGiaMaDG",
                table: "PhieuMuons",
                column: "DocGiaMaDG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuons");

            migrationBuilder.DropTable(
                name: "PhieuMuons");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "DocGias");
        }
    }
}
