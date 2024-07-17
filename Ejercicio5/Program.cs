using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();

            Console.WriteLine($"Tu inicial es:{Nombre[0]}");
            Console.ReadKey();
        }
    }
}