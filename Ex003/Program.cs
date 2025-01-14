namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int limite;
            string resposta;
            int contador = 1;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------- Vamos fazer uma tabuada ----------");
            Console.WriteLine("---------------------------------------------\n");

            while (true)
            {

                Console.WriteLine("\n---------------------------------------------");
                Console.Write("Escolha um número: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------\n");

                Console.WriteLine("\n---------------------------------------------");
                Console.Write("Até que número a tabuada deve ir?: ");
                limite = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------\n");

                for (int i = 1; i <= limite; i++)
                {
                    Console.WriteLine($"{valor} x {i} = {valor * i}");
                }
                Console.WriteLine("\nFima da tabuada!");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("-------- Deseja fazer outra tabuada? ---------");
                resposta = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------------\n");

                if (resposta == "SIM")
                {
                    contador++;
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"---------- Vamos fazer a {contador}° tabuada ----------");
                    Console.WriteLine("---------------------------------------------\n");
                }
                else if (resposta == "NAO")
                {
                    Console.WriteLine("\nFinalizando Programa");
                    break;
                }
            }
        }
    }
}
