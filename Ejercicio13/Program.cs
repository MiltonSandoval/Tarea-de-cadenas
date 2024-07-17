using System;
using System.Threading.Channels;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[4];

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i+1}:");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los numeros es:{Numeros.Sum()}");
            Console.WriteLine($"El promedio de los numeros es:{Numeros.Average()}");
            Console.ReadKey();
        }
    }
}
