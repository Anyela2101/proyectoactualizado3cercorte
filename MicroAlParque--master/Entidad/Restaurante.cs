using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Restaurante
    {
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string NIT { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Propietario { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Direccion { get; set; }

        [Column(TypeName = "int")]
        public int CantidadPersonal { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Telefono { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Email { get; set; }

        [Column(TypeName = "int")]
        public int Sedes { get; set; }

        [Column(TypeName = "int")]
        public int AñoFuncionamiento { get; set; }
        
        [Column(TypeName = "nvarchar(25)")]
        public string Especialidad { get; set; }
    }
}