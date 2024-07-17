using System;

namespace Ejercicio11
{
    class Programa
    {
        static void Main(string[] args)
        {
            string Nombre, NombreEspacio = "";
            Console.Write("Ingresa tu nombre:");
            Nombre = Console.ReadLine();

            for (int i = 0; i < Nombre.Length; i++)
            {
                NombreEspacio += Nombre.Substring(i, 1) + " ";;
            }
            Console.WriteLine(NombreEspacio.Remove(NombreEspacio.Length));
            Console.ReadKey();
        }
    }
}