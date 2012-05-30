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
    public partial class frmConsultaPastas : Form
    {
        public DataRow linha = null;

        public frmConsultaPastas()
        {
            InitializeComponent();

            ttbCodigo.MaxLength = 8;
            ttbLocalizacao.MaxLength = 30;
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
            if (dgvPastas.CurrentRow != null)
            {
                DataRowView currentDataRowView = (DataRowView)dgvPastas.CurrentRow.DataBoundItem;
                linha = currentDataRowView.Row;
                Close();
            }
        }

        private void rbtCodigo_CheckedChanged_1(object sender, EventArgs e)
        {
            ttbLocalizacao.Enabled = rbtLocalizacao.Checked;
            ttbCodigo.Enabled = rbtCodigo.Checked = !rbtLocalizacao.Checked;
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void ttbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLocalizar.PerformClick();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Pastas pas = new Pastas(new BancoM());

            int codigo = 0;
            int.TryParse(ttbCodigo.Text, out codigo);

            if (rbtCodigo.Checked)
                dgvPastas.DataSource = pas.localizarCodigo(codigo);

            if (rbtLocalizacao.Checked)
                dgvPastas.DataSource = pas.localizarLocalizacao(ttbLocalizacao.Text);
        }
    }
}
