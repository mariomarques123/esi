using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SAEA.Outros;

namespace SAEA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
