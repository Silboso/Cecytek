using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cecytek.Models
{
    /*CREATE TABLE Carreras (
    IDCarrera SERIAL PRIMARY KEY,
    NombreCarrera VARCHAR(50) NOT NULL
);
*/
    [Table("carreras")]
    public class Carreras
    {
        [Key]
        public int idcarrera { get; set; }
        [Required]
        [StringLength(50)]
        public string nombrecarrera { get; set; }


    }
}
