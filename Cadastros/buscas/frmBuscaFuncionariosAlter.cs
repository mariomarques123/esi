using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Cadastros.Consultas
{
    public partial class frmConsultaFuncionarios : Form
    {
        private DataRow linha = null;

        public DataRow getLinhaSelecionada()
        {
            return linha;
        }

        public frmConsultaFuncionarios()
        {
            InitializeComponent();

            ttbFiltroNome.MaxLength = 100;
            ttbFiltroCidade.MaxLength = 50;
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsultaFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentRow != null)
            {
                DataRowView currentDataRowView = (DataRowView)dgvFuncionarios.CurrentRow.DataBoundItem;
                linha = currentDataRowView.Row;
                Close();
            }
        }

        private void rbtCidade_CheckedChanged(object sender, EventArgs e)
        {
            ttbFiltroCidade.Enabled = rbtCidade.Checked;
            ttbFiltroNome.Enabled = rbtNome.Checked = !rbtCidade.Checked;
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void ttbFiltroNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLocalizar.PerformClick();
        }

        private void ttbFiltroCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLocalizar.PerformClick();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            FuncionariosAlter fun = new FuncionariosAlter(banco);
            banco.conecta();
            if (rbtNome.Checked)
                dgvFuncionarios.DataSource = fun.localizarPor("fun_nome", ttbFiltroNome.Text);

            if (rbtCidade.Checked)
                dgvFuncionarios.DataSource = fun.localizarPor("fun_cidade", ttbFiltroCidade.Text);
            banco.desconecta();
        }
    }
}
