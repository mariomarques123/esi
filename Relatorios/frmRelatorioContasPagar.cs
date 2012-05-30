using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using SAEA.Classes;

namespace SAEA.Relatorios
{
    public partial class frmRelatorioContasPagar : Form
    {
        public frmRelatorioContasPagar()
        {
            InitializeComponent();
            cbbTipo.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ReportDocument crDocument = new ReportDocument(); 
            crDocument.Load(Application.StartupPath + @"\..\..\RelContasPagar.rpt");

            if (rbSemFiltro.Checked)
            {
                crDocument.SetDataSource(new RelContas(new Banco()).semFiltro());
            }
            else if (ckbPeriodo.Checked && !ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelContas(new Banco()).porDataVenc(dtpIni.Value, dtpFim.Value));
            }
            else if (!ckbPeriodo.Checked && ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelContas(new Banco()).porPagas(cbbTipo.Text));
            }
            else if (ckbPeriodo.Checked && ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelContas(new Banco()).porDataVencPagas(dtpIni.Value, dtpFim.Value,cbbTipo.Text));
            }

            frmVisualizador f = new frmVisualizador(); 
            f.carregar(crDocument);
            f.ShowDialog();
        }

        private void ckbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPeriodo.Checked || ckbTipo.Checked)
                rbSemFiltro.Checked = false;
            else
                rbSemFiltro.Checked = true;
        }

        private void rbSemFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemFiltro.Checked)
            {
                ckbPeriodo.Checked = ckbTipo.Checked = false;
                rbSemFiltro.Checked = true;
            }
        }

        private void ckbTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPeriodo.Checked || ckbTipo.Checked)
                rbSemFiltro.Checked = false;
            else
                rbSemFiltro.Checked = true;
        }
    }
}
