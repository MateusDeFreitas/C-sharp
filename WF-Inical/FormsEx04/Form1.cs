namespace FormsEx04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculo de sálario";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            string HSStr = textBoxHS.Text;
            int HS = Convert.ToInt32(textBoxHS.Text);

            string HMStr = textBoxHM.Text;
            double HM = Convert.ToDouble(textBoxHM.Text);

            double salario = HS * HM;

            string resposta = $"O salário mensal de {nome} é {salario}";

            labelResultado.Text = resposta;
        }
    }
}
