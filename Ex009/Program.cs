using System;

namespace Ex009
{
    internal class Program
    {
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

                Console.WriteLine("Escolha a dificuldade do jogo:");
                Console.WriteLine("1. Fácil   - Você terá tentativas ilimitadas.");
                Console.WriteLine("2. Normal  - Você terá 10 tentativas para acertar o número.");
                Console.WriteLine("3. Difícil - Você terá apenas 5 tentativas para acertar o número e sem pistas.");
                Console.Write("Digite o número correspondente à dificuldade escolhida (1, 2 ou 3): ");
                difficulty = int.Parse(Console.ReadLine());

                while (difficulty <= 0 || difficulty >= 4) // while difficulty selection
                {
                    Console.Write("Digite uma dificuldade válida (1, 2 ou 3): ");
                    difficulty = int.Parse(Console.ReadLine());
                }

                while (true) // while game
                {

                    if (!showRules)
                    {
                        Console.WriteLine("\nBem-vindo ao jogo 'Adivinhe o Número'!");
                        Console.WriteLine("Regras do jogo:");
                        Console.WriteLine("1. O computador irá escolher um número aleatório entre 1 e 100.");
                        Console.WriteLine("2. Seu objetivo é adivinhar qual é esse número.");
                        Console.WriteLine("3. A cada tentativa, você será informado se o número que você digitou é:");
                        Console.WriteLine("   - Maior ou menor que o número secreto.");
                        Console.WriteLine("4. Continue tentando até acertar o número!");
                        Console.WriteLine("5. Quando você acertar, o jogo mostrará quantas tentativas foram necessárias.");
                        Console.WriteLine("6. Boa sorte e divirta-se!\n\n");
                        showRules = true;
                    }

                    if (difficulty == 2 && attempts > 9)
                    {
                        Console.WriteLine($"\n--- DERROTA ---");
                        Console.WriteLine($"\nVocê excedeu o limite de tentativas da sua dificuldade ({attempts}).");
                        break;
                    }
                    else if (difficulty == 3 && attempts > 4)
                    {
                        Console.WriteLine($"\n--- DERROTA ---");
                        Console.WriteLine($"\nVocê excedeu o limite de tentativas da sua dificuldade ({attempts}).");
                        break;
                    }

                    Console.WriteLine("Escolha um número entre 1 a 100");
                    shot = int.Parse(Console.ReadLine());
                    attempts++;


                    if (shot == randomNum)
                    {
                        Console.WriteLine($"\nParabéns, você acertou!");
                        Console.WriteLine($"\nVocê precisou de {attempts}° tentativas.");
                        break;
                    }
                    else if (shot > randomNum)
                    {
                        Console.WriteLine($"\nO número secreto é menor do que o seu chute!");
                        if (difficulty != 3)
                        {
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
                        Console.WriteLine($"\nO número secreto é maior do que o seu chute!");
                        if (difficulty != 3)
                        {
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
                    Console.WriteLine($"\nEstá foi a {attempts}° tentativa.");
                }

                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO") // while to play again
                {
                    Console.Write("Você quer jogar novamente? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
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
                    Console.WriteLine("\nFinalizando Programa");
                    break;
                }
            }
        }
    }
}
