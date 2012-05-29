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
public partial class frmCadastroFuncionarios : Form
{
    String titulo = "Cadastro de Funcionários";

    public frmCadastroFuncionarios()
    {
        InitializeComponent(); 

        ttbNome.MaxLength = 100;
        mtbRG.MaxLength = 15;
        mtbCPF.MaxLength = 15;
        mtbTelefone.MaxLength = 15;
        mtbCelular.MaxLength = 15;
        ttbEmail.MaxLength = 20;
        ttbEndereco.MaxLength = 100;
        ttbNumero.MaxLength = 20;
        ttbCidade.MaxLength = 50;
        ttbBairro.MaxLength = 50;

        CarregaTipo();
        Inicializa();
    }

    private void CarregaTipo()
    {
        DataTable dttTipo = new DataTable();

        dttTipo.Columns.Add("nome");
        dttTipo.Columns.Add("sigla", typeof(char));

        dttTipo.Rows.Add("Sócio", 'S');
        dttTipo.Rows.Add("Advogado", 'A');

        ccbTipoFunc.DataSource = dttTipo;
        ccbTipoFunc.DisplayMember = "nome";
        ccbTipoFunc.ValueMember = "sigla";
    }

    private void Inicializa()
    {
        Funcoes.Limpar(pnlDados);
        Habilitar("N");
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
        ttbNome.Focus();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        Habilitar("A");
        ttbNome.Focus();
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
        int codigo = 0;
        int.TryParse(ttbCodigo.Text, out codigo);

        if (ttbNome.Text.Trim() == "")
        {
            MessageBox.Show("Digite o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ttbNome.Focus();
        }
        else 
        {
            Funcionarios fun = new Funcionarios(new BancoM());

            string cpf = Funcoes.mtbValido(mtbCPF);
            string rg = Funcoes.mtbValido(mtbRG);
            string telefone = Funcoes.mtbValido(mtbCelular);
            string celular = Funcoes.mtbValido(mtbTelefone);

            if (codigo == 0)
            {
                if (fun.incluir(ttbNome.Text,rg,cpf,Convert.ToChar(ccbTipoFunc.SelectedValue),telefone,celular,ttbEmail.Text,ttbEndereco.Text,ttbNumero.Text,ttbCidade.Text,ttbBairro.Text))
                    MessageBox.Show("Cadastro efetivado com sucesso!");
                else
                    MessageBox.Show("Não foi possivel excluir este funcionário, ele possui vínculos com outros cadastros");
            }
            else
            {
                if (fun.alterar(codigo, ttbNome.Text, rg, cpf, Convert.ToChar(ccbTipoFunc.SelectedValue), telefone, celular, ttbEmail.Text, ttbEndereco.Text, ttbNumero.Text, ttbCidade.Text, ttbBairro.Text))
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
            if (new Funcionarios(new BancoM()).excluir(codigo))
                MessageBox.Show("Exclusão efetivada com sucesso!");
            else
                MessageBox.Show("Erro ao excluir!");
                     
            Inicializa();
        }
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
        frmConsultaFuncionarios f = new frmConsultaFuncionarios();
        f.ShowDialog();
            
        if (f.linha != null)
        {
            ttbCodigo.Text      = f.linha["fun_codigo"].ToString();
            ttbNome.Text        = f.linha["fun_nome"].ToString();
            mtbRG.Text          = f.linha["fun_rg"].ToString();
            mtbCPF.Text         = f.linha["fun_cpf"].ToString();
            ccbTipoFunc.SelectedIndex = f.linha["fun_tipo"].ToString() == "S" ? 0 : 1;
            ccbTipoFunc.SelectedIndex = f.linha["fun_tipo"].ToString().Trim() == "" ? -1 : ccbTipoFunc.SelectedIndex;
            mtbTelefone.Text    = f.linha["fun_telefone"].ToString();
            mtbCelular.Text     = f.linha["fun_celular"].ToString();
            ttbEmail.Text       = f.linha["fun_email"].ToString();
            ttbEndereco.Text    = f.linha["fun_endereco"].ToString();
            ttbNumero.Text      = f.linha["fun_numero"].ToString();
            ttbCidade.Text      = f.linha["fun_cidade"].ToString();
            ttbBairro.Text      = f.linha["fun_bairro"].ToString();

            Habilitar("V");
        }
    }
}
}
