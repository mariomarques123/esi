using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using SAEA.Cadastros.buscas;

namespace SAEA.Cadastros
{
    public partial class frmCadastroDespesasEscritorio : Form
    {
        string titulo = "Cadastros de Despesas do Escritório";


        public frmCadastroDespesasEscritorio()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            ttbCodigo.Clear();
            ttbDataVencimento.Clear();
            ttbNome.Clear();
            cbbTipo.SelectedIndex = -1;
            ttbValor.Clear();
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
            btnAlterar.Enabled = acao == "V";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
            btnCancelar.Enabled = "IAV".IndexOf(acao) >= 0;
            btnLocalizar.Enabled = "NV".IndexOf(acao) >= 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializar();
            habilitar("I");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmBuscaCadastroContasEsc janela = new frmBuscaCadastroContasEsc();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigo.Text = selecao["ces_codigo"].ToString();
                ttbDataVencimento.Text = selecao["ces_datamesvenc"].ToString();
                ttbNome.Text = selecao["ces_nome"].ToString();
                ttbValor.Text = double.Parse(selecao["ces_valor"].ToString()).ToString("$00000.00");
                switch (selecao["ces_tipo"].ToString()[0])
                {
                    case 'U':
                        cbbTipo.SelectedIndex = 0;
                        break;
                    case 'M':
                        cbbTipo.SelectedIndex = 1;
                        break;
                    case 'A':
                        cbbTipo.SelectedIndex = 2;
                        break;
                    default:
                        cbbTipo.SelectedIndex = -1;
                        break;
                }
                habilitar("V");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitar("A");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar("N");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int diaMes = int.Parse(ttbDataVencimento.Text);
            if (ttbDataVencimento.Text == null)
                MessageBox.Show("Digite a data de vencimento no mês");
            else if (ttbNome.Text == null)
                MessageBox.Show("Digite o nome da conta");
            else if (cbbTipo.SelectedIndex == -1)
                MessageBox.Show("Selecione o tipo da conta");
            else if (ttbValor.Text.Trim() == "")
                MessageBox.Show("Digite o valor da conta");
            else if(diaMes <= 0 || diaMes >=32)
                MessageBox.Show("Valor digitado para dia do Mês é inválido");
            else
            {
                Banco banco = new Banco();
                CadastroDespesasEscritorio cadastro = new CadastroDespesasEscritorio(banco);
                banco.conecta();
                if (ttbCodigo.Text != "")
                {
                    if (cadastro.alterar(int.Parse(ttbCodigo.Text),ttbNome.Text, cbbTipo.SelectedItem.ToString()[0],int.Parse(ttbDataVencimento.Text.Trim()),double.Parse(ttbValor.Text.Substring(2).Trim())))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(ttbNome.Text, cbbTipo.SelectedItem.ToString()[0], int.Parse(ttbDataVencimento.Text.Trim()), double.Parse(ttbValor.Text.Substring(2).Trim())))
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    inicializar();
                }
                else
                    MessageBox.Show("Cadastro não realizado");
                banco.desconecta();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(ttbCodigo.Text, out codigo);
            if (codigo > 0)
            {
                if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    Banco banco = new Banco();
                    banco.conecta();
                    CadastroDespesasEscritorio com = new CadastroDespesasEscritorio(banco);
                    if (com.excluir(codigo))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão!");
                    banco.desconecta();
                }
            }
        }
    }
}
