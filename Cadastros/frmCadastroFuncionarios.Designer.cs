namespace SAEA.Cadastros
{
    partial class frmCadastroFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionarios));
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbTipoFunc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbLocalizacao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbEndereco = new System.Windows.Forms.TextBox();
            this.ttbBairro = new System.Windows.Forms.TextBox();
            this.ttbCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ttbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.gpbLocalizacao.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.mtbCPF);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.mtbRG);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbNome);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCodigo);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label11);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label12);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label3);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ccbTipoFunc);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label8);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label2);
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(10, 5);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(571, 116);
            this.gpbIdentificacaoDoCliente.TabIndex = 0;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação do funcionário";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(464, 83);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(93, 20);
            this.mtbCPF.TabIndex = 4;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(365, 84);
            this.mtbRG.Mask = "000.000.000-0";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(93, 20);
            this.mtbRG.TabIndex = 3;
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.SystemColors.Window;
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(74, 44);
            this.ttbNome.MaxLength = 60;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(483, 20);
            this.ttbNome.TabIndex = 1;
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
            this.label11.TabIndex = 13;
            this.label11.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // ccbTipoFunc
            // 
            this.ccbTipoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbTipoFunc.FormattingEnabled = true;
            this.ccbTipoFunc.Location = new System.Drawing.Point(12, 83);
            this.ccbTipoFunc.Name = "ccbTipoFunc";
            this.ccbTipoFunc.Size = new System.Drawing.Size(340, 21);
            this.ccbTipoFunc.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo de funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome (*)";
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.gpbLocalizacao);
            this.pnlDados.Controls.Add(this.gpbContato);
            this.pnlDados.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.pnlDados.Location = new System.Drawing.Point(0, 72);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(588, 361);
            this.pnlDados.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "(*) Campo de preenchimento obrigatório.";
            // 
            // gpbLocalizacao
            // 
            this.gpbLocalizacao.Controls.Add(this.label6);
            this.gpbLocalizacao.Controls.Add(this.ttbEndereco);
            this.gpbLocalizacao.Controls.Add(this.ttbBairro);
            this.gpbLocalizacao.Controls.Add(this.ttbCidade);
            this.gpbLocalizacao.Controls.Add(this.label15);
            this.gpbLocalizacao.Controls.Add(this.ttbNumero);
            this.gpbLocalizacao.Controls.Add(this.label16);
            this.gpbLocalizacao.Controls.Add(this.label7);
            this.gpbLocalizacao.Location = new System.Drawing.Point(10, 212);
            this.gpbLocalizacao.Margin = new System.Windows.Forms.Padding(5);
            this.gpbLocalizacao.Name = "gpbLocalizacao";
            this.gpbLocalizacao.Size = new System.Drawing.Size(571, 118);
            this.gpbLocalizacao.TabIndex = 2;
            this.gpbLocalizacao.TabStop = false;
            this.gpbLocalizacao.Text = "Localização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endereço";
            // 
            // ttbEndereco
            // 
            this.ttbEndereco.Location = new System.Drawing.Point(9, 42);
            this.ttbEndereco.MaxLength = 50;
            this.ttbEndereco.Name = "ttbEndereco";
            this.ttbEndereco.Size = new System.Drawing.Size(491, 20);
            this.ttbEndereco.TabIndex = 0;
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(8, 81);
            this.ttbBairro.MaxLength = 30;
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(301, 20);
            this.ttbBairro.TabIndex = 2;
            // 
            // ttbCidade
            // 
            this.ttbCidade.Location = new System.Drawing.Point(315, 81);
            this.ttbCidade.MaxLength = 50;
            this.ttbCidade.Name = "ttbCidade";
            this.ttbCidade.Size = new System.Drawing.Size(242, 20);
            this.ttbCidade.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(503, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Número";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(506, 42);
            this.ttbNumero.MaxLength = 12;
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(51, 20);
            this.ttbNumero.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro";
            // 
            // gpbContato
            // 
            this.gpbContato.BackColor = System.Drawing.SystemColors.Control;
            this.gpbContato.Controls.Add(this.mtbCelular);
            this.gpbContato.Controls.Add(this.mtbTelefone);
            this.gpbContato.Controls.Add(this.label13);
            this.gpbContato.Controls.Add(this.ttbEmail);
            this.gpbContato.Controls.Add(this.label14);
            this.gpbContato.Controls.Add(this.label10);
            this.gpbContato.Location = new System.Drawing.Point(10, 127);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(571, 77);
            this.gpbContato.TabIndex = 1;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(113, 40);
            this.mtbCelular.Mask = "(00)0000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(93, 20);
            this.mtbCelular.TabIndex = 1;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(13, 40);
            this.mtbTelefone.Mask = "(00)0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(93, 20);
            this.mtbTelefone.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Telefone";
            // 
            // ttbEmail
            // 
            this.ttbEmail.Location = new System.Drawing.Point(212, 40);
            this.ttbEmail.MaxLength = 100;
            this.ttbEmail.Name = "ttbEmail";
            this.ttbEmail.Size = new System.Drawing.Size(345, 20);
            this.ttbEmail.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular";
            // 
            // btnIncluir
            // 
            this.btnIncluir.AutoSize = true;
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(0, 0);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 70);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
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
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(300, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(516, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(591, 70);
            this.pnlBotoes.TabIndex = 11;
            // 
            // frmCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 433);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroFuncionarios_KeyDown);
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.gpbLocalizacao.ResumeLayout(false);
            this.gpbLocalizacao.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.ComboBox ccbTipoFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ttbEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpbLocalizacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbEndereco;
        private System.Windows.Forms.TextBox ttbBairro;
        private System.Windows.Forms.TextBox ttbCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
    }
}