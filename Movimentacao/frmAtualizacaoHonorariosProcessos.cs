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

namespace SAEA.Movimentacao
{
    public partial class frmAtualizacaoHonorariosProcessos : Form
    {
        string titulo = "Atualização de Honorários de Processos";
        DataTable parcelas;

        public frmAtualizacaoHonorariosProcessos()
        {
            InitializeComponent();
            parcelas = new DataTable();
            parcelas.Columns.Add("Rece_Descricao", typeof(String));
            parcelas.Columns.Add("Rece_dataVenc", typeof(DateTime));
            parcelas.Columns.Add("Rece_Valor", typeof(Double));
            dgvResultado.DataSource = parcelas;
            inicializar();

            
        }


        private void inicializar()
        {
            habilitar("N");
            Gerais.clearControlValues(grbDados);
            parcelas.Rows.Clear();


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
            btnAlterar.Enabled = acao == "V";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
            btnCancelar.Enabled = "IAV".IndexOf(acao) >= 0;
            btnLocalizar.Enabled = "NV".IndexOf(acao) >= 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar("I");

               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitar("A");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmBuscaHonorario janela = new FrmBuscaHonorario();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbNumeroProcesso.Text = selecao["pro_numero"].ToString();
                ttbCodigo.Text = selecao["hon_codigo"].ToString();
                ttbValorTotal.Text = double.Parse(selecao["hon_valortotal"].ToString()).ToString("$000000000.00");
                //; ; ttbValorTotal.Text = selecao["hon_"].ToString();
                rbParcelaUnica.Checked = false;
                rbClienteNãoPaga.Checked = false;
                rbParcelado.Checked = false;
                

                ttbQuantidadePar.Text = selecao["hon_quantidadeparcelas"].ToString();
                ttbDiasParcelas.Text = selecao["hon_diasParcelas"].ToString();


                ttbDescricao.Text = selecao["hon_descricao"].ToString();
                cbbNivelAcesso.SelectedIndex = int.Parse(selecao["hon_nivelacesso"].ToString());
                switch (selecao["hon_parcelado"].ToString()[0])
                {
                    case 'U':
                        rbParcelaUnica.Checked = true;

                        preparaParcelaUnica();

                        break;
                    case 'C':
                        rbClienteNãoPaga.Checked = true;
                        limpaPagamentos();
                        break;
                    case 'P':
                        rbParcelado.Checked = true;
                        preparaParcelas();
                        break;
                    default:
                        rbParcelaUnica.Checked = true;
                        preparaParcelaUnica();
                        break;
                }
                habilitar("V");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ttbNumeroProcesso.Text == "")
                MessageBox.Show("Digite o número do processo");
            else if (!rbClienteNãoPaga.Checked && !rbParcelado.Checked && !rbParcelaUnica.Checked)
                MessageBox.Show("Selecione o tipo de pagamento");
            else if (rbParcelado.Checked && ttbQuantidadePar.Text == "")
                MessageBox.Show("Digite a quantidade de parcelas");
            else if (rbParcelado.Checked && ttbDiasParcelas.Text == "")
                MessageBox.Show("Digite a quantidade de dias entre as parcelas");
            else if (ttbValorTotal.Text == "")
                MessageBox.Show("Digite o valor total");
            else if (cbbNivelAcesso.SelectedIndex == -1)
                MessageBox.Show("Selecione o nivel de acesso");
            else
            {
                Banco banco = new Banco();
                AtualizacaoHonorario cadastro = new AtualizacaoHonorario(banco);
                GerenciamentoRecebimentos recebimentos = new GerenciamentoRecebimentos(banco);

                banco.conecta();
                int qtdParcela, diasParcela;
                
                if (ttbQuantidadePar.Text == "")
                    qtdParcela = 0;
                else
                    qtdParcela = int.Parse(ttbQuantidadePar.Text);

                if (qtdParcela == 0)
                    qtdParcela = 1;

                if (ttbDiasParcelas.Text == "")
                    diasParcela = 0;
                else
                    diasParcela = int.Parse(ttbDiasParcelas.Text);
                
                if (diasParcela == 0)
                    diasParcela = 1;

                if (rbParcelaUnica.Checked)
                    qtdParcela = 1;


                double valorTotal = Gerais.converteStoD(ttbValorTotal.Text);

                double valorParcela = 1;
                int contador = 0;
                valorParcela = valorTotal / qtdParcela;

                DateTime datas;

                if (ttbCodigo.Text != "")
                {
                    if (cadastro.alterar(
                        int.Parse(ttbCodigo.Text), 
                        ttbNumeroProcesso.Text, 
                        dtpData.Value, 
                        valorTotal, 
                        selecionaTipoParcela(),
                        qtdParcela, 
                        ttbDescricao.Text, 
                        cbbNivelAcesso.SelectedIndex,
                        diasParcela)
                        )
                    {
                        MessageBox.Show("Alteração realizada com sucesso");

                        if (!rbClienteNãoPaga.Checked)
                        {
                            //if (MessageBox.Show("Deseja realizar o lançamento destes recebimentos?", "Lançamento de recebimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            //{

                                for (int i = 0; i < qtdParcela; i++)
                                {
                                    datas = dtpData.Value.AddDays((i) * diasParcela);
                                    if (recebimentos.incluirHonorario(int.Parse(ttbCodigo.Text), ttbNumeroProcesso.Text, null, ttbDescParcela.Text, valorParcela, datas, 0))
                                        contador++;
                                }
                                if (contador == qtdParcela)
                                    MessageBox.Show("Cadastro realizado com sucesso");
                            //}

                        }
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(
                    ttbNumeroProcesso.Text,
                    dtpData.Value,
                    valorTotal,
                    selecionaTipoParcela(),
                    qtdParcela, 
                    ttbDescricao.Text,
                    cbbNivelAcesso.SelectedIndex,
                    diasParcela))
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    if (!rbClienteNãoPaga.Checked)
                    {
                        int codigo = banco.getIdentity();
                        //if (MessageBox.Show("Deseja realizar o lançamento destes recebimentos?", "Lançamento de recebimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        //{

                            for (int i = 0; i < qtdParcela; i++)
                            {
                                datas = dtpData.Value.AddDays((i) * diasParcela);
                                if (recebimentos.incluirHonorario(codigo, ttbNumeroProcesso.Text, null, ttbDescParcela.Text, valorParcela, datas, 0))
                                    contador++;
                            }
                            if (contador == qtdParcela)
                                MessageBox.Show("Cadastro de parcelas realizado com sucesso");
                        //}

                    }
                    inicializar();
                }
                else
                    MessageBox.Show("Cadastro não realizado");
                banco.desconecta();
            }
        }

