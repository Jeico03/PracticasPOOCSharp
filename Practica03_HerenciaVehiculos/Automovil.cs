using System;
using System.Collections.Generic;
using System.Text;

namespace Practica03_HerenciaVehiculos
{
    internal class Automovil: Vehiculo
    {
        public string color; 
        public override void obtenerInformación()
        {
            base.obtenerInformación();
            Console.WriteLine($"Color: {color}");
        }
    }
}
