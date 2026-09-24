using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("Especialidades")]
    public class Especialidad
    {
        [Key]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }

        [Column("nombre_especialidad")]
        [MaxLength(50)]
        [Required]
        public string nombreEspecialidad { get; set; }

        [Column("descripcion")]
        [MaxLength(200)]
        public string descripcion { get; set; }

        //relacion con odontologo
        List<Odontologo>? Odontologos { get; set; } = new List<Odontologo>();
    }
}
