using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Cadastros.buscas;

namespace SAEA.associativa
{
    public partial class FrmAssociaProcessoCliente : Form
    {
        bool confirmar = false;
        DataTable clientes;
        public FrmAssociaProcessoCliente()
        {
            InitializeComponent();
        }

        public void setProcesso(string numeroProcesso, string advogadoResponsavel, string vara, string tipoAcao)
        {
            ttbNumero.Text = numeroProcesso;
            ttbAdvogado.Text = advogadoResponsavel;
            ttbVara.Text = vara;
            ttbAcao.Text = tipoAcao;
        }

        public void setCliente(DataTable clientes)
        {
            this.clientes = clientes;
            dgvResultado.DataSource = clientes;
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
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

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            confirmar = true;
            Close();
        }

        public bool getConfirmar()
        {
            return confirmar;
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            if (ttbCodigo.Text == "")
                MessageBox.Show("Selecione um cliente");
            else if (ttbNumero.Text == "")
                MessageBox.Show("Selecione um processo");
            else
            {
                int selecionado;
                bool validar = true;
                selecionado = Convert.ToInt32(ttbCodigo.Text);
                foreach( DataRow i in clientes.Rows) {
                    if (i["cli_codigo"].ToString() == selecionado.ToString())
                    {
                        validar = false;
                    }
                }
                if (validar)
                {
                    DataRow nova = clientes.NewRow();
                    nova["cli_codigo"] = int.Parse(ttbCodigo.Text);
                    nova["cli_nome"] = ttbNome.Text;
                    clientes.Rows.Add(nova);
                }
                else
                    MessageBox.Show("Este cliente já foi inserido.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 1)
                MessageBox.Show("Selecione um campo para excluir", "Campo inválido");
            else if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                DataRow exclusao = null;
                foreach (DataRow i in clientes.Rows)
                {
                    if (i["cli_codigo"].ToString() == dgvResultado.SelectedRows[0].Cells["Column1"].Value.ToString())
                        exclusao = i;
                }
                if(exclusao != null)
                    clientes.Rows.Remove(exclusao);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count == 0)
                MessageBox.Show("Nenhum item para ser exluidopara excluir", "Campo inválido");
            else if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                clientes.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
