namespace SAEA.associativa
{
    partial class FrmAssociaProcessoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociaProcessoCliente));
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.ttbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.ttbRG = new System.Windows.Forms.MaskedTextBox();
            this.ttbCPF = new System.Windows.Forms.MaskedTextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSelCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbAdvogado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbAcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbVara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(412, 352);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarConta.TabIndex = 65;
            this.btnAdicionarConta.Text = "Adicionar";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // ttbCNPJ
            // 
            this.ttbCNPJ.Location = new System.Drawing.Point(252, 83);
            this.ttbCNPJ.Mask = "00.000.000/0000-00";
            this.ttbCNPJ.Name = "ttbCNPJ";
            this.ttbCNPJ.Size = new System.Drawing.Size(120, 20);
            this.ttbCNPJ.TabIndex = 11;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(412, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 64;
            this.btnExcluir.Text = "Remover";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(249, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "CNPJ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(412, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dgvResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResultado.Location = new System.Drawing.Point(12, 352);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(394, 225);
            this.dgvResultado.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cli_codigo";
            this.Column1.HeaderText = "Codigo cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "cli_nome";
            this.Column3.HeaderText = "Nome cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCNPJ);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label20);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbRG);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCPF);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCodigo);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label11);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbNome);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label12);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label5);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label6);
            this.gpbIdentificacaoDoCliente.Enabled = false;
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(12, 217);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(475, 128);
            this.gpbIdentificacaoDoCliente.TabIndex = 61;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação do cliente";
            // 
            // ttbRG
            // 
            this.ttbRG.Location = new System.Drawing.Point(136, 83);
            this.ttbRG.Mask = "00.000.000-0";
            this.ttbRG.Name = "ttbRG";
            this.ttbRG.Size = new System.Drawing.Size(108, 20);
            this.ttbRG.TabIndex = 9;
            // 
            // ttbCPF
            // 
            this.ttbCPF.Location = new System.Drawing.Point(11, 83);
            this.ttbCPF.Mask = "000.000.000-00";
            this.ttbCPF.Name = "ttbCPF";
            this.ttbCPF.Size = new System.Drawing.Size(119, 20);
            this.ttbCPF.TabIndex = 9;
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(11, 44);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(57, 20);
            this.ttbCodigo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Código";
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.SystemColors.Window;
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(75, 44);
            this.ttbNome.MaxLength = 100;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(347, 20);
            this.ttbNome.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnSelCliente);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(495, 70);
            this.pnlBotoes.TabIndex = 60;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(118, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 70);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Efetivar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSelCliente
            // 
            this.btnSelCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSelCliente.Image")));
            this.btnSelCliente.Location = new System.Drawing.Point(0, 0);
            this.btnSelCliente.Name = "btnSelCliente";
            this.btnSelCliente.Size = new System.Drawing.Size(118, 70);
            this.btnSelCliente.TabIndex = 7;
            this.btnSelCliente.Text = "Localizar Cliente";
            this.btnSelCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelCliente.UseVisualStyleBackColor = true;
            this.btnSelCliente.Click += new System.EventHandler(this.btnSelCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(420, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbAdvogado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttbNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ttbAcao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ttbVara);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 129);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Processo";
            // 
            // ttbAdvogado
            // 
            this.ttbAdvogado.Location = new System.Drawing.Point(207, 45);
            this.ttbAdvogado.Name = "ttbAdvogado";
            this.ttbAdvogado.Size = new System.Drawing.Size(171, 20);
            this.ttbAdvogado.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Advogado Responsável ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Número do processo ";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(11, 45);
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(171, 20);
            this.ttbNumero.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo de ação ";
            // 
            // ttbAcao
            // 
            this.ttbAcao.Location = new System.Drawing.Point(207, 85);
            this.ttbAcao.Name = "ttbAcao";
            this.ttbAcao.Size = new System.Drawing.Size(171, 20);
            this.ttbAcao.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vara ";
            // 
            // ttbVara
            // 
            this.ttbVara.Location = new System.Drawing.Point(11, 85);
            this.ttbVara.Name = "ttbVara";
            this.ttbVara.Size = new System.Drawing.Size(171, 20);
            this.ttbVara.TabIndex = 28;
            // 
            // FrmAssociaProcessoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 583);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssociaProcessoCliente";
            this.Text = "Associação de Clientes com Processos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.MaskedTextBox ttbCNPJ;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.MaskedTextBox ttbRG;
        private System.Windows.Forms.MaskedTextBox ttbCPF;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSelCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbAdvogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbAcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbVara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGravar;

    }
}