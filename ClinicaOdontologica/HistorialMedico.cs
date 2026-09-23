using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("historialesmedicos")]
    public class HistorialMedico
    {
        [Key]
        [Column("id_historial")]
        public int idHistorial { get; set; }

        [Column("alergias")]
        [MaxLength(200)]
        public string alergias { get; set; }

        [Column("enfermedades_previas")]
        [MaxLength(200)]
        public string enfermedadesPrevias { get; set; }

        [Column("tipo_sangre")]
        [MaxLength(5)]
        public string tipoSangre { get; set; }

        // foraneas
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [ForeignKey("idPaciente")]
        public virtual Paciente Paciente { get; set; }
    }
}
