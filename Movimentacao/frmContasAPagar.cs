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
public partial class frmContasAPagar : Form
{
    bool flag = false;

    public frmContasAPagar()
    {
        InitializeComponent();
        carregaFunc();
        AtualizaHistorico();
    }

    private void carregaFunc()
    {
        Funcionarios fun = new Funcionarios(new BancoM());
        cbbFunc.DataSource = fun.localizarPor("fun_codigo", "%");
        cbbFunc.DisplayMember = "fun_nome";
        cbbFunc.ValueMember = "fun_codigo";
        cbbFunc.SelectedIndex = -1;
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        if (ttbDescricao.Text.Trim() == "")
        {
            MessageBox.Show("Insira a descrição");
            ttbDescricao.Focus();
        }
        else if (!flag)
        {
            MessageBox.Show("Insira o valor");
            mtbValor.Focus();
        }
        else
        {
            if (ttbCodigo.Text.Trim() == "") 
            {
                int fun_codigo = 0;
                if (cbbFunc.SelectedIndex != -1)
                    int.TryParse(cbbFunc.SelectedValue.ToString(), out fun_codigo);

                ContasPagar cop = new ContasPagar(new BancoM());

                if (cop.registrar(ttbDescricao.Text, dtpDataVenc.Value, float.Parse(mtbValor.Text.Substring(2).Trim()), fun_codigo))
                    MessageBox.Show("Conta lançada com sucesso");
                else
                    MessageBox.Show("Erro ao lançar a conta");

                AtualizaHistorico();
            }
        }
    }

    private void AtualizaHistorico()
    {
        ContasPagar cop = new ContasPagar(new BancoM());
        if (rbtVencProx.Checked)
        {
            dgvHistorico.DataSource = cop.UltimosVencimentos();
        }
        else if (rbtAberto.Checked)
        {
            dgvHistorico.DataSource = cop.abertos();
        }
        else if (rbtPagas.Checked)
        {
            dgvHistorico.DataSource = cop.pagas();
        }
        else if (rbtVencidas.Checked)
        {
            dgvHistorico.DataSource = cop.vencidas();
        }
    }

    private void rbtUltimosLan_CheckedChanged(object sender, EventArgs e)
    {
        AtualizaHistorico();
    }

    private void mtbValor_KeyDown(object sender, KeyEventArgs e)
    {
        flag = true;
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        ttbCodigo.Clear();
        dtpDataVenc.Value = DateTime.Now;
        mtbValor.Clear();
        cbbFunc.SelectedIndex = -1;
    }

    private void btnSelecionar_Click(object sender, EventArgs e)
    {
        if (dgvHistorico.CurrentRow != null)
        {
            //btnRegistrar.Text = "Alterar";
            //rbtTrans.Checked = rbtTrans.Enabled = false;

            //DataRowView currentDataRowView = (DataRowView)dgvHistorico.CurrentRow.DataBoundItem;
            //DataRow linha = currentDataRowView.Row;

            //ttbCodigo.Text = linha["mov_codigo"].ToString();
            //dtpData.Value = Convert.ToDateTime(linha["mov_data"].ToString());
            //cbbDestino.SelectedValue = int.Parse(linha["con_codigo"].ToString());
            //mtbValor.Text = float.Parse(linha["mov_valor"].ToString()).ToString("$00000.00");

            //if (char.Parse(linha["mov_tipo"].ToString()) == 'C')
            //    rbtCredito.Checked = true;
            //else if (char.Parse(linha["mov_tipo"].ToString()) == 'D')
            //    rbtDebito.Checked = true;
            //else
            //    rbtTrans.Checked = true;
        }
        else
        {
            MessageBox.Show("Selecione um lançamento registrado");
            dgvHistorico.Focus();
        }
    }

    private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        btnSelecionar.PerformClick();
    }
}
}
