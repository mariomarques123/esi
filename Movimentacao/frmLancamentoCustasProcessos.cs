using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using SAEA.Movimentacao.buscas;
using SAEA.Cadastros.buscas;

namespace SAEA.Movimentacao
{
    public partial class frmLancamentoCustasProcessos : Form
    {
        string titulo = "Lançamento de Custas do Processo";
        DataTable custasProcessos = new DataTable();

        public frmLancamentoCustasProcessos()
        {
            InitializeComponent();
            inicializar();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializar();
            habilitar("I");
            custasProcessos.Rows.Clear();
        }


        private void inicializar()
        {
            Gerais.clearControlValues(grbDados);
            habilitar("N");
        }

        private void habilitar(string acao) //I, A, N, V  (N = neutro)
        {
            switch (acao)
            {
                case "I": Text = titulo + " (INCLUINDO)"; break;
                case "A": Text = titulo + " (ALTERANDO)"; break;
                case "V": Text = titulo + " (VISUALIZANDO)"; break;
                case "N": Text = titulo + " - AlvesMarques Advogados"; break;
            }

            grbDados.Enabled = "IA".IndexOf(acao) >= 0;
            btnNovo.Enabled = acao == "N";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
            btnCancelar.Enabled = "IAV".IndexOf(acao) >= 0;
            btnLocalizar.Enabled = "NV".IndexOf(acao) >= 0;
        }

