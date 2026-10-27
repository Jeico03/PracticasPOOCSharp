using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Practica07_ClasesAbstractasEInterfaces
{
    internal abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();

        public void ImprimirInformacion()
        {
           Console.WriteLine($"El área de la figura es: {CalcularArea()}");
        }
    }
}
