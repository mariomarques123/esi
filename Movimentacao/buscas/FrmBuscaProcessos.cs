using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Movimentacao.buscas
{
    public partial class FrmBuscaProcessos : Form
    {
        DataRow linhaSelecionada;

        public FrmBuscaProcessos()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            GerenciamentoProcessos conta = new GerenciamentoProcessos(banco);
            banco.conecta();
            if (rbArea.Checked)
            {
                dgvResultado.DataSource = conta.localizarAreaAtuacao(ttbArea.Text);
            }
            else if (rbNumero.Checked)
            {
                if(ttbNumero.Text == "")
                    dgvResultado.DataSource = conta.listarProcessos();
                else
                    dgvResultado.DataSource = conta.localizarPorNumero(ttbNumero.Text);
            }
            else
            {
                dgvResultado.DataSource = conta.listarProcessos();
            }
            banco.desconecta();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1)
            {
                DataRowView selecao = (DataRowView)dgvResultado.CurrentRow.DataBoundItem;
                linhaSelecionada = selecao.Row;
            }
            Close();
        }

        public DataRow getLinhaSelecionada()
        {
            return linhaSelecionada;
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbConta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
