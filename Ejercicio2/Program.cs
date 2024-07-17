using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();
            if (Nombre.ToLower() == "milton")
            {
                Console.WriteLine("Bienvenido Jefe");
            }
            else
            {
                Console.WriteLine($"Bienvenido {Nombre}");
            }
            Console.ReadKey();
        }
    }
}