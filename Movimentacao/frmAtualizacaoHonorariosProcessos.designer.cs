namespace SAEA.Movimentacao
{
    partial class frmAtualizacaoHonorariosProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizacaoHonorariosProcessos));
            this.rbParcelado = new System.Windows.Forms.RadioButton();
            this.rbClienteNãoPaga = new System.Windows.Forms.RadioButton();
            this.rbParcelaUnica = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbNumeroProcesso = new System.Windows.Forms.TextBox();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ttbDescParcela = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Rece_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rece_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rece_dataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbResultadoParcela = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.ttbQuantidadePar = new System.Windows.Forms.MaskedTextBox();
            this.ttbDiasParcelas = new System.Windows.Forms.MaskedTextBox();
            this.ttbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbParcelado
            // 
            this.rbParcelado.AutoSize = true;
            this.rbParcelado.Location = new System.Drawing.Point(16, 31);
            this.rbParcelado.Name = "rbParcelado";
            this.rbParcelado.Size = new System.Drawing.Size(73, 17);
            this.rbParcelado.TabIndex = 28;
            this.rbParcelado.TabStop = true;
            this.rbParcelado.Text = "Parcelado";
            this.rbParcelado.UseVisualStyleBackColor = true;
            this.rbParcelado.CheckedChanged += new System.EventHandler(this.rbParcelado_CheckedChanged);
            // 
            // rbClienteNãoPaga
            // 
            this.rbClienteNãoPaga.AutoSize = true;
            this.rbClienteNãoPaga.Location = new System.Drawing.Point(111, 52);
            this.rbClienteNãoPaga.Name = "rbClienteNãoPaga";
            this.rbClienteNãoPaga.Size = new System.Drawing.Size(122, 17);
            this.rbClienteNãoPaga.TabIndex = 31;
            this.rbClienteNãoPaga.TabStop = true;
            this.rbClienteNãoPaga.Text = "Cliente não irá pagar";
            this.rbClienteNãoPaga.UseVisualStyleBackColor = true;
            this.rbClienteNãoPaga.CheckedChanged += new System.EventHandler(this.rbClienteNãoPaga_CheckedChanged);
            // 
            // rbParcelaUnica
            // 
            this.rbParcelaUnica.AutoSize = true;
            this.rbParcelaUnica.Location = new System.Drawing.Point(16, 52);
            this.rbParcelaUnica.Name = "rbParcelaUnica";
            this.rbParcelaUnica.Size = new System.Drawing.Size(90, 17);
            this.rbParcelaUnica.TabIndex = 30;
            this.rbParcelaUnica.TabStop = true;
            this.rbParcelaUnica.Text = "Parcela única";
            this.rbParcelaUnica.UseVisualStyleBackColor = true;
            this.rbParcelaUnica.CheckedChanged += new System.EventHandler(this.rbParcelaUnica_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data incial (ou vencimento)";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 73);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(128, 20);
            this.dtpData.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantidade de parcelas *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dias entre parcelas *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descrição do acordo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Número do processo *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor total *";
            // 
            // ttbNumeroProcesso
            // 
            this.ttbNumeroProcesso.Enabled = false;
            this.ttbNumeroProcesso.Location = new System.Drawing.Point(486, 119);
            this.ttbNumeroProcesso.Name = "ttbNumeroProcesso";
            this.ttbNumeroProcesso.Size = new System.Drawing.Size(124, 20);
            this.ttbNumeroProcesso.TabIndex = 18;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.label9);
            this.grbDados.Controls.Add(this.ttbDescParcela);
            this.grbDados.Controls.Add(this.dgvResultado);
            this.grbDados.Controls.Add(this.ttbDescricao);
            this.grbDados.Controls.Add(this.button2);
            this.grbDados.Controls.Add(this.label8);
            this.grbDados.Controls.Add(this.ttbResultadoParcela);
            this.grbDados.Controls.Add(this.label11);
            this.grbDados.Controls.Add(this.cbbNivelAcesso);
            this.grbDados.Controls.Add(this.ttbQuantidadePar);
            this.grbDados.Controls.Add(this.ttbDiasParcelas);
            this.grbDados.Controls.Add(this.ttbValorTotal);
            this.grbDados.Controls.Add(this.label7);
            this.grbDados.Controls.Add(this.ttbCodigo);
            this.grbDados.Controls.Add(this.label5);
            this.grbDados.Controls.Add(this.ttbNumeroProcesso);
            this.grbDados.Controls.Add(this.label2);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.label4);
            this.grbDados.Controls.Add(this.dtpData);
            this.grbDados.Controls.Add(this.label6);
            this.grbDados.Controls.Add(this.label1);
            this.grbDados.Controls.Add(this.groupBox2);
            this.grbDados.Location = new System.Drawing.Point(12, 76);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(688, 345);
            this.grbDados.TabIndex = 45;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Informações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Descrição Parcela";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ttbDescParcela
            // 
            this.ttbDescParcela.Location = new System.Drawing.Point(371, 118);
            this.ttbDescParcela.MaxLength = 100;
            this.ttbDescParcela.Name = "ttbDescParcela";
            this.ttbDescParcela.Size = new System.Drawing.Size(90, 20);
            this.ttbDescParcela.TabIndex = 77;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rece_Descricao,
            this.Rece_Valor,
            this.Rece_dataVenc});
            this.dgvResultado.Location = new System.Drawing.Point(317, 173);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(365, 168);
            this.dgvResultado.TabIndex = 76;
            // 
            // Rece_Descricao
            // 
            this.Rece_Descricao.DataPropertyName = "Rece_Descricao";
            this.Rece_Descricao.HeaderText = "Descrição";
            this.Rece_Descricao.Name = "Rece_Descricao";
            this.Rece_Descricao.ReadOnly = true;
            // 
            // Rece_Valor
            // 
            this.Rece_Valor.DataPropertyName = "Rece_Valor";
            this.Rece_Valor.HeaderText = "Valor";
            this.Rece_Valor.Name = "Rece_Valor";
            this.Rece_Valor.ReadOnly = true;
            // 
            // Rece_dataVenc
            // 
            this.Rece_dataVenc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rece_dataVenc.DataPropertyName = "Rece_dataVenc";
            this.Rece_dataVenc.HeaderText = "Data de vencimento";
            this.Rece_dataVenc.Name = "Rece_dataVenc";
            this.Rece_dataVenc.ReadOnly = true;
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(6, 171);
            this.ttbDescricao.MaxLength = 255;
            this.ttbDescricao.Multiline = true;
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(305, 170);
            this.ttbDescricao.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(616, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Localizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Resultado Parcela";
            // 
            // ttbResultadoParcela
            // 
            this.ttbResultadoParcela.Enabled = false;
            this.ttbResultadoParcela.Location = new System.Drawing.Point(273, 118);
            this.ttbResultadoParcela.Name = "ttbResultadoParcela";
            this.ttbResultadoParcela.Size = new System.Drawing.Size(76, 20);
            this.ttbResultadoParcela.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nivel de acesso *";
            // 
            // cbbNivelAcesso
            // 
            this.cbbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNivelAcesso.FormattingEnabled = true;
            this.cbbNivelAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Advogado"});
            this.cbbNivelAcesso.Location = new System.Drawing.Point(165, 118);
            this.cbbNivelAcesso.Name = "cbbNivelAcesso";
            this.cbbNivelAcesso.Size = new System.Drawing.Size(89, 21);
            this.cbbNivelAcesso.TabIndex = 55;
            // 
            // ttbQuantidadePar
            // 
            this.ttbQuantidadePar.Location = new System.Drawing.Point(163, 32);
            this.ttbQuantidadePar.Mask = "000";
            this.ttbQuantidadePar.Name = "ttbQuantidadePar";
            this.ttbQuantidadePar.Size = new System.Drawing.Size(89, 20);
            this.ttbQuantidadePar.TabIndex = 38;
            // 
            // ttbDiasParcelas
            // 
            this.ttbDiasParcelas.Location = new System.Drawing.Point(165, 73);
            this.ttbDiasParcelas.Mask = "000";
            this.ttbDiasParcelas.Name = "ttbDiasParcelas";
            this.ttbDiasParcelas.Size = new System.Drawing.Size(123, 20);
            this.ttbDiasParcelas.TabIndex = 37;
            // 
            // ttbValorTotal
            // 
            this.ttbValorTotal.Location = new System.Drawing.Point(13, 118);
            this.ttbValorTotal.Mask = "$000000000.00";
            this.ttbValorTotal.Name = "ttbValorTotal";
            this.ttbValorTotal.Size = new System.Drawing.Size(124, 20);
            this.ttbValorTotal.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Código";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(13, 32);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(76, 20);
            this.ttbCodigo.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbParcelaUnica);
            this.groupBox2.Controls.Add(this.rbParcelado);
            this.groupBox2.Controls.Add(this.rbClienteNãoPaga);
            this.groupBox2.Location = new System.Drawing.Point(371, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 81);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo *";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(712, 70);
            this.pnlBotoes.TabIndex = 46;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(637, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(375, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 70);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(300, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(225, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 70);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            // frmAtualizacaoHonorariosProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 433);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAtualizacaoHonorariosProcessos";
            this.Text = "Atualização de honorários de processos ";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbParcelado;
        private System.Windows.Forms.RadioButton rbClienteNãoPaga;
        private System.Windows.Forms.RadioButton rbParcelaUnica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbNumeroProcesso;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox ttbQuantidadePar;
        private System.Windows.Forms.MaskedTextBox ttbDiasParcelas;
        private System.Windows.Forms.MaskedTextBox ttbValorTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbNivelAcesso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbResultadoParcela;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ttbDescParcela;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_dataVenc;
    }
}

