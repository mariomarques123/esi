using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.Outros
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            ttbUsuario.MaxLength = 30;
            ttbSenha.MaxLength = 20;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios(new BancoM());
            DataTable dtt = usu.localizarPor("usu_login", ttbUsuario.Text);
			

            if (ttbUsuario.Text.Trim() =="" || dtt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbUsuario.Focus();
            }
            else if (dtt.Rows[0]["usu_senha"].ToString() != ttbSenha.Text)
            {
                MessageBox.Show("Senha invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttbSenha.Focus();
            }
            else
            {
				//somente prosseguira quando os dados da empresa forem cadastrados corretamente!
				
				
				Banco banco = new Banco();
				CadastroDadosEmpresa consulta = new CadastroDadosEmpresa(banco);
				banco.conecta();
				
				while (consulta.verificaPrimeiroAcesso())
				{
					frmCadastroEmpresaInicial janela = new frmCadastroEmpresaInicial();
					janela.ShowDialog();
					janela.Dispose(); 
				}
			
                this.Visible = false;
                frmMenuPrincipal f = new frmMenuPrincipal(dtt.Rows[0]);
                f.ShowDialog();
                f.Close();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void ttbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
