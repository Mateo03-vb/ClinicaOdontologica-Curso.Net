using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("consultorios")]
    public class Consultorio
    {
        [Key]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }

        [Column("numero_sala")]
        [MaxLength(10)]
        [Required]
        public string numeroSala { get; set; }

        [Column("piso")]
        [Required]
        public int piso { get; set; }

        [Column("equipamiento_principal")]
        [MaxLength(100)]
        public string equipamientoPrincipal { get; set; }


        // relaciones citas
        public List<Cita>? Citas { get; set; } = new List<Cita>();
    }
}
