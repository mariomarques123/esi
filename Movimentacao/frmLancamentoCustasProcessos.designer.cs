namespace SAEA.Movimentacao
{
    partial class frmLancamentoCustasProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentoCustasProcessos));
            this.rbClientePaga = new System.Windows.Forms.RadioButton();
            this.rbAdvogadoPaga = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbPago = new System.Windows.Forms.CheckBox();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.ttbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbDescricaoCusta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbCodigoTipo = new System.Windows.Forms.TextBox();
            this.ttbNumeroProcesso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbCodigoCusta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbPagamento = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.ttbValorRecebido = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvResultado1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbPagamento.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbClientePaga
            // 
            this.rbClientePaga.AutoSize = true;
            this.rbClientePaga.Location = new System.Drawing.Point(23, 32);
            this.rbClientePaga.Name = "rbClientePaga";
            this.rbClientePaga.Size = new System.Drawing.Size(101, 17);
            this.rbClientePaga.TabIndex = 43;
            this.rbClientePaga.TabStop = true;
            this.rbClientePaga.Text = "Cliente irá pagar";
            this.rbClientePaga.UseVisualStyleBackColor = true;
            // 
            // rbAdvogadoPaga
            // 
            this.rbAdvogadoPaga.AutoSize = true;
            this.rbAdvogadoPaga.Location = new System.Drawing.Point(23, 55);
            this.rbAdvogadoPaga.Name = "rbAdvogadoPaga";
            this.rbAdvogadoPaga.Size = new System.Drawing.Size(120, 17);
            this.rbAdvogadoPaga.TabIndex = 45;
            this.rbAdvogadoPaga.TabStop = true;
            this.rbAdvogadoPaga.Text = "Advocacia irá pagar";
            this.rbAdvogadoPaga.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Número do processo *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Valor total a ser pago *";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(152, 96);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(124, 20);
            this.dtpVencimento.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Vencimento *";
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(121, 46);
            this.ttbDescricao.MaxLength = 100;
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(204, 20);
            this.ttbDescricao.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descrição *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ccbPago
            // 
            this.ccbPago.AutoSize = true;
            this.ccbPago.Location = new System.Drawing.Point(23, 78);
            this.ccbPago.Name = "ccbPago";
            this.ccbPago.Size = new System.Drawing.Size(51, 17);
            this.ccbPago.TabIndex = 46;
            this.ccbPago.Text = "Pago";
            this.ccbPago.UseVisualStyleBackColor = true;
            this.ccbPago.CheckedChanged += new System.EventHandler(this.ccbPago_CheckedChanged);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.ttbValorTotal);
            this.grbDados.Controls.Add(this.groupBox4);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.ttbNumeroProcesso);
            this.grbDados.Controls.Add(this.dtpVencimento);
            this.grbDados.Controls.Add(this.label7);
            this.grbDados.Controls.Add(this.ttbCodigoCusta);
            this.grbDados.Controls.Add(this.groupBox2);
            this.grbDados.Controls.Add(this.button1);
            this.grbDados.Controls.Add(this.label4);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.ttbDescricao);
            this.grbDados.Controls.Add(this.label1);
            this.grbDados.Enabled = false;
            this.grbDados.Location = new System.Drawing.Point(12, 76);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(571, 299);
            this.grbDados.TabIndex = 48;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados da custa";
            // 
            // ttbValorTotal
            // 
            this.ttbValorTotal.Location = new System.Drawing.Point(18, 96);
            this.ttbValorTotal.Mask = "$0000000.00";
            this.ttbValorTotal.Name = "ttbValorTotal";
            this.ttbValorTotal.Size = new System.Drawing.Size(104, 20);
            this.ttbValorTotal.TabIndex = 52;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.ttbDescricaoCusta);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ttbCodigoTipo);
            this.groupBox4.Location = new System.Drawing.Point(18, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 120);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo do custo *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Descrição";
            // 
            // ttbDescricaoCusta
            // 
            this.ttbDescricaoCusta.Enabled = false;
            this.ttbDescricaoCusta.Location = new System.Drawing.Point(18, 80);
            this.ttbDescricaoCusta.Name = "ttbDescricaoCusta";
            this.ttbDescricaoCusta.Size = new System.Drawing.Size(141, 20);
            this.ttbDescricaoCusta.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(100, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 51;
            this.button2.Text = "Localizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Código";
            // 
            // ttbCodigoTipo
            // 
            this.ttbCodigoTipo.Enabled = false;
            this.ttbCodigoTipo.Location = new System.Drawing.Point(18, 38);
            this.ttbCodigoTipo.Name = "ttbCodigoTipo";
            this.ttbCodigoTipo.Size = new System.Drawing.Size(74, 20);
            this.ttbCodigoTipo.TabIndex = 52;
            // 
            // ttbNumeroProcesso
            // 
            this.ttbNumeroProcesso.Enabled = false;
            this.ttbNumeroProcesso.Location = new System.Drawing.Point(366, 59);
            this.ttbNumeroProcesso.Name = "ttbNumeroProcesso";
            this.ttbNumeroProcesso.Size = new System.Drawing.Size(131, 20);
            this.ttbNumeroProcesso.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Código";
            // 
            // ttbCodigoCusta
            // 
            this.ttbCodigoCusta.Enabled = false;
            this.ttbCodigoCusta.Location = new System.Drawing.Point(18, 46);
            this.ttbCodigoCusta.Name = "ttbCodigoCusta";
            this.ttbCodigoCusta.Size = new System.Drawing.Size(74, 20);
            this.ttbCodigoCusta.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grbPagamento);
            this.groupBox2.Controls.Add(this.rbClientePaga);
            this.groupBox2.Controls.Add(this.ccbPago);
            this.groupBox2.Controls.Add(this.rbAdvogadoPaga);
            this.groupBox2.Location = new System.Drawing.Point(220, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 152);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pagamento *";
            // 
            // grbPagamento
            // 
            this.grbPagamento.Controls.Add(this.label5);
            this.grbPagamento.Controls.Add(this.label9);
            this.grbPagamento.Controls.Add(this.dtpPagamento);
            this.grbPagamento.Controls.Add(this.ttbValorRecebido);
            this.grbPagamento.Enabled = false;
            this.grbPagamento.Location = new System.Drawing.Point(171, 22);
            this.grbPagamento.Name = "grbPagamento";
            this.grbPagamento.Size = new System.Drawing.Size(157, 124);
            this.grbPagamento.TabIndex = 53;
            this.grbPagamento.TabStop = false;
            this.grbPagamento.Text = "Pagamento já realizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Data de Pagamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Valor Pago";
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamento.Location = new System.Drawing.Point(15, 90);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(124, 20);
            this.dtpPagamento.TabIndex = 57;
            // 
            // ttbValorRecebido
            // 
            this.ttbValorRecebido.Location = new System.Drawing.Point(15, 46);
            this.ttbValorRecebido.Mask = "$0000000.00";
            this.ttbValorRecebido.Name = "ttbValorRecebido";
            this.ttbValorRecebido.Size = new System.Drawing.Size(78, 20);
            this.ttbValorRecebido.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(503, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Localizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Custas deste processo";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(595, 70);
            this.pnlBotoes.TabIndex = 49;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(300, 0);
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
            this.btnSair.Location = new System.Drawing.Point(520, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(225, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(150, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 70);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(75, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 70);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 70);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvResultado1
            // 
            this.dgvResultado1.AllowUserToAddRows = false;
            this.dgvResultado1.AllowUserToDeleteRows = false;
            this.dgvResultado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3});
            this.dgvResultado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultado1.Location = new System.Drawing.Point(0, 403);
            this.dgvResultado1.MultiSelect = false;
            this.dgvResultado1.Name = "dgvResultado1";
            this.dgvResultado1.ReadOnly = true;
            this.dgvResultado1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado1.Size = new System.Drawing.Size(595, 168);
            this.dgvResultado1.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cus_codigo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cus_valor";
            this.Column5.HeaderText = "Valor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "cus_descricao";
            this.Column6.HeaderText = "Descricao";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tic_codigo";
            this.Column2.HeaderText = "Codigo do tipo do custo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "rece_valorrecebido";
            this.Column3.HeaderText = "Valor pago";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmLancamentoCustasProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 571);
            this.Controls.Add(this.dgvResultado1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLancamentoCustasProcessos";
            this.Text = " Lançamento de custas de processos ";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbPagamento.ResumeLayout(false);
            this.grbPagamento.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClientePaga;
        private System.Windows.Forms.RadioButton rbAdvogadoPaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ccbPago;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbCodigoCusta;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox ttbNumeroProcesso;
        private System.Windows.Forms.MaskedTextBox ttbValorTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbDescricaoCusta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbCodigoTipo;
        private System.Windows.Forms.GroupBox grbPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.MaskedTextBox ttbValorRecebido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvResultado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}