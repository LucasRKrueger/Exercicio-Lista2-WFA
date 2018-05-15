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
    public partial class Exercicio06 : Form
    {
        int numero = 0;
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void btInformeUmNumero_Click(object sender, EventArgs e)
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

            if (numero != 1)
            {
                MessageBox.Show("O número " + numero + " é diferente de 1");
            }
            else
            {
                MessageBox.Show("O número " + numero + " não é diferente de 1");
            }           
        }
    }
}
