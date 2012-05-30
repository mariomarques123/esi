namespace SAEA.Cadastros
{
    partial class frmConsultaPastas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPastas));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtLocalizacao = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.ttbLocalizacao = new System.Windows.Forms.TextBox();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.dgvPastas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastas)).BeginInit();
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
            this.pnlBotoes.TabIndex = 15;
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
            this.groupBox1.Controls.Add(this.rbtLocalizacao);
            this.groupBox1.Controls.Add(this.rbtCodigo);
            this.groupBox1.Controls.Add(this.ttbLocalizacao);
            this.groupBox1.Controls.Add(this.ttbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(11, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // rbtLocalizacao
            // 
            this.rbtLocalizacao.AutoSize = true;
            this.rbtLocalizacao.Checked = true;
            this.rbtLocalizacao.Location = new System.Drawing.Point(16, 28);
            this.rbtLocalizacao.Name = "rbtLocalizacao";
            this.rbtLocalizacao.Size = new System.Drawing.Size(82, 17);
            this.rbtLocalizacao.TabIndex = 0;
            this.rbtLocalizacao.TabStop = true;
            this.rbtLocalizacao.Text = "Localização";
            this.rbtLocalizacao.UseVisualStyleBackColor = true;
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(16, 54);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtCodigo.TabIndex = 2;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            this.rbtCodigo.CheckedChanged += new System.EventHandler(this.rbtCodigo_CheckedChanged_1);
            // 
            // ttbLocalizacao
            // 
            this.ttbLocalizacao.Location = new System.Drawing.Point(108, 27);
            this.ttbLocalizacao.MaxLength = 50;
            this.ttbLocalizacao.Name = "ttbLocalizacao";
            this.ttbLocalizacao.Size = new System.Drawing.Size(333, 20);
            this.ttbLocalizacao.TabIndex = 1;
            this.ttbLocalizacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttbCodigo_KeyDown);
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Enabled = false;
            this.ttbCodigo.Location = new System.Drawing.Point(108, 53);
            this.ttbCodigo.MaxLength = 60;
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(333, 20);
            this.ttbCodigo.TabIndex = 3;
            this.ttbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttbCodigo_KeyDown);
            // 
            // dgvPastas
            // 
            this.dgvPastas.AllowUserToAddRows = false;
            this.dgvPastas.AllowUserToDeleteRows = false;
            this.dgvPastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.a,
            this.Column17,
            this.Column1});
            this.dgvPastas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPastas.Location = new System.Drawing.Point(0, 191);
            this.dgvPastas.Name = "dgvPastas";
            this.dgvPastas.ReadOnly = true;
            this.dgvPastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastas.Size = new System.Drawing.Size(634, 371);
            this.dgvPastas.TabIndex = 1;
            this.dgvPastas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "pas_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // a
            // 
            this.a.DataPropertyName = "pro_descricao";
            this.a.HeaderText = "Descrição do processo";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column17.DataPropertyName = "pas_locpasta";
            this.Column17.HeaderText = "Localização";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 89;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "pro_numero";
            this.Column1.HeaderText = "Número do processo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 119;
            // 
            // frmConsultaPastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPastas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultaPastas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pastas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaFuncionarios_KeyDown);
            this.pnlBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtLocalizacao;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.TextBox ttbLocalizacao;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.DataGridView dgvPastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}