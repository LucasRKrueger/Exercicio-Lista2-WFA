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
        string numeroImparParNetrou = "", numeroPositivoOuNegativo = "", numeroMaiorQue10 = "";
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            if (numero == 0)
            {
                numeroImparParNetrou = "Neutro";
            }
            else if (numero %2 == 0)
            {
                numeroImparParNetrou = "Par";
            }
            else
            {
                numeroImparParNetrou = "Impar";
            }

            if (numero < 0)
            {
                numeroPositivoOuNegativo = "Negativo";
            }
            else if (numero > 0)
            {
                numeroPositivoOuNegativo = "Positivo";
            }
            else
            {
                numeroPositivoOuNegativo = "Neutro";
            }

            if (numero > 10)
            {
                numeroMaiorQue10 = "Número maior que 10";
            }
            else
            {
                numeroMaiorQue10 = "Não é maior que 10";
            }



        }
    }
}
