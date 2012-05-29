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
    public partial class FrmBuscaCustoProcessoM : Form
    {
        public FrmBuscaCustoProcessoM()
        {
            InitializeComponent();
        }

        DataRow linhaSelecionada;

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            GerenciamentoCustasProcesso conta = new GerenciamentoCustasProcesso(banco);
            banco.conecta();
            if (rbCodigo.Checked)
            {
                if(ttbDescricao.Text == "")
                    dgvResultado.DataSource = conta.listarTodos();
                else
                    dgvResultado.DataSource = conta.localizarPorCodigo(int.Parse( Gerais.retiraTodosCharter(ttbDescricao.Text, ' ')));
            }
            else if (rbNome.Checked)
            {
                if (ttbCodigo.Text == "")
                    dgvResultado.DataSource = conta.listarTodos();
                else
                    dgvResultado.DataSource = conta.localizarPorNome(ttbCodigo.Text);
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
