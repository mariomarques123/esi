using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using CrystalDecisions.CrystalReports.Engine;

namespace SAEA.Relatorios
{
    public partial class frmRelatorioTransacoesBancarias : Form
    {
        public frmRelatorioTransacoesBancarias()
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
            crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\RelTransacoesBancarias.rpt");

            if (rbSemFiltro.Checked)
            {
                crDocument.SetDataSource(new RelTransacoes(new Banco()).semFiltro());
            }
            else if (ckbPeriodo.Checked && !ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelTransacoes(new Banco()).porPeriodo(dtpIni.Value,dtpFim.Value));
            }
            else if (!ckbPeriodo.Checked && ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelTransacoes(new Banco()).porTipo(cbbTipo.Text[0]));
            }
            else if (ckbPeriodo.Checked && ckbTipo.Checked)
            {
                crDocument.SetDataSource(new RelTransacoes(new Banco()).porPeriodoTipo(dtpIni.Value, dtpFim.Value,cbbTipo.Text[0]));
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
