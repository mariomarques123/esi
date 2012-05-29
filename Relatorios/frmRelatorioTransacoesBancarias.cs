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
using SAEA.Relatorios.Crystal;

namespace SAEA.Relatorios
{
    public partial class frmRelatorioTransacoesBancarias : Form
    {
        public frmRelatorioTransacoesBancarias()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (rbSemFiltro.Checked)
            {
                ReportDocument crDocument = new RelTransacoesBancarias1();//ReportDocument(); 
                //crDocument.Load(Application.StartupPath + @"\..\..\RelTransacoesBancarias1.rpt");
                crDocument.SetDataSource(new MovContas(new BancoM()).RelSemFiltro());

                frmVisualizador f = new frmVisualizador(); 
                f.carregar(crDocument);
                f.ShowDialog();
            }
        }
    }
}
