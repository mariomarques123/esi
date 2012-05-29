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
    public partial class FrmBuscaBancos : Form
    {
        DataRow linhaSelecionada;

        public FrmBuscaBancos()
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
            CadastroBancos conta = new CadastroBancos(banco);
            banco.conecta();
            if (rbNome.Checked)
            {
                dgvResultado.DataSource = conta.localizarPorNome(ttbNome.Text);
            }
            else if (rbCodigo.Checked)
            {
                string saida = Gerais.retiraTodosCharter(ttbCodigo.Text, ' ');
                int codigo = int.Parse(saida);
                dgvResultado.DataSource = conta.localizarPorCodigo(codigo);
            }
            else
            {
                dgvResultado.DataSource = conta.listarTodos();
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
