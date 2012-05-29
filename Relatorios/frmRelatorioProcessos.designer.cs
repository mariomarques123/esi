namespace SAEA.Relatorios
{
    partial class frmRelatorioProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioProcessos));
            this.a = new System.Windows.Forms.GroupBox();
            this.rbClienteUnico = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.rbArquivado = new System.Windows.Forms.RadioButton();
            this.rbCGrupoCliente = new System.Windows.Forms.RadioButton();
            this.rbSemFiltro = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.rbClienteUnico);
            this.a.Controls.Add(this.button2);
            this.a.Controls.Add(this.rbAndamento);
            this.a.Controls.Add(this.ttbNome);
            this.a.Controls.Add(this.rbArquivado);
            this.a.Controls.Add(this.rbCGrupoCliente);
            this.a.Controls.Add(this.rbSemFiltro);
            this.a.Location = new System.Drawing.Point(12, 76);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(610, 83);
            this.a.TabIndex = 34;
            this.a.TabStop = false;
            this.a.Text = "Filtros";
            // 
            // rbClienteUnico
            // 
            this.rbClienteUnico.AutoSize = true;
            this.rbClienteUnico.Location = new System.Drawing.Point(336, 49);
            this.rbClienteUnico.Name = "rbClienteUnico";
            this.rbClienteUnico.Size = new System.Drawing.Size(78, 17);
            this.rbClienteUnico.TabIndex = 41;
            this.rbClienteUnico.Text = "Por cliente:";
            this.rbClienteUnico.UseVisualStyleBackColor = true;
            this.rbClienteUnico.CheckedChanged += new System.EventHandler(this.rbClienteUnico_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(526, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Localizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbAndamento
            // 
            this.rbAndamento.AutoSize = true;
            this.rbAndamento.Location = new System.Drawing.Point(23, 49);
            this.rbAndamento.Name = "rbAndamento";
            this.rbAndamento.Size = new System.Drawing.Size(96, 17);
            this.rbAndamento.TabIndex = 7;
            this.rbAndamento.Text = "Em andamento";
            this.rbAndamento.UseVisualStyleBackColor = true;
            this.rbAndamento.CheckedChanged += new System.EventHandler(this.rbClienteUnico_CheckedChanged);
            // 
            // ttbNome
            // 
            this.ttbNome.Enabled = false;
            this.ttbNome.Location = new System.Drawing.Point(420, 48);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(100, 20);
            this.ttbNome.TabIndex = 38;
            // 
            // rbArquivado
            // 
            this.rbArquivado.AutoSize = true;
            this.rbArquivado.Location = new System.Drawing.Point(153, 49);
            this.rbArquivado.Name = "rbArquivado";
            this.rbArquivado.Size = new System.Drawing.Size(73, 17);
            this.rbArquivado.TabIndex = 8;
            this.rbArquivado.Text = "Arquivado";
            this.rbArquivado.UseVisualStyleBackColor = true;
            this.rbArquivado.CheckedChanged += new System.EventHandler(this.rbClienteUnico_CheckedChanged);
            // 
            // rbCGrupoCliente
            // 
            this.rbCGrupoCliente.AutoSize = true;
            this.rbCGrupoCliente.Location = new System.Drawing.Point(153, 26);
            this.rbCGrupoCliente.Name = "rbCGrupoCliente";
            this.rbCGrupoCliente.Size = new System.Drawing.Size(123, 17);
            this.rbCGrupoCliente.TabIndex = 5;
            this.rbCGrupoCliente.Text = "Agrupado por cliente";
            this.rbCGrupoCliente.UseVisualStyleBackColor = true;
            this.rbCGrupoCliente.CheckedChanged += new System.EventHandler(this.rbClienteUnico_CheckedChanged);
            // 
            // rbSemFiltro
            // 
            this.rbSemFiltro.AutoSize = true;
            this.rbSemFiltro.Location = new System.Drawing.Point(23, 26);
            this.rbSemFiltro.Name = "rbSemFiltro";
            this.rbSemFiltro.Size = new System.Drawing.Size(68, 17);
            this.rbSemFiltro.TabIndex = 6;
            this.rbSemFiltro.Text = "Sem filtro";
            this.rbSemFiltro.UseVisualStyleBackColor = true;
            this.rbSemFiltro.CheckedChanged += new System.EventHandler(this.rbClienteUnico_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column14});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(634, 397);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cli_nome";
            this.Column1.HeaderText = "Nome do cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fun_nome";
            this.Column2.HeaderText = "Advogado Responsável";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pro_numero";
            this.Column3.HeaderText = "Número do processo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "pro_forum";
            this.Column4.HeaderText = "Forum";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pro_vara";
            this.Column5.HeaderText = "Vara";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "pro_clientenpcusto";
            this.Column6.HeaderText = "Cliente paga custo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pro_tipo";
            this.Column7.HeaderText = "Tipo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pro_datadistribuicao";
            this.Column8.HeaderText = "Data distribuição";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "pro_area";
            this.Column9.HeaderText = "Area";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "pro_local";
            this.Column10.HeaderText = "Local";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "pro_situacao";
            this.Column11.HeaderText = "Situação";
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
            // Column13
            // 
            this.Column13.DataPropertyName = "pro_descricao";
            this.Column13.HeaderText = "Descrição";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "TOTAL";
            this.Column14.HeaderText = "TOTAL";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnGerar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(634, 70);
            this.pnlBotoes.TabIndex = 37;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(559, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(75, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 70);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            // frmRelatorioProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.a);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioProcessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de processos";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbAndamento;
        private System.Windows.Forms.RadioButton rbArquivado;
        private System.Windows.Forms.RadioButton rbCGrupoCliente;
        private System.Windows.Forms.RadioButton rbSemFiltro;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbClienteUnico;
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
    }
}