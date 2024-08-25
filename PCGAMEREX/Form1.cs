using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PCGAMEREX
{
    public partial class Form1 : Form
    {
        //variaveos
        private string nomeUsuario;
        private string gabineteSelecionado;
        private string placaMaeSelecionada;
        private string placaVideoSelecionada;
        private string memoriaSelecionada;
        private string processadorSelecionado;
        private string discoRigidoSelecionado;
        private string perifericosSelecionados;
        private decimal precoTotal = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DarkGray;
            groupBoxGabinete.BackColor = Color.Gray ;    
            groupBoxDiscoRigido.BackColor = Color.Gray; 
            groupBoxMemoria.BackColor = Color.Gray; 
            groupBoxProcessador.BackColor = Color.Gray;
            groupBoxPlacaVideo.BackColor = Color.Gray;
            groupBoxPerifericos.BackColor = Color.Gray;
            groupBoxPlacaMae.BackColor = Color.Gray;

            labelNomeUsuario.ForeColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            // nome do otario
            nomeUsuario = txtNomeUsuario.Text;

            //info dos radionm
            gabineteSelecionado = rbtnGabineteSimples.Checked ? "Gabinete Simples" : "Gabinete Gamer";
            placaMaeSelecionada = rbtnPlacaMaeSimples.Checked ? "Placa Mãe Simples" : "Placa Mãe Gamer";
            placaVideoSelecionada = rbtnPlacaVideoSimples.Checked ? "Placa de Vídeo Simples" : "Placa de Vídeo Gamer";
            memoriaSelecionada = rbtnMemoriaSimples.Checked ? "Memória Simples" : "Memória Gamer";
            processadorSelecionado = rbtnProcessadorSimples.Checked ? "Processador Simples" : "Processador Gamer";
            discoRigidoSelecionado = rbtnDiscoRigidoSimples.Checked ? "Disco Rígido Simples" : "Disco Rígido Gamer";
            perifericosSelecionados = rbtnPerifericosSimples.Checked ? "Periféricos Simples" : "Periféricos Gamer";

            // Calcular preço
            precoTotal = CalcularPreco(gabineteSelecionado) + CalcularPreco(placaMaeSelecionada) +
                         CalcularPreco(placaVideoSelecionada) + CalcularPreco(memoriaSelecionada) +
                         CalcularPreco(processadorSelecionado) + CalcularPreco(discoRigidoSelecionado) +
                         CalcularPreco(perifericosSelecionados);

            //resumo message
            string resumoPedido = $"Nome do Comprador: {nomeUsuario}\n" +
                                  $"Gabinete: {gabineteSelecionado}\n" +
                                  $"Placa Mãe: {placaMaeSelecionada}\n" +
                                  $"Placa de Vídeo: {placaVideoSelecionada}\n" +
                                  $"Memória: {memoriaSelecionada}\n" +
                                  $"Processador: {processadorSelecionado}\n" +
                                  $"Disco Rígido: {discoRigidoSelecionado}\n" +
                                  $"Periféricos: {perifericosSelecionados}\n" +
                                  $"Preço Total: R$ {precoTotal}";

            MessageBox.Show(resumoPedido, "Resumo do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal CalcularPreco(string componente)
        {
            //calculo
            switch (componente)
            {
                case "Gabinete Simples":
                    return 230;
                case "Gabinete Gamer":
                    return 540;
                case "Placa Mãe Simples":
                    return 400;
                case "Placa Mãe Gamer":
                    return 700;
                case "Placa de Vídeo Simples":
                    return 900;
                case "Placa de Vídeo Gamer":
                    return 2100;
                case "Memória Simples":
                    return 90;
                case "Memória Gamer":
                    return 400;
                case "Processador Simples":
                    return 510;
                case "Processador Gamer":
                    return 900;
                case "Disco Rígido Simples":
                    return 340;
                case "Disco Rígido Gamer":
                    return 500;
                case "Periféricos Simples":
                    return 700;
                case "Periféricos Gamer":
                    return 1100;
                default:
                    return 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPerifericosSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPerifericosSimples.Checked)
            {
                MessageBox.Show("Monitor 75hz. R$ 700");
                pictureBoxMonitor.Image = Properties.Resources.PerifericoSimples;
            }
        }

        private void rbtnGabineteSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGabineteSimples.Checked)
            {
                MessageBox.Show("Gabinete Simples. R$230");
                pictureBoxComponent.Image = Properties.Resources.GabineteSimples;
            }
        }

        private void rbtnGabineteGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGabineteGamer.Checked)
            {
                MessageBox.Show("Gabinete Gamer. R$540");
                pictureBoxComponent.Image = Properties.Resources.GabineteGamer;
            }
        }

        private void rbtnProcessadorSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProcessadorSimples.Checked)
            {
                MessageBox.Show("Ryzen 2400. R$510");
                pictureBoxProcessador.Image = Properties.Resources.ProcessadorSimples;
            }
        }

        private void rbtnPlacaMaeSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlacaMaeSimples.Checked)
            {
                MessageBox.Show("A520M. R$400");
                pictureBoxPlacaMae.Image = Properties.Resources.PlacaMaeSimples;
            }
        }

        private void rbtnPlacaMaeGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlacaMaeGamer.Checked)
            {
                MessageBox.Show("B550M. R$700");
                pictureBoxPlacaMae.Image = Properties.Resources.PlacaMaeGamer;
            }
        }

        private void rbtnProcessadorGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProcessadorGamer.Checked)
            {
                MessageBox.Show("Ryzrn 5600. R$900");
                pictureBoxProcessador.Image = Properties.Resources.ProcessadorGamer;
            }
        }

        private void rbtnDiscoRigidoSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDiscoRigidoSimples.Checked)
            {
                MessageBox.Show("HDD. R$340");
                pictureBoxDiscoRigido.Image = Properties.Resources.DiscoRigidoSimples;
            }
        }

        private void rbtnDiscoRigidoGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDiscoRigidoGamer.Checked)
            {
                MessageBox.Show("SSD. R$500");
                pictureBoxDiscoRigido.Image = Properties.Resources.DiscoRigidoGamer;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPerifericosGamer.Checked)
            {
                MessageBox.Show("Monitor 144hz. R$1100");
                pictureBoxMonitor.Image = Properties.Resources.PerifericoGamer;
            }
        }

        private void rbtnPlacaVideoSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlacaVideoSimples.Checked)
            {
                MessageBox.Show("RX 580. R$900");
                pictureBoxPlacaVideo.Image = Properties.Resources.PlacaVideoSimples;
            }
        }

        private void rbtnPlacaVideoGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlacaVideoGamer.Checked)
            {
                MessageBox.Show("RX 6750Xt. R$2100");
                pictureBoxPlacaVideo.Image = Properties.Resources.PlacaVideoGamer;
            }
        }

        private void rbtnMemoriaSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMemoriaSimples.Checked)
            {
                MessageBox.Show("8GB DDR3. R$90");
                pictureBoxMemoria.Image = Properties.Resources.MemoriaSimples;
            }
        }

        private void rbtnMemoriaGamer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMemoriaGamer.Checked)
            {
                MessageBox.Show("16GB DDR4. R$400");
                pictureBoxMemoria.Image = Properties.Resources.MemoriaGamer;
            }
        }

        private void labelNomeUsuario_Click(object sender, EventArgs e)
        {
           
        }
    }
}
 