using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_CodeFirst_example1.Models.DTOs
{
    public class AsignaturaDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int asignatura_id { get; set; }
        public string asignatura_nombre { get; set; }
        

        public int alumno_id { get; set; }
        [ForeignKey("alumno_id")]
        public virtual AlumnoDTO alumno { get; set; }
    }
}
