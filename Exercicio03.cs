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
    public partial class Exercicio03 : Form
    {
        int numero1 = 0;
        int numero2 = 0;
        public Exercicio03()
        {
            InitializeComponent();
        }
     
        private void btZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero1.Focus();
                return;
            }

             try
            {
                numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero2.Focus();
                return;
            }

            



        }


        private void btZagen_Click(object sender, EventArgs e)
        {
            if (cbOperacoes.SelectedItem.ToString() == "Somar")
            {
                try
                {
                    numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero1.Focus();
                    return;
                }

                try
                {
                    numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero2.Focus();
                    return;
                }

                int soma = numero1 + numero2;
                MessageBox.Show("A soma dos números \"" + numero1 + "\" e \"" + numero2 + "\" é: " + soma);
            }

            if (cbOperacoes.SelectedItem.ToString() == "Subtrair")
            {
              try
                {
                    numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
                }
              catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero1.Focus();
                    return;
                }

              try
                {
                    numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
                }
              catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero2.Focus();
                    return;
                }

              int subtracao = numero1 - numero2;
              MessageBox.Show("A subtração dos números \"" + numero1 + "\" e \"" + numero2 + "\" é: " + subtracao);  
            }

            if (cbOperacoes.SelectedItem.ToString() == "Multiplicar" )
            {
                try
                {
                    numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero1.Focus();
                    return;
                }

                try
                {
                    numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Leid, Nur Zahlen");
                    txtInformeUmNumero2.Focus();
                    return;
                }

                int multiplicacao = numero1 * numero2;
                MessageBox.Show("A multiplição dos números \"" + numero1 + "\" e \"" + numero2 + "\" é: " + multiplicacao);  
            }

            if (cbOperacoes.SelectedItem.ToString() == "Dividir")
            {
               try
            {
                numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero1.Focus();
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero2.Focus();
                return;
            }

            double divisao = numero1 / numero2;
            MessageBox.Show("A divisão dos números \"" + numero1 + "\" e \"" + numero2 + "\" é: " + divisao); 
            }
        }




    }
}
