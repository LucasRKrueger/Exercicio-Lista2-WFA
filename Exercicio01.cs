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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            int numero = 0;
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

            if (numero > 0)
            {
                MessageBox.Show("O número \"" + numero + "\" é positivo");
            }
            else
            {
                MessageBox.Show("O número \"" + numero + "\" NÃO é positivo");
            }

            
            
        }
    }
}
