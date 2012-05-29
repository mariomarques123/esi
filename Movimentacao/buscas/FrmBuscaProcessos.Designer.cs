namespace SAEA.Movimentacao.buscas
{
    partial class FrmBuscaProcessos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaProcessos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.ttbArea = new System.Windows.Forms.TextBox();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbNumero = new System.Windows.Forms.RadioButton();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Área = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNumero);
            this.groupBox1.Controls.Add(this.ttbArea);
            this.groupBox1.Controls.Add(this.rbArea);
            this.groupBox1.Controls.Add(this.rbNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 113);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(140, 31);
            this.ttbNumero.MaxLength = 35;
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(147, 20);
            this.ttbNumero.TabIndex = 52;
            // 
            // ttbArea
            // 
            this.ttbArea.Location = new System.Drawing.Point(140, 55);
            this.ttbArea.MaxLength = 100;
            this.ttbArea.Name = "ttbArea";
            this.ttbArea.Size = new System.Drawing.Size(147, 20);
            this.ttbArea.TabIndex = 51;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(17, 55);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(89, 17);
            this.rbArea.TabIndex = 49;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Área de ação";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.rbConta_CheckedChanged);
            // 
            // rbNumero
            // 
            this.rbNumero.AutoSize = true;
            this.rbNumero.Location = new System.Drawing.Point(17, 32);
            this.rbNumero.Name = "rbNumero";
            this.rbNumero.Size = new System.Drawing.Size(123, 17);
            this.rbNumero.TabIndex = 48;
            this.rbNumero.TabStop = true;
            this.rbNumero.Text = "Número do processo";
            this.rbNumero.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(494, 70);
            this.pnlBotoes.TabIndex = 50;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(419, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.Location = new System.Drawing.Point(75, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 70);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 70);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Área,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column6,
            this.Column11,
            this.Column12,
            this.c13});
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultado.Location = new System.Drawing.Point(0, 201);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(494, 320);
            this.dgvResultado.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pro_numero";
            this.Column1.HeaderText = "Número";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pro_forum";
            this.Column2.HeaderText = "Forum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "pro_vara";
            this.Column4.HeaderText = "Vara";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pro_tipo";
            this.Column5.HeaderText = "Tipo de ação";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pro_datadistribuicao";
            this.Column3.HeaderText = "Data de distribuição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Área
            // 
            this.Área.DataPropertyName = "pro_area";
            this.Área.HeaderText = "Área de ação";
            this.Área.Name = "Área";
            this.Área.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pro_local";
            this.Column7.HeaderText = "Local";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pro_nivelacesso";
            this.Column8.HeaderText = "Nivel de Acesso";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "pro_situacao";
            this.Column9.HeaderText = "Situação";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "fun_advresp";
            this.Column10.HeaderText = "Advogado responsável";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fun_nome";
            this.Column6.HeaderText = "Nome funcionário";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "pro_descricao";
            this.Column11.HeaderText = "Descrição";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "pro_juiz";
            this.Column12.HeaderText = "Juiz";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // c13
            // 
            this.c13.DataPropertyName = "pro_clientenpcusto";
            this.c13.HeaderText = "Custo Cliente";
            this.c13.Name = "c13";
            this.c13.ReadOnly = true;
            // 
            // FrmBuscaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dgvResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscaProcessos";
            this.Text = "Busca de processos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbArea;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.RadioButton rbNumero;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Área;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn c13;
    }
}