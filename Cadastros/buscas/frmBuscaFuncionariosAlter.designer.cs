namespace SAEA.Cadastros.Consultas
{
    partial class frmConsultaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFuncionarios));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtCidade = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.ttbFiltroCidade = new System.Windows.Forms.TextBox();
            this.ttbFiltroNome = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.fun_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBotoes.Size = new System.Drawing.Size(634, 70);
            this.pnlBotoes.TabIndex = 12;
            this.pnlBotoes.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(559, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
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
            this.btnSelecionar.Size = new System.Drawing.Size(75, 70);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 70);
            this.btnLocalizar.TabIndex = 0;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCidade);
            this.groupBox1.Controls.Add(this.rbtNome);
            this.groupBox1.Controls.Add(this.ttbFiltroCidade);
            this.groupBox1.Controls.Add(this.ttbFiltroNome);
            this.groupBox1.Location = new System.Drawing.Point(11, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // rbtCidade
            // 
            this.rbtCidade.AutoSize = true;
            this.rbtCidade.Location = new System.Drawing.Point(16, 57);
            this.rbtCidade.Name = "rbtCidade";
            this.rbtCidade.Size = new System.Drawing.Size(58, 17);
            this.rbtCidade.TabIndex = 2;
            this.rbtCidade.Text = "Cidade";
            this.rbtCidade.UseVisualStyleBackColor = true;
            this.rbtCidade.CheckedChanged += new System.EventHandler(this.rbtCidade_CheckedChanged);
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Checked = true;
            this.rbtNome.Location = new System.Drawing.Point(16, 25);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(53, 17);
            this.rbtNome.TabIndex = 0;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // ttbFiltroCidade
            // 
            this.ttbFiltroCidade.Enabled = false;
            this.ttbFiltroCidade.Location = new System.Drawing.Point(108, 56);
            this.ttbFiltroCidade.MaxLength = 50;
            this.ttbFiltroCidade.Name = "ttbFiltroCidade";
            this.ttbFiltroCidade.Size = new System.Drawing.Size(333, 20);
            this.ttbFiltroCidade.TabIndex = 1;
            this.ttbFiltroCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttbFiltroCidade_KeyDown);
            // 
            // ttbFiltroNome
            // 
            this.ttbFiltroNome.Location = new System.Drawing.Point(108, 19);
            this.ttbFiltroNome.MaxLength = 60;
            this.ttbFiltroNome.Name = "ttbFiltroNome";
            this.ttbFiltroNome.Size = new System.Drawing.Size(333, 20);
            this.ttbFiltroNome.TabIndex = 0;
            this.ttbFiltroNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttbFiltroNome_KeyDown);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fun_codigo,
            this.fun_nome,
            this.fun_rg,
            this.fun_cpf,
            this.Column4,
            this.Column20,
            this.Column2,
            this.Column3,
            this.Column18,
            this.Número,
            this.Column5,
            this.Column6});
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 191);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(634, 371);
            this.dgvFuncionarios.TabIndex = 1;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // fun_codigo
            // 
            this.fun_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fun_codigo.DataPropertyName = "fun_codigo";
            this.fun_codigo.HeaderText = "Código";
            this.fun_codigo.Name = "fun_codigo";
            this.fun_codigo.ReadOnly = true;
            // 
            // fun_nome
            // 
            this.fun_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fun_nome.DataPropertyName = "fun_nome";
            this.fun_nome.HeaderText = "Nome";
            this.fun_nome.Name = "fun_nome";
            this.fun_nome.ReadOnly = true;
            // 
            // fun_rg
            // 
            this.fun_rg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fun_rg.DataPropertyName = "fun_rg";
            this.fun_rg.HeaderText = "RG";
            this.fun_rg.Name = "fun_rg";
            this.fun_rg.ReadOnly = true;
            // 
            // fun_cpf
            // 
            this.fun_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fun_cpf.DataPropertyName = "fun_cpf";
            this.fun_cpf.HeaderText = "CPF";
            this.fun_cpf.Name = "fun_cpf";
            this.fun_cpf.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "fun_tipo";
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column20.DataPropertyName = "fun_telefone";
            this.Column20.HeaderText = "Telefone";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "fun_celular";
            this.Column2.HeaderText = "Celular";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "fun_email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column18.DataPropertyName = "fun_endereco";
            this.Column18.HeaderText = "Endereço";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // Número
            // 
            this.Número.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Número.DataPropertyName = "fun_numero";
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            this.Número.Visible = false;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "fun_cidade";
            this.Column5.HeaderText = "Cidade";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "fun_bairro";
            this.Column6.HeaderText = "Bairro";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // frmConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "frmConsultaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funcionários";
            this.pnlBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtCidade;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.TextBox ttbFiltroCidade;
        private System.Windows.Forms.TextBox ttbFiltroNome;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}