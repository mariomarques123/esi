namespace SAEA.Movimentacao
{
    partial class frmMovimentacaoConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoConta));
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtUltimosLan = new System.Windows.Forms.RadioButton();
            this.rbtPeriodo = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.rbtTipo = new System.Windows.Forms.RadioButton();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.ggbHistorico = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbbLancamento = new System.Windows.Forms.GroupBox();
            this.cbbOrigem = new System.Windows.Forms.ComboBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalizar2 = new System.Windows.Forms.Button();
            this.rbtTrans = new System.Windows.Forms.RadioButton();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtDebito = new System.Windows.Forms.RadioButton();
            this.rbtCredito = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLocalizarLan = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.ggbHistorico.SuspendLayout();
            this.gbbLancamento.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvHistorico.Location = new System.Drawing.Point(3, 72);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(711, 270);
            this.dgvHistorico.TabIndex = 0;
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
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
            this.Column5.DataPropertyName = "Con_Codigo";
            this.Column5.HeaderText = "Conta";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "mov_codDestino";
            this.Column6.HeaderText = "Conta Destino";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // rbtUltimosLan
            // 
            this.rbtUltimosLan.AutoSize = true;
            this.rbtUltimosLan.Checked = true;
            this.rbtUltimosLan.Location = new System.Drawing.Point(16, 45);
            this.rbtUltimosLan.Name = "rbtUltimosLan";
            this.rbtUltimosLan.Size = new System.Drawing.Size(126, 17);
            this.rbtUltimosLan.TabIndex = 1;
            this.rbtUltimosLan.TabStop = true;
            this.rbtUltimosLan.Text = "Últimos Lançamentos";
            this.rbtUltimosLan.UseVisualStyleBackColor = true;
            this.rbtUltimosLan.CheckedChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // rbtPeriodo
            // 
            this.rbtPeriodo.AutoSize = true;
            this.rbtPeriodo.Location = new System.Drawing.Point(179, 45);
            this.rbtPeriodo.Name = "rbtPeriodo";
            this.rbtPeriodo.Size = new System.Drawing.Size(63, 17);
            this.rbtPeriodo.TabIndex = 1;
            this.rbtPeriodo.Text = "Período";
            this.rbtPeriodo.UseVisualStyleBackColor = true;
            this.rbtPeriodo.CheckedChanged += new System.EventHandler(this.rbtPeriodo_CheckedChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Enabled = false;
            this.lblA.Location = new System.Drawing.Point(337, 45);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "à";
            // 
            // dtpIni
            // 
            this.dtpIni.Enabled = false;
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(246, 42);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(85, 20);
            this.dtpIni.TabIndex = 4;
            this.dtpIni.ValueChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Enabled = false;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(356, 41);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(83, 20);
            this.dtpFim.TabIndex = 4;
            this.dtpFim.ValueChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // rbtTipo
            // 
            this.rbtTipo.AutoSize = true;
            this.rbtTipo.Location = new System.Drawing.Point(469, 44);
            this.rbtTipo.Name = "rbtTipo";
            this.rbtTipo.Size = new System.Drawing.Size(46, 17);
            this.rbtTipo.TabIndex = 1;
            this.rbtTipo.Text = "Tipo";
            this.rbtTipo.UseVisualStyleBackColor = true;
            this.rbtTipo.CheckedChanged += new System.EventHandler(this.rbtTipo_CheckedChanged);
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.Enabled = false;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(521, 40);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(172, 21);
            this.cbbTipo.TabIndex = 5;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(14, 32);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(92, 20);
            this.ttbCodigo.TabIndex = 6;
            // 
            // ggbHistorico
            // 
            this.ggbHistorico.Controls.Add(this.dgvHistorico);
            this.ggbHistorico.Controls.Add(this.cbbTipo);
            this.ggbHistorico.Controls.Add(this.dtpFim);
            this.ggbHistorico.Controls.Add(this.rbtUltimosLan);
            this.ggbHistorico.Controls.Add(this.dtpIni);
            this.ggbHistorico.Controls.Add(this.rbtTipo);
            this.ggbHistorico.Controls.Add(this.lblA);
            this.ggbHistorico.Controls.Add(this.rbtPeriodo);
            this.ggbHistorico.Controls.Add(this.groupBox2);
            this.ggbHistorico.Location = new System.Drawing.Point(9, 145);
            this.ggbHistorico.Name = "ggbHistorico";
            this.ggbHistorico.Size = new System.Drawing.Size(717, 345);
            this.ggbHistorico.TabIndex = 7;
            this.ggbHistorico.TabStop = false;
            this.ggbHistorico.Text = "Histórico da conta concorrente";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // gbbLancamento
            // 
            this.gbbLancamento.Controls.Add(this.cbbOrigem);
            this.gbbLancamento.Controls.Add(this.mtbValor);
            this.gbbLancamento.Controls.Add(this.label1);
            this.gbbLancamento.Controls.Add(this.btnLocalizar2);
            this.gbbLancamento.Controls.Add(this.rbtTrans);
            this.gbbLancamento.Controls.Add(this.lblOrigem);
            this.gbbLancamento.Controls.Add(this.label4);
            this.gbbLancamento.Controls.Add(this.rbtDebito);
            this.gbbLancamento.Controls.Add(this.rbtCredito);
            this.gbbLancamento.Controls.Add(this.dtpData);
            this.gbbLancamento.Location = new System.Drawing.Point(9, 496);
            this.gbbLancamento.Name = "gbbLancamento";
            this.gbbLancamento.Size = new System.Drawing.Size(717, 126);
            this.gbbLancamento.TabIndex = 8;
            this.gbbLancamento.TabStop = false;
            this.gbbLancamento.Text = "Lançamento";
            // 
            // cbbOrigem
            // 
            this.cbbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrigem.FormattingEnabled = true;
            this.cbbOrigem.Location = new System.Drawing.Point(252, 82);
            this.cbbOrigem.Name = "cbbOrigem";
            this.cbbOrigem.Size = new System.Drawing.Size(250, 21);
            this.cbbOrigem.TabIndex = 47;
            this.cbbOrigem.Visible = false;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(278, 46);
            this.mtbValor.Mask = "$00000.00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(87, 20);
            this.mtbValor.TabIndex = 58;
            this.mtbValor.TextChanged += new System.EventHandler(this.mtbValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Valor *";
            // 
            // btnLocalizar2
            // 
            this.btnLocalizar2.Location = new System.Drawing.Point(508, 80);
            this.btnLocalizar2.Name = "btnLocalizar2";
            this.btnLocalizar2.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar2.TabIndex = 13;
            this.btnLocalizar2.Text = "Localizar ";
            this.btnLocalizar2.UseVisualStyleBackColor = true;
            this.btnLocalizar2.Visible = false;
            this.btnLocalizar2.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // rbtTrans
            // 
            this.rbtTrans.AutoSize = true;
            this.rbtTrans.Location = new System.Drawing.Point(16, 90);
            this.rbtTrans.Name = "rbtTrans";
            this.rbtTrans.Size = new System.Drawing.Size(90, 17);
            this.rbtTrans.TabIndex = 0;
            this.rbtTrans.Text = "Transferência";
            this.rbtTrans.UseVisualStyleBackColor = true;
            this.rbtTrans.CheckedChanged += new System.EventHandler(this.rbtTrans_CheckedChanged);
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(170, 87);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(76, 13);
            this.lblOrigem.TabIndex = 9;
            this.lblOrigem.Text = "Conta origem *";
            this.lblOrigem.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data *";
            // 
            // rbtDebito
            // 
            this.rbtDebito.AutoSize = true;
            this.rbtDebito.Location = new System.Drawing.Point(16, 60);
            this.rbtDebito.Name = "rbtDebito";
            this.rbtDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtDebito.TabIndex = 0;
            this.rbtDebito.Text = "Débito";
            this.rbtDebito.UseVisualStyleBackColor = true;
            // 
            // rbtCredito
            // 
            this.rbtCredito.AutoSize = true;
            this.rbtCredito.Checked = true;
            this.rbtCredito.Location = new System.Drawing.Point(16, 31);
            this.rbtCredito.Name = "rbtCredito";
            this.rbtCredito.Size = new System.Drawing.Size(58, 17);
            this.rbtCredito.TabIndex = 0;
            this.rbtCredito.TabStop = true;
            this.rbtCredito.Text = "Crédito";
            this.rbtCredito.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(173, 46);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(85, 20);
            this.dtpData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conta corrente *";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnLocalizarLan);
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnRegistrar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(738, 70);
            this.pnlBotoes.TabIndex = 12;
            // 
            // btnLocalizarLan
            // 
            this.btnLocalizarLan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizarLan.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarLan.Image")));
            this.btnLocalizarLan.Location = new System.Drawing.Point(300, 0);
            this.btnLocalizarLan.Name = "btnLocalizarLan";
            this.btnLocalizarLan.Size = new System.Drawing.Size(75, 70);
            this.btnLocalizarLan.TabIndex = 9;
            this.btnLocalizarLan.Text = "Localizar";
            this.btnLocalizarLan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizarLan.UseVisualStyleBackColor = true;
            this.btnLocalizarLan.Click += new System.EventHandler(this.btnLocalizarLan_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.Location = new System.Drawing.Point(225, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 70);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(150, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 70);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(663, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(75, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 70);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(371, 29);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 13;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "(*) Campo de preenchimento obrigatório.";
            // 
            // cbbDestino
            // 
            this.cbbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDestino.FormattingEnabled = true;
            this.cbbDestino.Location = new System.Drawing.Point(115, 31);
            this.cbbDestino.Name = "cbbDestino";
            this.cbbDestino.Size = new System.Drawing.Size(250, 21);
            this.cbbDestino.TabIndex = 47;
            this.cbbDestino.SelectedIndexChanged += new System.EventHandler(this.cbbDestino_SelectedIndexChanged);
            this.cbbDestino.SelectionChangeCommitted += new System.EventHandler(this.rbtUltimosLan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDestino);
            this.groupBox1.Controls.Add(this.btnLocalizar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(9, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 63);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // frmMovimentacaoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.gbbLancamento);
            this.Controls.Add(this.ggbHistorico);
            this.Name = "frmMovimentacaoConta";
            this.Text = "Movimentacao Conta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ggbHistorico.ResumeLayout(false);
            this.ggbHistorico.PerformLayout();
            this.gbbLancamento.ResumeLayout(false);
            this.gbbLancamento.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.RadioButton rbtUltimosLan;
        private System.Windows.Forms.RadioButton rbtPeriodo;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.RadioButton rbtTipo;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.GroupBox ggbHistorico;
        private System.Windows.Forms.GroupBox gbbLancamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnLocalizar2;
        private System.Windows.Forms.RadioButton rbtTrans;
        private System.Windows.Forms.RadioButton rbtDebito;
        private System.Windows.Forms.RadioButton rbtCredito;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbOrigem;
        private System.Windows.Forms.ComboBox cbbDestino;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizarLan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}