namespace Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("-------- Posso votar? --------");
                Console.WriteLine("------------------------------\n\n");

                Console.Write("Digite o ano em que você nasceu: ");
                int ano = int.Parse(Console.ReadLine());
                Console.WriteLine(Voto(ano));
                Console.WriteLine("\n\n");
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
        static string Voto(int anoNascimento)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = anoAtual - anoNascimento;

            if (idade < 16)
            {
                return $"Você não vota antes dos 18 anos.";
            }
            else if (idade < 18 || idade >= 70)
            {
                return $"Com {idade} anos, você pode optar por votar ou não.";
            }
            else if (idade < 70 && idade > 17)
            {
                return $"Com {idade} anos, você é obrigado a votar.";
            }
            return "ERRO";
        }
        static void simplePause()
        {
            Thread.Sleep(500);
        }
        static void shortPause()
        {
            Thread.Sleep(200);
        }
    }
}
