using System;
using System.Collections.Generic;
using System.Text;

namespace Practica03_HerenciaVehiculos
{
    internal class Motocicleta: Vehiculo
    {
        public string tipo;

        public override void obtenerInformación()
        {
            base.obtenerInformación();
            Console.WriteLine($"Tipo: {tipo}");
        }
    }
}
