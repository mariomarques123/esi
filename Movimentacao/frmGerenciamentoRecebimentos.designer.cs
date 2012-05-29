namespace SAEA.Movimentacao
{
    partial class frmGerenciamentoRecebimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciamentoRecebimentos));
            this.grbRecebimentos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbClientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataRecebimentoEfetiva = new System.Windows.Forms.DateTimePicker();
            this.grbCriterio = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbProcesso = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.ttbCriterio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbRecebido = new System.Windows.Forms.RadioButton();
            this.rbNaoRecebido = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbHonorario = new System.Windows.Forms.RadioButton();
            this.rbCusta = new System.Windows.Forms.RadioButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.ttbValor = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEfetivarRecebimento = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Rece_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rece_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rece_dataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rece_datareceb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rece_valorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hon_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rece_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbRecebimentos.SuspendLayout();
            this.grbCriterio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRecebimentos
            // 
            this.grbRecebimentos.Controls.Add(this.label1);
            this.grbRecebimentos.Controls.Add(this.ttbClientes);
            this.grbRecebimentos.Controls.Add(this.label4);
            this.grbRecebimentos.Controls.Add(this.dtpDataRecebimentoEfetiva);
            this.grbRecebimentos.Controls.Add(this.grbCriterio);
            this.grbRecebimentos.Controls.Add(this.groupBox2);
            this.grbRecebimentos.Controls.Add(this.groupBox1);
            this.grbRecebimentos.Controls.Add(this.btnAtualizar);
            this.grbRecebimentos.Controls.Add(this.ttbValor);
            this.grbRecebimentos.Controls.Add(this.label10);
            this.grbRecebimentos.Controls.Add(this.btnEfetivarRecebimento);
            this.grbRecebimentos.Controls.Add(this.dgvResultado);
            this.grbRecebimentos.Location = new System.Drawing.Point(12, 12);
            this.grbRecebimentos.Name = "grbRecebimentos";
            this.grbRecebimentos.Size = new System.Drawing.Size(802, 342);
            this.grbRecebimentos.TabIndex = 55;
            this.grbRecebimentos.TabStop = false;
            this.grbRecebimentos.Text = "Recebimentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Clientes";
            // 
            // ttbClientes
            // 
            this.ttbClientes.Enabled = false;
            this.ttbClientes.Location = new System.Drawing.Point(465, 75);
            this.ttbClientes.Name = "ttbClientes";
            this.ttbClientes.Size = new System.Drawing.Size(315, 20);
            this.ttbClientes.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Data recebimento";
            // 
            // dtpDataRecebimentoEfetiva
            // 
            this.dtpDataRecebimentoEfetiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRecebimentoEfetiva.Location = new System.Drawing.Point(665, 230);
            this.dtpDataRecebimentoEfetiva.Name = "dtpDataRecebimentoEfetiva";
            this.dtpDataRecebimentoEfetiva.Size = new System.Drawing.Size(106, 20);
            this.dtpDataRecebimentoEfetiva.TabIndex = 77;
            // 
            // grbCriterio
            // 
            this.grbCriterio.Controls.Add(this.rbCliente);
            this.grbCriterio.Controls.Add(this.rbProcesso);
            this.grbCriterio.Controls.Add(this.label12);
            this.grbCriterio.Controls.Add(this.ttbCriterio);
            this.grbCriterio.Location = new System.Drawing.Point(411, 19);
            this.grbCriterio.Name = "grbCriterio";
            this.grbCriterio.Size = new System.Drawing.Size(369, 43);
            this.grbCriterio.TabIndex = 85;
            this.grbCriterio.TabStop = false;
            this.grbCriterio.Text = "Critério de busca";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(10, 19);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 80;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbProcesso
            // 
            this.rbProcesso.AutoSize = true;
            this.rbProcesso.Location = new System.Drawing.Point(73, 18);
            this.rbProcesso.Name = "rbProcesso";
            this.rbProcesso.Size = new System.Drawing.Size(69, 17);
            this.rbProcesso.TabIndex = 80;
            this.rbProcesso.TabStop = true;
            this.rbProcesso.Text = "Processo";
            this.rbProcesso.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Critério";
            // 
            // ttbCriterio
            // 
            this.ttbCriterio.Location = new System.Drawing.Point(210, 15);
            this.ttbCriterio.MaxLength = 35;
            this.ttbCriterio.Name = "ttbCriterio";
            this.ttbCriterio.Size = new System.Drawing.Size(144, 20);
            this.ttbCriterio.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rbRecebido);
            this.groupBox2.Controls.Add(this.rbNaoRecebido);
            this.groupBox2.Location = new System.Drawing.Point(225, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 76);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleção";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 82;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ambos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbRecebido
            // 
            this.rbRecebido.AutoSize = true;
            this.rbRecebido.Location = new System.Drawing.Point(10, 19);
            this.rbRecebido.Name = "rbRecebido";
            this.rbRecebido.Size = new System.Drawing.Size(71, 17);
            this.rbRecebido.TabIndex = 80;
            this.rbRecebido.TabStop = true;
            this.rbRecebido.Text = "Recebido";
            this.rbRecebido.UseVisualStyleBackColor = true;
            // 
            // rbNaoRecebido
            // 
            this.rbNaoRecebido.AutoSize = true;
            this.rbNaoRecebido.Location = new System.Drawing.Point(87, 19);
            this.rbNaoRecebido.Name = "rbNaoRecebido";
            this.rbNaoRecebido.Size = new System.Drawing.Size(89, 17);
            this.rbNaoRecebido.TabIndex = 80;
            this.rbNaoRecebido.TabStop = true;
            this.rbNaoRecebido.Text = "Não recebido";
            this.rbNaoRecebido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbHonorario);
            this.groupBox1.Controls.Add(this.rbCusta);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 76);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 81;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ambos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbHonorario
            // 
            this.rbHonorario.AutoSize = true;
            this.rbHonorario.Location = new System.Drawing.Point(10, 19);
            this.rbHonorario.Name = "rbHonorario";
            this.rbHonorario.Size = new System.Drawing.Size(71, 17);
            this.rbHonorario.TabIndex = 80;
            this.rbHonorario.TabStop = true;
            this.rbHonorario.Text = "Honorário";
            this.rbHonorario.UseVisualStyleBackColor = true;
            // 
            // rbCusta
            // 
            this.rbCusta.AutoSize = true;
            this.rbCusta.Location = new System.Drawing.Point(87, 19);
            this.rbCusta.Name = "rbCusta";
            this.rbCusta.Size = new System.Drawing.Size(113, 17);
            this.rbCusta.TabIndex = 80;
            this.rbCusta.TabStop = true;
            this.rbCusta.Text = "Custa de processo";
            this.rbCusta.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(665, 101);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 59);
            this.btnAtualizar.TabIndex = 79;
            this.btnAtualizar.Text = "Buscar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(665, 191);
            this.ttbValor.Mask = "$0000000.00";
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(106, 20);
            this.ttbValor.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Valor Recebido";
            // 
            // btnEfetivarRecebimento
            // 
            this.btnEfetivarRecebimento.Location = new System.Drawing.Point(665, 264);
            this.btnEfetivarRecebimento.Name = "btnEfetivarRecebimento";
            this.btnEfetivarRecebimento.Size = new System.Drawing.Size(106, 64);
            this.btnEfetivarRecebimento.TabIndex = 76;
            this.btnEfetivarRecebimento.Text = "Efetivar recebimento";
            this.btnEfetivarRecebimento.UseVisualStyleBackColor = true;
            this.btnEfetivarRecebimento.Click += new System.EventHandler(this.btnEfetivarRecebimento_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rece_Descricao,
            this.pro_numero,
            this.Rece_Valor,
            this.Rece_dataVenc,
            this.rece_datareceb,
            this.rece_valorRecebido,
            this.cus_codigo,
            this.hon_codigo,
            this.Rece_codigo});
            this.dgvResultado.Location = new System.Drawing.Point(15, 101);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(644, 227);
            this.dgvResultado.TabIndex = 75;
            this.dgvResultado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResultado_CellMouseClick);
            // 
            // Rece_Descricao
            // 
            this.Rece_Descricao.DataPropertyName = "Rece_Descricao";
            this.Rece_Descricao.HeaderText = "Descrição";
            this.Rece_Descricao.Name = "Rece_Descricao";
            this.Rece_Descricao.ReadOnly = true;
            // 
            // pro_numero
            // 
            this.pro_numero.DataPropertyName = "pro_numero";
            this.pro_numero.HeaderText = "Número do Processo";
            this.pro_numero.Name = "pro_numero";
            this.pro_numero.ReadOnly = true;
            // 
            // Rece_Valor
            // 
            this.Rece_Valor.DataPropertyName = "Rece_Valor";
            this.Rece_Valor.HeaderText = "Valor";
            this.Rece_Valor.Name = "Rece_Valor";
            this.Rece_Valor.ReadOnly = true;
            // 
            // Rece_dataVenc
            // 
            this.Rece_dataVenc.DataPropertyName = "Rece_dataVenc";
            this.Rece_dataVenc.HeaderText = "Data de vencimento";
            this.Rece_dataVenc.Name = "Rece_dataVenc";
            this.Rece_dataVenc.ReadOnly = true;
            // 
            // rece_datareceb
            // 
            this.rece_datareceb.DataPropertyName = "rece_datareceb";
            this.rece_datareceb.HeaderText = "Data de Pagamento";
            this.rece_datareceb.Name = "rece_datareceb";
            this.rece_datareceb.ReadOnly = true;
            // 
            // rece_valorRecebido
            // 
            this.rece_valorRecebido.DataPropertyName = "rece_valorRecebido";
            this.rece_valorRecebido.HeaderText = "Valor recebido";
            this.rece_valorRecebido.Name = "rece_valorRecebido";
            this.rece_valorRecebido.ReadOnly = true;
            // 
            // cus_codigo
            // 
            this.cus_codigo.DataPropertyName = "cus_codigo";
            this.cus_codigo.HeaderText = "Código do custo";
            this.cus_codigo.Name = "cus_codigo";
            this.cus_codigo.ReadOnly = true;
            // 
            // hon_codigo
            // 
            this.hon_codigo.DataPropertyName = "hon_codigo";
            this.hon_codigo.HeaderText = "Código do honorário";
            this.hon_codigo.Name = "hon_codigo";
            this.hon_codigo.ReadOnly = true;
            // 
            // Rece_codigo
            // 
            this.Rece_codigo.DataPropertyName = "Rece_codigo";
            this.Rece_codigo.HeaderText = "Codigo";
            this.Rece_codigo.Name = "Rece_codigo";
            this.Rece_codigo.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(739, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 56;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // frmGerenciamentoRecebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grbRecebimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciamentoRecebimentos";
            this.Text = "Gerenciamento de recebimentos";
            this.grbRecebimentos.ResumeLayout(false);
            this.grbRecebimentos.PerformLayout();
            this.grbCriterio.ResumeLayout(false);
            this.grbCriterio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRecebimentos;
        private System.Windows.Forms.Button btnEfetivarRecebimento;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.MaskedTextBox ttbValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbCusta;
        private System.Windows.Forms.RadioButton rbHonorario;
        private System.Windows.Forms.TextBox ttbCriterio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRecebido;
        private System.Windows.Forms.RadioButton rbNaoRecebido;
        private System.Windows.Forms.GroupBox grbCriterio;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbProcesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataRecebimentoEfetiva;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_dataVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rece_datareceb;
        private System.Windows.Forms.DataGridViewTextBoxColumn rece_valorRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hon_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rece_codigo;
    }
}