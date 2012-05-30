using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Movimentacao.buscas;
using SAEA.Classes;

namespace SAEA.Movimentacao
{
    public partial class frmGerenciamentoRecebimentos : Form
    {
        string titulo = "Gerenciamento de Recebimentos";
        DataTable resultado = new DataTable();

        public frmGerenciamentoRecebimentos()
        {
            InitializeComponent();
            inicializar();
        }


        private void inicializar()
        {
            //habilitar("N");
            //Gerais.clearControlValues(grbDados);

        }

        //private void habilitar(string acao) //I, A, N, V  (N = neutro)
        //{
        //    switch (acao)
        //    {
        //        case "I": Text = titulo + " (INCLUINDO)"; break;
        //        case "A": Text = titulo + " (ALTERANDO)"; break;
        //        case "V": Text = titulo + " (VISUALIZANDO)"; break;
        //        case "N": Text = titulo + " - AlvesMarques Advogados"; break;
        //    }

        //    grbDados.Enabled = "IA".IndexOf(acao) >= 0;
        //    btnNovo.Enabled = acao == "N";
        //    btnExcluir.Enabled = acao == "V";
        //    btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
        //    btnCancelarReceb.Enabled = "IAV".IndexOf(acao) >= 0;
        //}
        //



        private void btnLimparProcesso_Click(object sender, EventArgs e)
        {
        }

        private void btnLimparHonorario_Click(object sender, EventArgs e)
        {
        }

        private void btnLimparCusto_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        //private void btnNovo_Click(object sender, EventArgs e)
        //{
        //    habilitar("I");
        //}

        //private void btnAlterar_Click(object sender, EventArgs e)
        //{
        //    habilitar("A");
        //}

        //private void btnLocalizar_Click(object sender, EventArgs e)
        //{
        //    habilitar("V");
        //}

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rbProcesso.Checked && ttbCriterio.Text == "")
            {
                MessageBox.Show("Digite o número do processo.");
            }
            else
            {
                Banco banco = new Banco();
                GerenciamentoRecebimentos op = new GerenciamentoRecebimentos(banco);
                banco.conecta();
                int op1 = 0, op2 = 0, op3 = 0;
                bool validar = true;
                if (rbHonorario.Checked)
                {
                    op1 = 1;
                    validar = false;
                }
                else if (rbCusta.Checked)
                {
                    validar = false;
                    op1 = 2;
                }


                if (rbRecebido.Checked)
                {
                    op2 = 1;
                    validar = false;
                }
                else if (rbNaoRecebido.Checked)
                {
                    validar = false;
                    op2 = 2;
                }

                if (rbCliente.Checked)
                {
                    op3 = 1;
                    validar = false;
                }
                else if (rbProcesso.Checked)
                {
                    op3 = 2;
                    validar = false;
                }
                if (validar)
                    resultado = op.localizarTodos();
                else
                    resultado = op.granLocaliza(ttbCriterio.Text, op1, op2, op3);

                
                dgvResultado.DataSource = resultado;
                banco.desconecta();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEfetivarRecebimento_Click(object sender, EventArgs e)
        {
            double valor;
            if(!double.TryParse(ttbValor.Text.Substring(2),out valor))
                MessageBox.Show("Digite o valor recebido.");
            else if (dgvResultado.SelectedRows.Count == 0)
                MessageBox.Show("Selecione um campo da busca para efetivar o recebimento.");
            else
            {
                string data = dgvResultado.Rows[dgvResultado.SelectedRows[0].Index].Cells["rece_datareceb"].Value.ToString();
                if (data.Length != 0)
                    MessageBox.Show("Impossível efetivar recebimento, o campo selecionado já possui uma data de recebimento.");
                else
                {
                    Banco banco = new Banco();
                    GerenciamentoRecebimentos op = new GerenciamentoRecebimentos(banco);
                    banco.conecta();
                    int codigo;
                    if (!int.TryParse(dgvResultado.Rows[dgvResultado.SelectedRows[0].Index].Cells["rece_codigo"].Value.ToString(), out codigo))
                    {
                        MessageBox.Show("Falha ao tentar converter o código do recebimento.");
                    }
                    else
                    {
                        op.efetivar(codigo,dtpDataRecebimentoEfetiva.Value,double.Parse(ttbValor.Text.Substring(2).Trim()));
                        MessageBox.Show("Recebimento realizado com sucesso.");
                        btnAtualizar.PerformClick();
                    }
                    banco.desconecta();
                }
            }

        }

        private void dgvResultado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double valor;
            if (dgvResultado.SelectedRows.Count == 1)
            {
                if (double.TryParse(dgvResultado.Rows[dgvResultado.SelectedRows[0].Index].Cells["rece_valor"].Value.ToString(), out valor))
                {
                    ttbValor.Text = valor.ToString("$0000000.00");
                }

                Banco banco = new Banco();
                GerenciamentoProcessos gerencia = new GerenciamentoProcessos(banco);
                banco.conecta();
                try
                {
                    ttbClientes.Text = gerencia.listarClientes(dgvResultado.Rows[dgvResultado.SelectedRows[0].Index].Cells["pro_numero"].Value.ToString());
                }
                catch(Exception exx) 
                {
                    ttbClientes.Text = "";
                }
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
