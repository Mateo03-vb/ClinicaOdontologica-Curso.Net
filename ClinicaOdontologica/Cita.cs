using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita")]
        public int idCita { get; set; }

        [Column("fecha_cita")]
        [Required]
        public DateTime fechaCita { get; set; }

        [Column("motivo")]
        [MaxLength(200)]
        public string motivo { get; set; }

        [Column("estado_cita")]
        [MaxLength(20)]
        [Required]
        public string estadoCita { get; set; }

        // foraneas 
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [ForeignKey("idPaciente")]
        public virtual Paciente? Paciente { get; set; }

        [Column("id_odontologo")]
        public int idOdontologo { get; set; }

        [ForeignKey("idOdontologo")]
        public virtual Odontologo? Odontologo { get; set; }

        [Column("id_consultorio")]
        public int idConsultorio { get; set; }

        [ForeignKey("idConsultorio")]
        public virtual Consultorio? Consultorio { get; set; }

        //relaciones detallecita
        public List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();

        // Navegación cita
        public virtual Factura? Factura { get; set; }

        // relacion con recetas 
        public List<Receta>? Recetas { get; set; } = new List<Receta>();
    }
}
