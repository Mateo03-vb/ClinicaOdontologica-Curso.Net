using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("registro_medico")]
        [MaxLength(20)]
        [Required]
        public string registroMedico { get; set; }

        // foraign key
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }

        [ForeignKey("idEspecialidad")]
        public virtual Especialidad Especialidad { get; set; }

        // relacion con citas
        List<Cita>? Citas { get; set; } = new List<Cita>();
    }
}
