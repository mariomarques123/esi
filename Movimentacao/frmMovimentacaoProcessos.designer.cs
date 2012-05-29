namespace SAEA.Movimentacao
{
    partial class frmMovimentacaoProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoProcessos));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.ccbProcessos = new System.Windows.Forms.ComboBox();
            this.ccbPastas = new System.Windows.Forms.ComboBox();
            this.rdbArquivo = new System.Windows.Forms.RadioButton();
            this.gpbLocalAtual = new System.Windows.Forms.GroupBox();
            this.rdbPasta = new System.Windows.Forms.RadioButton();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.gbpProcesso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.gpbLocalAtual.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.gbpProcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnGravar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(681, 70);
            this.pnlBotoes.TabIndex = 45;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(606, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(75, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Limpar tela";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(0, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 70);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // ccbProcessos
            // 
            this.ccbProcessos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbProcessos.FormattingEnabled = true;
            this.ccbProcessos.Location = new System.Drawing.Point(144, 29);
            this.ccbProcessos.Name = "ccbProcessos";
            this.ccbProcessos.Size = new System.Drawing.Size(494, 21);
            this.ccbProcessos.TabIndex = 0;
            this.ccbProcessos.SelectionChangeCommitted += new System.EventHandler(this.ccbProcessos_SelectionChangeCommitted);
            // 
            // ccbPastas
            // 
            this.ccbPastas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPastas.Enabled = false;
            this.ccbPastas.FormattingEnabled = true;
            this.ccbPastas.Location = new System.Drawing.Point(144, 56);
            this.ccbPastas.Name = "ccbPastas";
            this.ccbPastas.Size = new System.Drawing.Size(494, 21);
            this.ccbPastas.TabIndex = 2;
            // 
            // rdbArquivo
            // 
            this.rdbArquivo.AutoSize = true;
            this.rdbArquivo.Location = new System.Drawing.Point(16, 30);
            this.rdbArquivo.Name = "rdbArquivo";
            this.rdbArquivo.Size = new System.Drawing.Size(73, 17);
            this.rdbArquivo.TabIndex = 0;
            this.rdbArquivo.TabStop = true;
            this.rdbArquivo.Text = "Arquivado";
            this.rdbArquivo.UseVisualStyleBackColor = true;
            // 
            // gpbLocalAtual
            // 
            this.gpbLocalAtual.Controls.Add(this.rdbPasta);
            this.gpbLocalAtual.Controls.Add(this.rdbArquivo);
            this.gpbLocalAtual.Controls.Add(this.ccbPastas);
            this.gpbLocalAtual.Enabled = false;
            this.gpbLocalAtual.Location = new System.Drawing.Point(12, 81);
            this.gpbLocalAtual.Name = "gpbLocalAtual";
            this.gpbLocalAtual.Size = new System.Drawing.Size(657, 99);
            this.gpbLocalAtual.TabIndex = 1;
            this.gpbLocalAtual.TabStop = false;
            this.gpbLocalAtual.Text = "Local atual";
            // 
            // rdbPasta
            // 
            this.rdbPasta.AutoSize = true;
            this.rdbPasta.Location = new System.Drawing.Point(16, 60);
            this.rdbPasta.Name = "rdbPasta";
            this.rdbPasta.Size = new System.Drawing.Size(52, 17);
            this.rdbPasta.TabIndex = 1;
            this.rdbPasta.TabStop = true;
            this.rdbPasta.Text = "Pasta";
            this.rdbPasta.UseVisualStyleBackColor = true;
            this.rdbPasta.CheckedChanged += new System.EventHandler(this.rdbPasta_CheckedChanged);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.gpbLocalAtual);
            this.pnlDados.Controls.Add(this.gbpProcesso);
            this.pnlDados.Location = new System.Drawing.Point(0, 76);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(681, 191);
            this.pnlDados.TabIndex = 48;
            // 
            // gbpProcesso
            // 
            this.gbpProcesso.Controls.Add(this.label1);
            this.gbpProcesso.Controls.Add(this.ccbProcessos);
            this.gbpProcesso.Location = new System.Drawing.Point(12, 9);
            this.gbpProcesso.Name = "gbpProcesso";
            this.gbpProcesso.Size = new System.Drawing.Size(657, 66);
            this.gbpProcesso.TabIndex = 2;
            this.gbpProcesso.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o processo";
            // 
            // frmMovimentacaoProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 268);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMovimentacaoProcessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de processos";
            this.pnlBotoes.ResumeLayout(false);
            this.gpbLocalAtual.ResumeLayout(false);
            this.gpbLocalAtual.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.gbpProcesso.ResumeLayout(false);
            this.gbpProcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox ccbProcessos;
        private System.Windows.Forms.ComboBox ccbPastas;
        private System.Windows.Forms.RadioButton rdbArquivo;
        private System.Windows.Forms.GroupBox gpbLocalAtual;
        private System.Windows.Forms.RadioButton rdbPasta;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbpProcesso;
        private System.Windows.Forms.Label label1;
    }
}