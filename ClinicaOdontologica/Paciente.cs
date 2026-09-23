using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [Column("dni")]
        [MaxLength(10)]
        [Required]
        public string cedula { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("fecha_nacimiento")]
        [Required]
        public DateOnly fechaNacimiento { get; set; }

        [Column("email")]
        [MaxLength(50)]
        public string email { get; set; }

        [Column("telefono")]
        [MaxLength(10)]
        public string telefono { get; set; }
    }
}
