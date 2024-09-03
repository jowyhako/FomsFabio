using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloco_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Clique aqui para ver a contagem de caracteres";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            TemaEscuro();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();  
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copiar
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);  
            }
        }

        private void coalrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colar
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();  
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // isso foi INCRIVELMENTE fácil tmj hot slq oque
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font; 
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bloco de Notas - Versão fabio Chatao\nCriado por jao, gab e pito", "Sobre"); 
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarContagemCaracteres()
        {
            toolStripStatusLabel1.Text = "Caracteres: " + richTextBox1.Text.Length.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            AtualizarContagemCaracteres();
        }
        private void TemaEscuro()
        {
          
            this.BackColor = Color.Black;
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DarkGray;
            richTextBox1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.DarkGray;
            statusStrip1.ForeColor = Color.White;
        }
    }
}
