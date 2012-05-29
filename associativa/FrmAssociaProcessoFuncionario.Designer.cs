namespace SAEA.associativa
{
    partial class FrmAssociaProcessoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociaProcessoFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbAdvogado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbAcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbVara = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.cbbAdvogadoResponsavel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 129);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Processo";
            // 
            // ttbAdvogado
            // 
            this.ttbAdvogado.Location = new System.Drawing.Point(231, 43);
            this.ttbAdvogado.Name = "ttbAdvogado";
            this.ttbAdvogado.Size = new System.Drawing.Size(171, 20);
            this.ttbAdvogado.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Advogado Responsável ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Número do processo ";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(35, 43);
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(171, 20);
            this.ttbNumero.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tipo de ação ";
            // 
            // ttbAcao
            // 
            this.ttbAcao.Location = new System.Drawing.Point(231, 83);
            this.ttbAcao.Name = "ttbAcao";
            this.ttbAcao.Size = new System.Drawing.Size(171, 20);
            this.ttbAcao.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Vara ";
            // 
            // ttbVara
            // 
            this.ttbVara.Location = new System.Drawing.Point(35, 83);
            this.ttbVara.Name = "ttbVara";
            this.ttbVara.Size = new System.Drawing.Size(171, 20);
            this.ttbVara.TabIndex = 58;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(495, 70);
            this.pnlBotoes.TabIndex = 53;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(0, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 70);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Efetivar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
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
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.cbbAdvogadoResponsavel);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label6);
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(12, 211);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(475, 94);
            this.gpbIdentificacaoDoCliente.TabIndex = 54;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação do Funcionário";
            // 
            // cbbAdvogadoResponsavel
            // 
            this.cbbAdvogadoResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAdvogadoResponsavel.FormattingEnabled = true;
            this.cbbAdvogadoResponsavel.Location = new System.Drawing.Point(35, 49);
            this.cbbAdvogadoResponsavel.Name = "cbbAdvogadoResponsavel";
            this.cbbAdvogadoResponsavel.Size = new System.Drawing.Size(242, 21);
            this.cbbAdvogadoResponsavel.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(412, 323);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarConta.TabIndex = 58;
            this.btnAdicionarConta.Text = "Adicionar";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(412, 352);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.Text = "Remover";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.dgvResultado.Location = new System.Drawing.Point(12, 323);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(394, 225);
            this.dgvResultado.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fun_codigo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "fun_nome";
            this.Column3.HeaderText = "Nome Funcionario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmAssociaProcessoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 560);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssociaProcessoFuncionario";
            this.Text = "Associação de Funcionários com Processos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnLocalizarProcesso;
        private System.Windows.Forms.TextBox ttbAdvogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbAcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbVara;
        private System.Windows.Forms.ComboBox cbbAdvogadoResponsavel;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}