namespace TabelaKM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.rbIda = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblFuncional = new System.Windows.Forms.Label();
            this.txtFuncional = new System.Windows.Forms.TextBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.gbIdaVolta = new System.Windows.Forms.GroupBox();
            this.rbIdaVolta = new System.Windows.Forms.RadioButton();
            this.gbCargo = new System.Windows.Forms.GroupBox();
            this.rbGerente = new System.Windows.Forms.RadioButton();
            this.rbOperacional = new System.Windows.Forms.RadioButton();
            this.rbDiretor = new System.Windows.Forms.RadioButton();
            this.lblKmPercorridos = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbBandeiraDestino = new System.Windows.Forms.PictureBox();
            this.pbBandeiraOrigem = new System.Windows.Forms.PictureBox();
            this.gbIdaVolta.SuspendLayout();
            this.gbCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraOrigem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Espírito Santo",
            "Minas Gerais"});
            this.cbOrigem.Location = new System.Drawing.Point(24, 182);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(120, 21);
            this.cbOrigem.TabIndex = 2;
            this.cbOrigem.SelectedIndexChanged += new System.EventHandler(this.cbOrigem_SelectedIndexChanged);
            // 
            // rbIda
            // 
            this.rbIda.AutoSize = true;
            this.rbIda.Checked = true;
            this.rbIda.Location = new System.Drawing.Point(9, 19);
            this.rbIda.Name = "rbIda";
            this.rbIda.Size = new System.Drawing.Size(40, 17);
            this.rbIda.TabIndex = 3;
            this.rbIda.TabStop = true;
            this.rbIda.Text = "Ida";
            this.rbIda.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(24, 291);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblFuncional
            // 
            this.lblFuncional.AutoSize = true;
            this.lblFuncional.Location = new System.Drawing.Point(6, 64);
            this.lblFuncional.Name = "lblFuncional";
            this.lblFuncional.Size = new System.Drawing.Size(53, 13);
            this.lblFuncional.TabIndex = 6;
            this.lblFuncional.Text = "Funcional";
            // 
            // txtFuncional
            // 
            this.txtFuncional.Location = new System.Drawing.Point(62, 64);
            this.txtFuncional.Name = "txtFuncional";
            this.txtFuncional.Size = new System.Drawing.Size(61, 20);
            this.txtFuncional.TabIndex = 7;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Espírito Santo",
            "Minas Gerais"});
            this.cbDestino.Location = new System.Drawing.Point(161, 182);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(120, 21);
            this.cbDestino.TabIndex = 8;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(158, 166);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 10;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(21, 166);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(43, 13);
            this.lblOrigem.TabIndex = 11;
            this.lblOrigem.Text = "Origem:";
            // 
            // gbIdaVolta
            // 
            this.gbIdaVolta.Controls.Add(this.rbIdaVolta);
            this.gbIdaVolta.Controls.Add(this.rbIda);
            this.gbIdaVolta.Location = new System.Drawing.Point(24, 90);
            this.gbIdaVolta.Name = "gbIdaVolta";
            this.gbIdaVolta.Size = new System.Drawing.Size(85, 67);
            this.gbIdaVolta.TabIndex = 13;
            this.gbIdaVolta.TabStop = false;
            this.gbIdaVolta.Text = "Ida e volta";
            // 
            // rbIdaVolta
            // 
            this.rbIdaVolta.AutoSize = true;
            this.rbIdaVolta.Location = new System.Drawing.Point(9, 42);
            this.rbIdaVolta.Name = "rbIdaVolta";
            this.rbIdaVolta.Size = new System.Drawing.Size(75, 17);
            this.rbIdaVolta.TabIndex = 4;
            this.rbIdaVolta.Text = "Ida e volta";
            this.rbIdaVolta.UseVisualStyleBackColor = true;
            // 
            // gbCargo
            // 
            this.gbCargo.Controls.Add(this.rbDiretor);
            this.gbCargo.Controls.Add(this.rbOperacional);
            this.gbCargo.Controls.Add(this.rbGerente);
            this.gbCargo.Location = new System.Drawing.Point(115, 90);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Size = new System.Drawing.Size(218, 43);
            this.gbCargo.TabIndex = 14;
            this.gbCargo.TabStop = false;
            this.gbCargo.Text = "Cargo na empresa";
            // 
            // rbGerente
            // 
            this.rbGerente.AutoSize = true;
            this.rbGerente.Location = new System.Drawing.Point(89, 19);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.Size = new System.Drawing.Size(63, 17);
            this.rbGerente.TabIndex = 5;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.UseVisualStyleBackColor = true;
            // 
            // rbOperacional
            // 
            this.rbOperacional.AutoSize = true;
            this.rbOperacional.Checked = true;
            this.rbOperacional.Location = new System.Drawing.Point(6, 19);
            this.rbOperacional.Name = "rbOperacional";
            this.rbOperacional.Size = new System.Drawing.Size(82, 17);
            this.rbOperacional.TabIndex = 6;
            this.rbOperacional.TabStop = true;
            this.rbOperacional.Text = "Operacional";
            this.rbOperacional.UseVisualStyleBackColor = true;
            // 
            // rbDiretor
            // 
            this.rbDiretor.AutoSize = true;
            this.rbDiretor.Location = new System.Drawing.Point(158, 19);
            this.rbDiretor.Name = "rbDiretor";
            this.rbDiretor.Size = new System.Drawing.Size(56, 17);
            this.rbDiretor.TabIndex = 7;
            this.rbDiretor.Text = "Diretor";
            this.rbDiretor.UseVisualStyleBackColor = true;
            // 
            // lblKmPercorridos
            // 
            this.lblKmPercorridos.AutoSize = true;
            this.lblKmPercorridos.Location = new System.Drawing.Point(12, 327);
            this.lblKmPercorridos.Name = "lblKmPercorridos";
            this.lblKmPercorridos.Size = new System.Drawing.Size(104, 13);
            this.lblKmPercorridos.TabIndex = 15;
            this.lblKmPercorridos.Text = "KM A PERCORRER";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(189, 327);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(92, 13);
            this.lblTotalPagar.TabIndex = 16;
            this.lblTotalPagar.Text = "TOTAL A PAGAR";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(115, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(206, 291);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbBandeiraDestino
            // 
            this.pbBandeiraDestino.Location = new System.Drawing.Point(161, 209);
            this.pbBandeiraDestino.Name = "pbBandeiraDestino";
            this.pbBandeiraDestino.Size = new System.Drawing.Size(120, 66);
            this.pbBandeiraDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBandeiraDestino.TabIndex = 9;
            this.pbBandeiraDestino.TabStop = false;
            this.pbBandeiraDestino.Click += new System.EventHandler(this.pbBandeiraDestino_Click);
            // 
            // pbBandeiraOrigem
            // 
            this.pbBandeiraOrigem.Location = new System.Drawing.Point(24, 209);
            this.pbBandeiraOrigem.Name = "pbBandeiraOrigem";
            this.pbBandeiraOrigem.Size = new System.Drawing.Size(120, 66);
            this.pbBandeiraOrigem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBandeiraOrigem.TabIndex = 0;
            this.pbBandeiraOrigem.TabStop = false;
            this.pbBandeiraOrigem.Click += new System.EventHandler(this.pbBandeiraOrigem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 378);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblKmPercorridos);
            this.Controls.Add(this.gbCargo);
            this.Controls.Add(this.gbIdaVolta);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.pbBandeiraDestino);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.txtFuncional);
            this.Controls.Add(this.lblFuncional);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pbBandeiraOrigem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIdaVolta.ResumeLayout(false);
            this.gbIdaVolta.PerformLayout();
            this.gbCargo.ResumeLayout(false);
            this.gbCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraOrigem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBandeiraOrigem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.RadioButton rbIda;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblFuncional;
        private System.Windows.Forms.TextBox txtFuncional;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.PictureBox pbBandeiraDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.GroupBox gbIdaVolta;
        private System.Windows.Forms.RadioButton rbIdaVolta;
        private System.Windows.Forms.GroupBox gbCargo;
        private System.Windows.Forms.RadioButton rbDiretor;
        private System.Windows.Forms.RadioButton rbOperacional;
        private System.Windows.Forms.RadioButton rbGerente;
        private System.Windows.Forms.Label lblKmPercorridos;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

