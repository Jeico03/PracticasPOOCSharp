using System;
using System.Collections.Generic;
using System.Text;

namespace Practica04_EncapsulacionAutomovil
{
    internal class Automovil
    {
        public string CantidadRuedas;
        private string Color;

        public string GetColor()
        {
            return Color;
        }

        public void SetColorFachada(string ColorFachada)
        {
            Color = ColorFachada;
        }
        protected string cantidadPuertas;
        private string Motor;
        public string Propietario;

    }
}
