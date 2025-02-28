using System.Security.Cryptography;

namespace FormEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Dias da semana";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxNumero.Text;
            byte opcao = Convert.ToByte(input);

            switch (opcao)
            {
                case 1:
                    labelResposta.Text = "Domingo";
                    break;
                case 2:
                    labelResposta.Text = "Segunda-feira";
                    break;
                case 3:
                    labelResposta.Text = "Terça-feira";
                    break;
                case 4:
                    labelResposta.Text = "Quarta-feira";
                    break;
                case 5:
                    labelResposta.Text = "Quinta-feira";
                    break;
                case 6:
                    labelResposta.Text = "Sexta-feira";
                    break;
                case 7:
                    labelResposta.Text = "Sábado";
                    break;
                default:
                    labelResposta.Text = "Valor inválido";
                    break;
            }
        }
    }
}
