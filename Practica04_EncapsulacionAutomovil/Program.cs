using System.Security.Cryptography.X509Certificates;

namespace Practica04_EncapsulacionAutomovil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil = new Automovil();

            automovil.Propietario = "Juan Perez";
            automovil.CantidadRuedas = "4";

            automovil.SetColorFachada("Rojo");
            automovil.GetColor();
        }
    }
}
