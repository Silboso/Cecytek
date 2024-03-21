using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cecytek.Models
{

    /*CREATE TABLE Alumnos (
    IDAlumno SERIAL PRIMARY KEY,
    NoControl VARCHAR(20) UNIQUE NOT NULL,
    NombreAlumno VARCHAR(100) NOT NULL,
    Grado INTEGER NOT NULL,
    Grupo CHAR(1) NOT NULL,
    IDCarrera INTEGER REFERENCES Carreras(IDCarrera),
    Turno INTEGER NOT NULL
);*/
    
    [Table("alumnos")]
    [Index(nameof(nocontrol), IsUnique = true)]
    public class Alumnos
    {
        [Key]
        public int idalumno { get; set; }
        [Required]
        [StringLength(20)]
        public string nocontrol { get; set; }
        [Required]
        [StringLength(100)]
        public string nombrealumno { get; set; }
        [Required]
        public Grados grado { get; set; } = Grados.Primero;
        [Required]
        public string grupo { get; set; } = "A";
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una carrera")]
        public int idcarrera { get; set; }
        [Required]
        public Turnos turno { get; set; }
        [Required]
        public Estado estado { get; set; }

       

    }

    public enum Grados
    {
        Primero = 1,
        Segundo = 2,
        Tercero = 3,
        Cuarto = 4,
        Quinto = 5,
        Sexto = 6
    }

    public enum Turnos
    {
        Matutino ,
        Vespertino ,
        Tonaya  
    }

    public enum Estado
    {
        Inactivo,
        Activo,
        Graduado,
        Recursando,
        Revalidado,
        Baja      
    }
}
