using Microsoft.EntityFrameworkCore.Migrations;

namespace GenerationN.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelMains",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prefixOne = table.Column<string>(nullable: true),
                    prefixTwo = table.Column<string>(nullable: true),
                    coreWord = table.Column<string>(nullable: true),
                    endingOne = table.Column<string>(nullable: true),
                    endingTwo = table.Column<string>(nullable: true),
                    endingThree = table.Column<string>(nullable: true),
                    endingFour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelMains", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelMains");
        }
    }
}
