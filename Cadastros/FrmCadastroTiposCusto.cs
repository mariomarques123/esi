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
    public partial class frmCadastroTiposCusto : Form
    {
        string titulo = "Cadastros de Tipos de Custo";

        public frmCadastroTiposCusto()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            ttbCodigo.Clear();
            ttbDescricao.Clear();
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
            FrmBuscaTiposCusto janela = new FrmBuscaTiposCusto();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigo.Text = selecao["tic_codigo"].ToString();
                ttbDescricao.Text = selecao["tic_descricao"].ToString();
                ttbValor.Text = double.Parse(selecao["tic_valor"].ToString()).ToString("$00000.00");
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
            if (ttbDescricao.Text == null)
                MessageBox.Show("Digite a descricao do custo.");
            else if (ttbValor.Text.Trim() == "")
                MessageBox.Show("Digite o valor comum do custo");
            else
            {
                Banco banco = new Banco();
                CadastroTiposCusto cadastro = new CadastroTiposCusto(banco);
                banco.conecta();
                if (ttbCodigo.Text != "")
                {
                    if (cadastro.alterar(int.Parse(ttbCodigo.Text),ttbDescricao.Text, double.Parse(ttbValor.Text.Substring(2).Trim())))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(ttbDescricao.Text, double.Parse(ttbValor.Text.Substring(2).Trim())))
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
                    CadastroTiposCusto com = new CadastroTiposCusto(banco);
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
