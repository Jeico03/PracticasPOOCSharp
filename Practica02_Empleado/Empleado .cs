using System;
using System.Collections.Generic;
using System.Text;

namespace Practica02_Empleado
{
    internal class Empleado
    {
        public string name;

        public string apellido;

        public decimal salario;

        public DateTime fechaDeContratación;

        public void CalcularSalarioAnual()
        {
            decimal salarioAnual = salario * 12;
            Console.WriteLine($"Salario Anual: {salarioAnual}");
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - fechaDeContratación.Year;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {name}, Apellido: {apellido}, Salario: {salario}, Fecha de Contratación: {fechaDeContratación}");
        }


    }
}
