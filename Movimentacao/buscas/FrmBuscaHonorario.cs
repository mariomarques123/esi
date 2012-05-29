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
    public partial class FrmBuscaHonorario : Form
    {
        DataRow linhaSelecionada;

        public FrmBuscaHonorario()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            AtualizacaoHonorario conta = new AtualizacaoHonorario(banco);
            banco.conecta();
            if (rbConta.Checked)
            {
                if(ttbNumeroConta.Text == "")
                    dgvResultado.DataSource = conta.listarHonorarios();
                else
                    dgvResultado.DataSource = conta.localizarPorNumeroProcesso(ttbNumeroConta.Text);
            }
            else if (rbCodigo.Checked)
            {
                if (ttbCodigo.Text == "")
                    dgvResultado.DataSource = conta.listarHonorarios();
                else
                    dgvResultado.DataSource = conta.localizarPorCodigo(int.Parse( Gerais.retiraTodosCharter(ttbCodigo.Text, ' ') ));
            }
            else
            {
                dgvResultado.DataSource = conta.listarHonorarios();
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

        private void FrmBuscaHonorario_Load(object sender, EventArgs e)
        {

        }

    }
}
