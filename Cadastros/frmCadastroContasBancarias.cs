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
    public partial class frmCadastroContasBancarias : Form
    {
        private string titulo = "Cadastro de Contas Bancárias";

        public frmCadastroContasBancarias()
        {
            InitializeComponent();
            habilitar("N");

            DataTable temp = preencherCombobox();
            if (temp == null)
            {
                MessageBox.Show("Impossivel cadastrar contas pois não existe nenhum banco cadastrado!");
                if (MessageBox.Show("Deseja cadastrar bancos agora?", "Cadastro de Bancos?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmCadastroBanco janela = new frmCadastroBanco();
                    janela.ShowDialog();
                    janela.Dispose();
                    temp = preencherCombobox();
                }
            }

            if (temp != null) { 
                cbbBancos.DisplayMember = "Ban_Nome";
                cbbBancos.ValueMember = "Ban_codigoChave";
                cbbBancos.DataSource = temp;
            }
        }

        private static DataTable preencherCombobox()
        {
            DataTable temp;
            Banco banco = new Banco();
            CadastroBancos bancos = new CadastroBancos(banco);
            banco.conecta();

            temp = bancos.listarTodos();
            banco.desconecta();
            return temp;
        }

        private void inicializar()
        {
            ttbCodigo.Clear();
            ttbNumAgencia.Clear();
            ttbNumeroConta.Clear();
            cbbBancos.SelectedIndex = -1;
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

        private void habilitarAlterar()
        {
            habilitar("A");
        }

        private void habilitarIncluir()
        {
            habilitar("I");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitarIncluir();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            habilitarAlterar();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            if(ttbNumAgencia.Text == "")
                MessageBox.Show("Digite o código da agência");
            else if(ttbNumeroConta.Text == "")
                MessageBox.Show("Digite o número da conta");
            else if(cbbBancos.SelectedIndex == -1)
                MessageBox.Show("Selecione o banco");
            else
            {
                Banco banco = new Banco();
                CadastroContas cadastro = new CadastroContas(banco);
                banco.conecta();
                if (ttbCodigo.Text != "")
                {
                    if (cadastro.alterar(int.Parse(ttbCodigo.Text), ttbNumeroConta.Text, cbbBancos.SelectedIndex, int.Parse(ttbNumAgencia.Text.Trim())))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.verificaExistConta(ttbNumeroConta.Text, int.Parse(ttbNumAgencia.Text), int.Parse(cbbBancos.SelectedValue.ToString())))
                {
                    MessageBox.Show("Impossivel realizar cadastro, este número de conta neste banco já existe.");
                }
                else if (cadastro.incluir(ttbNumeroConta.Text, int.Parse(cbbBancos.SelectedValue.ToString()), int.Parse(ttbNumAgencia.Text.Trim())))
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
            frmBuscaCadastroContaBancaria janela = new frmBuscaCadastroContaBancaria();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigo.Text = selecao["con_codigo"].ToString();
                ttbNumAgencia.Text = selecao["con_numeroagencia"].ToString();
                ttbNumeroConta.Text = selecao["con_numero"].ToString();
                int desejado = int.Parse(selecao["Ban_codigochave"].ToString());
                int encontro = -1;
                for (int i = 0; i < cbbBancos.Items.Count; i++)
                {
                    cbbBancos.SelectedIndex = i;
                    if (desejado.ToString() == cbbBancos.SelectedValue.ToString())
                        encontro = i;

                }
                cbbBancos.SelectedIndex = encontro;
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
                    CadastroContas com = new CadastroContas(banco);
                    if (com.excluir(codigo))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão! Verifique se existe associações com esta conta");
                    banco.desconecta();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssociaClienteContaBancaria janela = new frmAssociaClienteContaBancaria();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void btnAssociaContasBanco_Click(object sender, EventArgs e)
        {
            FrmAssociaFuncionarioContaBancaria janela = new FrmAssociaFuncionarioContaBancaria();
            janela.ShowDialog();
            janela.Dispose();
        }
    }
}
