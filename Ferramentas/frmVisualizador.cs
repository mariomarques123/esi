using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace SAEA
{
    public partial class frmVisualizador : Form
    {
        public frmVisualizador()
        {
            InitializeComponent();
            crv.ShowRefreshButton = false;
            crv.Zoom(100);
        }

        public void carregar(ReportDocument crDocument)
        {
            crv.ReportSource = crDocument;
        } 
    }
}
