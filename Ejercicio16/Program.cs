using System;
using System.Threading.Channels;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[5];
            string Opcion;

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}:");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Desea ordenar los numeros de forma:" +
                "A (ascendente) o D (descendente):");
            Opcion = Console.ReadLine();

            switch (Opcion.ToUpper())
            {
                case "A":
                case "ASCENDENTE":
                case "1":
                    Console.WriteLine("Numeros en orden ascendente: " + string.Join(", ", Numeros.Order()));
                    break;
                case "D":
                case "DESCENDENTE":
                case "2":
                    Console.WriteLine("Numeros en orden descendente: " + string.Join(", ", Numeros.OrderDescending()));
                    break;
                default:
                    Console.WriteLine("Error: asegúrate de ingresar un valor válido");
                    break;

            }
            Console.ReadKey();
        }
    }
}
