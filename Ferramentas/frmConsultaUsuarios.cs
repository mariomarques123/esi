using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Ferramentas
{
public partial class frmConsultaUsuarios : Form
{
    public DataRow linha = null;

    public frmConsultaUsuarios()
    {
        InitializeComponent();
        ttbLogin.MaxLength = 30;
        CarregaNiveis();
    }

    private void CarregaNiveis()
    {
        DataTable dttTipo = new DataTable();

        dttTipo.Columns.Add("nome");
        dttTipo.Columns.Add("nivel", typeof(int));

        dttTipo.Rows.Add("Advogado",0);
        dttTipo.Rows.Add("Administrador", 1);

        ccbNivelAcesso.DataSource = dttTipo;

        ccbNivelAcesso.DisplayMember = "nome";
        ccbNivelAcesso.ValueMember = "nivel";
        ccbNivelAcesso.Enabled = false;
        ccbNivelAcesso.SelectedIndex = -1;
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
        if (dgvUsuarios.CurrentRow != null)
        {
            DataRowView currentDataRowView = (DataRowView) dgvUsuarios.CurrentRow.DataBoundItem;
            linha = currentDataRowView.Row;
            Close();
        }
    }

    private void rbtLogin_CheckedChanged(object sender, EventArgs e)
    {
        ccbNivelAcesso.SelectedIndex = -1;
    }

    private void rbtNivelAcesso_CheckedChanged(object sender, EventArgs e)
    {
        ccbNivelAcesso.Enabled = rbtNivelAcesso.Checked;
        ttbLogin.Enabled = rbtLogin.Checked = !rbtNivelAcesso.Checked;
    }

    private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        btnSelecionar.PerformClick();
    }

    private void ttbLogin_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnLocalizar.PerformClick();
    }

    private void ccbFiltroNivelAcesso_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnLocalizar.PerformClick();
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
        Usuarios usu = new Usuarios(new BancoM());
        DataTable dtt;

        if (rbtLogin.Checked)
        {
            dtt = usu.localizarLogin(ttbLogin.Text);
            int aux = ccbNivelAcesso.SelectedIndex;
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                ccbNivelAcesso.SelectedValue = Convert.ToInt32(dtt.Rows[i]["usu_nivelacesso"]);
                dtt.Rows[i]["usu_nomenivel"] = ccbNivelAcesso.Text;
                ccbNivelAcesso.SelectedIndex = aux;
            }
            dgvUsuarios.DataSource = dtt;
        }

        if (rbtNivelAcesso.Checked)
        {
            dtt = usu.localizarNivelAcesso(Convert.ToInt32(ccbNivelAcesso.SelectedValue));
            for (int i = 0; i < dtt.Rows.Count; i++)
                dtt.Rows[i]["usu_nomenivel"] = ccbNivelAcesso.Text;
            dgvUsuarios.DataSource = dtt;
        }
    }
}
}
