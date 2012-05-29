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
    public partial class frmCadastroClientes : Form
    {
        string titulo = "Cadastro de clientes";
        public frmCadastroClientes()
        {
            InitializeComponent();
            inicializar();
        }


        private void inicializar()
        {
            habilitar("N");
            Gerais.clearControlValues(pnlDados);

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

            pnlDados.Enabled = "IA".IndexOf(acao) >= 0;
            btnNovo.Enabled = acao == "N";
            btnAlterar.Enabled = acao == "V";
            btnAssociaContasBanco.Enabled = acao == "A";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
            btnCancelar.Enabled = "IAV".IndexOf(acao) >= 0;
            btnLocalizar.Enabled = "NV".IndexOf(acao) >= 0;
        }


        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializar();
            habilitar("I");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar("N");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitar("A");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ttbNome.Text == null)
                MessageBox.Show("Digite o nome do cliente");
            else if (cbbUF.SelectedIndex == -1)
                MessageBox.Show("Selecione o estado");
            else
            {
                Banco banco = new Banco();
                CadastroCliente cadastro = new CadastroCliente(banco);
                banco.conecta();
                if (ttbCodigo.Text != "")
                {
                    if (cadastro.alterar(int.Parse(ttbCodigo.Text), ttbNome.Text, ttbCPF.Text.Trim(),ttbCNPJ.Text.Trim(),ttbRG.Text.Trim(),ttbEndereco.Text, ttbNome.Text, ttbBairro.Text, ttbCEP.Text.Trim(), ttbCidade.Text, cbbUF.SelectedItem.ToString(),ttbEmail.Text, ttbTelRes.Text.Trim(), ttbTelCom.Text.Trim(), ttbCelular.Text.Trim()))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(ttbNome.Text, ttbCPF.Text.Trim(), ttbCNPJ.Text.Trim(), ttbRG.Text.Trim(), ttbEndereco.Text, ttbNome.Text, ttbBairro.Text, ttbCEP.Text.Trim(), ttbCidade.Text, cbbUF.SelectedItem.ToString(), ttbEmail.Text, ttbTelRes.Text.Trim(), ttbTelCom.Text.Trim(), ttbCelular.Text.Trim()))
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    inicializar();
                }
                else
                    MessageBox.Show("Cadastro não realizado");
                banco.desconecta();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmBuscaCliente janela = new frmBuscaCliente();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigo.Text = selecao["cli_codigo"].ToString();
                ttbNome.Text = selecao["cli_nome"].ToString();
                ttbCPF.Text = selecao["cli_cpf"].ToString();
                ttbCNPJ.Text = selecao["cli_cnpj"].ToString();
                ttbRG.Text = selecao["cli_rg"].ToString();
                ttbEndereco.Text = selecao["cli_endereco"].ToString();
                ttbNumero.Text = selecao["cli_numero"].ToString();
                ttbBairro.Text = selecao["cli_bairro"].ToString();
                ttbCEP.Text = selecao["cli_cep"].ToString();
                ttbCidade.Text = selecao["cli_cidade"].ToString();
                ttbEmail.Text = selecao["cli_email"].ToString();
                ttbTelRes.Text = selecao["cli_telefone"].ToString();
                ttbTelCom.Text = selecao["cli_telefonecomercial"].ToString();
                ttbCelular.Text = selecao["cli_celular"].ToString();
                cbbUF.SelectedIndex = Gerais.avaliaEstado(selecao["Cli_UF"].ToString());
                habilitar("V");
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
                    CadastroCliente com = new CadastroCliente(banco);
                    if (com.excluir(codigo))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão! Verifique se não existem associações com este cliente");
                    banco.desconecta();
                }
            }
        }

        private void btnAssociaContasBanco_Click(object sender, EventArgs e)
        {
            frmAssociaClienteContaBancaria janela = new frmAssociaClienteContaBancaria(ttbCodigo.Text, ttbNome.Text, ttbCPF.Text, ttbCNPJ.Text,ttbRG.Text);
            janela.ShowDialog();
            janela.Dispose();
        }
    }
}
