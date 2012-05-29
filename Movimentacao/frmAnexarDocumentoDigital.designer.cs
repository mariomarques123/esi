namespace SAEA.Movimentacao
{
    partial class frmAnexarDocumentoDigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnexarDocumentoDigital));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ttbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbProcessos = new System.Windows.Forms.ComboBox();
            this.dgvAnexos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.ggbDocumentoDigital = new System.Windows.Forms.GroupBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.ttbLocalizacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Anexos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAnexo = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.ofdAbrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.ggbDocumentoDigital.SuspendLayout();
            this.Anexos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(778, 70);
            this.pnlBotoes.TabIndex = 44;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(74, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 71);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.brnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(148, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 70);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Limpar tela";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(703, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 70);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(0, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 70);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Location = new System.Drawing.Point(14, 41);
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(81, 20);
            this.ttbCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descrição do Processo (*)";
            // 
            // ccbProcessos
            // 
            this.ccbProcessos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbProcessos.FormattingEnabled = true;
            this.ccbProcessos.Location = new System.Drawing.Point(101, 40);
            this.ccbProcessos.Name = "ccbProcessos";
            this.ccbProcessos.Size = new System.Drawing.Size(630, 21);
            this.ccbProcessos.TabIndex = 1;
            this.ccbProcessos.SelectionChangeCommitted += new System.EventHandler(this.ccbProcessos_SelectionChangeCommitted);
            // 
            // dgvAnexos
            // 
            this.dgvAnexos.AllowUserToAddRows = false;
            this.dgvAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnexos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Column1,
            this.descricao,
            this.Column17});
            this.dgvAnexos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnexos.Location = new System.Drawing.Point(3, 48);
            this.dgvAnexos.Name = "dgvAnexos";
            this.dgvAnexos.ReadOnly = true;
            this.dgvAnexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnexos.Size = new System.Drawing.Size(748, 240);
            this.dgvAnexos.TabIndex = 2;
            this.dgvAnexos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnexos_CellClick);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.DataPropertyName = "dod_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "pro_numero";
            this.Column1.HeaderText = "Número do processo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 119;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.DataPropertyName = "dod_descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column17.DataPropertyName = "dod_localizacao";
            this.Column17.HeaderText = "Localização";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 89;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.ggbDocumentoDigital);
            this.pnlDados.Controls.Add(this.Anexos);
            this.pnlDados.Location = new System.Drawing.Point(0, 76);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(778, 498);
            this.pnlDados.TabIndex = 62;
            // 
            // ggbDocumentoDigital
            // 
            this.ggbDocumentoDigital.Controls.Add(this.btnAbrirImagem);
            this.ggbDocumentoDigital.Controls.Add(this.label5);
            this.ggbDocumentoDigital.Controls.Add(this.btnVisualizar);
            this.ggbDocumentoDigital.Controls.Add(this.label3);
            this.ggbDocumentoDigital.Controls.Add(this.ccbProcessos);
            this.ggbDocumentoDigital.Controls.Add(this.ttbDescricao);
            this.ggbDocumentoDigital.Controls.Add(this.ttbLocalizacao);
            this.ggbDocumentoDigital.Controls.Add(this.label4);
            this.ggbDocumentoDigital.Controls.Add(this.label2);
            this.ggbDocumentoDigital.Controls.Add(this.label1);
            this.ggbDocumentoDigital.Controls.Add(this.ttbCodigo);
            this.ggbDocumentoDigital.Location = new System.Drawing.Point(12, 3);
            this.ggbDocumentoDigital.Name = "ggbDocumentoDigital";
            this.ggbDocumentoDigital.Size = new System.Drawing.Size(751, 186);
            this.ggbDocumentoDigital.TabIndex = 0;
            this.ggbDocumentoDigital.TabStop = false;
            this.ggbDocumentoDigital.Text = "Documento Digital";
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirImagem.Image")));
            this.btnAbrirImagem.Location = new System.Drawing.Point(706, 119);
            this.btnAbrirImagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(25, 20);
            this.btnAbrirImagem.TabIndex = 4;
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(11, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 15);
            this.label5.TabIndex = 66;
            this.label5.Text = "(*) Campo de preenchimento obrigatório.";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(508, 152);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(223, 23);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar documento";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(14, 80);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(717, 20);
            this.ttbDescricao.TabIndex = 2;
            // 
            // ttbLocalizacao
            // 
            this.ttbLocalizacao.Location = new System.Drawing.Point(14, 119);
            this.ttbLocalizacao.Name = "ttbLocalizacao";
            this.ttbLocalizacao.Size = new System.Drawing.Size(701, 20);
            this.ttbLocalizacao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Documento (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Descrição do documento";
            // 
            // Anexos
            // 
            this.Anexos.Controls.Add(this.btnRemoverAnexo);
            this.Anexos.Controls.Add(this.btnAnexar);
            this.Anexos.Controls.Add(this.dgvAnexos);
            this.Anexos.Location = new System.Drawing.Point(12, 195);
            this.Anexos.Name = "Anexos";
            this.Anexos.Size = new System.Drawing.Size(754, 291);
            this.Anexos.TabIndex = 1;
            this.Anexos.TabStop = false;
            this.Anexos.Text = "Anexados ao processo";
            // 
            // btnRemoverAnexo
            // 
            this.btnRemoverAnexo.Location = new System.Drawing.Point(621, 19);
            this.btnRemoverAnexo.Name = "btnRemoverAnexo";
            this.btnRemoverAnexo.Size = new System.Drawing.Size(110, 23);
            this.btnRemoverAnexo.TabIndex = 1;
            this.btnRemoverAnexo.Text = "Remover Anexo";
            this.btnRemoverAnexo.UseVisualStyleBackColor = true;
            this.btnRemoverAnexo.Click += new System.EventHandler(this.btnRemoverAnexo_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(508, 19);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(110, 23);
            this.btnAnexar.TabIndex = 0;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // ofdAbrirImagem
            // 
            this.ofdAbrirImagem.FileName = "openFileDialog1";
            // 
            // frmAnexarDocumentoDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 574);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAnexarDocumentoDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexar Documento Digital";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.ggbDocumentoDigital.ResumeLayout(false);
            this.ggbDocumentoDigital.PerformLayout();
            this.Anexos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox ttbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccbProcessos;
        private System.Windows.Forms.DataGridView dgvAnexos;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemoverAnexo;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.OpenFileDialog ofdAbrirImagem;
        private System.Windows.Forms.GroupBox ggbDocumentoDigital;
        private System.Windows.Forms.TextBox ttbLocalizacao;
        private System.Windows.Forms.GroupBox Anexos;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Button btnAbrirImagem;
    }
}