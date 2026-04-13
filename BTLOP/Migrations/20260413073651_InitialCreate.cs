using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLOP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kh",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sv",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhoaHocId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dk_kh_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "kh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dk_sv_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "sv",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dk_KhoaHocId",
                table: "dk",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_dk_SinhVienId",
                table: "dk",
                column: "SinhVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dk");

            migrationBuilder.DropTable(
                name: "kh");

            migrationBuilder.DropTable(
                name: "sv");
        }
    }
}
