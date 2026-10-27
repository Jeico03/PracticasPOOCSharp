using System;
using System.Collections.Generic;
using System.Text;

namespace Practica01_Persona
{
    internal class Persona
    {
        public string nombre;
        public int edad;

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }
}
