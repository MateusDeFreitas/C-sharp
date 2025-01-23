using System;
using System.Threading;

namespace Ex010
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
                string palavra;
                string palavraSemEspacoInvertida = "";
                string palavraSemEspaco = "";

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("----- Vamos verificar se é uma palíndromo -----");
                Console.WriteLine("-----------------------------------------------\n\n");

                simplePause();

                Console.WriteLine("Um palíndromo é uma palavra, frase ou número que pode ser lido da mesma forma de trás para frente\n");

                Console.Write("Digite uma palavra para verificarmos se é um palíndromo: ");
                palavra = Console.ReadLine();

                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    if (palavra.ToLower()[i] == 'á' || palavra.ToLower()[i] == 'à' || palavra.ToLower()[i] == 'â' || palavra.ToLower()[i] == 'ã')
                    {
                        palavraSemEspacoInvertida += 'a';
                    }
                    else if (palavra.ToLower()[i] == 'ó' || palavra.ToLower()[i] == 'ô' || palavra.ToLower()[i] == 'õ')
                    {
                        palavraSemEspacoInvertida += 'o';
                    }
                    else if (palavra.ToLower()[i] == 'é' || palavra.ToLower()[i] == 'ê')
                    {
                        palavraSemEspacoInvertida += 'e';
                    }
                    else if (palavra.ToLower()[i] == 'í')
                    {
                        palavraSemEspacoInvertida += 'i';
                    }
                    else if (palavra.ToLower()[i] == 'ú')
                    {
                        palavraSemEspacoInvertida += 'u';
                    }
                    else if (palavra[i] != ' ' & palavra[i] != ',' & palavra[i] != '!' & palavra[i] != '?' & palavra[i] != '.' & palavra[i] != ';')
                    {
                        palavraSemEspacoInvertida += palavra.ToLower()[i];
                    }
                }

                for (int i = palavraSemEspacoInvertida.Length - 1; i >= 0; i--)
                {
                    palavraSemEspaco += palavraSemEspacoInvertida.ToLower()[i];
                }

                Console.WriteLine($"{palavraSemEspacoInvertida}, {palavraSemEspaco}"); // Para debug

                if (palavraSemEspacoInvertida.ToLower() == palavraSemEspaco.ToLower())
                {
                    Console.WriteLine("É um palíndromo!");
                }
                else
                {
                    Console.WriteLine("Não é um palíndromo");
                }


                string resposta = "";
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