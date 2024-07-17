using System;
using System.Linq;


namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[6];
            int MultiplosN, Contador = 0;

            Dictionary<string,int> NumMultiplos = new Dictionary<string,int>();

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}:");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Ingrese el valor de N:");
            MultiplosN = int.Parse(Console.ReadLine());

            foreach (var numero in Numeros)
            {
                NumMultiplos[numero.ToString()] = 0;
                if (numero % MultiplosN == 0)
                {
                    NumMultiplos[numero.ToString()] = 1;
                    Contador++;
                }
                
            }
            foreach (var item in NumMultiplos)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"\nEl {item.Key} es multiplo de {MultiplosN}");
                }
            }
            Console.WriteLine($"\nHay {Contador} numeros multiplos de {MultiplosN}");
            Console.ReadKey();

        }
    }
}
