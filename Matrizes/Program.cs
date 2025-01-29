namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("------------------------------------");
                Console.WriteLine("------ Vamos criar uma matriz ------");
                Console.WriteLine("------------------------------------\n\n");

                Console.Write("Digite a quantidade de linhas da matriz: ");
                int linhas = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de colunas da matriz: ");
                int colunas = int.Parse(Console.ReadLine());

                int[,] matrix = new int[linhas, colunas];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"\nDigite o valor da matriz na {j + 1}° coluna da {i + 1}° fileira: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                Console.WriteLine($"A matriz criada foi: ");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($" {matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");


                string resposta = "";
                while (resposta != "SIM" || resposta != "NÃO") // while to play again
                {
                    Console.Write("Você quer fazer outro vetor? ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "SIM")
                    {
                        Console.WriteLine("\nVamos fazer mais um vetor!\n");
                        Console.Clear();
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
                    Console.WriteLine("\nFinalizando Programa");
                    break;
                }
            }
            
        }
    }
}
