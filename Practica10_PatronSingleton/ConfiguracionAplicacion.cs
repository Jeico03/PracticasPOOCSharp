using System;
using System.Collections.Generic;
using System.Text;

namespace Practica10_PatronSingleton
{
    internal class ConfiguracionAplicacion
    {
        private static ConfiguracionAplicacion _instancia;
        private ConfiguracionAplicacion()
        {
            Idioma = "Español";
            ModoOscuro = false;
        }
        public string Idioma { get; set; }
        public bool ModoOscuro { get; set; }

        public static ConfiguracionAplicacion Instance 
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConfiguracionAplicacion();
                }
                return _instancia;
            }
        }
    }
}
