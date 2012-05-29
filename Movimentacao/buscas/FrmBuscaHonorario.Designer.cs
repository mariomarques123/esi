namespace SAEA.Movimentacao.buscas
{
    partial class FrmBuscaHonorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaHonorario));
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.rbConta = new System.Windows.Forms.RadioButton();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.hon_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_datainicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_parcelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_quantidadeparcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hon_diasParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_nivelacesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbNumeroConta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(17, 32);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(117, 17);
            this.rbCodigo.TabIndex = 48;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código do cadastro";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNumeroConta);
            this.groupBox1.Controls.Add(this.ttbCodigo);
            this.groupBox1.Controls.Add(this.rbConta);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 113);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca";
            // 
            // ttbCodigo
            // 
            this.ttbCodigo.Location = new System.Drawing.Point(140, 32);
            this.ttbCodigo.Mask = "0000000";
            this.ttbCodigo.Name = "ttbCodigo";
            this.ttbCodigo.Size = new System.Drawing.Size(147, 20);
            this.ttbCodigo.TabIndex = 52;
            // 
            // rbConta
            // 
            this.rbConta.AutoSize = true;
            this.rbConta.Location = new System.Drawing.Point(17, 55);
            this.rbConta.Name = "rbConta";
            this.rbConta.Size = new System.Drawing.Size(123, 17);
            this.rbConta.TabIndex = 49;
            this.rbConta.TabStop = true;
            this.rbConta.Text = "Número do processo";
            this.rbConta.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(473, 70);
            this.pnlBotoes.TabIndex = 50;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(398, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.dgvResultado.Location = new System.Drawing.Point(0, 199);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(473, 320);
            this.dgvResultado.TabIndex = 51;
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
            // ttbNumeroConta
            // 
            this.ttbNumeroConta.Location = new System.Drawing.Point(140, 58);
            this.ttbNumeroConta.MaxLength = 35;
            this.ttbNumeroConta.Name = "ttbNumeroConta";
            this.ttbNumeroConta.Size = new System.Drawing.Size(147, 20);
            this.ttbNumeroConta.TabIndex = 53;
            // 
            // FrmBuscaHonorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.dgvResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscaHonorario";
            this.Text = "Busca de honorários";
            this.Load += new System.EventHandler(this.FrmBuscaHonorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox ttbCodigo;
        private System.Windows.Forms.RadioButton rbConta;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_datainicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_parcelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_quantidadeparcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hon_diasParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_nivelacesso;
        private System.Windows.Forms.TextBox ttbNumeroConta;
    }
}