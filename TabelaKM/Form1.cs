using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaKM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Gray;
            lblNome.ForeColor = System.Drawing.Color.White;
            lblFuncional.ForeColor = System.Drawing.Color.White;
            lblKmPercorridos.ForeColor = System.Drawing.Color.Red;
            lblTotalPagar.ForeColor = System.Drawing.Color.Red;
            btnCalcular.BackColor = System.Drawing.Color.DarkGray;
            btnCalcular.ForeColor = System.Drawing.Color.Black;
            btnSair.BackColor = System.Drawing.Color.DarkGray;
            btnSair.ForeColor = System.Drawing.Color.Black;
            btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            btnLimpar.ForeColor = System.Drawing.Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOrigem.SelectedIndexChanged += cbOrigem_SelectedIndexChanged;
            cbDestino.SelectedIndexChanged += cbDestino_SelectedIndexChanged;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Para de procurar erro Fábio.");
                return;
            }

            if (cbOrigem.SelectedIndex == -1 || cbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Voce precisa selecionar as duas cidades.");
                return;
            }

            if (cbOrigem.SelectedIndex == cbDestino.SelectedIndex)
            {
                MessageBox.Show("Não tem como voce voltar pra onde voce ja ta.");
                return;
            }

            //arrays nao deveriam existir
            int[,] distancias = {
        { 0, 357, 882, 489 }, // poluiçao
        { 357, 0, 521, 339 }, // roubo
        { 882, 521, 0, 378 }, // homossexualismo
        { 489, 339, 378, 0 }  // pao de queijo
    };
            int km = distancias[cbOrigem.SelectedIndex, cbDestino.SelectedIndex];

            // ida ou volta
            if (rbIdaVolta.Checked)
            {
                km *= 2;
            }

            lblKmPercorridos.Text = $"Km a Percorrer: {km}Km";

            // km por cargo
            double valorKm = 0;
            if (rbOperacional.Checked)
            {
                valorKm = 2.00;
            }
            else if (rbGerente.Checked)
            {
                valorKm = 2.50;
            }
            else if (rbDiretor.Checked)
            {
                valorKm = 3.00;
            }

            // Calc
            double totalPagar = km * valorKm;
            lblTotalPagar.Text = $"Total a pagar: R$ {totalPagar:F2}";

            // Exibir
            MessageBox.Show($"Nome: {txtNome.Text}\nFuncional: {txtFuncional.Text}\nCargo: {GetCargo()}\nOrigem: {cbOrigem.Text}\nDestino: {cbDestino.Text}\nOpção: {(rbIda.Checked ? "Ida" : "Ida e Volta")}\nKm Percorridos: {km}\nTotal a Pagar: R$ {totalPagar:F2}");
           //mano q desgraça
            DialogResult dialogResult = MessageBox.Show("Deseja fazer outra operação?", "Continuar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                btnLimpar_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                
                this.Close();
            }
        }

        private string GetCargo()
        {
            if (rbOperacional.Checked) return "Operacional";
            if (rbGerente.Checked) return "Gerente";
            return "Diretor";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        { 
            txtNome.Clear();
            txtFuncional.Clear();
            cbOrigem.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            rbIda.Checked = true;
            rbOperacional.Checked = true;
            lblKmPercorridos.Text = "";
            lblTotalPagar.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarBandeiraOrigem();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Focus();    
        }
        private void AtualizarBandeiraOrigem() //FILIPE FORTALECEU MUITO
        {
            string selectedText = cbOrigem.Text;

            if (selectedText == "NULO" || string.IsNullOrEmpty(selectedText))
            {
                pbBandeiraOrigem.Image = null; // Limpa
            }
            else if (selectedText == "Espírito Santo")
            {
                pbBandeiraOrigem.Image = Properties.Resources.EspiritoSanto;
            }
            else if (selectedText == "Minas Gerais")
            {
                pbBandeiraOrigem.Image = Properties.Resources.MinasGerais;
            }
            else if (selectedText == "Rio de Janeiro")
            {
                pbBandeiraOrigem.Image = Properties.Resources.RioDeJaneiro;   
            }
            else if (selectedText == "São Paulo")
            {
                pbBandeiraOrigem.Image = Properties.Resources.SaoPaulo;
            }
        }

        private void AtualizarBandeiraDestino() //crntl C crntl V
        {
            string selectedText = cbDestino.Text;

            if (selectedText == "NULO" || string.IsNullOrEmpty(selectedText))
            {
                pbBandeiraDestino.Image = null; 
            }
            else if (selectedText == "Espírito Santo")
            {
                pbBandeiraDestino.Image = Properties.Resources.EspiritoSanto; 
            }
            else if (selectedText == "Minas Gerais")
            {
                pbBandeiraDestino.Image = Properties.Resources.MinasGerais;
            }
            else if (selectedText == "Rio de Janeiro")
            {
                pbBandeiraDestino.Image = Properties.Resources.RioDeJaneiro;
            }
            else if (selectedText == "São Paulo")
            {
                pbBandeiraDestino.Image = Properties.Resources.SaoPaulo;
            }
        }

        private void pbBandeiraOrigem_Click(object sender, EventArgs e)
        {
            AtualizarBandeiraOrigem();
        }

        private void pbBandeiraDestino_Click(object sender, EventArgs e)
        {
            AtualizarBandeiraDestino();
        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarBandeiraDestino();
        }
    }
}
