using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Cadastros
{
public partial class frmCadastroPastas : Form
{
    String titulo = "Cadastro de Pastas";

    public frmCadastroPastas()
    {
        InitializeComponent(); 

        ttbCodigo.MaxLength = 8;
        ttbLocalizacao.MaxLength = 30;

        CarregaProcessos();
        Inicializa();
    }

    private void CarregaProcessos()
    {
        Processos pro = new Processos(new BancoM());
        DataTable dtt2 = pro.localizarPor("pro_numero", "%");

        DataRow linha = dtt2.NewRow();
        linha["pro_descricao"] = "Pasta vazia";
        linha["pro_numero"] = 0;
        dtt2.Rows.InsertAt(linha, 0);
        
        ccbProcessos.DataSource = dtt2;
        ccbProcessos.DisplayMember = "pro_descricao";
        ccbProcessos.ValueMember = "pro_numero";
    }

    private void Inicializa()
    {
        Funcoes.Limpar(pnlDados);
        Habilitar("N");
        ccbProcessos.SelectedIndex = 0;
    }

    private void frmCadastroFuncionarios_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            this.SelectNextControl(this.ActiveControl, true, true, true, true);
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Inicializa();
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
        Habilitar("I");
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        Habilitar("A");
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Habilitar(string acao) //I, A, N, V  (N = neutro)
    {
        switch (acao)
        {
            case "I": Text = titulo + " (Incluindo)";       break;
            case "A": Text = titulo + " (Alterando)";       break;
            case "V": Text = titulo + " (Visualizando)";    break;
            case "N": Text = titulo;                        break;
        }

        ttbCodigo.Enabled       = false;
        pnlDados.Enabled        = "IA".IndexOf(acao) >= 0;
        btnIncluir.Enabled      = acao == "N";
        btnAlterar.Enabled      = acao == "V";
        btnExcluir.Enabled      = acao == "V";
        btnGravar.Enabled       = "IA".IndexOf(acao) >= 0;
        btnCancelar.Enabled     = "IAV".IndexOf(acao) >= 0;
        btnLocalizar.Enabled    = "NV".IndexOf(acao) >= 0;
        btnLocalizar.Enabled    = true;
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        int pas_codigo = 0;
        int.TryParse(ttbCodigo.Text, out pas_codigo);
        int pro_numero = Convert.ToInt32(ccbProcessos.SelectedValue);

        Pastas pas = new Pastas(new BancoM());

        if (pas_codigo == 0 && pas.processoemPasta(pro_numero).Rows.Count > 0)
        {
            MessageBox.Show("Erro, este processo já esta cadastrado em uma pasta");
            ccbProcessos.Focus();
        }
        else
        {
            if (pas_codigo == 0)
            {
                if (pas.incluir(pro_numero, ttbLocalizacao.Text))
                    MessageBox.Show("Cadastro efetivado com sucesso!");
                else
                    MessageBox.Show("Erro ao cadastrar");
            }
            else
            {
                if (pas.alterar(pas_codigo, pro_numero, ttbLocalizacao.Text))
                    MessageBox.Show("Alteracao efetivada com sucesso!");
                else
                    MessageBox.Show("Erro ao alterar");
            }
            Inicializa();
        }

    }
    
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        int codigo = 0;

        if (!int.TryParse(ttbCodigo.Text, out codigo))
        {
            MessageBox.Show("Selecione um funcionário válido para excluir.");
            btnLocalizar.Focus();
        }
        else if (MessageBox.Show("Confirma exclusão?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
            Pastas pas = new Pastas(new BancoM());

            if (pas.excluir(codigo))
                MessageBox.Show("Exclusão efetivada com sucesso!");
            else
                MessageBox.Show("Erro ao excluir!");
                     
            Inicializa();
        }
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
        frmConsultaPastas f = new frmConsultaPastas();
        f.ShowDialog();
            
        if (f.linha != null)
        {
            ttbCodigo.Text              = f.linha["pas_codigo"].ToString();
            int pro_numero = 0;
            int.TryParse(f.linha["pro_numero"].ToString(), out pro_numero);
            ccbProcessos.SelectedValue  = pro_numero;
            ttbLocalizacao.Text         = f.linha["pas_locpasta"].ToString();

            Habilitar("V");
        }
    }
}
}
