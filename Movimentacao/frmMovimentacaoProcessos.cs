using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Movimentacao
{
    public partial class frmMovimentacaoProcessos : Form
    {
        int pas_cod_anterior = 0;

        public frmMovimentacaoProcessos()
        {
            InitializeComponent();
            CarregaProcessos();
        }

        private void CarregaProcessos()
        {
            ccbProcessos.DataSource = new Processos(new BancoM()).localizarPor("pro_numero", "%");
            ccbProcessos.DisplayMember = "pro_descricao";
            ccbProcessos.ValueMember = "pro_numero";
            ccbProcessos.SelectedIndex = -1;
        }

        private void Inicializa()
        {
            Funcoes.Limpar(pnlDados);
            gpbLocalAtual.Enabled = false;
            rdbArquivo.Checked = rdbPasta.Checked = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializa();
        }

        private void ccbProcessos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gpbLocalAtual.Enabled = true;
            int pro_numero = 0;
            int.TryParse(ccbProcessos.SelectedValue.ToString(), out pro_numero);

            DataTable dtt = new Pastas(new BancoM()).pastasDisponiveis(pro_numero);
            if (dtt.Rows.Count > 0)
            {
                rdbPasta.Checked = true;
                ccbPastas.DataSource = dtt;
                ccbPastas.DisplayMember = "pas_codigo";
                ccbPastas.ValueMember = "pro_numero";
                ccbPastas.SelectedValue = pro_numero;

                if (ccbPastas.Text.Trim() == "")
                {
                    rdbArquivo.Checked = true;
                    pas_cod_anterior = 0;
                }
                else
                    int.TryParse(ccbPastas.Text.ToString(), out pas_cod_anterior);
            }
            else
            {
                ccbPastas.DataSource = null;
                rdbArquivo.Checked = true;
                ccbPastas.Enabled = false;
            }
        }

        private void rdbPasta_CheckedChanged(object sender, EventArgs e)
        {
            ccbPastas.Enabled = rdbPasta.Checked;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int pro_numero = 0,pas_codigo = 0;
            int.TryParse(ccbProcessos.SelectedValue.ToString(), out pro_numero);
            int.TryParse(ccbPastas.Text.ToString(),out pas_codigo);

            if (rdbPasta.Checked && pas_codigo == 0)
            {
                MessageBox.Show("Selecione uma pasta");
                ccbPastas.Focus();
            }
            else
            {
                Pastas pas = new Pastas(new BancoM());
                bool certo = true;

                if(pas_cod_anterior != 0)
                    if (!pas.esvaziapasta(pas_cod_anterior))
                        certo = false;

                if (certo && rdbPasta.Checked)
                    if (!pas.alterarprocesso(pas_codigo, pro_numero))
                        certo = false;

                if (certo)
                    MessageBox.Show("Alteração efetivada com sucesso");
                else
                    MessageBox.Show("Erro ao alterar");

                Inicializa();
            }
        }
    }
}
