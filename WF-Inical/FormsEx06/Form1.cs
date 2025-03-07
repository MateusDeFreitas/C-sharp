using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsEx06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelStatus.Text = @"
Opções de operação:

1. Soma.
2. Subtração.
3. Multiplicação.
4. Divisão
5. Potenciação
6. Radiciação";
        }


        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelConta.Text = "";
            textBoxOperador.Text = "";
            textBoxL1.Text = "";
            textBoxL2.Text = "";
            labelStatus.Text = "";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double l1 = Convert.ToDouble(textBoxL1.Text);
            double l2 = Convert.ToDouble(textBoxL2.Text);

            string operador = textBoxOperador.Text;
            switch (Convert.ToInt32(operador))
            {
                case 1:
                    labelStatus.Text = "Operador: Soma";
                    labelConta.Text = $"{l1+l2}";
                    break;
                case 2:
                    labelStatus.Text = "Operador: Subtração";
                    labelConta.Text = $"{l1 - l2}";
                    break;
                case 3:
                    labelStatus.Text = "Operador: Multiplicação";
                    labelConta.Text = $"{l1 * l2}";
                    break;
                case 4:
                    labelStatus.Text = "Operador: Divisão";
                    if (l2 == 0)
                    {
                        labelConta.Text = "";
                        labelStatus.Text = "Operador: Divisão\n\nERRO : Divisão por 0.";
                    }
                    else
                    {
                        labelConta.Text = $"{l1 / l2}";
                    }     
                    break;
                case 5:
                    labelStatus.Text = "Operador: Potenciação";
                    labelConta.Text = $"{Math.Pow(l1, l2)}";
                    break;
                case 6:
                    labelStatus.Text = "Operador: Radiciação";
                    labelConta.Text = $"{Math.Pow(l1, 1.0 / l2)}"; 
                    break;
                default:
                    labelStatus.Text = "Operador inválido";
                    labelConta.Text = "";
                    break;

            }
        }
    }
}
