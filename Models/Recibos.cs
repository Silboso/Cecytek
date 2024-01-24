using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cecytek.Models
{
    /*CREATE TABLE Recibos (
    IDRecibo SERIAL PRIMARY KEY,
    NoControl VARCHAR(20) REFERENCES Alumnos(NoControl),
    IDTipoPago INTEGER REFERENCES TipoPago(IDTipoPago),
    Cantidad DECIMAL(10, 2) NOT NULL,
    Url VARCHAR(255) NOT NULL
);*/
    [Table("recibos")]
    public class Recibos
    {
        [Key]
        public int idrecibo { get; set; }
        [Required]
        [StringLength(20)]
        public string nocontrol { get; set; }
        [Required]
        public int idtipopago { get; set; }
        [Required]
        public decimal cantidad { get; set; }
        [Required]
        [StringLength(255)]
        public string url { get; set; }
    }
}
