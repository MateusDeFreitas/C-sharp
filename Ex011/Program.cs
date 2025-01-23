using System;
using System.Threading;

namespace Ex011
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

            while (true) // while system
            {
                string texto;
                string textoFormatado = "";
                string resposta;
                string[] palavras;
                int maior = 0;

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("-------- Vamos achar a maior palavra --------");
                Console.WriteLine("---------------------------------------------\n\n");

                simplePause();

                Console.WriteLine("Você irá digitar uma frase ou um texto e irei achar a maior palavra entre as demais.\n");

                Console.Write("Digite o que você quiser: ");
                texto = Console.ReadLine();

                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto.ToLower()[i] == 'á' || texto.ToLower()[i] == 'à' || texto.ToLower()[i] == 'â' || texto.ToLower()[i] == 'ã')
                    {
                        textoFormatado += 'a';
                    }
                    else if (texto.ToLower()[i] == 'ó' || texto.ToLower()[i] == 'ô' || texto.ToLower()[i] == 'õ')
                    {
                        textoFormatado += 'o';
                    }
                    else if (texto.ToLower()[i] == 'é' || texto.ToLower()[i] == 'ê')
                    {
                        textoFormatado += 'e';
                    }
                    else if (texto.ToLower()[i] == 'í')
                    {
                        textoFormatado += 'i';
                    }
                    else if (texto.ToLower()[i] == 'ú')
                    {
                        textoFormatado += 'u';
                    }
                    else if (texto[i] != ',' & texto[i] != '!' & texto[i] != '?' & texto[i] != '.' & texto[i] != ';')// & texto[i] != ' ')
                    {
                        textoFormatado += texto.ToLower()[i];
                    }
                }

                palavras = textoFormatado.Split(' ');
                int[] tamanhosDasPalavras = new int[palavras.Length];

                int cont = 0;
                foreach (String palavra in palavras)
                {
                    tamanhosDasPalavras[cont] = palavra.Length;
                    cont++;
                }
                
                for (int i = 0 ; i < tamanhosDasPalavras.Length ; i++)
                {
                    if (i == 0)
                    {
                        maior = tamanhosDasPalavras[i];
                    }
                    else if (tamanhosDasPalavras[i] > maior)
                    {
                        maior = tamanhosDasPalavras[i];
                    }
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"As maiores palavras têm {maior} caracteres!");
                Console.WriteLine("São elas: \n\n");

                foreach (String palavra in palavras)
                {
                    if (palavra.Length == maior)
                    {
                        Console.WriteLine($"- {palavra}");
                    }
                }

                Console.WriteLine("\n");


                resposta = "";
                while (resposta != "SIM" || resposta != "NÃO") // while to play again
                {
                    simplePause();
                    Console.Write("Você quer fazer outro teste? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        shortPause();
                        Console.WriteLine("\nVamos fazer mais um teste!\n");
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