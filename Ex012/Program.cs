using System;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex012
{
    internal class Program
    {
        static void simplePause()
        {
            Thread.Sleep(500);
        }
        static void shortPause()
        {
            Thread.Sleep(200);
        }

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------- Vamos criar vetores --------");
                Console.WriteLine("-------------------------------------\n\n");

                int tamanho;

                Console.Write($"Didite um tamanho para o vetor: ");
                tamanho = int.Parse(Console.ReadLine());
                shortPause();

                int[] numeros = new int[tamanho];
                Console.Write($"\n\n");


                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write($"Insira um valor numérico para a {i+1}° posição: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("O vetor formado foi: \n");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine($"Na {i}° posição: {numeros[i]}");
                    shortPause();
                }

                Console.Write($"\n\n");

                Console.WriteLine($"O maior valor do vetor é {numeros.Max()}, que está na posição {Array.IndexOf(numeros, numeros.Max())}");
                shortPause();
                Console.WriteLine($"O menor valor do vetor é {numeros.Min()}, que está na posição {Array.IndexOf(numeros, numeros.Min())}");
                shortPause();
                Console.WriteLine($"A média dos valores do vetor é {numeros.Average()}");
                shortPause();
                Console.WriteLine($"O primeiro valor inserido foi {numeros.First()}");
                shortPause();
                Console.WriteLine($"O ultimo valor inserido foi {numeros.Last()}");
                shortPause();

                Console.WriteLine("\n");


                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO") // while to play again
                {
                    simplePause();
                    Console.Write("Você quer fazer outro vetor? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        shortPause();
                        Console.WriteLine("\nVamos fazer mais um vetor!\n");
                        break;
                    }
                    else if (resposta == "NÃO")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor válido.");
                    }
                }
                Console.Clear();
                if (resposta == "NÃO")
                {
                    simplePause();
                    Console.WriteLine("\nFinalizando Programa");
                    break;
                }
            }
        }
    }
}
