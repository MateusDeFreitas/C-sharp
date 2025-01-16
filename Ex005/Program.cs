namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Insira a velocidade do carro par validação: ");
                double velocidade = Convert.ToDouble(Console.ReadLine());

                if (velocidade > 80)
                {
                    Console.WriteLine($"Esse carro foi multado em {7 * (velocidade - 80)} reais.");
                }
                else
                {
                    Console.WriteLine("O carro está dirigindo dentro da lei! Parabéns");
                }


                Console.Write("Você quer analisar outro carro?: ");
                string resposta = Console.ReadLine();
                
                if (resposta == "sim")
                {
                    
                }
                else
                {
                    break;
                }
            }
        }
    }
}
