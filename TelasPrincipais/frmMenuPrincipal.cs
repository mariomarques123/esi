using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Cadastros;
using SAEA.Ferramentas;
using SAEA.Movimentacao;
using SAEA.Relatorios;
using SAEA.TelasPrincipais;

namespace SAEA.Outros
{
    public partial class frmMenuPrincipal : Form
    {
        private DataRow usuarioatual;

        public frmMenuPrincipal(DataRow usuarioatual)
        {
            InitializeComponent();

            this.usuarioatual = usuarioatual;

            msMenuAdministrador.Visible = msMenuAdvogado.Visible = false;

            if (Convert.ToInt32(usuarioatual["usu_nivelacesso"]) == 1)
            {
                msMenuAdministrador.Visible = true;
                msMenuAdministrador.Dock = DockStyle.Top;
            }
            else
            {
                msMenuAdvogado.Visible = true;
                msMenuAdvogado.Dock = DockStyle.Top;
            }
        }

        private void tsmDesconectar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin f = new frmLogin();
            f.ShowDialog();
            f.Close();
            this.Close();
        }

        private void tsmFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmCadastroPastas_Click(object sender, EventArgs e)
        {
            frmCadastroPastas f = new frmCadastroPastas();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            new frmCadastroFuncionarios().ShowDialog();
        }

        private void tsmCadastroUsuarios_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuarios(usuarioatual).ShowDialog();
        }

        private void tsmAnexarDocumentoDigital_Click(object sender, EventArgs e)
        {
            new frmAnexarDocumentoDigital().ShowDialog();
        }

        private void tsmMovimentarPastas_Click(object sender, EventArgs e)
        {
            new frmMovimentacaoProcessos().ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmAlterarSenha().ShowDialog();
        }

        private void tsmCadastroClientes_Click(object sender, EventArgs e)
        {
            frmCadastroClientes f = new frmCadastroClientes();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmCadastroContas_Click(object sender, EventArgs e)
        {
            frmCadastroContasBancarias f = new frmCadastroContasBancarias();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmCadastroDespesas_Click(object sender, EventArgs e)
        {
            frmCadastroDespesasEscritorio f = new frmCadastroDespesasEscritorio();
            f.ShowDialog();
            f.Dispose();
        }

        private void tiposCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTiposCusto janela = new FrmCadastroTiposCusto();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroBanco janela = new frmCadastroBanco();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void tsmAtualizarCustasClientes_Click(object sender, EventArgs e)
        {
            frmLancamentoCustasProcessos janela = new frmLancamentoCustasProcessos();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void tsmAtualizarHonorarios_Click(object sender, EventArgs e)
        {
            frmAtualizacaoHonorariosProcessos f = new frmAtualizacaoHonorariosProcessos();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmGerenciarCalendario_Click(object sender, EventArgs e)
        {
            frmGerenciamentoCalendario f = new frmGerenciamentoCalendario();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmGerenciarProcessos_Click(object sender, EventArgs e)
        {
            frmGerenciamentoProcessos f = new frmGerenciamentoProcessos();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmGerenciarContasAPagar_Click(object sender, EventArgs e)
        {
            frmContasAPagar f = new frmContasAPagar();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmGerenciarRecebimentos_Click(object sender, EventArgs e)
        {
            frmGerenciamentoRecebimentos f = new frmGerenciamentoRecebimentos();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmMovimentarContas_Click(object sender, EventArgs e)
        {
            frmMovimentoConta f = new frmMovimentoConta();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmPainelInformacoes_Click(object sender, EventArgs e)
        {

        }

        private void tsmRelatorioProcessos_Click(object sender, EventArgs e)
        {
            frmRelatorioProcessos f = new frmRelatorioProcessos();
            f.ShowDialog();
            f.Dispose();
 
        }

        private void tsmRelatorioTransacoes_Click(object sender, EventArgs e)
        {
            frmRelatorioTransacoesBancarias f = new frmRelatorioTransacoesBancarias();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmRelatorioHonorarios_Click(object sender, EventArgs e)
        {
            frmRelatorioHonorarios f = new frmRelatorioHonorarios();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsmRelatorioBalanco_Click(object sender, EventArgs e)
        {
            frmRelatorioMovimentacoes f = new frmRelatorioMovimentacoes();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioClientes janela = new FrmRelatorioClientes();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmBackup f = new frmBackup();
            f.ShowDialog();
            f.Dispose();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresaInicial janela = new frmCadastroEmpresaInicial();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void tsmRelatorioLocalizacaoProcesso_Click(object sender, EventArgs e)
        {
            frmRelatorioLocalizacaoProcesso janela = new frmRelatorioLocalizacaoProcesso();
            janela.ShowDialog();
            janela.Dispose();
            
        }

        private void tsmRelatorioContasPagas_Click(object sender, EventArgs e)
        {

        }

        private void tsmRelatorioContasPagar_Click(object sender, EventArgs e)
        {
            frmRelatorioContasAAAAPAGAR janela = new frmRelatorioContasAAAAPAGAR();
            janela.ShowDialog();
            janela.Dispose();
        }

        private void tsmRelatorioMalaDireta_Click(object sender, EventArgs e)
        {
            frmRelatorioMalaDireta janela = new frmRelatorioMalaDireta();
            janela.ShowDialog();
            janela.Dispose();
        }

    }
}
