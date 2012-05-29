using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Cadastros.buscas;
using SAEA.Classes;

namespace SAEA.Movimentacao
{
    public partial class frmMovimentacaoConta : Form
    {
        bool flag = false;

        public frmMovimentacaoConta()
        {
            InitializeComponent();
            CarregaDestino();
            CarregaTipo();
            Inicializa();
        }

        private void CarregaTipo()
        {
            DataTable dttTipo = new DataTable();

            dttTipo.Columns.Add("nome");
            dttTipo.Columns.Add("sigla", typeof(char));

            dttTipo.Rows.Add("Crédito", 'C');
            dttTipo.Rows.Add("Débito", 'D');

            cbbTipo.DataSource = dttTipo;
            cbbTipo.DisplayMember = "nome";
            cbbTipo.ValueMember = "sigla";
        }

        private void CarregaOrigem(int destino)
        {
            Contas con = new Contas(new BancoM());

            cbbOrigem.DataSource = con.listarMenos1(destino);
            cbbOrigem.DisplayMember = "con_numero";
            cbbOrigem.ValueMember = "con_codigo";
        }

        private void CarregaDestino()
        {
            Contas con = new Contas(new BancoM());

            cbbDestino.DataSource = con.listar1();

            cbbDestino.DisplayMember = "con_numero";
            cbbDestino.ValueMember = "con_codigo";
        }

        private void rbtTrans_CheckedChanged(object sender, EventArgs e)
        {
            lblOrigem.Visible = cbbOrigem.Visible = btnLocalizar2.Visible = rbtTrans.Checked;
            CarregaOrigem(0);
            cbbOrigem.SelectedIndex = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmBuscaCadastroContaBancaria j = new frmBuscaCadastroContaBancaria();
            j.ShowDialog();
            DataRow selecao = j.getLinhaSelecionada();
            j.Dispose();

            if (selecao != null)
            {
                if (((System.Windows.Forms.Button)sender).Name == "btnLocalizar2")
                    cbbOrigem.SelectedValue = selecao["con_codigo"].ToString();
                else
                    cbbDestino.SelectedValue = selecao["con_codigo"].ToString();

                AtualizaHistorico();
            }
        }


        private void rbtPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            lblA.Enabled = dtpIni.Enabled = dtpFim.Enabled = rbtPeriodo.Checked;
            dtpIni.Value = dtpFim.Value = DateTime.Now;
            AtualizaHistorico();
        }

        private void rbtTipo_CheckedChanged(object sender, EventArgs e)
        {
            cbbTipo.Enabled = rbtTipo.Checked;
            cbbTipo.SelectedIndex = -1;
            AtualizaHistorico();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Inicializa();
        }

