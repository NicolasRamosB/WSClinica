using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSClinica.Models
{

    [Table("Habitacion")]
    public class Habitacion
    {
        public int Id { get; set; }

        [Range(1, 100, ErrorMessage ="Solo se permiten números entre 1 y 100")]
        public string Numero { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Estado { get; set; }

        public int ClinicaId { get; set; }

        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }
    }

}
