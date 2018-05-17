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
    public partial class Exercicio08 : Form
    {
        double boloBrigadeiro = 29.50, boloFlorestaNegra = 2.00, boloLeiteComNutella = 29.23, boloMousseDeChocolate = 7.10, boloNegaMaluca = 19.33, bombaDeCreme = 17.71, bombaDeMorango = 4.48, fileMignonComFritasCheddar = 21.16, HamburguerComQueijosChampignonRucula = 12.70,
            provoloneComSalame = 19.70, vegetarianoDeBerinjela = 28.22, calabresa = 8.89, napolitana = 0.42, peruana = 18.36, portuguesa = 27.50, total = 0;
        string produto1 = "", produto2 = "", produto3 = "";
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bolo Brigadeiro" )
            {
                produto1 = "Bolo Brigadeiro";
                total = total + boloBrigadeiro;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bolo Floresta Negra")
            {
                produto1 = "Bolo Floresta Negra";
                total = total + boloFlorestaNegra;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bolo Leite com Nutella")
            {
                produto1 = "Bolo Leite com Nutella";
                total = total + boloLeiteComNutella;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bolo Mousse de Chocolate")
            {
                produto1 = "Bolo Mousse de Chocolate";
                total = total + boloMousseDeChocolate;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bolo Nega Maluca")
            {
                produto1 = "Bolo Nega Maluca";
                total = total + boloNegaMaluca;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bomba de Creme")
            {
                produto1 = "Bomba de Creme";
                total = total + bombaDeCreme;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Bomba de Morango")
            {
                produto1 = "Bomba de Morango";
                total = total + bombaDeMorango;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Filé-Mignon com fritas e cheddar")
            {
                produto1 = "Filé-Mignon com fritas e cheddar";
                total = total + fileMignonComFritasCheddar;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Hambúguer com queijos, champignon e rúcula")
            {
                produto1 = "Hambúguer com queijos, champignon e rúcula";
                total = total + HamburguerComQueijosChampignonRucula;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Provolone com salame")
            {
                produto1 = "Provolone com salame";
                total = total + provoloneComSalame;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Vegetariano de berinjela")
            {
                produto1 = "Vegetariano de berinjela";
                total = total + vegetarianoDeBerinjela;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Calabresa")
            {
                produto1 = "Calabresa";
                total = total + calabresa;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Napolitana")
            {
                produto1 = "Napolitana";
                total = total + napolitana;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Peruana")
            {
                produto1 = "Peruana";
                total = total + peruana;
            }

            else if (cbEscolhaUmProduto1.SelectedItem.ToString() == "Portuguesa")
            {
                produto1 = "Portuguesa";
                total = total + portuguesa;

            }

            if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bolo Brigadeiro")
            {
                produto2 = "Bolo Brigadeiro";
                total = total + boloBrigadeiro;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bolo Floresta Negra")
            {
                produto2 = "Bolo Floresta Negra";
                total = total + boloFlorestaNegra;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bolo Leite com Nutella")
            {
                produto2 = "Bolo Leite com Nutella";
                total = total + boloLeiteComNutella;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bolo Mousse de Chocolate")
            {
                produto2 = "Bolo Mousse de Chocolate";
                total = total + boloMousseDeChocolate;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bolo Nega Maluca")
            {
                produto2 = "Bolo Nega Maluca";
                total = total + boloNegaMaluca;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bomba de Creme")
            {
                produto2 = "Bomba de Creme";
                total = total + bombaDeCreme;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Bomba de Morango")
            {
                produto2 = "Bomba de Morango";
                total = total + bombaDeMorango;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Filé-Mignon com fritas e cheddar")
            {
                produto2 = "Filé-Mignon com fritas e cheddar";
                total = total + fileMignonComFritasCheddar;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Hambúguer com queijos, champignon e rúcula")
            {
                produto2 = "Hambúguer com queijos, champignon e rúcula";
                total = total + HamburguerComQueijosChampignonRucula;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Provolone com salame")
            {
                produto2 = "Provolone com salame";
                total = total + provoloneComSalame;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Vegetariano de berinjela")
            {
                produto2 = "Vegetariano de berinjela";
                total = total + vegetarianoDeBerinjela;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Calabresa")
            {
                produto2 = "Calabresa";
                total = total + calabresa;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Napolitana")
            {
                produto2 = "Napolitana";
                total = total + napolitana;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Peruana")
            {
                produto2 = "Peruana";
                total = total + peruana;
            }

            else if (cbEscolhaUmProduto2.SelectedItem.ToString() == "Portuguesa")
            {
                produto2 = "Portuguesa";
                total = total + portuguesa;

            }

            if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bolo Brigadeiro")
            {
                produto3 = "Bolo Brigadeiro";
                total = total + boloBrigadeiro;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bolo Floresta Negra")
            {
                produto3 = "Bolo Floresta Negra";
                total = total + boloFlorestaNegra;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bolo Leite com Nutella")
            {
                produto3 = "Bolo Leite com Nutella";
                total = total + boloLeiteComNutella;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bolo Mousse de Chocolate")
            {
                produto3 = "Bolo Mousse de Chocolate";
                total = total + boloMousseDeChocolate;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bolo Nega Maluca")
            {
                produto3 = "Bolo Nega Maluca";
                total = total + boloNegaMaluca;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bomba de Creme")
            {
                produto3 = "Bomba de Creme";
                total = total + bombaDeCreme;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Bomba de Morango")
            {
                produto3 = "Bomba de Morango";
                total = total + bombaDeMorango;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Filé-Mignon com fritas e cheddar")
            {
                produto3 = "Filé-Mignon com fritas e cheddar";
                total = total + fileMignonComFritasCheddar;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Hambúguer com queijos, champignon e rúcula")
            {
                produto3 = "Hambúguer com queijos, champignon e rúcula";
                total = total + HamburguerComQueijosChampignonRucula;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Provolone com salame")
            {
                produto3 = "Provolone com salame";
                total = total + provoloneComSalame;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Vegetariano de berinjela")
            {
                produto3 = "Vegetariano de berinjela";
                total = total + vegetarianoDeBerinjela;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Calabresa")
            {
                produto3 = "Calabresa";
                total = total + calabresa;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Napolitana")
            {
                produto3 = "Napolitana";
                total = total + napolitana;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Peruana")
            {
                produto3 = "Peruana";
                total = total + peruana;
            }

            else if (cbEscolhaUmProduto3.SelectedItem.ToString() == "Portuguesa")
            {
                produto3 = "Portuguesa";
                total = total + portuguesa;

            }
            MessageBox.Show("Os produtos escolhidos foram " + produto1 + ", " + produto2 + ", " + produto3 + "\nCom o valor total de R$" + total);
	{
		 
	}
        }

        private void labelProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
