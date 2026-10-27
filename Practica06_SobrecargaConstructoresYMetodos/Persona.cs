using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica06_SobrecargaConstructoresYMetodos
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string Profesion { get; set; }

        public string Nacionalidad { get; set; }

        public Persona(){ }
       
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public Persona(string nombre, string apellido, int edad, string profesion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Profesion = profesion;
        }

        public Persona(string nombre, string apellido, int edad, string profesion, string nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Profesion = profesion;
            Nacionalidad = nacionalidad;
        }

        public void Comunicarse(string nombre)
        {
            Console.WriteLine($"Hola mi nombre es: {nombre}");
        }

        public void Comunicarse(string nombre, string apellido)
        {
            Console.WriteLine($"Hola mi nombre completo es: {nombre} {apellido}");

        }

        public void Comunicarse(string nombre, string apellido, int edad)
        {
            Console.WriteLine($"Hola mi nombre completo es: {nombre} {apellido} y mi edad es: {edad}");
        }

        public void Comunicarse(string nombre, string apellido, int edad, string profesion)
        {
            Console.WriteLine($"Hola mi nombre completo es: {nombre} {apellido} y mi edad es: {edad} y mi profesion es {profesion}");
        }

        public void Comunicarse(string nombre, string apellido, int edad, string profesion, string nacionalidad)
        {
            Console.WriteLine($"Hola mi nombre completo es: {nombre} {apellido} y mi edad es: {edad}, mi profesion es: {profesion}, y mi nacionalidad es: {nacionalidad}");
        }
    }
}
