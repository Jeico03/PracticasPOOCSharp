using System;
using System.Collections.Generic;

namespace Practica08_TiposGenericosLista
{
    internal class Lista<T>
    {
        private List<T> elementos;

        public Lista()
        {
            elementos = new List<T>();
        }

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
            Console.WriteLine($"Agregando elemento: {elemento}");
        }

        public void Eliminar(T elemento)
        {
            if (elementos.Remove(elemento))
            {
                Console.WriteLine($"Eliminando elemento: {elemento}");
            }
            else
            {
                Console.WriteLine($"No se encontró el elemento: {elemento}");
            }
        }

        public T Obtener(int indice)
        {
            if (indice < 0 || indice >= elementos.Count)
            {
                throw new IndexOutOfRangeException("Índice fuera de rango.");
            }
            return elementos[indice];
        }

        public void Mostrar()
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                Console.WriteLine($"[{i}] {elementos[i]}");
            }
        }
    }
}   