namespace WF_Inical
{
    public partial class Form1 : Form
    {

        double nota1, nota2;
        double media, limite;
        string situacao, nota1Str, nota2Str, mediaStr;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            limite = 7;
            nota1Str = textBoxN1.Text;
            nota2Str = textBoxN2.Text;

            nota1 = Convert.ToDouble(nota1Str);
            nota2 = Convert.ToDouble(nota2Str);

            media = (nota1 + nota2) / 2;

            if (media >= limite)
            {
                situacao = "Aprovado";
            }
            else if (media < 5)
            {
                situacao = "Reprovado";
            }
            else
            {
                situacao = "Recuperação";
            }

            labelMediaResultado.Text = Convert.ToString(media);
            labelSituacaoResultado.Text = situacao;
        }
    }
}
