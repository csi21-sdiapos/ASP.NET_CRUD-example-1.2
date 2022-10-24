using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramework_CodeFirst_example1.Migrations
{
    public partial class CreacionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumnos",
                columns: table => new
                {
                    alumno_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alumno_nombre = table.Column<string>(type: "text", nullable: false),
                    alumno_apellidos = table.Column<string>(type: "text", nullable: false),
                    alumno_email = table.Column<string>(type: "text", nullable: false),
                    asignatura_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumnos", x => x.alumno_id);
                });

            migrationBuilder.CreateTable(
                name: "asignaturas",
                columns: table => new
                {
                    asignatura_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    asignatura_nombre = table.Column<string>(type: "text", nullable: false),
                    alumno_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asignaturas", x => x.asignatura_id);
                    table.ForeignKey(
                        name: "FK_asignaturas_alumnos_alumno_id",
                        column: x => x.alumno_id,
                        principalTable: "alumnos",
                        principalColumn: "alumno_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alumnos_asignatura_id",
                table: "alumnos",
                column: "asignatura_id");

            migrationBuilder.CreateIndex(
                name: "IX_asignaturas_alumno_id",
                table: "asignaturas",
                column: "alumno_id");

            migrationBuilder.AddForeignKey(
                name: "FK_alumnos_asignaturas_asignatura_id",
                table: "alumnos",
                column: "asignatura_id",
                principalTable: "asignaturas",
                principalColumn: "asignatura_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alumnos_asignaturas_asignatura_id",
                table: "alumnos");

            migrationBuilder.DropTable(
                name: "asignaturas");

            migrationBuilder.DropTable(
                name: "alumnos");
        }
    }
}
