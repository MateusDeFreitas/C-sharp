namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            float number1;
            float number2;

            while (true)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("----- Vamos fazer um calculo! -----");
                Console.WriteLine("-----------------------------------");

                while (true)
                {
                    try
                    {
                        Console.Write("\nDigite um valor: ");
                        number1 = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor válido");
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Digite mais um valor: ");
                        number2 = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Insira um valor válido");
                    }

                }

                Console.WriteLine("\n-----------------------------------");
                Console.Write(
                    "\n" +
                    "Que operação vamos fazer?\n" +
                    "1) Adção\n" +
                    "2) Subtração\n" +
                    "3) Multiplicação\n" +
                    "4) divisão\n" +
                    "\n" +
                    "Escolha: "
                    );

                int signal = int.Parse(Console.ReadLine());
                Console.WriteLine("\n-----------------------------------");


                if (signal == 1)
                {
                    result = number1 + number2;
                }
                else if (signal == 2)
                {
                    result = number1 - number2;
                }
                else if (signal == 3)
                {
                    result = number1 * number2;
                }
                else if (signal == 4)
                {
                    while (number2 == 0)
                    {
                        Console.WriteLine("ERRO - Divisão por Zero");
                        Console.Write("\nRedefina o segundo valor: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n-----------------------------------");
                    }

                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Escolha um número de 1 a 4 correspondente ao valor da operação desejada.");
                }


                Console.WriteLine(
                    $"\n------\n" +
                    $"O resultado da sua conta é: {result}\n" +
                    $"------\n"
                );

                string answer;

                while (true)
                {

                    Console.WriteLine("Você deseja realizar outra operação? [SIM/NAO]");
                    answer = Console.ReadLine().ToUpper();

                    if (answer == "NAO")
                    {
                        break;
                    }
                    else if (answer == "SIM")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor válido (SIM ou NÂO)");
                    }
                }
                if (answer == "NAO")
                {
                    Console.WriteLine("Programa finalizado");
                    break;
                }

            }
        }
    }
}
