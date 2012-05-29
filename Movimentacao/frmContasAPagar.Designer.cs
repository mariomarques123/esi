namespace SAEA.Movimentacao
{
    partial class frmContasAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasAPagar));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbFunc = new System.Windows.Forms.ComboBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataVenc = new System.Windows.Forms.DateTimePicker();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ggbHistorico = new System.Windows.Forms.GroupBox();
            this.rbtVencidas = new System.Windows.Forms.RadioButton();
            this.rbtPagas = new System.Windows.Forms.RadioButton();
            this.rbtAberto = new System.Windows.Forms.RadioButton();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.rbtVencProx = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ggbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(832, 70);
            this.pnlBotoes.TabIndex = 12;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(757, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(150, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 70);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(75, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 70);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Lançar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 70);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbFunc);
            this.groupBox1.Controls.Add(this.mtbValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDataVenc);
            this.groupBox1.Controls.Add(this.ttbDescricao);
            this.groupBox1.Controls.Add(this.ttbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 136);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Funcionário";
            // 
            // cbbFunc
            // 
            this.cbbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFunc.FormattingEnabled = true;
            this.cbbFunc.Location = new System.Drawing.Point(213, 93);
            this.cbbFunc.Name = "cbbFunc";
            this.cbbFunc.Size = new System.Drawing.Size(573, 21);
            this.cbbFunc.TabIndex = 47;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(114, 93);
            this.mtbValor.Mask = "$00000.00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(84, 20);
            this.mtbValor.TabIndex = 58;
            this.mtbValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbValor_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Valor *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vencimento *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Código";
            // 
            // dtpDataVenc
            // 
            this.dtpDataVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenc.Location = new System.Drawing.Point(16, 94);
            this.dtpDataVenc.Name = "dtpDataVenc";
            this.dtpDataVenc.Size = new System.Drawing.Size(85, 20);
            this.dtpDataVenc.TabIndex = 4;
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(114, 47);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(672, 20);
            this.ttbDescricao.TabIndex = 6;
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(16, 47);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(92, 20);
            this.ttbCodigo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 656);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "(*) Campo de preenchimento obrigatório.";
            // 
            // ggbHistorico
            // 
            this.ggbHistorico.Controls.Add(this.rbtVencidas);
            this.ggbHistorico.Controls.Add(this.rbtPagas);
            this.ggbHistorico.Controls.Add(this.rbtAberto);
            this.ggbHistorico.Controls.Add(this.dgvHistorico);
            this.ggbHistorico.Controls.Add(this.rbtVencProx);
            this.ggbHistorico.Location = new System.Drawing.Point(12, 218);
            this.ggbHistorico.Name = "ggbHistorico";
            this.ggbHistorico.Size = new System.Drawing.Size(808, 435);
            this.ggbHistorico.TabIndex = 49;
            this.ggbHistorico.TabStop = false;
            this.ggbHistorico.Text = "Histórico de contas";
            // 
            // rbtVencidas
            // 
            this.rbtVencidas.AutoSize = true;
            this.rbtVencidas.Location = new System.Drawing.Point(717, 30);
            this.rbtVencidas.Name = "rbtVencidas";
            this.rbtVencidas.Size = new System.Drawing.Size(69, 17);
            this.rbtVencidas.TabIndex = 2;
            this.rbtVencidas.Text = "Vencidas";
            this.rbtVencidas.UseVisualStyleBackColor = true;
            this.rbtVencidas.CheckedChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // rbtPagas
            // 
            this.rbtPagas.AutoSize = true;
            this.rbtPagas.Location = new System.Drawing.Point(643, 30);
            this.rbtPagas.Name = "rbtPagas";
            this.rbtPagas.Size = new System.Drawing.Size(55, 17);
            this.rbtPagas.TabIndex = 2;
            this.rbtPagas.Text = "Pagas";
            this.rbtPagas.UseVisualStyleBackColor = true;
            this.rbtPagas.CheckedChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // rbtAberto
            // 
            this.rbtAberto.AutoSize = true;
            this.rbtAberto.Location = new System.Drawing.Point(555, 30);
            this.rbtAberto.Name = "rbtAberto";
            this.rbtAberto.Size = new System.Drawing.Size(73, 17);
            this.rbtAberto.TabIndex = 2;
            this.rbtAberto.Text = "Em aberto";
            this.rbtAberto.UseVisualStyleBackColor = true;
            this.rbtAberto.CheckedChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.AllowUserToOrderColumns = true;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5});
            this.dgvHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistorico.Location = new System.Drawing.Point(3, 63);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(802, 369);
            this.dgvHistorico.TabIndex = 0;
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
            // 
            // rbtVencProx
            // 
            this.rbtVencProx.AutoSize = true;
            this.rbtVencProx.Checked = true;
            this.rbtVencProx.Location = new System.Drawing.Point(16, 30);
            this.rbtVencProx.Name = "rbtVencProx";
            this.rbtVencProx.Size = new System.Drawing.Size(130, 17);
            this.rbtVencProx.TabIndex = 1;
            this.rbtVencProx.TabStop = true;
            this.rbtVencProx.Text = "Próximos vencimentos";
            this.rbtVencProx.UseVisualStyleBackColor = true;
            this.rbtVencProx.CheckedChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "cop_codigo";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "cop_descricao";
            this.Column6.HeaderText = "Descrição";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "cop_valor";
            this.Column3.HeaderText = "Valor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "cop_dataPag";
            this.Column4.HeaderText = "Data Pagamento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 103;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "cop_dataVenc";
            this.Column2.HeaderText = "Data Vencimento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "fun_codigo";
            this.Column5.HeaderText = "Funcionário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 87;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.Location = new System.Drawing.Point(225, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 70);
            this.btnSelecionar.TabIndex = 9;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ggbHistorico);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "frmContasAPagar";
            this.Text = "Contas a Pagar";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ggbHistorico.ResumeLayout(false);
            this.ggbHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataVenc;
        private System.Windows.Forms.GroupBox ggbHistorico;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.RadioButton rbtVencProx;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtVencidas;
        private System.Windows.Forms.RadioButton rbtPagas;
        private System.Windows.Forms.RadioButton rbtAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSelecionar;
    }
}