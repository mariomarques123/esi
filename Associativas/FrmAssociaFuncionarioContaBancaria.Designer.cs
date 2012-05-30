namespace SAEA.Cadastros
{
    partial class FrmAssociaFuncionarioContaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociaFuncionarioContaBancaria));
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.ttbNumAgencia = new System.Windows.Forms.MaskedTextBox();
            this.ttbCodigoBanco = new System.Windows.Forms.MaskedTextBox();
            this.ttbCodConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbNomeBanco = new System.Windows.Forms.TextBox();
            this.ttbNumeroConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLocalizaConta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLocalizarFuncionario = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbRG = new System.Windows.Forms.TextBox();
            this.ttbCPF = new System.Windows.Forms.TextBox();
            this.grbDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.ttbNumAgencia);
            this.grbDados.Controls.Add(this.ttbCodigoBanco);
            this.grbDados.Controls.Add(this.ttbCodConta);
            this.grbDados.Controls.Add(this.label1);
            this.grbDados.Controls.Add(this.label4);
            this.grbDados.Controls.Add(this.ttbNomeBanco);
            this.grbDados.Controls.Add(this.ttbNumeroConta);
            this.grbDados.Controls.Add(this.label5);
            this.grbDados.Controls.Add(this.label6);
            this.grbDados.Controls.Add(this.label7);
            this.grbDados.Enabled = false;
            this.grbDados.Location = new System.Drawing.Point(12, 197);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(527, 125);
            this.grbDados.TabIndex = 45;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados da conta";
            // 
            // ttbNumAgencia
            // 
            this.ttbNumAgencia.Location = new System.Drawing.Point(297, 44);
            this.ttbNumAgencia.Mask = "000000";
            this.ttbNumAgencia.Name = "ttbNumAgencia";
            this.ttbNumAgencia.Size = new System.Drawing.Size(100, 20);
            this.ttbNumAgencia.TabIndex = 47;
            // 
            // ttbCodigoBanco
            // 
            this.ttbCodigoBanco.Location = new System.Drawing.Point(297, 91);
            this.ttbCodigoBanco.Mask = "000000";
            this.ttbCodigoBanco.Name = "ttbCodigoBanco";
            this.ttbCodigoBanco.Size = new System.Drawing.Size(100, 20);
            this.ttbCodigoBanco.TabIndex = 47;
            // 
            // ttbCodConta
            // 
            this.ttbCodConta.Enabled = false;
            this.ttbCodConta.Location = new System.Drawing.Point(19, 44);
            this.ttbCodConta.Name = "ttbCodConta";
            this.ttbCodConta.Size = new System.Drawing.Size(56, 20);
            this.ttbCodConta.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Número da conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Código";
            // 
            // ttbNomeBanco
            // 
            this.ttbNomeBanco.Location = new System.Drawing.Point(19, 91);
            this.ttbNomeBanco.MaxLength = 50;
            this.ttbNomeBanco.Name = "ttbNomeBanco";
            this.ttbNomeBanco.Size = new System.Drawing.Size(224, 20);
            this.ttbNomeBanco.TabIndex = 41;
            // 
            // ttbNumeroConta
            // 
            this.ttbNumeroConta.Location = new System.Drawing.Point(81, 43);
            this.ttbNumeroConta.MaxLength = 25;
            this.ttbNumeroConta.Name = "ttbNumeroConta";
            this.ttbNumeroConta.Size = new System.Drawing.Size(207, 20);
            this.ttbNumeroConta.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Código do banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nome do banco";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Número da agência";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnLocalizaConta);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnLocalizarFuncionario);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(551, 70);
            this.pnlBotoes.TabIndex = 46;
            // 
            // btnLocalizaConta
            // 
            this.btnLocalizaConta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizaConta.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaConta.Image")));
            this.btnLocalizaConta.Location = new System.Drawing.Point(111, 0);
            this.btnLocalizaConta.Name = "btnLocalizaConta";
            this.btnLocalizaConta.Size = new System.Drawing.Size(118, 70);
            this.btnLocalizaConta.TabIndex = 7;
            this.btnLocalizaConta.Text = "Localizar conta";
            this.btnLocalizaConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizaConta.UseVisualStyleBackColor = true;
            this.btnLocalizaConta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(476, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLocalizarFuncionario
            // 
            this.btnLocalizarFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarFuncionario.Image")));
            this.btnLocalizarFuncionario.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizarFuncionario.Name = "btnLocalizarFuncionario";
            this.btnLocalizarFuncionario.Size = new System.Drawing.Size(111, 70);
            this.btnLocalizarFuncionario.TabIndex = 2;
            this.btnLocalizarFuncionario.Text = "Loca... Funcionario";
            this.btnLocalizarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizarFuncionario.UseVisualStyleBackColor = true;
            this.btnLocalizarFuncionario.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgvResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResultado.Location = new System.Drawing.Point(12, 328);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(440, 225);
            this.dgvResultado.TabIndex = 47;
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(458, 328);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarConta.TabIndex = 53;
            this.btnAdicionarConta.Text = "Adicionar";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(458, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 52;
            this.btnExcluir.Text = "Remover";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(458, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCPF);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbRG);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbNome);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCodigo);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label11);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label12);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label3);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label2);
            this.gpbIdentificacaoDoCliente.Enabled = false;
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(12, 76);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(527, 116);
            this.gpbIdentificacaoDoCliente.TabIndex = 54;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação do funcionário";
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.SystemColors.Window;
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(74, 44);
            this.ttbNome.MaxLength = 60;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(380, 20);
            this.ttbNome.TabIndex = 14;
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(11, 44);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(57, 20);
            this.ttbCodigo.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
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
            this.Column3.DataPropertyName = "fun_nome";
            this.Column3.HeaderText = "Nome Funcionario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "con_codigo";
            this.Column2.HeaderText = "Codigo conta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "con_numero";
            this.Column4.HeaderText = "Numero da conta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ttbRG
            // 
            this.ttbRG.Enabled = false;
            this.ttbRG.Location = new System.Drawing.Point(11, 83);
            this.ttbRG.Name = "ttbRG";
            this.ttbRG.Size = new System.Drawing.Size(88, 20);
            this.ttbRG.TabIndex = 46;
            // 
            // ttbCPF
            // 
            this.ttbCPF.Enabled = false;
            this.ttbCPF.Location = new System.Drawing.Point(111, 83);
            this.ttbCPF.Name = "ttbCPF";
            this.ttbCPF.Size = new System.Drawing.Size(116, 20);
            this.ttbCPF.TabIndex = 47;
            // 
            // FrmAssociaFuncionarioContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 565);
            this.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAssociaFuncionarioContaBancaria";
            this.Text = "Associação de Clientes com Contas Bancárias";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.MaskedTextBox ttbNumAgencia;
        private System.Windows.Forms.MaskedTextBox ttbCodigoBanco;
        private System.Windows.Forms.TextBox ttbCodConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbNomeBanco;
        private System.Windows.Forms.TextBox ttbNumeroConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnLocalizaConta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLocalizarFuncionario;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox ttbCPF;
        private System.Windows.Forms.TextBox ttbRG;
    }
}