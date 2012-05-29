using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEA.Classes
{
    class Gerais
    {

        public static int avaliaEstado(string estado)
        {
            switch (estado)
            {
                case "AC": return 0; 
                case "AL": return 1; 
                case "AP": return 2; 
                case "AM": return 3; 
                case "BA": return 4; 
                case "CE": return 5; 
                case "DF": return 6; 
                case "ES": return 7; 
                case "GO": return 8; 
                case "MA": return 9; 
                case "MT": return 10; 
                case "MS": return 11; 
                case "MG": return 12; 
                case "PA": return 13; 
                case "PB": return 14; 
                case "PR": return 15; 
                case "PE": return 16; 
                case "PI": return 17; 
                case "RJ": return 18; 
                case "RN": return 19; 
                case "RS": return 20; 
                case "RO": return 21; 
                case "RR": return 22; 
                case "SC": return 23; 
                case "SP": return 24; 
                case "SE": return 25; 
                case "TO": return 26; 
                default: return -1; 
            }
        }

        public static void clearControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).Text = "";
                    else if (ctrl.GetType() == typeof(MaskedTextBox))
                        ((MaskedTextBox)ctrl).Text = "";
                    else if (ctrl.GetType() == typeof(ComboBox))
                        ((ComboBox)ctrl).SelectedIndex = -1;

                    if (ctrl.Controls.Count > 0)
                        clearControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string retiraTodosCharter(string entrada, char desejo)
        {
            string saida = "";
            foreach (char charter in entrada)
                if (charter != desejo)
                    saida += charter;
            return saida;
        }

        /*
         * 
          SELECT     *
            FROM         INFORMATION_SCHEMA.COLUMNS
            WHERE     (table_name = 'clientes')
         */

        public static double converteStoD(string entrada)
        {
            
            double saida = 0;
            if (entrada != null)
            {
                string avalia = retiraTodosCharter(entrada,' ');
                if (entrada[0] == 'R' || entrada[0] == '$')
                {
                    try
                    {
                        saida = double.Parse(avalia.Substring(2));
                    }
                    catch (Exception e)
                    {
                        saida = 0.0;
                    }
                }
                else
                {
                    try
                    {
                        saida = double.Parse(avalia);
                    }
                    catch (Exception e)
                    {
                        saida = 0.0;
                    }
                }
            }
            return saida;
        }
    }
}
