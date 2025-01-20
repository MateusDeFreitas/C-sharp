namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("------ Vamos calcular o preço da viagem ------");
            Console.WriteLine("----------------------------------------------\n\n");
            while (true)
            {
                Console.Write("\nDigite a distância da viagem em kilometros: ");
                double distancia = double.Parse(Console.ReadLine());

                double preco = 0;

                if (distancia <= 200)
                {
                    preco = distancia * 0.50;  
                }
                else if (distancia > 200)
                {
                    preco = distancia * 0.45;
                }

                Console.WriteLine($"\nUma viagem de {distancia} custará {preco} reais!\n");


                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO")
                {
                    Console.Write("Você quer cotar outra viagem? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        Console.WriteLine("\nVamos cotar mais uma viagem!\n");
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
