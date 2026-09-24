using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("recetas")]
    public class Receta
    { 
        [Key]
        [Column("id_receta")]
        public int idReceta { get; set; }

        [Column("fecha_emision", TypeName = "date")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("indicaciones")]
        public string indicaciones { get; set; }

        // foranea
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int idCita { get; set; }        
        public virtual Cita? Cita { get; set; }


    }
}
