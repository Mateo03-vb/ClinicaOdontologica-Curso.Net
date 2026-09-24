using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("tratamientos")]
    public class Tratamiento
    {
        [Key]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }

        [Column("nombre_tratamiento")]
        [MaxLength(50)]
        [Required]
        public string nombreTratamiento { get; set; }

        [Column("costo_base", TypeName = "numeric(10,2)")]
        [Required]
        public decimal costoBase { get; set; }

        [Column("duracion_estimada_minutos")]
        [Required]
        public TimeOnly duracionEstimadaMinutos { get; set; }

        //relacion con detallecita
        List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();



    }

}
