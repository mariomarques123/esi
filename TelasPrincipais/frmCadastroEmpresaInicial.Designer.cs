namespace SAEA.TelasPrincipais
{
    partial class frmCadastroEmpresaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmpresaInicial));
            this.gpbLocalizacao = new System.Windows.Forms.GroupBox();
            this.ttbCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbEndereco = new System.Windows.Forms.TextBox();
            this.ttbBairro = new System.Windows.Forms.TextBox();
            this.ttbCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.ttbCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.ttbCelular1 = new System.Windows.Forms.MaskedTextBox();
            this.ttbTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.ttbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.ttbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ttbDescrição = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.gpbLogo = new System.Windows.Forms.GroupBox();
            this.ofdAbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbLocalizacao.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.gpbLogo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLocalizacao
            // 
            this.gpbLocalizacao.Controls.Add(this.ttbCEP);
            this.gpbLocalizacao.Controls.Add(this.cbbUF);
            this.gpbLocalizacao.Controls.Add(this.label6);
            this.gpbLocalizacao.Controls.Add(this.ttbEndereco);
            this.gpbLocalizacao.Controls.Add(this.ttbBairro);
            this.gpbLocalizacao.Controls.Add(this.ttbCidade);
            this.gpbLocalizacao.Controls.Add(this.label15);
            this.gpbLocalizacao.Controls.Add(this.ttbNumero);
            this.gpbLocalizacao.Controls.Add(this.label16);
            this.gpbLocalizacao.Controls.Add(this.label7);
            this.gpbLocalizacao.Controls.Add(this.label1);
            this.gpbLocalizacao.Controls.Add(this.label18);
            this.gpbLocalizacao.Location = new System.Drawing.Point(12, 282);
            this.gpbLocalizacao.Margin = new System.Windows.Forms.Padding(5);
            this.gpbLocalizacao.Name = "gpbLocalizacao";
            this.gpbLocalizacao.Size = new System.Drawing.Size(600, 118);
            this.gpbLocalizacao.TabIndex = 5;
            this.gpbLocalizacao.TabStop = false;
            this.gpbLocalizacao.Text = "Localização";
            // 
            // ttbCEP
            // 
            this.ttbCEP.Location = new System.Drawing.Point(464, 42);
            this.ttbCEP.Mask = "00000-000";
            this.ttbCEP.Name = "ttbCEP";
            this.ttbCEP.Size = new System.Drawing.Size(118, 20);
            this.ttbCEP.TabIndex = 10;
            // 
            // cbbUF
            // 
            this.cbbUF.DisplayMember = "est_Sigla";
            this.cbbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(544, 80);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(38, 21);
            this.cbbUF.TabIndex = 5;
            this.cbbUF.ValueMember = "est_Sigla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Endereço *";
            // 
            // ttbEndereco
            // 
            this.ttbEndereco.Location = new System.Drawing.Point(9, 42);
            this.ttbEndereco.MaxLength = 50;
            this.ttbEndereco.Name = "ttbEndereco";
            this.ttbEndereco.Size = new System.Drawing.Size(389, 20);
            this.ttbEndereco.TabIndex = 0;
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(8, 81);
            this.ttbBairro.MaxLength = 30;
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(301, 20);
            this.ttbBairro.TabIndex = 3;
            // 
            // ttbCidade
            // 
            this.ttbCidade.Location = new System.Drawing.Point(315, 81);
            this.ttbCidade.MaxLength = 50;
            this.ttbCidade.Name = "ttbCidade";
            this.ttbCidade.Size = new System.Drawing.Size(216, 20);
            this.ttbCidade.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(401, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Número";
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(404, 42);
            this.ttbNumero.MaxLength = 10;
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(51, 20);
            this.ttbNumero.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Cidade *";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UF *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "CEP";
            // 
            // gpbContato
            // 
            this.gpbContato.BackColor = System.Drawing.SystemColors.Control;
            this.gpbContato.Controls.Add(this.ttbCelular2);
            this.gpbContato.Controls.Add(this.ttbCelular1);
            this.gpbContato.Controls.Add(this.ttbTelFixo);
            this.gpbContato.Controls.Add(this.ttbEmail);
            this.gpbContato.Controls.Add(this.label14);
            this.gpbContato.Controls.Add(this.label4);
            this.gpbContato.Controls.Add(this.label5);
            this.gpbContato.Controls.Add(this.label10);
            this.gpbContato.Location = new System.Drawing.Point(12, 197);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(600, 77);
            this.gpbContato.TabIndex = 4;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // ttbCelular2
            // 
            this.ttbCelular2.Location = new System.Drawing.Point(207, 40);
            this.ttbCelular2.Mask = "(00) 0000-0000";
            this.ttbCelular2.Name = "ttbCelular2";
            this.ttbCelular2.Size = new System.Drawing.Size(88, 20);
            this.ttbCelular2.TabIndex = 9;
            this.ttbCelular2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ttbCelular2_MaskInputRejected);
            // 
            // ttbCelular1
            // 
            this.ttbCelular1.Location = new System.Drawing.Point(113, 40);
            this.ttbCelular1.Mask = "(00) 0000-0000";
            this.ttbCelular1.Name = "ttbCelular1";
            this.ttbCelular1.Size = new System.Drawing.Size(88, 20);
            this.ttbCelular1.TabIndex = 9;
            // 
            // ttbTelFixo
            // 
            this.ttbTelFixo.Location = new System.Drawing.Point(12, 40);
            this.ttbTelFixo.Mask = "(00) 0000-0000";
            this.ttbTelFixo.Name = "ttbTelFixo";
            this.ttbTelFixo.Size = new System.Drawing.Size(95, 20);
            this.ttbTelFixo.TabIndex = 9;
            // 
            // ttbEmail
            // 
            this.ttbEmail.Location = new System.Drawing.Point(301, 40);
            this.ttbEmail.MaxLength = 100;
            this.ttbEmail.Name = "ttbEmail";
            this.ttbEmail.Size = new System.Drawing.Size(281, 20);
            this.ttbEmail.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celular 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone Fixo *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular 1";
            // 
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCNPJ);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label20);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbDescrição);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbNome);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label3);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label2);
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(12, 76);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(600, 115);
            this.gpbIdentificacaoDoCliente.TabIndex = 3;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação da empresa";
            // 
            // ttbCNPJ
            // 
            this.ttbCNPJ.Location = new System.Drawing.Point(462, 44);
            this.ttbCNPJ.Mask = "00.000.000/0000-00";
            this.ttbCNPJ.Name = "ttbCNPJ";
            this.ttbCNPJ.Size = new System.Drawing.Size(120, 20);
            this.ttbCNPJ.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(459, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "CNPJ";
            // 
            // ttbDescrição
            // 
            this.ttbDescrição.BackColor = System.Drawing.SystemColors.Window;
            this.ttbDescrição.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbDescrição.Location = new System.Drawing.Point(12, 83);
            this.ttbDescrição.MaxLength = 100;
            this.ttbDescrição.Name = "ttbDescrição";
            this.ttbDescrição.Size = new System.Drawing.Size(570, 20);
            this.ttbDescrição.TabIndex = 1;
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.SystemColors.Window;
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(12, 44);
            this.ttbNome.MaxLength = 50;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(433, 20);
            this.ttbNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome *";
            // 
            // pbxImagem
            // 
            this.pbxImagem.Location = new System.Drawing.Point(69, 19);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(432, 143);
            this.pbxImagem.TabIndex = 12;
            this.pbxImagem.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(507, 117);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(75, 45);
            this.btnAbrirImagem.TabIndex = 13;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // gpbLogo
            // 
            this.gpbLogo.Controls.Add(this.btnAbrirImagem);
            this.gpbLogo.Controls.Add(this.pbxImagem);
            this.gpbLogo.Location = new System.Drawing.Point(12, 408);
            this.gpbLogo.Name = "gpbLogo";
            this.gpbLogo.Size = new System.Drawing.Size(600, 168);
            this.gpbLogo.TabIndex = 14;
            this.gpbLogo.TabStop = false;
            this.gpbLogo.Text = "Logomarca";
            // 
            // ofdAbrirImagem
            // 
            this.ofdAbrirImagem.Filter = "Arquivos BMP, PNG, JPG|*.bmp;*.png;*.jpg";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(621, 70);
            this.pnlBotoes.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(546, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            // frmCadastroEmpresaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 588);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.gpbLocalizacao);
            this.Controls.Add(this.gpbContato);
            this.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.Controls.Add(this.gpbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastroEmpresaInicial";
            this.Text = "Cadastro de Empresa";
            this.gpbLocalizacao.ResumeLayout(false);
            this.gpbLocalizacao.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.gpbLogo.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLocalizacao;
        private System.Windows.Forms.MaskedTextBox ttbCEP;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbEndereco;
        private System.Windows.Forms.TextBox ttbBairro;
        private System.Windows.Forms.TextBox ttbCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.MaskedTextBox ttbCelular1;
        private System.Windows.Forms.MaskedTextBox ttbTelFixo;
        private System.Windows.Forms.TextBox ttbEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.MaskedTextBox ttbCNPJ;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ttbCelular2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbDescrição;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.GroupBox gpbLogo;
        private System.Windows.Forms.OpenFileDialog ofdAbrirImagem;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
    }
}