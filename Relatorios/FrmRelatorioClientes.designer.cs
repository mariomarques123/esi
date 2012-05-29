namespace SAEA.Relatorios
{
    partial class FrmRelatorioClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioClientes));
            this.a = new System.Windows.Forms.GroupBox();
            this.rbBuscaCidade = new System.Windows.Forms.RadioButton();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.rbGrupoCidade = new System.Windows.Forms.RadioButton();
            this.rbSem = new System.Windows.Forms.RadioButton();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.rbBuscaCidade);
            this.a.Controls.Add(this.ttbNome);
            this.a.Controls.Add(this.rbAndamento);
            this.a.Controls.Add(this.rbGrupoCidade);
            this.a.Controls.Add(this.rbSem);
            this.a.Location = new System.Drawing.Point(12, 76);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(539, 97);
            this.a.TabIndex = 8;
            this.a.TabStop = false;
            this.a.Text = "Filtros";
            // 
            // rbBuscaCidade
            // 
            this.rbBuscaCidade.AutoSize = true;
            this.rbBuscaCidade.Location = new System.Drawing.Point(175, 24);
            this.rbBuscaCidade.Name = "rbBuscaCidade";
            this.rbBuscaCidade.Size = new System.Drawing.Size(79, 17);
            this.rbBuscaCidade.TabIndex = 43;
            this.rbBuscaCidade.Text = "Por cidade:";
            this.rbBuscaCidade.UseVisualStyleBackColor = true;
            this.rbBuscaCidade.CheckedChanged += new System.EventHandler(this.rbBuscaCidade_CheckedChanged);
            // 
            // ttbNome
            // 
            this.ttbNome.Enabled = false;
            this.ttbNome.Location = new System.Drawing.Point(259, 23);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(100, 20);
            this.ttbNome.TabIndex = 42;
            // 
            // rbAndamento
            // 
            this.rbAndamento.AutoSize = true;
            this.rbAndamento.Location = new System.Drawing.Point(27, 47);
            this.rbAndamento.Name = "rbAndamento";
            this.rbAndamento.Size = new System.Drawing.Size(96, 17);
            this.rbAndamento.TabIndex = 10;
            this.rbAndamento.Text = "Em andamento";
            this.rbAndamento.UseVisualStyleBackColor = true;
            // 
            // rbGrupoCidade
            // 
            this.rbGrupoCidade.AutoSize = true;
            this.rbGrupoCidade.Location = new System.Drawing.Point(27, 70);
            this.rbGrupoCidade.Name = "rbGrupoCidade";
            this.rbGrupoCidade.Size = new System.Drawing.Size(124, 17);
            this.rbGrupoCidade.TabIndex = 9;
            this.rbGrupoCidade.Text = "Agrupado por cidade";
            this.rbGrupoCidade.UseVisualStyleBackColor = true;
            // 
            // rbSem
            // 
            this.rbSem.AutoSize = true;
            this.rbSem.Checked = true;
            this.rbSem.Location = new System.Drawing.Point(27, 24);
            this.rbSem.Name = "rbSem";
            this.rbSem.Size = new System.Drawing.Size(68, 17);
            this.rbSem.TabIndex = 2;
            this.rbSem.TabStop = true;
            this.rbSem.Text = "Sem filtro";
            this.rbSem.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnGerar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(563, 70);
            this.pnlBotoes.TabIndex = 36;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(75, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 70);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(488, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSize = true;
            this.btnGerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.Location = new System.Drawing.Point(0, 0);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 70);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultado.Location = new System.Drawing.Point(0, 190);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(563, 217);
            this.dgvResultado.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cli_Codigo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cli_Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Cli_CPF";
            this.Column3.HeaderText = "CPF";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cli_CNPJ";
            this.Column4.HeaderText = "CNPJ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Cli_RG";
            this.Column5.HeaderText = "RG";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cli_Endereco";
            this.Column6.HeaderText = "Endereço";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Cli_Numero";
            this.Column7.HeaderText = "Número";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Cli_Bairro";
            this.Column8.HeaderText = "Bairro";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Cli_CEP";
            this.Column9.HeaderText = "CEP";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Cli_Cidade";
            this.Column10.HeaderText = "Cidade";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Cli_UF";
            this.Column11.HeaderText = "UF";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Cli_Email";
            this.Column12.HeaderText = "Email";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Cli_Telefone";
            this.Column13.HeaderText = "Telefone";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Cli_TelefoneComercial";
            this.Column14.HeaderText = "Telefone Comercial";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Cli_Celular";
            this.Column15.HeaderText = "Celular";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // FrmRelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 407);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Clientes";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.RadioButton rbSem;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbAndamento;
        private System.Windows.Forms.RadioButton rbGrupoCidade;
        private System.Windows.Forms.RadioButton rbBuscaCidade;
        private System.Windows.Forms.TextBox ttbNome;

    }
}