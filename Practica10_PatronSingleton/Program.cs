namespace Practica10_PatronSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfiguracionAplicacion config1 = ConfiguracionAplicacion.Instance;
            Console.WriteLine($"[Config 1] Idioma inicial: {config1.Idioma}");

            config1.Idioma = "Inglés";
            config1.ModoOscuro = true;

            ConfiguracionAplicacion config2 = ConfiguracionAplicacion.Instance;
            Console.WriteLine($"[Config 2] Idioma después de cambiar: {config2.Idioma}");

            Console.WriteLine($"[Config 2] Idioma modificado: {config2.Idioma}");
            Console.WriteLine($"[Config 2] Modo Oscuro: {config2.ModoOscuro}");

            if (config1 == config2)
            {
                Console.WriteLine("\n¡Comprobado! config1 y config2 son exactamente la misma instancia (Singleton exitoso).");
            }
        }
    }
}
