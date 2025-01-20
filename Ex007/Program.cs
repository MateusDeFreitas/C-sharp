namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------ Vamos testar se o número é par -------");
            Console.WriteLine("---------------------------------------------\n\n");
            while (true)
            {
                Console.Write("\nDigite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Esse número é par");
                    Console.WriteLine("---------------------------------------------\n\n");
                }
                else if (numero % 2 == 1)
                {
                    Console.WriteLine("Esse número é impar");
                    Console.WriteLine("---------------------------------------------\n\n");
                }


                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO")
                {
                    Console.Write("Você quer testar outro número? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        Console.WriteLine("\nVamos testar mais um número!\n");
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

