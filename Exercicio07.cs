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
    public partial class Exercicio07 : Form
    {
        int numero = 0;
        string numeroImparParNetrou = "", numeroPositivoOuNegativo = "", numeroMaiorQue10 = "", numeroMenorOuIgualA50 = "", seEhMenorQueMenos10 = "", seEhMaiorOuIgualA30 = "", seEhDiferenteDe1 = "";
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNumero.Focus();
                return;
            }

            if (numero == 0)
            {
                numeroImparParNetrou = "é neutro";
            }
            else if (numero %2 == 0)
            {
                numeroImparParNetrou = "é par";
            }
            else
            {
                numeroImparParNetrou = "é impar";
            }

            if (numero < 0)
            {
                numeroPositivoOuNegativo = "é negativo";
            }
            else if (numero > 0)
            {
                numeroPositivoOuNegativo = "é positivo";
            }
            else
            {
                numeroPositivoOuNegativo = "Neutro";
            }

            if (numero > 10)
            {
                numeroMaiorQue10 = " maior que 10";
            }
            else
            {
                numeroMaiorQue10 = "não é maior que 10";
            }

            if (numero < 50)
            {
                numeroMenorOuIgualA50 = "é menor que 50";
            }
            else if (numero == 50)
            {
                numeroMenorOuIgualA50 = "é igual a 50";
            }
            else
            {
                numeroMenorOuIgualA50 = "não é menor, nem igual a 50";
            }

            if (numero < -10)
            {
                seEhMenorQueMenos10 = "é menor que -10";
            }
            else
            {
                seEhMenorQueMenos10 = "não é menor que -10";
            }

            if (numero > 30)
            {
                seEhMaiorOuIgualA30 = "é maior que 30";
            }
            else if (numero == 30)
            {
                seEhMaiorOuIgualA30 = "é igual a 30";
            }
            else
            {
                seEhMaiorOuIgualA30 = "não é maior e nem igual a 30";
            }

            if (numero != 1)
            {
                seEhDiferenteDe1 = "é diferente de 1";
            }
            else
            {
                seEhDiferenteDe1 = "não é diferente de 1";
            }

            string textao = "O número " + numeroImparParNetrou + "\r\nO número " + numeroPositivoOuNegativo + "\r\nO número " + numeroMaiorQue10 + "\r\nO número " + numeroMenorOuIgualA50 + "\r\nO número " + seEhMenorQueMenos10 +
                "\r\nO número " + seEhMaiorOuIgualA30 + "\r\nO número " + seEhDiferenteDe1;
            txtResultado.Text = textao;




        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
