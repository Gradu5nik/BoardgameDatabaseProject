using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardgameDatabase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
             Code was commented for the first update-database as the database was created first,
            so pushing this migration up would only result in errors
            however now it can be used to set up tables anew from scartch if needed
             */
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adress = table.Column<string>(type: "ntext", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Adresses__737584F7788FE335", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Boardgames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Keeper = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MinPlayers = table.Column<int>(type: "int", nullable: false),
                    MaxPlayers = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    ForSale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardgames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BG_Keeper",
                        column: x => x.Keeper,
                        principalTable: "Adresses",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BG_Owner",
                        column: x => x.Owner,
                        principalTable: "Adresses",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boardgames_Keeper",
                table: "Boardgames",
                column: "Keeper");

            migrationBuilder.CreateIndex(
                name: "IX_Boardgames_Owner",
                table: "Boardgames",
                column: "Owner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boardgames");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
