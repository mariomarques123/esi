using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Cadastros
{
    public partial class frmConsultaFuncionarios : Form
    {
        public DataRow linha = null;

        public DataRow getLinhaSelecionada()
        {
            return linha;
        }

        public frmConsultaFuncionarios()
        {
            InitializeComponent();

            ttbNome.MaxLength = 100;
            ttbCidade.MaxLength = 50;
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
            ttbCidade.Enabled = rbtCidade.Checked;
            ttbNome.Enabled = rbtNome.Checked = !rbtCidade.Checked;
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void ttbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLocalizar.PerformClick();
        }

        private void ttbCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLocalizar.PerformClick();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios(new BancoM());

            if (rbtNome.Checked)
                dgvFuncionarios.DataSource = fun.localizarPor("fun_nome", ttbNome.Text);

            if (rbtCidade.Checked)
                dgvFuncionarios.DataSource = fun.localizarPor("fun_cidade", ttbCidade.Text);
        }
    }
}
