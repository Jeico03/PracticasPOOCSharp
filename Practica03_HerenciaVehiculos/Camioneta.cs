using System;
using System.Collections.Generic;
using System.Text;

namespace Practica03_HerenciaVehiculos
{
    internal class Camioneta: Vehiculo
    {
        public string velocidadMaxima;
        public override void obtenerInformación()
        {
            base.obtenerInformación();
            Console.WriteLine($"Velocidad Máxima: {velocidadMaxima}");
        }
    }
}
