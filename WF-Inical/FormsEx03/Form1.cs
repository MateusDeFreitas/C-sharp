namespace FormsEx03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Maior número";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string n1Str = textBoxN1.Text;
            string n2Str = textBoxN2.Text;
            string n3Str = textBoxN3.Text;
            int maior = 0, menor = 0, meio = 0;

            int n1 = Convert.ToInt32(n1Str);
            int n2 = Convert.ToInt32(n2Str);
            int n3 = Convert.ToInt32(n3Str);


            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
                if (n2 > n3)
                {
                    meio = n2;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                    menor = n2;
                }
            }
            else if (n2 > n3 && n2 > n1)
            {
                maior = n2;
                if (n3 > n1)
                {
                    meio = n3;
                    menor = n1;
                }
                else
                {
                    meio = n1;
                    menor = n3;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                maior = n2;
                if (n1 > n2)
                {
                    meio = n1;
                    menor = n2;
                }
                else
                {
                    meio = n2;
                    menor = n1;
                }
            }

            string resposta =
                $"- O maior número é {maior}\n\n" +
                $"- O número em sequência é {meio}\n\n" +
                $"- O menor número é {menor}";

            labelApresentar.Text = resposta;
        }
    }
}
