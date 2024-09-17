using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapelao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeAluno = txtNomeAluno.Text;

            if (string.IsNullOrWhiteSpace(nomeAluno))
            {
                MessageBox.Show("Por favor, insira o nome do aluno.");
                return;
            }

            string casaEscolhida = aleatorio();

            
            MessageBox.Show($"{nomeAluno}, irá para {casaEscolhida}!");

            
            switch (casaEscolhida)
            {
                case "Grifinória":
                    listBoxGrifinoria.Items.Add(nomeAluno);
                    break;
                case "Lufa-Lufa":
                    listBoxLufaLufa.Items.Add(nomeAluno);
                    break;
                case "Corvinal":
                    listBoxCorvinal.Items.Add(nomeAluno);
                    break;
                case "Sonserina":
                    listBoxSonserina.Items.Add(nomeAluno);
                    break;
            }

            
            txtNomeAluno.Clear();
            txtNomeAluno.Focus();  
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private string aleatorio()
        {
            Random rand = new Random();
            string[] casas = { "Grifinória", "Lufa-Lufa", "Corvinal", "Sonserina" };
            int index = rand.Next(casas.Length);
            return casas[index];
        }

    }
}
