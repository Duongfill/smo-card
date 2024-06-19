using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoCard.Data.Migrations
{
    /// <inheritdoc />
    public partial class addtableCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Customer = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fb_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zalo_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiktok_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Messenger_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedln_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Avatar1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Avatar2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Customers_Id_Customer",
                        column: x => x.Id_Customer,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Id_Customer",
                table: "Cards",
                column: "Id_Customer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
