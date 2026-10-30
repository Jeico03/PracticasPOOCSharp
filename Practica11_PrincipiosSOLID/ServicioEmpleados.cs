using System;
using System.Collections.Generic;
using System.Text;

namespace Practica11_PrincipiosSOLID
{
    internal class ServicioEmpleados
    {
        public decimal CalcularSalarioAnual(Empleado empleado)
        {
            return empleado.Salario * 12;
        }

        public int CalcularAntiguedad(Empleado empleado)
        {
            return DateTime.Today.Year - empleado.FechaDeContratacion.Year;
        }
    }
}
