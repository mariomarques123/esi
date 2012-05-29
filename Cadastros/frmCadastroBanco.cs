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
    public partial class frmCadastroBanco : Form
    {
        private string titulo = "Cadastro de Bancos";

        public frmCadastroBanco()
        {
            InitializeComponent();
            habilitar("N");
        }

        private void inicializar()
        {
            ttbCodigoBanco.Clear();
            ttbCodigoChave.Clear();
            ttbNomeBanco.Clear();
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
            habilitar("I");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ttbCodigoBanco.Text == "")
                MessageBox.Show("Digite o código do banco");
            else if (ttbNomeBanco.Text == "")
                MessageBox.Show("Digite o nome do banco");
            else
            {
                Banco banco = new Banco();
                CadastroBancos cadastro = new CadastroBancos(banco);
                banco.conecta();
                if (cadastro.verificaCodigoBancoEx(int.Parse(ttbCodigoBanco.Text)) && ttbCodigoChave.Text == "")
                {
                    MessageBox.Show("Código do banco já cadastrado.");
                }
                else if (ttbCodigoChave.Text != "")
                {
                    if (cadastro.alterar(int.Parse(ttbCodigoChave.Text),ttbNomeBanco.Text, int.Parse(ttbCodigoBanco.Text.Trim())))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(ttbNomeBanco.Text, int.Parse(ttbCodigoBanco.Text.Trim()) ))
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    inicializar();
                }
                else
                    MessageBox.Show("Falha!, Cadastro não realizado");
                banco.desconecta();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmBuscaBancos janela = new FrmBuscaBancos();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigoChave.Text = selecao["ban_codigoChave"].ToString();
                ttbNomeBanco.Text = selecao["Ban_nome"].ToString();
                ttbCodigoBanco.Text = selecao["Ban_codigo"].ToString();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(ttbCodigoChave.Text, out codigo);
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
                    CadastroBancos com = new CadastroBancos(banco);
                    if (com.excluir(codigo))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão! Verifique se não existem associações com esta entrada");
                    banco.desconecta();
                }
            }
        }
    }
}
