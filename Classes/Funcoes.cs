using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEA.Classes
{
    class Funcoes
    {
        static public bool NumeralValido(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        static public void Limpar(System.Windows.Forms.Control Container)
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
                    else if ((ctrl.GetType() == typeof(RichTextBox)))
                        ((RichTextBox)ctrl).Clear();
                    if (ctrl.Controls.Count > 0)
                        Limpar(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static public bool SomenteNumeros(System.Windows.Forms.TextBox ttb)
        {
            if (!NumeralValido(ttb.Text))
            {
                MessageBox.Show(ttb.Name.Substring(3) + " invalido, digite somente numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttb.Focus();
                return false;
            }
            return true;
        }

        static public bool StringVazia(System.Windows.Forms.TextBox ttb,string msg)
        {
            if (ttb.Text.Trim() == "")
            {
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttb.Focus();
                return true;
            }
            return false;
        }

        static public string mtbValido(System.Windows.Forms.MaskedTextBox mtb)
        {
            if (mtb.MaskFull)
                return mtb.Text;
            else
                return "";
        }
    }
}
