using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEnd.Aritmica.Migrations.Pessoa
{
    public class _202519101219_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                  name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPerson = table.Column<int>(type: "integer", nullable: false),
                    LastClassViewed = table.Column<int>(type: "integer", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Student_Person",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
               name: "IX_Student_IdPerson",
               table: "Student",
               column: "IdPerson");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
