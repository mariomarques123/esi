using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Movimentacao
{
    public partial class frmConsultaLancamentos : Form
    {
        public DataRow linha = null;

        public frmConsultaLancamentos()
        {
            InitializeComponent();
        }

        private void rbtPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            lblA.Enabled = dtpIni.Enabled = dtpFim.Enabled = rbtPeriodo.Checked;
            dtpIni.Value = dtpFim.Value = DateTime.Now;
        }

        private void rbtValor_CheckedChanged(object sender, EventArgs e)
        {
            lblA2.Enabled = mtbValorIni.Enabled = mtbValorFim.Enabled = rbtValor.Checked;
            mtbValorIni.Clear();
            mtbValorFim.Clear();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            MovContas mov = new MovContas(new BancoM());

            if (rbtExibirTodos.Checked)
            {
                dgvHistorico.DataSource = mov.exibirTodos();
            }
            else if (rbtCredito.Checked)
            {
                dgvHistorico.DataSource = mov.porTipo('C');
            }
            else if (rbtDebito.Checked)
            {
                dgvHistorico.DataSource = mov.porTipo('D');
            }
            else if (rbtPeriodo.Checked)
            {
                dgvHistorico.DataSource = mov.porPeriodo(dtpIni.Value.AddDays(-1), dtpFim.Value);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvHistorico.CurrentRow != null)
            {
                DataRowView currentDataRowView = (DataRowView)dgvHistorico.CurrentRow.DataBoundItem;
                linha = currentDataRowView.Row;
                Close();
            }
        }

        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }
    }
}
