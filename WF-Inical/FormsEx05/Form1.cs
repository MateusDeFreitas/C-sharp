namespace FormsEx05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] nomesProdutos = new string[6];
        double[] precoProdutos = new double[6];
        int contador = 0;
        double maior = 0;
        int indice = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            nomesProdutos[contador] = textBoxNome.Text;
            precoProdutos[contador] = Convert.ToDouble(textBoxPreco.Text);
            contador++;

            labelStatus.Text = $"Produto {contador} adicionado com sucesso!";

            textBoxNome.Text = "";
            textBoxPreco.Text = "";
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < precoProdutos.Length; i++ )
            {
                if (i == 0)
                {
                    maior = precoProdutos[i];
                    indice = i;
                }
                else
                {
                    if (precoProdutos[i] > maior)
                    {
                        maior = precoProdutos[i];
                        indice = i;
                    }
                }
            }

            labelNomeResultado.Text = nomesProdutos[indice];
            labelPrecoResultado.Text = Convert.ToString(precoProdutos[indice])+"R$";
        }
    }
}
