namespace PCGAMEREX
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
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.groupBoxGabinete = new System.Windows.Forms.GroupBox();
            this.pictureBoxComponent = new System.Windows.Forms.PictureBox();
            this.rbtnGabineteGamer = new System.Windows.Forms.RadioButton();
            this.rbtnGabineteSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxPlacaMae = new System.Windows.Forms.GroupBox();
            this.pictureBoxPlacaMae = new System.Windows.Forms.PictureBox();
            this.rbtnPlacaMaeGamer = new System.Windows.Forms.RadioButton();
            this.rbtnPlacaMaeSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxPlacaVideo = new System.Windows.Forms.GroupBox();
            this.pictureBoxPlacaVideo = new System.Windows.Forms.PictureBox();
            this.rbtnPlacaVideoGamer = new System.Windows.Forms.RadioButton();
            this.rbtnPlacaVideoSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxMemoria = new System.Windows.Forms.GroupBox();
            this.pictureBoxMemoria = new System.Windows.Forms.PictureBox();
            this.rbtnMemoriaGamer = new System.Windows.Forms.RadioButton();
            this.rbtnMemoriaSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxProcessador = new System.Windows.Forms.GroupBox();
            this.pictureBoxProcessador = new System.Windows.Forms.PictureBox();
            this.rbtnProcessadorGamer = new System.Windows.Forms.RadioButton();
            this.rbtnProcessadorSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxDiscoRigido = new System.Windows.Forms.GroupBox();
            this.pictureBoxDiscoRigido = new System.Windows.Forms.PictureBox();
            this.rbtnDiscoRigidoGamer = new System.Windows.Forms.RadioButton();
            this.rbtnDiscoRigidoSimples = new System.Windows.Forms.RadioButton();
            this.groupBoxPerifericos = new System.Windows.Forms.GroupBox();
            this.pictureBoxMonitor = new System.Windows.Forms.PictureBox();
            this.rbtnPerifericosGamer = new System.Windows.Forms.RadioButton();
            this.rbtnPerifericosSimples = new System.Windows.Forms.RadioButton();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.groupBoxGabinete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponent)).BeginInit();
            this.groupBoxPlacaMae.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlacaMae)).BeginInit();
            this.groupBoxPlacaVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlacaVideo)).BeginInit();
            this.groupBoxMemoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemoria)).BeginInit();
            this.groupBoxProcessador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessador)).BeginInit();
            this.groupBoxDiscoRigido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscoRigido)).BeginInit();
            this.groupBoxPerifericos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(55, 12);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Location = new System.Drawing.Point(3, 15);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelNomeUsuario.TabIndex = 1;
            this.labelNomeUsuario.Text = "Usuário:";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // groupBoxGabinete
            // 
            this.groupBoxGabinete.Controls.Add(this.pictureBoxComponent);
            this.groupBoxGabinete.Controls.Add(this.rbtnGabineteGamer);
            this.groupBoxGabinete.Controls.Add(this.rbtnGabineteSimples);
            this.groupBoxGabinete.Location = new System.Drawing.Point(200, 12);
            this.groupBoxGabinete.Name = "groupBoxGabinete";
            this.groupBoxGabinete.Size = new System.Drawing.Size(200, 153);
            this.groupBoxGabinete.TabIndex = 2;
            this.groupBoxGabinete.TabStop = false;
            this.groupBoxGabinete.Text = "Gabinete";
            // 
            // pictureBoxComponent
            // 
            this.pictureBoxComponent.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxComponent.Location = new System.Drawing.Point(50, 59);
            this.pictureBoxComponent.Name = "pictureBoxComponent";
            this.pictureBoxComponent.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxComponent.TabIndex = 2;
            this.pictureBoxComponent.TabStop = false;
            this.pictureBoxComponent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbtnGabineteGamer
            // 
            this.rbtnGabineteGamer.AutoSize = true;
            this.rbtnGabineteGamer.Location = new System.Drawing.Point(6, 42);
            this.rbtnGabineteGamer.Name = "rbtnGabineteGamer";
            this.rbtnGabineteGamer.Size = new System.Drawing.Size(102, 17);
            this.rbtnGabineteGamer.TabIndex = 1;
            this.rbtnGabineteGamer.TabStop = true;
            this.rbtnGabineteGamer.Text = "Gabinete Gamer";
            this.rbtnGabineteGamer.UseVisualStyleBackColor = true;
            this.rbtnGabineteGamer.CheckedChanged += new System.EventHandler(this.rbtnGabineteGamer_CheckedChanged);
            // 
            // rbtnGabineteSimples
            // 
            this.rbtnGabineteSimples.AutoSize = true;
            this.rbtnGabineteSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnGabineteSimples.Name = "rbtnGabineteSimples";
            this.rbtnGabineteSimples.Size = new System.Drawing.Size(107, 17);
            this.rbtnGabineteSimples.TabIndex = 0;
            this.rbtnGabineteSimples.TabStop = true;
            this.rbtnGabineteSimples.Text = "Gabinete Simples";
            this.rbtnGabineteSimples.UseVisualStyleBackColor = true;
            this.rbtnGabineteSimples.CheckedChanged += new System.EventHandler(this.rbtnGabineteSimples_CheckedChanged);
            // 
            // groupBoxPlacaMae
            // 
            this.groupBoxPlacaMae.Controls.Add(this.pictureBoxPlacaMae);
            this.groupBoxPlacaMae.Controls.Add(this.rbtnPlacaMaeGamer);
            this.groupBoxPlacaMae.Controls.Add(this.rbtnPlacaMaeSimples);
            this.groupBoxPlacaMae.Location = new System.Drawing.Point(200, 330);
            this.groupBoxPlacaMae.Name = "groupBoxPlacaMae";
            this.groupBoxPlacaMae.Size = new System.Drawing.Size(200, 153);
            this.groupBoxPlacaMae.TabIndex = 3;
            this.groupBoxPlacaMae.TabStop = false;
            this.groupBoxPlacaMae.Text = "Placa-Mãe";
            // 
            // pictureBoxPlacaMae
            // 
            this.pictureBoxPlacaMae.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxPlacaMae.Location = new System.Drawing.Point(50, 59);
            this.pictureBoxPlacaMae.Name = "pictureBoxPlacaMae";
            this.pictureBoxPlacaMae.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxPlacaMae.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlacaMae.TabIndex = 4;
            this.pictureBoxPlacaMae.TabStop = false;
            // 
            // rbtnPlacaMaeGamer
            // 
            this.rbtnPlacaMaeGamer.AutoSize = true;
            this.rbtnPlacaMaeGamer.Location = new System.Drawing.Point(6, 39);
            this.rbtnPlacaMaeGamer.Name = "rbtnPlacaMaeGamer";
            this.rbtnPlacaMaeGamer.Size = new System.Drawing.Size(59, 17);
            this.rbtnPlacaMaeGamer.TabIndex = 3;
            this.rbtnPlacaMaeGamer.TabStop = true;
            this.rbtnPlacaMaeGamer.Text = "B550M";
            this.rbtnPlacaMaeGamer.UseVisualStyleBackColor = true;
            this.rbtnPlacaMaeGamer.CheckedChanged += new System.EventHandler(this.rbtnPlacaMaeGamer_CheckedChanged);
            // 
            // rbtnPlacaMaeSimples
            // 
            this.rbtnPlacaMaeSimples.AutoSize = true;
            this.rbtnPlacaMaeSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnPlacaMaeSimples.Name = "rbtnPlacaMaeSimples";
            this.rbtnPlacaMaeSimples.Size = new System.Drawing.Size(59, 17);
            this.rbtnPlacaMaeSimples.TabIndex = 2;
            this.rbtnPlacaMaeSimples.TabStop = true;
            this.rbtnPlacaMaeSimples.Text = "A520M";
            this.rbtnPlacaMaeSimples.UseVisualStyleBackColor = true;
            this.rbtnPlacaMaeSimples.CheckedChanged += new System.EventHandler(this.rbtnPlacaMaeSimples_CheckedChanged);
            // 
            // groupBoxPlacaVideo
            // 
            this.groupBoxPlacaVideo.Controls.Add(this.pictureBoxPlacaVideo);
            this.groupBoxPlacaVideo.Controls.Add(this.rbtnPlacaVideoGamer);
            this.groupBoxPlacaVideo.Controls.Add(this.rbtnPlacaVideoSimples);
            this.groupBoxPlacaVideo.Location = new System.Drawing.Point(406, 330);
            this.groupBoxPlacaVideo.Name = "groupBoxPlacaVideo";
            this.groupBoxPlacaVideo.Size = new System.Drawing.Size(200, 153);
            this.groupBoxPlacaVideo.TabIndex = 3;
            this.groupBoxPlacaVideo.TabStop = false;
            this.groupBoxPlacaVideo.Text = "Placa De Video";
            // 
            // pictureBoxPlacaVideo
            // 
            this.pictureBoxPlacaVideo.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxPlacaVideo.Location = new System.Drawing.Point(58, 59);
            this.pictureBoxPlacaVideo.Name = "pictureBoxPlacaVideo";
            this.pictureBoxPlacaVideo.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxPlacaVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlacaVideo.TabIndex = 4;
            this.pictureBoxPlacaVideo.TabStop = false;
            // 
            // rbtnPlacaVideoGamer
            // 
            this.rbtnPlacaVideoGamer.AutoSize = true;
            this.rbtnPlacaVideoGamer.Location = new System.Drawing.Point(6, 42);
            this.rbtnPlacaVideoGamer.Name = "rbtnPlacaVideoGamer";
            this.rbtnPlacaVideoGamer.Size = new System.Drawing.Size(84, 17);
            this.rbtnPlacaVideoGamer.TabIndex = 3;
            this.rbtnPlacaVideoGamer.TabStop = true;
            this.rbtnPlacaVideoGamer.Text = "RX 6750 XT";
            this.rbtnPlacaVideoGamer.UseVisualStyleBackColor = true;
            this.rbtnPlacaVideoGamer.CheckedChanged += new System.EventHandler(this.rbtnPlacaVideoGamer_CheckedChanged);
            // 
            // rbtnPlacaVideoSimples
            // 
            this.rbtnPlacaVideoSimples.AutoSize = true;
            this.rbtnPlacaVideoSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnPlacaVideoSimples.Name = "rbtnPlacaVideoSimples";
            this.rbtnPlacaVideoSimples.Size = new System.Drawing.Size(64, 17);
            this.rbtnPlacaVideoSimples.TabIndex = 2;
            this.rbtnPlacaVideoSimples.TabStop = true;
            this.rbtnPlacaVideoSimples.Text = "RX 580 ";
            this.rbtnPlacaVideoSimples.UseVisualStyleBackColor = true;
            this.rbtnPlacaVideoSimples.CheckedChanged += new System.EventHandler(this.rbtnPlacaVideoSimples_CheckedChanged);
            // 
            // groupBoxMemoria
            // 
            this.groupBoxMemoria.Controls.Add(this.pictureBoxMemoria);
            this.groupBoxMemoria.Controls.Add(this.rbtnMemoriaGamer);
            this.groupBoxMemoria.Controls.Add(this.rbtnMemoriaSimples);
            this.groupBoxMemoria.Location = new System.Drawing.Point(612, 12);
            this.groupBoxMemoria.Name = "groupBoxMemoria";
            this.groupBoxMemoria.Size = new System.Drawing.Size(200, 153);
            this.groupBoxMemoria.TabIndex = 3;
            this.groupBoxMemoria.TabStop = false;
            this.groupBoxMemoria.Text = "Memoria Ram";
            // 
            // pictureBoxMemoria
            // 
            this.pictureBoxMemoria.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxMemoria.Location = new System.Drawing.Point(53, 59);
            this.pictureBoxMemoria.Name = "pictureBoxMemoria";
            this.pictureBoxMemoria.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxMemoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemoria.TabIndex = 4;
            this.pictureBoxMemoria.TabStop = false;
            // 
            // rbtnMemoriaGamer
            // 
            this.rbtnMemoriaGamer.AutoSize = true;
            this.rbtnMemoriaGamer.Location = new System.Drawing.Point(6, 42);
            this.rbtnMemoriaGamer.Name = "rbtnMemoriaGamer";
            this.rbtnMemoriaGamer.Size = new System.Drawing.Size(85, 17);
            this.rbtnMemoriaGamer.TabIndex = 3;
            this.rbtnMemoriaGamer.TabStop = true;
            this.rbtnMemoriaGamer.Text = "16GB DDR4";
            this.rbtnMemoriaGamer.UseVisualStyleBackColor = true;
            this.rbtnMemoriaGamer.CheckedChanged += new System.EventHandler(this.rbtnMemoriaGamer_CheckedChanged);
            // 
            // rbtnMemoriaSimples
            // 
            this.rbtnMemoriaSimples.AutoSize = true;
            this.rbtnMemoriaSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnMemoriaSimples.Name = "rbtnMemoriaSimples";
            this.rbtnMemoriaSimples.Size = new System.Drawing.Size(79, 17);
            this.rbtnMemoriaSimples.TabIndex = 2;
            this.rbtnMemoriaSimples.TabStop = true;
            this.rbtnMemoriaSimples.Text = "8GB DDR3";
            this.rbtnMemoriaSimples.UseVisualStyleBackColor = true;
            this.rbtnMemoriaSimples.CheckedChanged += new System.EventHandler(this.rbtnMemoriaSimples_CheckedChanged);
            // 
            // groupBoxProcessador
            // 
            this.groupBoxProcessador.Controls.Add(this.pictureBoxProcessador);
            this.groupBoxProcessador.Controls.Add(this.rbtnProcessadorGamer);
            this.groupBoxProcessador.Controls.Add(this.rbtnProcessadorSimples);
            this.groupBoxProcessador.Location = new System.Drawing.Point(200, 171);
            this.groupBoxProcessador.Name = "groupBoxProcessador";
            this.groupBoxProcessador.Size = new System.Drawing.Size(200, 153);
            this.groupBoxProcessador.TabIndex = 3;
            this.groupBoxProcessador.TabStop = false;
            this.groupBoxProcessador.Text = "Processador";
            // 
            // pictureBoxProcessador
            // 
            this.pictureBoxProcessador.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxProcessador.Location = new System.Drawing.Point(50, 59);
            this.pictureBoxProcessador.Name = "pictureBoxProcessador";
            this.pictureBoxProcessador.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxProcessador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessador.TabIndex = 3;
            this.pictureBoxProcessador.TabStop = false;
            // 
            // rbtnProcessadorGamer
            // 
            this.rbtnProcessadorGamer.AutoSize = true;
            this.rbtnProcessadorGamer.Location = new System.Drawing.Point(6, 42);
            this.rbtnProcessadorGamer.Name = "rbtnProcessadorGamer";
            this.rbtnProcessadorGamer.Size = new System.Drawing.Size(91, 17);
            this.rbtnProcessadorGamer.TabIndex = 3;
            this.rbtnProcessadorGamer.TabStop = true;
            this.rbtnProcessadorGamer.Text = "Ryzen 5 5600";
            this.rbtnProcessadorGamer.UseVisualStyleBackColor = true;
            this.rbtnProcessadorGamer.CheckedChanged += new System.EventHandler(this.rbtnProcessadorGamer_CheckedChanged);
            // 
            // rbtnProcessadorSimples
            // 
            this.rbtnProcessadorSimples.AutoSize = true;
            this.rbtnProcessadorSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnProcessadorSimples.Name = "rbtnProcessadorSimples";
            this.rbtnProcessadorSimples.Size = new System.Drawing.Size(91, 17);
            this.rbtnProcessadorSimples.TabIndex = 2;
            this.rbtnProcessadorSimples.TabStop = true;
            this.rbtnProcessadorSimples.Text = "Ryzen 5 2400";
            this.rbtnProcessadorSimples.UseVisualStyleBackColor = true;
            this.rbtnProcessadorSimples.CheckedChanged += new System.EventHandler(this.rbtnProcessadorSimples_CheckedChanged);
            // 
            // groupBoxDiscoRigido
            // 
            this.groupBoxDiscoRigido.Controls.Add(this.pictureBoxDiscoRigido);
            this.groupBoxDiscoRigido.Controls.Add(this.rbtnDiscoRigidoGamer);
            this.groupBoxDiscoRigido.Controls.Add(this.rbtnDiscoRigidoSimples);
            this.groupBoxDiscoRigido.Location = new System.Drawing.Point(406, 12);
            this.groupBoxDiscoRigido.Name = "groupBoxDiscoRigido";
            this.groupBoxDiscoRigido.Size = new System.Drawing.Size(200, 153);
            this.groupBoxDiscoRigido.TabIndex = 3;
            this.groupBoxDiscoRigido.TabStop = false;
            this.groupBoxDiscoRigido.Text = "Disco Rigido";
            // 
            // pictureBoxDiscoRigido
            // 
            this.pictureBoxDiscoRigido.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxDiscoRigido.Location = new System.Drawing.Point(58, 59);
            this.pictureBoxDiscoRigido.Name = "pictureBoxDiscoRigido";
            this.pictureBoxDiscoRigido.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxDiscoRigido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiscoRigido.TabIndex = 4;
            this.pictureBoxDiscoRigido.TabStop = false;
            // 
            // rbtnDiscoRigidoGamer
            // 
            this.rbtnDiscoRigidoGamer.AutoSize = true;
            this.rbtnDiscoRigidoGamer.Location = new System.Drawing.Point(7, 42);
            this.rbtnDiscoRigidoGamer.Name = "rbtnDiscoRigidoGamer";
            this.rbtnDiscoRigidoGamer.Size = new System.Drawing.Size(101, 17);
            this.rbtnDiscoRigidoGamer.TabIndex = 3;
            this.rbtnDiscoRigidoGamer.TabStop = true;
            this.rbtnDiscoRigidoGamer.Text = "SSD 1TB Nvme";
            this.rbtnDiscoRigidoGamer.UseVisualStyleBackColor = true;
            this.rbtnDiscoRigidoGamer.CheckedChanged += new System.EventHandler(this.rbtnDiscoRigidoGamer_CheckedChanged);
            // 
            // rbtnDiscoRigidoSimples
            // 
            this.rbtnDiscoRigidoSimples.AutoSize = true;
            this.rbtnDiscoRigidoSimples.Location = new System.Drawing.Point(7, 19);
            this.rbtnDiscoRigidoSimples.Name = "rbtnDiscoRigidoSimples";
            this.rbtnDiscoRigidoSimples.Size = new System.Drawing.Size(85, 17);
            this.rbtnDiscoRigidoSimples.TabIndex = 2;
            this.rbtnDiscoRigidoSimples.TabStop = true;
            this.rbtnDiscoRigidoSimples.Text = "HDD 500GB";
            this.rbtnDiscoRigidoSimples.UseVisualStyleBackColor = true;
            this.rbtnDiscoRigidoSimples.CheckedChanged += new System.EventHandler(this.rbtnDiscoRigidoSimples_CheckedChanged);
            // 
            // groupBoxPerifericos
            // 
            this.groupBoxPerifericos.Controls.Add(this.pictureBoxMonitor);
            this.groupBoxPerifericos.Controls.Add(this.rbtnPerifericosGamer);
            this.groupBoxPerifericos.Controls.Add(this.rbtnPerifericosSimples);
            this.groupBoxPerifericos.Location = new System.Drawing.Point(406, 171);
            this.groupBoxPerifericos.Name = "groupBoxPerifericos";
            this.groupBoxPerifericos.Size = new System.Drawing.Size(200, 153);
            this.groupBoxPerifericos.TabIndex = 4;
            this.groupBoxPerifericos.TabStop = false;
            this.groupBoxPerifericos.Text = "Monitor";
            // 
            // pictureBoxMonitor
            // 
            this.pictureBoxMonitor.Image = global::PCGAMEREX.Properties.Resources.NULO;
            this.pictureBoxMonitor.Location = new System.Drawing.Point(58, 59);
            this.pictureBoxMonitor.Name = "pictureBoxMonitor";
            this.pictureBoxMonitor.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonitor.TabIndex = 4;
            this.pictureBoxMonitor.TabStop = false;
            // 
            // rbtnPerifericosGamer
            // 
            this.rbtnPerifericosGamer.AutoSize = true;
            this.rbtnPerifericosGamer.Location = new System.Drawing.Point(6, 42);
            this.rbtnPerifericosGamer.Name = "rbtnPerifericosGamer";
            this.rbtnPerifericosGamer.Size = new System.Drawing.Size(145, 17);
            this.rbtnPerifericosGamer.TabIndex = 3;
            this.rbtnPerifericosGamer.TabStop = true;
            this.rbtnPerifericosGamer.Text = "Monitor QUAD HD 144hz";
            this.rbtnPerifericosGamer.UseVisualStyleBackColor = true;
            this.rbtnPerifericosGamer.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // rbtnPerifericosSimples
            // 
            this.rbtnPerifericosSimples.AutoSize = true;
            this.rbtnPerifericosSimples.Location = new System.Drawing.Point(6, 19);
            this.rbtnPerifericosSimples.Name = "rbtnPerifericosSimples";
            this.rbtnPerifericosSimples.Size = new System.Drawing.Size(108, 17);
            this.rbtnPerifericosSimples.TabIndex = 2;
            this.rbtnPerifericosSimples.TabStop = true;
            this.rbtnPerifericosSimples.Text = "Monitor HD 75hz ";
            this.rbtnPerifericosSimples.UseVisualStyleBackColor = true;
            this.rbtnPerifericosSimples.CheckedChanged += new System.EventHandler(this.rbtnPerifericosSimples_CheckedChanged);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(612, 178);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(200, 29);
            this.btnFinalizarPedido.TabIndex = 5;
            this.btnFinalizarPedido.Text = "FINALIZAR PEDIDO";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 496);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.groupBoxPerifericos);
            this.Controls.Add(this.groupBoxDiscoRigido);
            this.Controls.Add(this.groupBoxPlacaMae);
            this.Controls.Add(this.groupBoxProcessador);
            this.Controls.Add(this.groupBoxMemoria);
            this.Controls.Add(this.groupBoxPlacaVideo);
            this.Controls.Add(this.groupBoxGabinete);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGabinete.ResumeLayout(false);
            this.groupBoxGabinete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComponent)).EndInit();
            this.groupBoxPlacaMae.ResumeLayout(false);
            this.groupBoxPlacaMae.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlacaMae)).EndInit();
            this.groupBoxPlacaVideo.ResumeLayout(false);
            this.groupBoxPlacaVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlacaVideo)).EndInit();
            this.groupBoxMemoria.ResumeLayout(false);
            this.groupBoxMemoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemoria)).EndInit();
            this.groupBoxProcessador.ResumeLayout(false);
            this.groupBoxProcessador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessador)).EndInit();
            this.groupBoxDiscoRigido.ResumeLayout(false);
            this.groupBoxDiscoRigido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscoRigido)).EndInit();
            this.groupBoxPerifericos.ResumeLayout(false);
            this.groupBoxPerifericos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.GroupBox groupBoxGabinete;
        private System.Windows.Forms.GroupBox groupBoxPlacaMae;
        private System.Windows.Forms.GroupBox groupBoxPlacaVideo;
        private System.Windows.Forms.GroupBox groupBoxMemoria;
        private System.Windows.Forms.GroupBox groupBoxProcessador;
        private System.Windows.Forms.GroupBox groupBoxDiscoRigido;
        private System.Windows.Forms.RadioButton rbtnGabineteGamer;
        private System.Windows.Forms.RadioButton rbtnGabineteSimples;
        private System.Windows.Forms.RadioButton rbtnPlacaMaeGamer;
        private System.Windows.Forms.RadioButton rbtnPlacaMaeSimples;
        private System.Windows.Forms.RadioButton rbtnPlacaVideoGamer;
        private System.Windows.Forms.RadioButton rbtnPlacaVideoSimples;
        private System.Windows.Forms.RadioButton rbtnMemoriaGamer;
        private System.Windows.Forms.RadioButton rbtnMemoriaSimples;
        private System.Windows.Forms.RadioButton rbtnProcessadorGamer;
        private System.Windows.Forms.RadioButton rbtnProcessadorSimples;
        private System.Windows.Forms.RadioButton rbtnDiscoRigidoGamer;
        private System.Windows.Forms.RadioButton rbtnDiscoRigidoSimples;
        private System.Windows.Forms.GroupBox groupBoxPerifericos;
        private System.Windows.Forms.RadioButton rbtnPerifericosGamer;
        private System.Windows.Forms.RadioButton rbtnPerifericosSimples;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.PictureBox pictureBoxComponent;
        private System.Windows.Forms.PictureBox pictureBoxPlacaMae;
        private System.Windows.Forms.PictureBox pictureBoxPlacaVideo;
        private System.Windows.Forms.PictureBox pictureBoxMemoria;
        private System.Windows.Forms.PictureBox pictureBoxProcessador;
        private System.Windows.Forms.PictureBox pictureBoxDiscoRigido;
        private System.Windows.Forms.PictureBox pictureBoxMonitor;
    }
}

