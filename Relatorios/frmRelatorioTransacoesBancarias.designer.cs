namespace SAEA.Relatorios
{
    partial class frmRelatorioTransacoesBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioTransacoesBancarias));
            this.a = new System.Windows.Forms.GroupBox();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.ckbTipo = new System.Windows.Forms.CheckBox();
            this.ckbPeriodo = new System.Windows.Forms.CheckBox();
            this.rbSemFiltro = new System.Windows.Forms.RadioButton();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.cbbTipo);
            this.a.Controls.Add(this.dtpFim);
            this.a.Controls.Add(this.dtpIni);
            this.a.Controls.Add(this.lblA);
            this.a.Controls.Add(this.ckbTipo);
            this.a.Controls.Add(this.ckbPeriodo);
            this.a.Controls.Add(this.rbSemFiltro);
            this.a.Location = new System.Drawing.Point(12, 76);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(418, 117);
            this.a.TabIndex = 8;
            this.a.TabStop = false;
            this.a.Text = "Filtros";
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.Enabled = false;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "C",
            "D"});
            this.cbbTipo.Location = new System.Drawing.Point(200, 62);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(193, 21);
            this.cbbTipo.TabIndex = 44;
            // 
            // dtpFim
            // 
            this.dtpFim.Enabled = false;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(310, 29);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(83, 20);
            this.dtpFim.TabIndex = 42;
            // 
            // dtpIni
            // 
            this.dtpIni.Enabled = false;
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(200, 30);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(85, 20);
            this.dtpIni.TabIndex = 43;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Enabled = false;
            this.lblA.Location = new System.Drawing.Point(291, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 41;
            this.lblA.Text = "à";
            // 
            // ckbTipo
            // 
            this.ckbTipo.AutoSize = true;
            this.ckbTipo.Location = new System.Drawing.Point(121, 66);
            this.ckbTipo.Name = "ckbTipo";
            this.ckbTipo.Size = new System.Drawing.Size(47, 17);
            this.ckbTipo.TabIndex = 40;
            this.ckbTipo.Text = "Tipo";
            this.ckbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbTipo.UseVisualStyleBackColor = true;
            // 
            // ckbPeriodo
            // 
            this.ckbPeriodo.AutoSize = true;
            this.ckbPeriodo.Location = new System.Drawing.Point(121, 30);
            this.ckbPeriodo.Name = "ckbPeriodo";
            this.ckbPeriodo.Size = new System.Drawing.Size(64, 17);
            this.ckbPeriodo.TabIndex = 39;
            this.ckbPeriodo.Text = "Período";
            this.ckbPeriodo.UseVisualStyleBackColor = true;
            // 
            // rbSemFiltro
            // 
            this.rbSemFiltro.AutoSize = true;
            this.rbSemFiltro.Checked = true;
            this.rbSemFiltro.Location = new System.Drawing.Point(26, 29);
            this.rbSemFiltro.Name = "rbSemFiltro";
            this.rbSemFiltro.Size = new System.Drawing.Size(68, 17);
            this.rbSemFiltro.TabIndex = 2;
            this.rbSemFiltro.TabStop = true;
            this.rbSemFiltro.Text = "Sem filtro";
            this.rbSemFiltro.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnGerar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(442, 70);
            this.pnlBotoes.TabIndex = 36;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(367, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSize = true;
            this.btnGerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.Location = new System.Drawing.Point(0, 0);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 70);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // frmRelatorioTransacoesBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 201);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.a);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioTransacoesBancarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de transações bancárias";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.RadioButton rbSemFiltro;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.CheckBox ckbTipo;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.CheckBox ckbPeriodo;
        private System.Windows.Forms.ComboBox cbbTipo;

    }
}