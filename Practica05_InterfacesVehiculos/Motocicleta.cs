using System;
using System.Collections.Generic;
using System.Text;

namespace Practica05_InterfacesVehiculos
{
    internal class Motocicleta: IVehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("La motocicleta ha arrancado.");
        }
        public void Detener()
        {
            Console.WriteLine("La motocicleta se ha detenido.");
        }
    }
}