        private char selecionaTipoParcela() 
        {
            char saida = ' ';
            if (rbClienteNãoPaga.Checked)
                saida = 'C';
            else if (rbParcelado.Checked)
                saida = 'P';
            else if (rbParcelaUnica.Checked)
                saida = 'U';

            return saida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscaProcessos janela = new FrmBuscaProcessos();
            janela.ShowDialog();
            DataRow linha = janela.getLinhaSelecionada();
            if (linha != null)
            {
                ttbNumeroProcesso.Text = linha["pro_numero"].ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(ttbCodigo.Text, out codigo);
            Banco banco = new Banco();
            banco.conecta();
            AtualizacaoHonorario com = new AtualizacaoHonorario(banco);
            if (com.verificaExistenciaRecebPago(codigo))
            {
                MessageBox.Show("Exclusão não pode ser realizada pois existe um ou mais recebimentos deste honorário recebidos.");
            }
            else if (codigo > 0)
            {
                if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    if (com.excluirRecebimentos(codigo))
                        MessageBox.Show("Exclusão dos recebimentos realizada com sucesso");
                    else
                        MessageBox.Show("Falha na exclusão dos recebentos!");

                    if (com.excluir(codigo))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão! Verifique se não existem associações com este honorário");
                    banco.desconecta();
                }
            }
        }

        private void rbParcelado_CheckedChanged(object sender, EventArgs e)
        {
           // if (rbParcelado.Checked)
           // {
            preparaParcelas();

           // }
        }

        private void preparaParcelas()
        {
            if (ttbQuantidadePar.Text != "" && ttbValorTotal.Text != "")
            {
                double valor;

                int qtd;
                int data;
                try
                {
                    qtd = int.Parse(ttbQuantidadePar.Text);
                    valor = double.Parse(ttbValorTotal.Text.Trim().Substring(2));
                    data = int.Parse(ttbDiasParcelas.Text);
                }
                catch (Exception ex)
                {
                    valor = 1;
                    data = 30;
                    qtd = 1;
                }
                double valorParcela = valor / qtd;
                ttbResultadoParcela.Text = Math.Round(valorParcela, 2).ToString();

                parcelas.Rows.Clear();
                for (int i = 0; i < qtd; i++)
                {
                    DataRow linha = this.parcelas.NewRow();
                    linha["Rece_Descricao"] = ttbDescParcela.Text;
                    linha["Rece_dataVenc"] = dtpData.Value.AddDays(i * data);

                    if (i + 1 == qtd)
                    {
                        double parcial = valor - Math.Round(valorParcela, 2) * qtd;
                        valorParcela += parcial;
                    }
                    linha["Rece_Valor"] = Math.Round(valorParcela, 2);

                    parcelas.Rows.Add(linha);
                }
            }
        }

        private void rbParcelaUnica_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbParcelaUnica.Checked)
            //{


            preparaParcelaUnica();
            //}
        }

        private void preparaParcelaUnica()
        {
           
                ttbResultadoParcela.Text = Gerais.converteStoD(ttbValorTotal.Text).ToString();

                parcelas.Rows.Clear();
                DataRow linha = this.parcelas.NewRow();
                linha["Rece_Descricao"] = ttbDescParcela.Text;
                linha["Rece_dataVenc"] = dtpData.Value;
            
                linha["Rece_Valor"] = Math.Round(Gerais.converteStoD(ttbResultadoParcela.Text),2).ToString();
                parcelas.Rows.Add(linha);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rbClienteNãoPaga_CheckedChanged(object sender, EventArgs e)
        {
            limpaPagamentos();
        }

        private void limpaPagamentos()
        {
            parcelas.Rows.Clear();
            ttbResultadoParcela.Text = "";
        }










    }
}
