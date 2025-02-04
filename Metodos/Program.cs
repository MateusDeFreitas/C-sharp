namespace Metodos
{
    internal class Program
    {
        double soma(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }

        double divisao(double a, double b)
        {
            Console.WriteLine($"{a} ÷ {b} = {a / b}");
            return a / b;
        }

        double subtracao(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            return a - b;
        }

        double multiplicacao(double a, double b)
        {
            Console.WriteLine($"{a} · {b} = {a + b}");
            return a * b;
        }

        int fatoracao(int num)
        {
            int resultado = num; 

            for (int i = num - 1; i > 0; i--)
            {
                resultado  *= i;
            }
            return resultado;
        }

        double areaTriangulo(double altura, double largura)
        {
            double area;
            area = altura * largura / 2;
            return area;
        }
        
        static void Main(string[] args)
        {


            Program obj = new Program();


            Console.WriteLine(obj.fatoracao(6));
        }
    }
}
