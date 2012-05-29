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
    public partial class FrmBuscaTiposCusto : Form
    {
        DataRow linhaSelecionada;

        public FrmBuscaTiposCusto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            CadastroTiposCusto conta = new CadastroTiposCusto(banco);
            banco.conecta();
            if (rbConta.Checked)
            {
                dgvResultado.DataSource = conta.localizarDescricao(ttbDescricao.Text);
            }
            else if (rbCodigo.Checked)
            {
                dgvResultado.DataSource = conta.localizarPorCodigo(int.Parse( Gerais.retiraTodosCharter(ttbCodigo.Text, ' ') ));
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
    }
}
