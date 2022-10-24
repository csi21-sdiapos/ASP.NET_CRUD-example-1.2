using EntityFramework_CodeFirst_example1.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_CodeFirst_example1.Models
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options)
            : base(options)
        {

        }

        public DbSet<AlumnoDTO> alumnos { get; set; } // así se llamará la tabla de "alumnos" (AlumnoDTO)
        public DbSet<AsignaturaDTO> asignaturas { get; set; } // así se llamará la tabla de "asignaturas" (AsignaturaDTO)

        // si quisiera que en la BBDD las tablas no se guardasen con un nombre en plural (si quisiera quitarle la 's' o llamarla de otra manera...) tendríamos que sobreescribir el métiodo OnModelCreating() de la clase padre DbContext
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnoDTO>().ToTable("alumno");
            modelBuilder.Entity<AsignaturaDTO>().ToTable("asignatura");
        }
        */
    }
}
