using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void txtValorInserido_KeyPress(object sender, KeyPressEventArgs e)
        {
            const byte BACKSPACE = 8;
            const byte ZERO = 48;
            const byte NOVE = 57;

            byte caractereDigitado = Convert.ToByte(e.KeyChar);

            if (caractereDigitado == BACKSPACE)
            {
                return;  //deixa o caractere entrar
            }

            if (caractereDigitado < ZERO || caractereDigitado > NOVE)
            {
                e.Handled = true;  //não deixa o caractere entrar
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (int.Parse(txtValorInserido.Text) < 100)
            {
                FopapMenorQueCem MenorQuecem = new FopapMenorQueCem();
                MenorQuecem.ShowDialog();                
            }
            if (int.Parse(txtValorInserido.Text) >= 100 && int.Parse(txtValorInserido.Text) < 200)
            {
                CemDuzentos cemDuzentos = new CemDuzentos();
                cemDuzentos.ShowDialog();               
            }
            if (int.Parse(txtValorInserido.Text) >= 200 && int.Parse(txtValorInserido.Text) < 500)
            {
                DuzentoaQuinhentos duzentoaQuinhentos = new DuzentoaQuinhentos();
                duzentoaQuinhentos.ShowDialog();                
            }
            if (int.Parse(txtValorInserido.Text) >= 500 && int.Parse(txtValorInserido.Text) < 1000)
            {
                QuinentosMil quinentosMil = new QuinentosMil();
                quinentosMil.ShowDialog();
                // se continuar subindo os valores talvez vc chegue la
            }
            if (int.Parse(txtValorInserido.Text) >= 1000)
            {
                MaisQueMil maisQueMil = new MaisQueMil();
                maisQueMil.ShowDialog();
                // nao importa o vamor que vc coloque aqui sua namorada te ama muito mais 
                // o amor dela por vc que se igrala ao infinito 
            }

            txtValorInserido.Text = "";
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

