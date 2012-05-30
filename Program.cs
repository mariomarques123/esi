using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SAEA.Outros;
using SAEA.Relatorios;

namespace SAEA
{
    //hi
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRelatorioTransacoesBancarias());
        }
    }
}
