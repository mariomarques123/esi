namespace SAEA.Movimentacao
{
    partial class frmRelatorioHonorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioHonorarios));
            this.a = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ttbCliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ttbNumeroProcesso = new System.Windows.Forms.TextBox();
            this.rbProcesso = new System.Windows.Forms.RadioButton();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbSem = new System.Windows.Forms.RadioButton();
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.hon_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_datainicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_parcelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_quantidadeparcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hon_diasParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_nivelacesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a.SuspendLayout();
            this.grbPeriodo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.button1);
            this.a.Controls.Add(this.ttbCliente);
            this.a.Controls.Add(this.button2);
            this.a.Controls.Add(this.ttbNumeroProcesso);
            this.a.Controls.Add(this.rbProcesso);
            this.a.Controls.Add(this.rbPeriodo);
            this.a.Controls.Add(this.rbCliente);
            this.a.Controls.Add(this.rbSem);
            this.a.Location = new System.Drawing.Point(12, 79);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(413, 126);
            this.a.TabIndex = 8;
            this.a.TabStop = false;
            this.a.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(328, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Localizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ttbCliente
            // 
            this.ttbCliente.Enabled = false;
            this.ttbCliente.Location = new System.Drawing.Point(198, 27);
            this.ttbCliente.Name = "ttbCliente";
            this.ttbCliente.Size = new System.Drawing.Size(124, 20);
            this.ttbCliente.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(328, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Localizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ttbNumeroProcesso
            // 
            this.ttbNumeroProcesso.Enabled = false;
            this.ttbNumeroProcesso.Location = new System.Drawing.Point(198, 86);
            this.ttbNumeroProcesso.Name = "ttbNumeroProcesso";
            this.ttbNumeroProcesso.Size = new System.Drawing.Size(124, 20);
            this.ttbNumeroProcesso.TabIndex = 24;
            // 
            // rbProcesso
            // 
            this.rbProcesso.AutoSize = true;
            this.rbProcesso.Location = new System.Drawing.Point(104, 89);
            this.rbProcesso.Name = "rbProcesso";
            this.rbProcesso.Size = new System.Drawing.Size(88, 17);
            this.rbProcesso.TabIndex = 3;
            this.rbProcesso.Text = "Por Processo";
            this.rbProcesso.UseVisualStyleBackColor = true;
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Location = new System.Drawing.Point(19, 50);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(63, 17);
            this.rbPeriodo.TabIndex = 4;
            this.rbPeriodo.Text = "Período";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            this.rbPeriodo.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(104, 27);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(76, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Por Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbSem
            // 
            this.rbSem.AutoSize = true;
            this.rbSem.Checked = true;
            this.rbSem.Location = new System.Drawing.Point(19, 27);
            this.rbSem.Name = "rbSem";
            this.rbSem.Size = new System.Drawing.Size(68, 17);
            this.rbSem.TabIndex = 2;
            this.rbSem.TabStop = true;
            this.rbSem.Text = "Sem filtro";
            this.rbSem.UseVisualStyleBackColor = true;
            // 
            // grbPeriodo
            // 
            this.grbPeriodo.Controls.Add(this.label3);
            this.grbPeriodo.Controls.Add(this.dtpFim);
            this.grbPeriodo.Controls.Add(this.dtpInicio);
            this.grbPeriodo.Controls.Add(this.label2);
            this.grbPeriodo.Enabled = false;
            this.grbPeriodo.Location = new System.Drawing.Point(431, 79);
            this.grbPeriodo.Name = "grbPeriodo";
            this.grbPeriodo.Size = new System.Drawing.Size(191, 126);
            this.grbPeriodo.TabIndex = 39;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Início";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(68, 73);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(100, 20);
            this.dtpFim.TabIndex = 14;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(68, 46);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpInicio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fim";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnGerar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(634, 70);
            this.pnlBotoes.TabIndex = 40;
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
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(75, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 70);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hon_codigo,
            this.pro_numero,
            this.hon_datainicial,
            this.hon_parcelado,
            this.hon_quantidadeparcelas,
            this.hon_descricao,
            this.Hon_diasParcelas,
            this.hon_nivelacesso});
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultado.Location = new System.Drawing.Point(0, 211);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(634, 302);
            this.dgvResultado.TabIndex = 52;
            // 
            // hon_codigo
            // 
            this.hon_codigo.DataPropertyName = "hon_codigo";
            this.hon_codigo.HeaderText = "Codigo";
            this.hon_codigo.Name = "hon_codigo";
            this.hon_codigo.ReadOnly = true;
            // 
            // pro_numero
            // 
            this.pro_numero.DataPropertyName = "pro_numero";
            this.pro_numero.HeaderText = "Numero do processo";
            this.pro_numero.Name = "pro_numero";
            this.pro_numero.ReadOnly = true;
            // 
            // hon_datainicial
            // 
            this.hon_datainicial.DataPropertyName = "hon_datainicial";
            this.hon_datainicial.HeaderText = "Data inicial";
            this.hon_datainicial.Name = "hon_datainicial";
            this.hon_datainicial.ReadOnly = true;
            // 
            // hon_parcelado
            // 
            this.hon_parcelado.DataPropertyName = "hon_parcelado";
            this.hon_parcelado.HeaderText = "Tipo de pagamento";
            this.hon_parcelado.Name = "hon_parcelado";
            this.hon_parcelado.ReadOnly = true;
            // 
            // hon_quantidadeparcelas
            // 
            this.hon_quantidadeparcelas.DataPropertyName = "hon_quantidadeparcelas";
            this.hon_quantidadeparcelas.HeaderText = "Quantidade Parcelas";
            this.hon_quantidadeparcelas.Name = "hon_quantidadeparcelas";
            this.hon_quantidadeparcelas.ReadOnly = true;
            // 
            // hon_descricao
            // 
            this.hon_descricao.DataPropertyName = "hon_descricao";
            this.hon_descricao.HeaderText = "Descricao";
            this.hon_descricao.Name = "hon_descricao";
            this.hon_descricao.ReadOnly = true;
            // 
            // Hon_diasParcelas
            // 
            this.Hon_diasParcelas.DataPropertyName = "Hon_diasParcelas";
            this.Hon_diasParcelas.HeaderText = "Dias entre parcelas";
            this.Hon_diasParcelas.Name = "Hon_diasParcelas";
            this.Hon_diasParcelas.ReadOnly = true;
            // 
            // hon_nivelacesso
            // 
            this.hon_nivelacesso.DataPropertyName = "hon_nivelacesso";
            this.hon_nivelacesso.HeaderText = "Nível de acesso";
            this.hon_nivelacesso.Name = "hon_nivelacesso";
            this.hon_nivelacesso.ReadOnly = true;
            // 
            // frmRelatorioHonorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 513);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grbPeriodo);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioHonorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de honorários";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.RadioButton rbProcesso;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbSem;
        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_datainicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_parcelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_quantidadeparcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hon_diasParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_nivelacesso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ttbCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ttbNumeroProcesso;

    }
}