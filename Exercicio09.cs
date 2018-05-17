using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioLista2WFA
{
    public partial class Exercicio09 : Form
    {
        double numeroLadoDeCima = 0;
        double numeroLadoDeBaixo = 0;
        double numeroDireito = 0;
        double numeroEsquerdo = 0;

        public Exercicio09()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bolos\t\t\tBolo Brigadeiro\t\t\tR$ 29,50");
            sb.AppendLine("Bolos\t\t\tBolo Floresta Negra\t\t\tR$  2,00");
            richTextBox1.Text = sb.ToString();

            /*try
            {
                numeroLadoDeCima = Convert.ToDouble(txtNumeroLadoDeCima.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNumeroLadoDeCima.Focus();
                return;
            }

            try
            {
                numeroLadoDeBaixo = Convert.ToDouble(txtNumeroLadoDeBaixo.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNumeroLadoDeBaixo.Focus();
                return;
            }

            try
            {
                numeroDireito = Convert.ToDouble(txtNumeroDireito.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNumeroDireito.Focus();
                return;
            }

            try
            {
                numeroEsquerdo = Convert.ToDouble(txtNumeroEsquerdo.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNumeroEsquerdo.Focus();
                return;
            }
            if((numeroLadoDeBaixo == numeroLadoDeCima) && (numeroEsquerdo == numeroDireito) && (numeroLadoDeBaixo == numeroEsquerdo) && (numeroLadoDeCima == numeroDireito))
            {
                MessageBox.Show("É um quadrado");
            }
            else
            {
                MessageBox.Show("Não é um quadrado");
            
            }*/

        }
    }
}
