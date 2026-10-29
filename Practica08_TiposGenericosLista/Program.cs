namespace Practica08_TiposGenericosLista

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<string> nombres = new Lista<string>();
            nombres.Agregar("Alice");
            nombres.Agregar("Bob");
            nombres.Mostrar();
            nombres.Eliminar("Alice");
        }
    }
}
