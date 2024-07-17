using System;
using System.Linq;


namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[6];
            int Contador = 0;

            Dictionary<string, int> Repetidos = new Dictionary<string, int>();

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}:");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (var numero in Numeros)
            {
                if (Repetidos.ContainsKey(numero.ToString()))
                {
                    Repetidos[numero.ToString()]++;
                    if (Repetidos[numero.ToString()] == 1)
                    {
                        Contador++;
                    }
                }else
                {
                    Repetidos[numero.ToString()] = 0;
                }
            }
            foreach (var item in Repetidos)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"\nEl {item.Key} esta repetido");
                }
            }
            Console.WriteLine($"\nHay {Contador} numeros repetidos");
            Console.ReadKey();

        }
    }
}
