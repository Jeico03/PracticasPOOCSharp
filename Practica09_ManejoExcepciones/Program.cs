namespace Practica09_ManejoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manejo de Excepciones en C#");
            Console.WriteLine("Ingrese el numero 1:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2:");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int resultado = Num1 / Num2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                Console.WriteLine($"Detalles del error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Formato de número inválido.");
                Console.WriteLine($"Detalles del error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado.");
                Console.WriteLine($"Detalles del error: {ex.Message}");
            }
                Console.WriteLine("Gracias por su visita.");

        }
    }
}
