using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClinicaOdontologica
{
    [Table("facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura")]
        public int idFactura { get; set;  }

        [Column("fecha_emision", TypeName = "date")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("subtotal", TypeName = "numeric(10,2)")]
        [Required]
        public decimal subtotal { get; set; }

        [Column("impuestos", TypeName = "numeric(10,2)")]
        [Required]
        public decimal impuestos { get; set; }

        [Column("total", TypeName = "numeric(10,2)")]
        [Required]
        public decimal total { get; set; }

        [Column("estado_pago")]
        [MaxLength(20)]
        [Required]
        public string estadoPago { get; set; }

        // foranea
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int idCita { get; set; }                
        public virtual Cita? Cita { get; set; }

        
        

    }
}
