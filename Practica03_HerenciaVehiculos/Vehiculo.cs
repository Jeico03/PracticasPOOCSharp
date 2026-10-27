using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Practica03_HerenciaVehiculos
{
    internal class Vehiculo
    {
       public string marca;
       public string modelo;
       public int año;

        public virtual void obtenerInformación()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {año}");
        }
    }
}
