using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace bed_room_finder.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    restaurantname = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    subcity = table.Column<string>(type: "text", nullable: true),
                    ownername = table.Column<string>(type: "text", nullable: true),
                    bedroomprice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "smallStarRestaurants",
                columns: table => new
                {
                    ssrid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    smtype = table.Column<string>(type: "text", nullable: true),
                    Restaurantid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smallStarRestaurants", x => x.ssrid);
                    table.ForeignKey(
                        name: "FK_smallStarRestaurants_restaurants_Restaurantid",
                        column: x => x.Restaurantid,
                        principalTable: "restaurants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_smallStarRestaurants_Restaurantid",
                table: "smallStarRestaurants",
                column: "Restaurantid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "smallStarRestaurants");

            migrationBuilder.DropTable(
                name: "restaurants");
        }
    }
}
