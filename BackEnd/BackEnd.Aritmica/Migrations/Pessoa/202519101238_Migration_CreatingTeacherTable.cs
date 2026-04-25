using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackEnd.Aritmica.Migrations.Pessoa
{
    public class _202519101238_Migration_CreatingTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(type: "integer", nullable: false).
                    Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdPerson = table.Column<int>(type: "integer", nullable: false),
                    Curriculum = table.Column<string>(type: "text", nullable: true),
                    AppliedDiciplines = table.Column<int[]>(type: "integer[]", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.IdTeacher);
                    table.ForeignKey(
                        name: "FK_Teacher_Person",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