        private void Inicializa()
        {
            cbbDestino.SelectedIndex = 0;
            ggbHistorico.Enabled = false;
            ttbCodigo.Text = "";
            cbbTipo.SelectedIndex = -1;
            dtpIni.Value = dtpData.Value = DateTime.Now;
            rbtUltimosLan.Checked = true;
            rbtTrans.Checked = false;
            rbtDebito.Checked = false;
            cbbDestino.SelectedIndex = -1;
            AtualizaHistorico();
            LimparLacamento();
            flag = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta destino");
                cbbDestino.Focus();
            }
            else if (!flag)
            {
                MessageBox.Show("Insira o valor do lançamento");
                mtbValor.Focus();
            }
            else if (rbtTrans.Checked && cbbOrigem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta origem");
                cbbOrigem.Focus();
            }
            else if (rbtTrans.Checked && cbbOrigem.SelectedValue.ToString() == cbbDestino.SelectedValue.ToString())
            {
                MessageBox.Show("Selecione uma conta origem diferente da conta destino");
                cbbOrigem.SelectedIndex = -1;
            }
            else
            {
                char tipo = 'C';

                if (rbtDebito.Checked)
                    tipo = 'D';

                if (ttbCodigo.Text.Trim() == "") //cadastrar
                {
                    MovContas mov = new MovContas(new BancoM());

                    if (rbtTrans.Checked)
                    {
                        if (mov.registrar(dtpData.Value, float.Parse(mtbValor.Text.Substring(2).Trim()), 'C', int.Parse(cbbDestino.SelectedValue.ToString()))
                        && mov.registrar(dtpData.Value, float.Parse(mtbValor.Text.Substring(2).Trim()), 'D', int.Parse(cbbOrigem.SelectedValue.ToString())))
                            MessageBox.Show("Transferencia realizada com sucesso");
                        else
                            MessageBox.Show("Erro ao transferir");
                    }
                    else
                    {
                        if (mov.registrar(dtpData.Value, float.Parse(mtbValor.Text.Substring(2).Trim()), tipo,
                                                            int.Parse(cbbDestino.SelectedValue.ToString())))
                            MessageBox.Show("Lançamento registrado com sucesso");
                        else
                            MessageBox.Show("Erro ao registrar o lançamento");

                    }
                }
                else
                {
                    MovContas mov = new MovContas(new BancoM());

                    if (mov.alterar(int.Parse(ttbCodigo.Text.ToString()),dtpData.Value, float.Parse(mtbValor.Text.Substring(2).Trim()), tipo,
                                                            int.Parse(cbbDestino.SelectedValue.ToString())))
                        MessageBox.Show("Lançamento alterado com sucesso");
                    else
                        MessageBox.Show("Erro ao alterar o lançamento");
                }

                flag = false;
                LimparLacamento();
                AtualizaHistorico();
            }
        }

        private void LimparLacamento()
        {
            mtbValor.Clear();
            dtpData.Value = DateTime.Now;
            rbtCredito.Checked = true;
            cbbOrigem.SelectedIndex = -1;
        }

        private void AtualizaHistorico()
        {
            ttbCodigo.Clear();
            btnRegistrar.Text = "Registrar";
            rbtTrans.Enabled = true;

            if (cbbDestino.SelectedIndex != -1)
            {
                ggbHistorico.Enabled = true;

                MovContas mov = new MovContas(new BancoM());
                if (rbtUltimosLan.Checked)
                {
                    dgvHistorico.DataSource = mov.UltimosLancamentos(int.Parse(cbbDestino.SelectedValue.ToString()));
                }
                else if (rbtPeriodo.Checked)
                {
                    dgvHistorico.DataSource = mov.porPeriodo(int.Parse(cbbDestino.SelectedValue.ToString()), dtpIni.Value.AddDays(-1), dtpFim.Value);
                }
                else
                {
                    char mov_tipo = 'X';
                    if(cbbTipo.SelectedIndex != -1)
                        char.TryParse(cbbTipo.SelectedValue.ToString(),out mov_tipo);
                    dgvHistorico.DataSource = mov.porTipo(int.Parse(cbbDestino.SelectedValue.ToString()),mov_tipo);
                }
            }
            else
            {
                ggbHistorico.Enabled = false;
                MovContas mov = new MovContas(new BancoM());
                dgvHistorico.DataSource = mov.UltimosLancamentos(0);
            }
        }

        private void rbtUltimosLan_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaHistorico();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ttbCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um lançamento");
                dgvHistorico.Focus();
            }
            else
            {
                MovContas mov = new MovContas(new BancoM());
                if(mov.excluir(int.Parse(ttbCodigo.Text)))
                    MessageBox.Show("Lançamento excluido com sucesso");
                else
                    MessageBox.Show("Erro ao excluir o lançamento");
                
                AtualizaHistorico();
                LimparLacamento();
            }
        }

        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void cbbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDestino.SelectedIndex != -1)
            {
                if (rbtTrans.Checked)
                    lblOrigem.Visible = cbbOrigem.Visible = btnLocalizar2.Visible = rbtTrans.Checked;
                ttbCodigo.Clear();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvHistorico.CurrentRow != null)
            {
                btnRegistrar.Text = "Alterar";
                rbtTrans.Checked = rbtTrans.Enabled = false;

                DataRowView currentDataRowView = (DataRowView)dgvHistorico.CurrentRow.DataBoundItem;
                DataRow linha = currentDataRowView.Row;

                ttbCodigo.Text = linha["mov_codigo"].ToString();
                dtpData.Value = Convert.ToDateTime(linha["mov_data"].ToString());
                cbbDestino.SelectedValue = int.Parse(linha["con_codigo"].ToString());
                mtbValor.Text = float.Parse(linha["mov_valor"].ToString()).ToString("$00000.00");

                if (char.Parse(linha["mov_tipo"].ToString()) == 'C')
                    rbtCredito.Checked = true;
                else if (char.Parse(linha["mov_tipo"].ToString()) == 'D')
                    rbtDebito.Checked = true;
                else
                    rbtTrans.Checked = true;
            }
            else
            {
                MessageBox.Show("Selecione um lançamento registrado");
                dgvHistorico.Focus();
            }
        }

        private void btnLocalizarLan_Click(object sender, EventArgs e)
        {
            frmConsultaLancamentos f = new frmConsultaLancamentos();
            f.ShowDialog();

            if (f.linha != null)
            {
                ttbCodigo.Text = f.linha["mov_codigo"].ToString();
                dtpData.Value = Convert.ToDateTime(f.linha["mov_data"].ToString());
                cbbDestino.SelectedValue = int.Parse(f.linha["con_codigo"].ToString());
                mtbValor.Text = float.Parse(f.linha["mov_valor"].ToString()).ToString("$00000.00");

                if (char.Parse(f.linha["mov_tipo"].ToString()) == 'C')
                    rbtCredito.Checked = true;
                else if (char.Parse(f.linha["mov_tipo"].ToString()) == 'D')
                    rbtDebito.Checked = true;
                else
                    rbtTrans.Checked = true;

                rbtUltimosLan.Checked = true;
                AtualizaHistorico();
            }
        }

        private void mtbValor_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }
    }
}
