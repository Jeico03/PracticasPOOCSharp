using System;
using System.Collections.Generic;
using System.Text;

namespace Practica11_PrincipiosSOLID
{
    public class Empleado
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaDeContratacion { get; set; }
    }
}
