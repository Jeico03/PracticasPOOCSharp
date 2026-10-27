namespace Practica01_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.nombre = "Juan";
            persona1.edad = 30;
            persona1.MostrarInformacion();
        }
    }
}
