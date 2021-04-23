namespace CalcVLSM
{
    partial class View
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListaResultados = new System.Windows.Forms.ListBox();
            this.dgvHosts = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalHostlbl = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.numHost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskBinario = new System.Windows.Forms.Label();
            this.ipBinario = new System.Windows.Forms.Label();
            this.btnRecomeço = new System.Windows.Forms.Button();
            this.outIPBase = new System.Windows.Forms.Label();
            this.oct1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.oct2 = new System.Windows.Forms.TextBox();
            this.outMascara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oct3 = new System.Windows.Forms.TextBox();
            this.outClasse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oct4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHost)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaResultados);
            this.groupBox1.Controls.Add(this.dgvHosts);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1051, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora VLSM";
            // 
            // ListaResultados
            // 
            this.ListaResultados.FormattingEnabled = true;
            this.ListaResultados.ItemHeight = 16;
            this.ListaResultados.Location = new System.Drawing.Point(8, 351);
            this.ListaResultados.Margin = new System.Windows.Forms.Padding(4);
            this.ListaResultados.Name = "ListaResultados";
            this.ListaResultados.Size = new System.Drawing.Size(1034, 132);
            this.ListaResultados.TabIndex = 17;
            this.ListaResultados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dgvHosts
            // 
            this.dgvHosts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHosts.Enabled = false;
            this.dgvHosts.Location = new System.Drawing.Point(574, 23);
            this.dgvHosts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHosts.Name = "dgvHosts";
            this.dgvHosts.RowHeadersWidth = 51;
            this.dgvHosts.Size = new System.Drawing.Size(468, 320);
            this.dgvHosts.TabIndex = 16;
            this.dgvHosts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHosts_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalHostlbl);
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.btnAddHost);
            this.groupBox3.Controls.Add(this.numHost);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(8, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(558, 123);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Hosts:";
            // 
            // totalHostlbl
            // 
            this.totalHostlbl.AutoSize = true;
            this.totalHostlbl.Enabled = false;
            this.totalHostlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalHostlbl.Location = new System.Drawing.Point(9, 95);
            this.totalHostlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalHostlbl.Name = "totalHostlbl";
            this.totalHostlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalHostlbl.Size = new System.Drawing.Size(108, 17);
            this.totalHostlbl.TabIndex = 17;
            this.totalHostlbl.Text = "Total de Hosts: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(426, 43);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAddHost
            // 
            this.btnAddHost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddHost.Enabled = false;
            this.btnAddHost.Location = new System.Drawing.Point(318, 43);
            this.btnAddHost.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(100, 28);
            this.btnAddHost.TabIndex = 15;
            this.btnAddHost.Text = "Adicionar";
            this.btnAddHost.UseVisualStyleBackColor = false;
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // numHost
            // 
            this.numHost.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numHost.Enabled = false;
            this.numHost.Location = new System.Drawing.Point(171, 43);
            this.numHost.Margin = new System.Windows.Forms.Padding(4);
            this.numHost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHost.Name = "numHost";
            this.numHost.Size = new System.Drawing.Size(113, 22);
            this.numHost.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantidades de Hosts:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskBinario);
            this.groupBox2.Controls.Add(this.ipBinario);
            this.groupBox2.Controls.Add(this.btnRecomeço);
            this.groupBox2.Controls.Add(this.outIPBase);
            this.groupBox2.Controls.Add(this.oct1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnProsseguir);
            this.groupBox2.Controls.Add(this.oct2);
            this.groupBox2.Controls.Add(this.outMascara);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.oct3);
            this.groupBox2.Controls.Add(this.outClasse);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.oct4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(8, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(558, 196);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seu IP aqui:";
            // 
            // maskBinario
            // 
            this.maskBinario.AutoSize = true;
            this.maskBinario.Location = new System.Drawing.Point(8, 167);
            this.maskBinario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maskBinario.Name = "maskBinario";
            this.maskBinario.Size = new System.Drawing.Size(114, 17);
            this.maskBinario.TabIndex = 17;
            this.maskBinario.Text = "Máscara Binário:";
            // 
            // ipBinario
            // 
            this.ipBinario.AutoSize = true;
            this.ipBinario.Location = new System.Drawing.Point(8, 145);
            this.ipBinario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipBinario.Name = "ipBinario";
            this.ipBinario.Size = new System.Drawing.Size(72, 17);
            this.ipBinario.TabIndex = 16;
            this.ipBinario.Text = "IP Binário:";
            // 
            // btnRecomeço
            // 
            this.btnRecomeço.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecomeço.Location = new System.Drawing.Point(426, 95);
            this.btnRecomeço.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecomeço.Name = "btnRecomeço";
            this.btnRecomeço.Size = new System.Drawing.Size(100, 28);
            this.btnRecomeço.TabIndex = 15;
            this.btnRecomeço.Text = "Recomeçar";
            this.btnRecomeço.UseVisualStyleBackColor = false;
            this.btnRecomeço.Click += new System.EventHandler(this.btnRecomeço_Click);
            // 
            // outIPBase
            // 
            this.outIPBase.AutoSize = true;
            this.outIPBase.Location = new System.Drawing.Point(8, 90);
            this.outIPBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outIPBase.Name = "outIPBase";
            this.outIPBase.Size = new System.Drawing.Size(60, 17);
            this.outIPBase.TabIndex = 14;
            this.outIPBase.Text = "IP Base:";
            // 
            // oct1
            // 
            this.oct1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.oct1.Location = new System.Drawing.Point(8, 23);
            this.oct1.Margin = new System.Windows.Forms.Padding(4);
            this.oct1.MaxLength = 3;
            this.oct1.Name = "oct1";
            this.oct1.Size = new System.Drawing.Size(72, 22);
            this.oct1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProsseguir.Location = new System.Drawing.Point(426, 21);
            this.btnProsseguir.Margin = new System.Windows.Forms.Padding(4);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(100, 28);
            this.btnProsseguir.TabIndex = 11;
            this.btnProsseguir.Text = "Prosseguir...";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // oct2
            // 
            this.oct2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.oct2.Location = new System.Drawing.Point(111, 23);
            this.oct2.Margin = new System.Windows.Forms.Padding(4);
            this.oct2.MaxLength = 3;
            this.oct2.Name = "oct2";
            this.oct2.Size = new System.Drawing.Size(72, 22);
            this.oct2.TabIndex = 2;
            // 
            // outMascara
            // 
            this.outMascara.AutoSize = true;
            this.outMascara.Location = new System.Drawing.Point(8, 117);
            this.outMascara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outMascara.Name = "outMascara";
            this.outMascara.Size = new System.Drawing.Size(66, 17);
            this.outMascara.TabIndex = 10;
            this.outMascara.Text = "Máscara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // oct3
            // 
            this.oct3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.oct3.Location = new System.Drawing.Point(213, 23);
            this.oct3.Margin = new System.Windows.Forms.Padding(4);
            this.oct3.MaxLength = 3;
            this.oct3.Name = "oct3";
            this.oct3.Size = new System.Drawing.Size(72, 22);
            this.oct3.TabIndex = 4;
            // 
            // outClasse
            // 
            this.outClasse.AutoSize = true;
            this.outClasse.Location = new System.Drawing.Point(8, 63);
            this.outClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outClasse.Name = "outClasse";
            this.outClasse.Size = new System.Drawing.Size(54, 17);
            this.outClasse.TabIndex = 9;
            this.outClasse.Text = "Classe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // oct4
            // 
            this.oct4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.oct4.Location = new System.Drawing.Point(316, 23);
            this.oct4.Margin = new System.Windows.Forms.Padding(4);
            this.oct4.MaxLength = 3;
            this.oct4.Name = "oct4";
            this.oct4.Size = new System.Drawing.Size(72, 22);
            this.oct4.TabIndex = 6;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 510);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "Calculadora VLSM";
            this.Load += new System.EventHandler(this.View_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHost)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Label outMascara;
        private System.Windows.Forms.Label outClasse;
        private System.Windows.Forms.TextBox oct4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oct3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oct2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oct1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.NumericUpDown numHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListaResultados;
        private System.Windows.Forms.DataGridView dgvHosts;
        private System.Windows.Forms.Label totalHostlbl;
        private System.Windows.Forms.Button btnRecomeço;
        private System.Windows.Forms.Label outIPBase;
        private System.Windows.Forms.Label maskBinario;
        private System.Windows.Forms.Label ipBinario;
    }
}

