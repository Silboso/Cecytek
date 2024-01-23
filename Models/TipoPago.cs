using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cecytek.Models
{
//    CREATE TABLE TipoPago(
//    IDTipoPago SERIAL PRIMARY KEY,
//    NombrePago VARCHAR(50) NOT NULL,
//    Monto DECIMAL(10, 2) NOT NULL
//);
    [Table("tipopago")]
    public class TipoPago
    {
        [Key]
        public int idtipopago { get; set; }
        [Required]
        [StringLength(50)]
        public string nombrepago { get; set; }
        [Required]
        public decimal monto { get; set; }
        
    }
}
