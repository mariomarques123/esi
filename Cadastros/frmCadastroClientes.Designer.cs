namespace SAEA.Cadastros
{
    partial class frmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
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
            this.gpbIdentificacaoDoCliente = new System.Windows.Forms.GroupBox();
            this.btnAssociaContasBanco = new System.Windows.Forms.Button();
            this.ttbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ttbRG = new System.Windows.Forms.MaskedTextBox();
            this.ttbCPF = new System.Windows.Forms.MaskedTextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.ttbCelular = new System.Windows.Forms.MaskedTextBox();
            this.ttbTelCom = new System.Windows.Forms.MaskedTextBox();
            this.ttbTelRes = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ttbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbLocalizacao.SuspendLayout();
            this.gpbIdentificacaoDoCliente.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.pnlDados.SuspendLayout();
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
            this.gpbLocalizacao.Location = new System.Drawing.Point(12, 217);
            this.gpbLocalizacao.Margin = new System.Windows.Forms.Padding(5);
            this.gpbLocalizacao.Name = "gpbLocalizacao";
            this.gpbLocalizacao.Size = new System.Drawing.Size(642, 118);
            this.gpbLocalizacao.TabIndex = 2;
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
            this.cbbUF.Location = new System.Drawing.Point(581, 80);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(50, 21);
            this.cbbUF.TabIndex = 5;
            this.cbbUF.ValueMember = "est_Sigla";
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
            this.ttbEndereco.MaxLength = 100;
            this.ttbEndereco.Name = "ttbEndereco";
            this.ttbEndereco.Size = new System.Drawing.Size(389, 20);
            this.ttbEndereco.TabIndex = 0;
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(8, 81);
            this.ttbBairro.MaxLength = 50;
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(301, 20);
            this.ttbBairro.TabIndex = 3;
            // 
            // ttbCidade
            // 
            this.ttbCidade.Location = new System.Drawing.Point(315, 81);
            this.ttbCidade.MaxLength = 50;
            this.ttbCidade.Name = "ttbCidade";
            this.ttbCidade.Size = new System.Drawing.Size(256, 20);
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
            this.ttbNumero.MaxLength = 20;
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
            this.label1.Location = new System.Drawing.Point(578, 65);
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
            // gpbIdentificacaoDoCliente
            // 
            this.gpbIdentificacaoDoCliente.Controls.Add(this.btnAssociaContasBanco);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCNPJ);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label20);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbRG);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCPF);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbCodigo);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label11);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.ttbNome);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label12);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label3);
            this.gpbIdentificacaoDoCliente.Controls.Add(this.label2);
            this.gpbIdentificacaoDoCliente.Location = new System.Drawing.Point(12, 11);
            this.gpbIdentificacaoDoCliente.Name = "gpbIdentificacaoDoCliente";
            this.gpbIdentificacaoDoCliente.Size = new System.Drawing.Size(642, 115);
            this.gpbIdentificacaoDoCliente.TabIndex = 0;
            this.gpbIdentificacaoDoCliente.TabStop = false;
            this.gpbIdentificacaoDoCliente.Text = "Identificação do cliente";
            // 
            // btnAssociaContasBanco
            // 
            this.btnAssociaContasBanco.Enabled = false;
            this.btnAssociaContasBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnAssociaContasBanco.Image")));
            this.btnAssociaContasBanco.Location = new System.Drawing.Point(495, 18);
            this.btnAssociaContasBanco.Name = "btnAssociaContasBanco";
            this.btnAssociaContasBanco.Size = new System.Drawing.Size(136, 85);
            this.btnAssociaContasBanco.TabIndex = 7;
            this.btnAssociaContasBanco.Text = "Associar Contas Bancárias";
            this.btnAssociaContasBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAssociaContasBanco.UseVisualStyleBackColor = true;
            this.btnAssociaContasBanco.Click += new System.EventHandler(this.btnAssociaContasBanco_Click);
            // 
            // ttbCNPJ
            // 
            this.ttbCNPJ.Location = new System.Drawing.Point(252, 83);
            this.ttbCNPJ.Mask = "00.000.000/0000-00";
            this.ttbCNPJ.Name = "ttbCNPJ";
            this.ttbCNPJ.Size = new System.Drawing.Size(120, 20);
            this.ttbCNPJ.TabIndex = 11;
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
            this.ttbNome.Size = new System.Drawing.Size(393, 20);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome *";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone Comercial";
            // 
            // gpbContato
            // 
            this.gpbContato.BackColor = System.Drawing.SystemColors.Control;
            this.gpbContato.Controls.Add(this.ttbCelular);
            this.gpbContato.Controls.Add(this.ttbTelCom);
            this.gpbContato.Controls.Add(this.ttbTelRes);
            this.gpbContato.Controls.Add(this.label13);
            this.gpbContato.Controls.Add(this.ttbEmail);
            this.gpbContato.Controls.Add(this.label14);
            this.gpbContato.Controls.Add(this.label5);
            this.gpbContato.Controls.Add(this.label10);
            this.gpbContato.Location = new System.Drawing.Point(12, 132);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(642, 77);
            this.gpbContato.TabIndex = 1;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // ttbCelular
            // 
            this.ttbCelular.Location = new System.Drawing.Point(229, 40);
            this.ttbCelular.Mask = "(00) 0000-0000";
            this.ttbCelular.Name = "ttbCelular";
            this.ttbCelular.Size = new System.Drawing.Size(88, 20);
            this.ttbCelular.TabIndex = 9;
            // 
            // ttbTelCom
            // 
            this.ttbTelCom.Location = new System.Drawing.Point(125, 40);
            this.ttbTelCom.Mask = "(00) 0000-0000";
            this.ttbTelCom.Name = "ttbTelCom";
            this.ttbTelCom.Size = new System.Drawing.Size(95, 20);
            this.ttbTelCom.TabIndex = 9;
            // 
            // ttbTelRes
            // 
            this.ttbTelRes.Location = new System.Drawing.Point(12, 40);
            this.ttbTelRes.Mask = "(00) 0000-0000";
            this.ttbTelRes.Name = "ttbTelRes";
            this.ttbTelRes.Size = new System.Drawing.Size(104, 20);
            this.ttbTelRes.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Telefone Residencial";
            // 
            // ttbEmail
            // 
            this.ttbEmail.Location = new System.Drawing.Point(323, 40);
            this.ttbEmail.MaxLength = 100;
            this.ttbEmail.Name = "ttbEmail";
            this.ttbEmail.Size = new System.Drawing.Size(308, 20);
            this.ttbEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular";
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDados.Controls.Add(this.gpbLocalizacao);
            this.pnlDados.Controls.Add(this.gpbContato);
            this.pnlDados.Controls.Add(this.gpbIdentificacaoDoCliente);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDados.Enabled = false;
            this.pnlDados.Location = new System.Drawing.Point(0, 70);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(657, 355);
            this.pnlDados.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(582, 0);
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
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.pnlBotoes.Size = new System.Drawing.Size(657, 70);
            this.pnlBotoes.TabIndex = 9;
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
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 425);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.gpbLocalizacao.ResumeLayout(false);
            this.gpbLocalizacao.PerformLayout();
            this.gpbIdentificacaoDoCliente.ResumeLayout(false);
            this.gpbIdentificacaoDoCliente.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLocalizacao;
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
        private System.Windows.Forms.GroupBox gpbIdentificacaoDoCliente;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ttbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox ttbCPF;
        private System.Windows.Forms.MaskedTextBox ttbCEP;
        private System.Windows.Forms.MaskedTextBox ttbRG;
        private System.Windows.Forms.MaskedTextBox ttbCelular;
        private System.Windows.Forms.MaskedTextBox ttbTelCom;
        private System.Windows.Forms.MaskedTextBox ttbTelRes;
        private System.Windows.Forms.MaskedTextBox ttbCNPJ;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAssociaContasBanco;
    }
}