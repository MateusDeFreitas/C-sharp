using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsEx06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelStatus.Text = @"
Op��es de opera��o:

1. Soma.
2. Subtra��o.
3. Multiplica��o.
4. Divis�o
5. Potencia��o
6. Radicia��o";
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
                    labelStatus.Text = "Operador: Subtra��o";
                    labelConta.Text = $"{l1 - l2}";
                    break;
                case 3:
                    labelStatus.Text = "Operador: Multiplica��o";
                    labelConta.Text = $"{l1 * l2}";
                    break;
                case 4:
                    labelStatus.Text = "Operador: Divis�o";
                    if (l2 == 0)
                    {
                        labelConta.Text = "";
                        labelStatus.Text = "Operador: Divis�o\n\nERRO : Divis�o por 0.";
                    }
                    else
                    {
                        labelConta.Text = $"{l1 / l2}";
                    }     
                    break;
                case 5:
                    labelStatus.Text = "Operador: Potencia��o";
                    labelConta.Text = $"{Math.Pow(l1, l2)}";
                    break;
                case 6:
                    labelStatus.Text = "Operador: Radicia��o";
                    labelConta.Text = $"{Math.Pow(l1, 1.0 / l2)}"; 
                    break;
                default:
                    labelStatus.Text = "Operador inv�lido";
                    labelConta.Text = "";
                    break;

            }
        }
    }
}
