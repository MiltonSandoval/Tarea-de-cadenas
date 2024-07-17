using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, NombreEspacio ="";
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();

            foreach (char letra in Nombre)
            {
                NombreEspacio += letra + " ";
            }
            Console.WriteLine(NombreEspacio);
            Console.ReadKey();
        }
    }
}