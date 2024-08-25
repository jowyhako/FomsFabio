namespace conversao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.comboBoxMoeda = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelMoeda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 110);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(110, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Conversor de moedas";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(92, 269);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(65, 13);
            this.labelValor.TabIndex = 1;
            this.labelValor.Text = "Valor em R$";
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(173, 329);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(75, 23);
            this.buttonConverter.TabIndex = 2;
            this.buttonConverter.Text = "FAÇA";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // comboBoxMoeda
            // 
            this.comboBoxMoeda.FormattingEnabled = true;
            this.comboBoxMoeda.Items.AddRange(new object[] {
            "Euro",
            "Dólar",
            "Yuan - Renminbi",
            "Iene",
            "Libra Esterlina"});
            this.comboBoxMoeda.Location = new System.Drawing.Point(151, 302);
            this.comboBoxMoeda.Name = "comboBoxMoeda";
            this.comboBoxMoeda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoeda.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(163, 266);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 6;
            // 
            // buttonSobre
            // 
            this.buttonSobre.Location = new System.Drawing.Point(81, 358);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(129, 44);
            this.buttonSobre.TabIndex = 7;
            this.buttonSobre.Text = "SOBRE";
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.buttonSobre_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(210, 358);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(129, 44);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "EXIT";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(392, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 353);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(207, 233);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(17, 13);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "\"\"";
            // 
            // labelMoeda
            // 
            this.labelMoeda.AutoSize = true;
            this.labelMoeda.Location = new System.Drawing.Point(160, 286);
            this.labelMoeda.Name = "labelMoeda";
            this.labelMoeda.Size = new System.Drawing.Size(103, 13);
            this.labelMoeda.TabIndex = 11;
            this.labelMoeda.Text = "Escolha uma moeda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.labelMoeda);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSobre);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxMoeda);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.ComboBox comboBoxMoeda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonSobre;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelMoeda;
    }
}

