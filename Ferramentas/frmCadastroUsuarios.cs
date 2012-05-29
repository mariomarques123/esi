using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Ferramentas
{
public partial class frmCadastroUsuarios : Form
{
    String titulo = "Cadastro de Usuários";
    DataRow usuario;

    public frmCadastroUsuarios(DataRow usuarioatual)
    {
        InitializeComponent(); 

        ttbLogin.MaxLength = 30;
        ttbSenha1.MaxLength = ttbSenha2.MaxLength = 20;

        this.usuario = usuarioatual;

        CarregaFuncionarios();
        Inicializa();
    }

    private void CarregaFuncionarios()
    {
        Funcionarios fun = new Funcionarios(new BancoM());

        ccbFuncionario.DataSource = fun.localizarPor("fun_codigo", "%");

        ccbFuncionario.DisplayMember = "fun_nome";
        ccbFuncionario.ValueMember = "fun_codigo";
    }

    private void Inicializa()
    {
        Funcoes.Limpar(pnlDados);
        Habilitar("N");
        rbtAdvogado.Checked = true;
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
        ttbLogin.Focus();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        Habilitar("A");
        ttbLogin.Focus();
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

        ttbLogin.Enabled        = "A".IndexOf(acao) < 0;
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
        if (!Funcoes.StringVazia(ttbLogin, "Digite o nome de usuário") && !Funcoes.StringVazia(ttbSenha1, "Digite a senha"))
        {
            if (ttbSenha1.Text != ttbSenha2.Text)
            {
                MessageBox.Show("As senhas nao coencidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbSenha1.Focus();
            }
            else if (ccbFuncionario.SelectedIndex < 0)            
            {
                MessageBox.Show("Selecione um funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ccbFuncionario.Focus();
            }
            else
            {
                Usuarios usu = new Usuarios(new BancoM());

                if (ttbLogin.Enabled == false)
                {
                    if (usu.alterar(ttbLogin.Text, Convert.ToInt32(rbtAdministrador.Checked), Convert.ToInt32(ccbFuncionario.SelectedValue), ttbSenha1.Text))
                        MessageBox.Show("Alteracao efetivada com sucesso!");
                    else
                        MessageBox.Show("Erro ao alterar");

                    Inicializa();
                }
                else if (usu.localizarPor("usu_login", ttbLogin.Text).Rows.Count > 0)
                {
                    MessageBox.Show("Este nome de usuário já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttbLogin.Focus();
                }
                else
                {
                    if (usu.incluir(ttbLogin.Text, Convert.ToInt32(rbtAdministrador.Checked), Convert.ToInt32(ccbFuncionario.SelectedValue), ttbSenha1.Text))
                        MessageBox.Show("Cadastro efetivado com sucesso!");
                    else
                        MessageBox.Show("Erro ao cadastrar");

                    Inicializa();
                }
            }
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (!Funcoes.StringVazia(ttbLogin, "Selecione um funcionário válido para excluir") && MessageBox.Show("Confirma exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
            if (ttbLogin.Text == usuario["usu_login"].ToString())
            {
                MessageBox.Show("Você não pode excluir seu proprio usuario!");
            }
            else
            {
                Usuarios usu = new Usuarios(new BancoM());

                if (usu.excluir(ttbLogin.Text))
                    MessageBox.Show("Exclusão efetivada com sucesso!");
                else
                    MessageBox.Show("Erro ao excluir!");
            }

            Inicializa();
         }
    }

    private void btnLocalizar_Click(object sender, EventArgs e)
    {
        frmConsultaUsuarios f = new frmConsultaUsuarios();
        f.ShowDialog();

        if (f.linha != null)
        {
            ttbLogin.Text = f.linha["usu_login"].ToString();
            ttbSenha1.Text = ttbSenha2.Text = f.linha["usu_senha"].ToString();
            ccbFuncionario.SelectedValue = f.linha["fun_codigo"].ToString();
            rbtAdministrador.Checked = Convert.ToBoolean(f.linha["usu_nivelacesso"]);

            Habilitar("V");
        }
    }
}
}

