using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cecytek.Models
{
    
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
        [Required]
        public DateTime fechapago { get; set; }
        [Required]
        public string homoclave { get; set; }
    }
}
