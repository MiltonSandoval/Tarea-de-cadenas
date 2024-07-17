using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"\n{Nombre}");
            }
            Console.ReadKey();
        }
    }
}