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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Inicializa();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!Funcoes.StringVazia(ttbLogin, "Digite o nome de usuário") && !Funcoes.StringVazia(ttbSenha1, "Digite a senha atual"))
            {
                Usuarios usu = new Usuarios(new BancoM());

                //if (ttbSenha1.Text != ttbSenha2.Text)
                //{
                //    MessageBox.Show("As senhas nao coencidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ttbSenha1.Focus();
                //}
                //else 
                //{
                    DataTable dtt = usu.localizarPor("usu_login", ttbLogin.Text);

                    if (dtt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Este nome de usuário não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ttbLogin.Focus();
                    }
                    else if (dtt.Rows[0]["usu_senha"].ToString() != ttbSenha1.Text)
                    {
                        MessageBox.Show("A senha atual nao confere", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ttbLogin.Focus();
                    }
                    else if (ttbSenha2.Text.Trim() == "")
                    {
                        MessageBox.Show("Digite a nova senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ttbLogin.Focus();
                    }
                    else
                    {
                        if (usu.alterarSenha(ttbLogin.Text, ttbSenha2.Text))
                            MessageBox.Show("Alteracao efetivada com sucesso!");
                        else
                            MessageBox.Show("Erro ao alterar");

                        Inicializa();
                    }
             //   }
            }
        }

        private void Inicializa()
        {
            ttbLogin.Clear();
            ttbSenha1.Clear();
            ttbSenha2.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