        private void ccbPago_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbPago.Checked)
                grbPagamento.Enabled = true;
            else
                grbPagamento.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscaProcessos janela = new FrmBuscaProcessos();
            janela.ShowDialog();
            DataRow linha = janela.getLinhaSelecionada();
            if (linha != null)
            {
                ttbNumeroProcesso.Text = linha["pro_numero"].ToString();
                Banco banco = new Banco();
                banco.conecta();
                GerenciamentoCustasProcesso consulta = new GerenciamentoCustasProcesso(banco);
                custasProcessos = consulta.listarCustasProcesso(linha["pro_numero"].ToString());
                banco.desconecta();
                dgvResultado1.DataSource = custasProcessos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscaTiposCusto janela = new FrmBuscaTiposCusto();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigoTipo.Text = selecao["tic_codigo"].ToString();
                ttbDescricaoCusta.Text = selecao["tic_descricao"].ToString();
                ttbValorTotal.Text = double.Parse(selecao["tic_valor"].ToString()).ToString("$0000000.00");
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmBuscaCustoProcessoM janela = new FrmBuscaCustoProcessoM();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigoCusta.Text = selecao["cus_codigo"].ToString();
                ttbDescricao.Text = selecao["cus_descricao"].ToString();
                ttbValorTotal.Text = double.Parse(selecao["cus_valor"].ToString()).ToString("$0000000.00");
                ttbCodigoTipo.Text = selecao["tic_codigo"].ToString();
                
                Banco banco = new Banco();
                CadastroTiposCusto conta = new CadastroTiposCusto(banco);
                GerenciamentoCustasProcesso custa = new GerenciamentoCustasProcesso(banco);
                banco.conecta();

                int numeroProcesso= custa.getNumeroProcesso(int.Parse(selecao["cus_codigo"].ToString()));

                if (numeroProcesso != -1)
                {
                    ttbNumeroProcesso.Text = numeroProcesso.ToString();
                    custasProcessos = custa.listarCustasProcesso(ttbNumeroProcesso.Text);
                    banco.desconecta();
                    dgvResultado1.DataSource = custasProcessos;
                }
                banco.conecta();
                DataTable resultado = conta.localizarPorCodigo(int.Parse(ttbCodigoTipo.Text));
                resultado.Rows[0]["tic_descricao"].ToString();
               
                habilitar("V");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ccbPago.Checked && ttbValorRecebido.Text == "")
                MessageBox.Show("Digite o valor recebido");
            else if(ttbCodigoTipo.Text == "")
                MessageBox.Show("Selecione o tipo de Custa");
            else if(ttbNumeroProcesso.Text == "")
                MessageBox.Show("Selecione o número do processo");
            else if(ttbDescricao.Text == "")
                MessageBox.Show("Digite a descrição da custa");
            else if(!rbAdvogadoPaga.Checked && !rbClientePaga.Checked)
                MessageBox.Show("Selecione quem irá pagar esta custa");
            else
            {
                Banco banco = new Banco();
                GerenciamentoCustasProcesso cadastro = new GerenciamentoCustasProcesso(banco);
                GerenciamentoRecebimentos recebimentos = new GerenciamentoRecebimentos(banco);
                GerenciamentoProcessos processo = new GerenciamentoProcessos(banco);

                banco.conecta();
                if (ttbCodigoCusta.Text == "")
                {
                    if (rbClientePaga.Checked)
                    {
                        if (processo.verificaPermisaoInclusao(ttbNumeroProcesso.Text))
                        {
                            if (cadastro.incluir(ttbDescricao.Text, Gerais.converteStoD(ttbValorTotal.Text), int.Parse(ttbCodigoTipo.Text)))
                            {
                                MessageBox.Show("Cadastro realizado com sucesso");
                                int codigo = banco.getIdentity();
                                //if (MessageBox.Show("Deseja realizar o lançamento destes recebimentos?", "Lançamento de recebimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                //{
                                    if (!ccbPago.Checked) //não pago
                                    {
                                        if (recebimentos.incluirCusta(codigo, 0, ttbNumeroProcesso.Text, null, ttbDescricao.Text, Gerais.converteStoD(ttbValorTotal.Text), dtpVencimento.Value, Gerais.converteStoD(ttbValorRecebido.Text)))
                                        {
                                            inicializar();
                                            MessageBox.Show("Cadastro dos recebimentos realizado com sucesso");
                                        }
                                        else
                                            MessageBox.Show("Cadastro não realizado");
                                    }
                                    else //pago
                                    {
                                        if (recebimentos.incluirCusta(codigo, 0, ttbNumeroProcesso.Text, dtpPagamento.Value, ttbDescricao.Text, Gerais.converteStoD(ttbValorTotal.Text), dtpVencimento.Value, Gerais.converteStoD(ttbValorRecebido.Text)))
                                        {
                                            MessageBox.Show("Cadastro realizado com sucesso");
                                            inicializar();
                                        }
                                        else
                                            MessageBox.Show("Cadastro não realizado");
                                    }
                                //}
                                //else
                                //    inicializar();
                            }
                            else
                                MessageBox.Show("Cadastro não realizado");
                        }
                        else
                            MessageBox.Show("Este processo não permite a inclusão de custas para o cliente");

                    }
                    else
                    {
                        if (cadastro.incluir(ttbDescricao.Text, Gerais.converteStoD(ttbValorTotal.Text), int.Parse(ttbCodigoTipo.Text)))
                        {
                            inicializar();
                            MessageBox.Show("Cadastro realizado com sucesso");
                        }
                        else
                            MessageBox.Show("Cadastro não realizado");
                    }
                }
                banco.desconecta();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conecta();
            GerenciamentoCustasProcesso consulta = new GerenciamentoCustasProcesso(banco);
            if (!consulta.veirifcaPagamento(int.Parse(ttbCodigoCusta.Text)))
                MessageBox.Show("Impossível realizar a exclusão desta entrada pois ela já foi paga");
            else
            {
                int codigo = 0;
                int.TryParse(ttbCodigoCusta.Text, out codigo);
                if (codigo > 0)
                {
                    if (MessageBox.Show("Confirma exclusão?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {

                        if (consulta.excluirRecebimentos(codigo))
                            MessageBox.Show("Exclusão do recebimento realizado com sucesso");
                        else
                            MessageBox.Show("Falha na exclusão do recebimento.");

                        if (consulta.excluir(codigo))
                        {
                            MessageBox.Show("Exclusão da custa realizada com sucesso");
                            inicializar();
                        }
                        else
                            MessageBox.Show("Falha na exclusão! Verifique se não existem associações com este cliente");
                        banco.desconecta();
                    }
                }
            }
            banco.desconecta();

        }

    }
}
