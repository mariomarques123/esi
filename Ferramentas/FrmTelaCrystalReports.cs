using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace SAEA.Ferramentas
{
    public partial class FrmTelaCrystalReports : Form
    {
        public FrmTelaCrystalReports()
        {
            InitializeComponent();
        }

        public void alterarTitulo(string novo)
        {
            this.Text = novo;
        }

        public void carregar(ReportDocument crDocumento)
        {
            crvRelatorio.ReportSource = crDocumento;
        }
    }
}
