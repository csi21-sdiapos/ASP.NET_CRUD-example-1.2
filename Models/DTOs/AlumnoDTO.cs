using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_CodeFirst_example1.Models.DTOs
{
    public class AlumnoDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // el autoincrementable
        public int alumno_id { get; set; }
        public string alumno_nombre { get; set; }
        public string alumno_apellidos { get; set; }
        public string alumno_email { get; set; }

        public int asignatura_id { get; set; }
        [ForeignKey("asignatura_id")]
        public virtual AsignaturaDTO asignatura { get; set; }
    }
}
