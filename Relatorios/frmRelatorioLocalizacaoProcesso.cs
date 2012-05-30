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

namespace SAEA.Movimentacao
{
    public partial class frmRelatorioLocalizacaoProcesso : Form
    {
        public frmRelatorioLocalizacaoProcesso()
        {
            InitializeComponent();

            cbbSituacao.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            ReportDocument crDocument = new ReportDocument();
            crDocument.Load(Application.StartupPath + @"\..\..\RelLocalizacaoProcesso.rpt");

            if (rbSemFiltro.Checked)
            {
                crDocument.SetDataSource(new RelProcesso(new Banco()).semfiltro());
            }
            else if (ckbNome.Checked && !ckbSituacao.Checked)
            {
                crDocument.SetDataSource(new RelProcesso(new Banco()).porNome(ttbNome.Text));
            }
            else if (!ckbNome.Checked && ckbSituacao.Checked)
            {
                //if(cbbSituacao.SelectedText == "Em Pasta")
                //    crDocument.SetDataSource(new RelProcesso(new Banco()).emPasta()));
                //else
                //    crDocument.SetDataSource(new RelProcesso(new Banco()).arquivado()));
            }
            else if (ckbNome.Checked && ckbSituacao.Checked)
            {

            }

            frmVisualizador f = new frmVisualizador();
            f.carregar(crDocument);
            f.ShowDialog();
        }

        private void ckbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNome.Checked || ckbSituacao.Checked)
                rbSemFiltro.Checked = false;
            else
                rbSemFiltro.Checked = true;
        }

        private void rbSemFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemFiltro.Checked)
            {
                ckbSituacao.Checked = ckbNome.Checked = false;
                rbSemFiltro.Checked = true;
            }
        }
    }
}
