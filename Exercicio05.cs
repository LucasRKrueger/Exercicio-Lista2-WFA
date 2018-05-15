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
    public partial class Exercicio05 : Form
    {
        int numero = 0;
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(txtInformeUmNumero.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero.Focus();
                return;
            }

            if (numero == 0)
            {
                MessageBox.Show("O número " + numero + " NÃO é impar");
            }
            else if(numero %2 == 0)
            {
                MessageBox.Show("O número " + numero + " NÃO é impar");
            }
            else
            {
                MessageBox.Show("O número " + numero + " é impar");
            }
        }
    }
}
