namespace SAEA.Movimentacao
{
    partial class frmRelatorioLocalizacaoProcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioLocalizacaoProcesso));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.GroupBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ckbSituacao = new System.Windows.Forms.CheckBox();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.rbSemFiltro = new System.Windows.Forms.RadioButton();
            this.cbbSituacao = new System.Windows.Forms.ComboBox();
            this.pnlBotoes.SuspendLayout();
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnGerar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(634, 70);
            this.pnlBotoes.TabIndex = 37;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(559, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // a
            // 
            this.a.Controls.Add(this.ttbNome);
            this.a.Controls.Add(this.cbbSituacao);
            this.a.Controls.Add(this.ckbSituacao);
            this.a.Controls.Add(this.ckbNome);
            this.a.Controls.Add(this.rbSemFiltro);
            this.a.Location = new System.Drawing.Point(12, 76);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(610, 113);
            this.a.TabIndex = 38;
            this.a.TabStop = false;
            this.a.Text = "Filtros";
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.SystemColors.Window;
            this.ttbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbNome.Location = new System.Drawing.Point(230, 27);
            this.ttbNome.MaxLength = 60;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(351, 20);
            this.ttbNome.TabIndex = 45;
            // 
            // ckbSituacao
            // 
            this.ckbSituacao.AutoSize = true;
            this.ckbSituacao.Location = new System.Drawing.Point(121, 69);
            this.ckbSituacao.Name = "ckbSituacao";
            this.ckbSituacao.Size = new System.Drawing.Size(68, 17);
            this.ckbSituacao.TabIndex = 40;
            this.ckbSituacao.Text = "Situação";
            this.ckbSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbSituacao.UseVisualStyleBackColor = true;
            this.ckbSituacao.CheckedChanged += new System.EventHandler(this.ckbNome_CheckedChanged);
            // 
            // ckbNome
            // 
            this.ckbNome.AutoSize = true;
            this.ckbNome.Location = new System.Drawing.Point(121, 30);
            this.ckbNome.Name = "ckbNome";
            this.ckbNome.Size = new System.Drawing.Size(103, 17);
            this.ckbNome.TabIndex = 39;
            this.ckbNome.Text = "Nome do cliente";
            this.ckbNome.UseVisualStyleBackColor = true;
            this.ckbNome.CheckedChanged += new System.EventHandler(this.ckbNome_CheckedChanged);
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
            this.rbSemFiltro.CheckedChanged += new System.EventHandler(this.rbSemFiltro_CheckedChanged);
            // 
            // cbbSituacao
            // 
            this.cbbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSituacao.FormattingEnabled = true;
            this.cbbSituacao.Items.AddRange(new object[] {
            "Em pasta",
            "Arquivado"});
            this.cbbSituacao.Location = new System.Drawing.Point(230, 65);
            this.cbbSituacao.Name = "cbbSituacao";
            this.cbbSituacao.Size = new System.Drawing.Size(351, 21);
            this.cbbSituacao.TabIndex = 44;
            // 
            // frmRelatorioLocalizacaoProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 194);
            this.Controls.Add(this.a);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioLocalizacaoProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de localização de processos";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.CheckBox ckbSituacao;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.RadioButton rbSemFiltro;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.ComboBox cbbSituacao;


    }
}