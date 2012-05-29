namespace SAEA.Movimentacao
{
    partial class frmConsultaLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaLancamentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDebito = new System.Windows.Forms.RadioButton();
            this.rbtCredito = new System.Windows.Forms.RadioButton();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.rbtExibirTodos = new System.Windows.Forms.RadioButton();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.rbtPeriodo = new System.Windows.Forms.RadioButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.rbtValor = new System.Windows.Forms.RadioButton();
            this.mtbValorIni = new System.Windows.Forms.MaskedTextBox();
            this.lblA2 = new System.Windows.Forms.Label();
            this.mtbValorFim = new System.Windows.Forms.MaskedTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDebito);
            this.groupBox1.Controls.Add(this.rbtCredito);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.rbtExibirTodos);
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.rbtPeriodo);
            this.groupBox1.Location = new System.Drawing.Point(11, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbtDebito
            // 
            this.rbtDebito.AutoSize = true;
            this.rbtDebito.Location = new System.Drawing.Point(147, 27);
            this.rbtDebito.Name = "rbtDebito";
            this.rbtDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtDebito.TabIndex = 13;
            this.rbtDebito.Text = "Débito";
            this.rbtDebito.UseVisualStyleBackColor = true;
            // 
            // rbtCredito
            // 
            this.rbtCredito.AutoSize = true;
            this.rbtCredito.Location = new System.Drawing.Point(231, 28);
            this.rbtCredito.Name = "rbtCredito";
            this.rbtCredito.Size = new System.Drawing.Size(58, 17);
            this.rbtCredito.TabIndex = 12;
            this.rbtCredito.Text = "Crédito";
            this.rbtCredito.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            this.dtpFim.Enabled = false;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(497, 28);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(83, 20);
            this.dtpFim.TabIndex = 10;
            // 
            // rbtExibirTodos
            // 
            this.rbtExibirTodos.AutoSize = true;
            this.rbtExibirTodos.Checked = true;
            this.rbtExibirTodos.Location = new System.Drawing.Point(23, 27);
            this.rbtExibirTodos.Name = "rbtExibirTodos";
            this.rbtExibirTodos.Size = new System.Drawing.Size(79, 17);
            this.rbtExibirTodos.TabIndex = 6;
            this.rbtExibirTodos.TabStop = true;
            this.rbtExibirTodos.Text = "Exibir todos";
            this.rbtExibirTodos.UseVisualStyleBackColor = true;
            // 
            // dtpIni
            // 
            this.dtpIni.Enabled = false;
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(387, 28);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(85, 20);
            this.dtpIni.TabIndex = 11;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Enabled = false;
            this.lblA.Location = new System.Drawing.Point(478, 31);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "à";
            // 
            // rbtPeriodo
            // 
            this.rbtPeriodo.AutoSize = true;
            this.rbtPeriodo.Location = new System.Drawing.Point(320, 28);
            this.rbtPeriodo.Name = "rbtPeriodo";
            this.rbtPeriodo.Size = new System.Drawing.Size(63, 17);
            this.rbtPeriodo.TabIndex = 8;
            this.rbtPeriodo.Text = "Período";
            this.rbtPeriodo.UseVisualStyleBackColor = true;
            this.rbtPeriodo.CheckedChanged += new System.EventHandler(this.rbtPeriodo_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(663, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 67);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.Location = new System.Drawing.Point(75, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 67);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(738, 67);
            this.pnlBotoes.TabIndex = 15;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 67);
            this.btnLocalizar.TabIndex = 0;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.AllowUserToOrderColumns = true;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistorico.Location = new System.Drawing.Point(0, 144);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(738, 514);
            this.dgvHistorico.TabIndex = 16;
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
            // 
            // rbtValor
            // 
            this.rbtValor.AutoSize = true;
            this.rbtValor.Location = new System.Drawing.Point(391, 286);
            this.rbtValor.Name = "rbtValor";
            this.rbtValor.Size = new System.Drawing.Size(49, 17);
            this.rbtValor.TabIndex = 14;
            this.rbtValor.Text = "Valor";
            this.rbtValor.UseVisualStyleBackColor = true;
            this.rbtValor.Visible = false;
            this.rbtValor.CheckedChanged += new System.EventHandler(this.rbtValor_CheckedChanged);
            // 
            // mtbValorIni
            // 
            this.mtbValorIni.Enabled = false;
            this.mtbValorIni.Location = new System.Drawing.Point(458, 285);
            this.mtbValorIni.Mask = "$00000.00";
            this.mtbValorIni.Name = "mtbValorIni";
            this.mtbValorIni.Size = new System.Drawing.Size(85, 20);
            this.mtbValorIni.TabIndex = 59;
            this.mtbValorIni.Visible = false;
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Enabled = false;
            this.lblA2.Location = new System.Drawing.Point(549, 288);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(13, 13);
            this.lblA2.TabIndex = 9;
            this.lblA2.Text = "à";
            this.lblA2.Visible = false;
            // 
            // mtbValorFim
            // 
            this.mtbValorFim.Enabled = false;
            this.mtbValorFim.Location = new System.Drawing.Point(568, 286);
            this.mtbValorFim.Mask = "$00000.00";
            this.mtbValorFim.Name = "mtbValorFim";
            this.mtbValorFim.Size = new System.Drawing.Size(83, 20);
            this.mtbValorFim.TabIndex = 59;
            this.mtbValorFim.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "mov_codigo";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "mov_data";
            this.Column2.HeaderText = "Data";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 55;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "mov_valor";
            this.Column3.HeaderText = "Valor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "mov_tipo";
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 53;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "con_numero";
            this.Column5.HeaderText = "Número da conta";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mov_codDestino";
            this.Column6.HeaderText = "Conta Destino";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // frmConsultaLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.mtbValorFim);
            this.Controls.Add(this.mtbValorIni);
            this.Controls.Add(this.rbtValor);
            this.Controls.Add(this.lblA2);
            this.MaximizeBox = false;
            this.Name = "frmConsultaLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Lançamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.RadioButton rbtExibirTodos;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton rbtPeriodo;
        private System.Windows.Forms.RadioButton rbtDebito;
        private System.Windows.Forms.RadioButton rbtCredito;
        private System.Windows.Forms.RadioButton rbtValor;
        private System.Windows.Forms.MaskedTextBox mtbValorFim;
        private System.Windows.Forms.MaskedTextBox mtbValorIni;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}