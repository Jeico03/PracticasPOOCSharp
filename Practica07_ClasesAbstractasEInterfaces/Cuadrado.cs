using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07_ClasesAbstractasEInterfaces
{
    internal class Cuadrado: FiguraGeometrica, IDibujable
    {
        public double lado; 
        public override double CalcularArea()
        {
            return lado * lado;
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujando un cuadrado.");
        }

    }
}
