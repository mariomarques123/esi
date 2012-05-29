using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Cadastros.buscas
{
    public partial class frmBuscaCadastroContasEsc : Form
    {

        DataRow linhaSelecionada;

        public frmBuscaCadastroContasEsc()
        {
            InitializeComponent();
        }

        public DataRow getLinhaSelecionada()
        {
            return linhaSelecionada;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            CadastroDespesasEscritorio conta = new CadastroDespesasEscritorio(banco);
            banco.conecta();
            if (rbNome.Checked)
            {
                dgvResultado.DataSource = conta.localizarPorNome(ttbNome.Text);
            }
            else if (rbCodigo.Checked)
            {
                dgvResultado.DataSource = conta.localizarPorCodigo(int.Parse((ttbCodigo.Text == "" ? "0" : ttbCodigo.Text.Trim())));
            }
            else
            {
                dgvResultado.DataSource = conta.listarTodas();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }
    }
}
