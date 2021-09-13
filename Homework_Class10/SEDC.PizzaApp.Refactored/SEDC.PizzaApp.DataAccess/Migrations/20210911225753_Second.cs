using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name" },
                values: new object[] { 1, "alek@gmail.com", "Good pizza", "Aleksandar" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name" },
                values: new object[] { 2, "ana@yahoo.com", "Great", "Ana" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
