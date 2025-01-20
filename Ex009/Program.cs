namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int randomNum = random.Next(1, 101); // from 1 to 100

                int shot;
                bool showRules = false;
                int attempts = 0;


                while (true)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("------- Vamos jogar o jogo dos números -------");
                    Console.WriteLine("----------------------------------------------\n\n");
                    
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
                        if (shot - randomNum <= 10)
                        {
                            Console.WriteLine($"\nVocê está quente!");
                        }
                        else
                        {
                            Console.WriteLine($"\nVocê está frio!");
                        }
                    }
                    else if (shot < randomNum)
                    {
                        Console.WriteLine($"\nO número secreto é maior do que o seu chute!");
                        if (randomNum - shot <= 10)
                        {
                            Console.WriteLine($"\nVocê está quente!");
                        }
                        else
                        {
                            Console.WriteLine($"\nVocê está frio!");
                        }
                    }
                    Console.WriteLine($"\nEstá foi a {attempts}° tentativa.");
                }

                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO")
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
