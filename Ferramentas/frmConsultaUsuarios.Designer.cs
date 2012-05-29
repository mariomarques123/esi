namespace SAEA.Ferramentas
{
    partial class frmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ccbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.rbtNivelAcesso = new System.Windows.Forms.RadioButton();
            this.rbtLogin = new System.Windows.Forms.RadioButton();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelacesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ccbNivelAcesso);
            this.groupBox1.Controls.Add(this.rbtNivelAcesso);
            this.groupBox1.Controls.Add(this.rbtLogin);
            this.groupBox1.Controls.Add(this.ttbLogin);
            this.groupBox1.Location = new System.Drawing.Point(11, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 94);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // ccbNivelAcesso
            // 
            this.ccbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbNivelAcesso.FormattingEnabled = true;
            this.ccbNivelAcesso.Location = new System.Drawing.Point(127, 53);
            this.ccbNivelAcesso.Name = "ccbNivelAcesso";
            this.ccbNivelAcesso.Size = new System.Drawing.Size(333, 21);
            this.ccbNivelAcesso.TabIndex = 3;
            this.ccbNivelAcesso.SelectionChangeCommitted += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // rbtNivelAcesso
            // 
            this.rbtNivelAcesso.AutoSize = true;
            this.rbtNivelAcesso.Location = new System.Drawing.Point(16, 57);
            this.rbtNivelAcesso.Name = "rbtNivelAcesso";
            this.rbtNivelAcesso.Size = new System.Drawing.Size(101, 17);
            this.rbtNivelAcesso.TabIndex = 2;
            this.rbtNivelAcesso.Text = "Nivel de acesso";
            this.rbtNivelAcesso.UseVisualStyleBackColor = true;
            this.rbtNivelAcesso.CheckedChanged += new System.EventHandler(this.rbtNivelAcesso_CheckedChanged);
            // 
            // rbtLogin
            // 
            this.rbtLogin.AutoSize = true;
            this.rbtLogin.Checked = true;
            this.rbtLogin.Location = new System.Drawing.Point(16, 25);
            this.rbtLogin.Name = "rbtLogin";
            this.rbtLogin.Size = new System.Drawing.Size(105, 17);
            this.rbtLogin.TabIndex = 0;
            this.rbtLogin.TabStop = true;
            this.rbtLogin.Text = "Nome de usuário";
            this.rbtLogin.UseVisualStyleBackColor = true;
            this.rbtLogin.CheckedChanged += new System.EventHandler(this.rbtLogin_CheckedChanged);
            // 
            // ttbLogin
            // 
            this.ttbLogin.Location = new System.Drawing.Point(127, 19);
            this.ttbLogin.MaxLength = 60;
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(333, 20);
            this.ttbLogin.TabIndex = 1;
            this.ttbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttbLogin_KeyDown);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Column1,
            this.Column4,
            this.Column3,
            this.nivelacesso,
            this.Column2});
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 191);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(634, 371);
            this.dgvUsuarios.TabIndex = 20;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
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
            this.pnlBotoes.TabIndex = 18;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(559, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
            this.btnFechar.TabIndex = 6;
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
            this.btnSelecionar.TabIndex = 3;
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
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Login.DataPropertyName = "usu_login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 58;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "usu_senha";
            this.Column1.HeaderText = "Senha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 63;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "usu_nomenivel";
            this.Column4.HeaderText = "Nível de acesso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fun_nome";
            this.Column3.HeaderText = "Nome do Funcionário";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // nivelacesso
            // 
            this.nivelacesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nivelacesso.DataPropertyName = "usu_nivelacesso";
            this.nivelacesso.HeaderText = "usu_nivelacesso";
            this.nivelacesso.Name = "nivelacesso";
            this.nivelacesso.ReadOnly = true;
            this.nivelacesso.Visible = false;
            this.nivelacesso.Width = 111;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "fun_codigo";
            this.Column2.HeaderText = "fun_cod";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 71;
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuários";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaFuncionarios_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNivelAcesso;
        private System.Windows.Forms.RadioButton rbtLogin;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox ccbNivelAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelacesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}