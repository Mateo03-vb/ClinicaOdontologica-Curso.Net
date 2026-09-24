using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("detallescita")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita")]
        public int idDetalleCita { get; set; }

        [Column("costo_aplicado", TypeName = "numeric(10,2)")]
        [Required]
        public decimal costoAplicado { get; set; }

        
        [MaxLength(200)]
        public string observaciones { get; set; }

        // foráneas
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int idCita { get; set; }        
        public virtual Cita Cita { get; set; }


        [ForeignKey("idTratamiento")]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }        
        public virtual Tratamiento Tratamiento { get; set; }

        
    }
}
