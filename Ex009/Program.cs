using System;
using System.Threading;

namespace Ex009
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
                Random random = new Random();
                int randomNum = random.Next(1, 101); // from 1 to 100

                int shot;
                bool showRules = false;
                int attempts = 0;
                int difficulty;

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("------- Vamos jogar o jogo dos números -------");
                Console.WriteLine("----------------------------------------------\n\n");
                simplePause();
                Console.WriteLine("Escolha a dificuldade do jogo:");
                simplePause();
                Console.WriteLine("1. Fácil   - Você terá tentativas ilimitadas.");
                simplePause();
                Console.WriteLine("2. Normal  - Você terá 10 tentativas para acertar o número.");
                simplePause();
                Console.WriteLine("3. Difícil - Você terá apenas 5 tentativas para acertar o número e sem pistas.");
                simplePause();
                Console.Write("Digite o número correspondente à dificuldade escolhida (1, 2 ou 3): ");
                difficulty = int.Parse(Console.ReadLine());

                while (difficulty <= 0 || difficulty >= 4) // while difficulty selection
                {
                    simplePause();
                    Console.Write("Digite uma dificuldade válida (1, 2 ou 3): ");
                    difficulty = int.Parse(Console.ReadLine());
                }

                while (true) // while game
                {

                    if (!showRules)
                    {
                        Console.WriteLine("\nBem-vindo ao jogo 'Adivinhe o Número'!");
                        Console.WriteLine("Regras do jogo:");
                        simplePause();
                        Console.WriteLine("1. O computador irá escolher um número aleatório entre 1 e 100.");
                        Console.WriteLine("2. Seu objetivo é adivinhar qual é esse número.");
                        simplePause();
                        Console.WriteLine("3. A cada tentativa, você será informado se o número que você digitou é:");
                        Console.WriteLine("   - Maior ou menor que o número secreto.");
                        simplePause();
                        Console.WriteLine("4. Continue tentando até acertar o número!");
                        Console.WriteLine("5. Quando você acertar, o jogo mostrará quantas tentativas foram necessárias.");
                        simplePause();
                        Console.WriteLine("6. Boa sorte e divirta-se!\n\n");
                        showRules = true;
                    }

                    if (difficulty == 2 && attempts > 9)
                    {
                        simplePause();
                        Console.WriteLine($"\n--- DERROTA ---");
                        simplePause();
                        Console.WriteLine($"\nVocê excedeu o limite de tentativas da sua dificuldade ({attempts}).");
                        Console.WriteLine($"\nO número secreto era {randomNum}.");
                        Console.WriteLine("\n\n----------------------------------------------");
                        break;
                    }
                    else if (difficulty == 3 && attempts > 4)
                    {
                        simplePause();
                        Console.WriteLine($"\n--- DERROTA ---");
                        simplePause();
                        Console.WriteLine($"\nVocê excedeu o limite de tentativas da sua dificuldade ({attempts}).");
                        Console.WriteLine($"\nO número secreto era {randomNum}.");
                        Console.WriteLine("\n\n----------------------------------------------");
                        break;
                    }

                    shortPause();
                    Console.WriteLine("Escolha um número entre 1 a 100");
                    shot = int.Parse(Console.ReadLine());
                    attempts++;


                    if (shot == randomNum)
                    {
                        shortPause();
                        Console.WriteLine($"\nParabéns, você acertou!");
                        Console.WriteLine($"\nVocê precisou de {attempts}° tentativas.");
                        break;
                    }
                    else if (shot > randomNum)
                    {
                        shortPause();
                        Console.WriteLine($"\nO número secreto é menor do que o seu chute!");
                        if (difficulty != 3)
                        {
                            shortPause();
                            if (shot - randomNum <= 10)
                            {
                                Console.WriteLine($"\nPista: Você está quente!");
                            }
                            else
                            {
                                Console.WriteLine($"\nPista: Você está frio!");
                            }
                        }
                    }
                    else if (shot < randomNum)
                    {
                        shortPause();
                        Console.WriteLine($"\nO número secreto é maior do que o seu chute!");
                        if (difficulty != 3)
                        {
                            shortPause();
                            if (randomNum - shot <= 10)
                            {
                                Console.WriteLine($"\nPista: Você está quente!");
                            }
                            else
                            {
                                Console.WriteLine($"\nPista: Você está frio!");
                            }
                        }
                    }
                    shortPause();
                    Console.WriteLine($"\nEstá foi a {attempts}° tentativa.");
                }

                simplePause();
                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO") // while to play again
                {
                    simplePause();
                    Console.Write("Você quer jogar novamente? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        shortPause();
                        Console.WriteLine("\nVamos jogar mais uma vez!\n");
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
