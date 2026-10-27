using System;
using System.Collections.Generic;
using System.Text;

namespace Practica05_InterfacesVehiculos
{
    internal class Automovil: IVehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("El automóvil ha arrancado.");
        }
        public void Detener()
        {
            Console.WriteLine("El automóvil se ha detenido.");
        }
    }
}
