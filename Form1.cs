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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btExercicio01_Click(object sender, EventArgs e)
        {
            Exercicio01 exercicio01 = new Exercicio01();
            exercicio01.Show();
        }

        private void btExercicio02_Click(object sender, EventArgs e)
        {
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Show();
        }

        private void btExercicio03_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Show();
        }

        private void btExercicio04_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

        private void btExercicio05_Click(object sender, EventArgs e)
        {
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Show();
        }

        private void btExercicio06_Click(object sender, EventArgs e)
        {
            Exercicio06 exercicio06 = new Exercicio06();
            exercicio06.Show();
        }
    }
}
