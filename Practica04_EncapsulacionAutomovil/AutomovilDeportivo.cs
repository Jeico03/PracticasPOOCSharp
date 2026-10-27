using System;
using System.Collections.Generic;
using System.Text;

namespace Practica04_EncapsulacionAutomovil
{
    internal class AutomovilDeportivo: Automovil
    {
        public AutomovilDeportivo(string cantidad)
        {
            cantidadPuertas = cantidad;
        }
    }
}
