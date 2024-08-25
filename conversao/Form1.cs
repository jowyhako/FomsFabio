using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Mudando a cor de fundo do formulário para preto
            this.BackColor = Color.Black;
            // Mudando a cor das letras para dourado
            this.ForeColor = Color.Gold;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            decimal valorEmReais;
            if (decimal.TryParse(textBoxValor.Text, out valorEmReais))
            {
                decimal valorConvertido = 0;
                string moedaSelecionada = comboBoxMoeda.SelectedItem.ToString();

                switch (moedaSelecionada)
                {
                    case "Euro":
                        valorConvertido = valorEmReais * 0.18m;
                        break;
                    case "Dólar":
                        valorConvertido = valorEmReais * 0.20m;
                        break;
                    case "Yuan - Renminbi":
                        valorConvertido = valorEmReais * 1.30m;
                        break;
                    case "Iene":
                        valorConvertido = valorEmReais * 23.45m;
                        break;
                    case "Libra Esterlina":
                        valorConvertido = valorEmReais * 0.15m;
                        break;
                    default:
                        MessageBox.Show("Por favor, selecione uma moeda.");
                        break;
                }

                labelResultado.Text = $"Valor Convertido: {valorConvertido:F2} {moedaSelecionada}";
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido em reais.");
            }
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é um programa de conversão de moedas.", "Sobre");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

