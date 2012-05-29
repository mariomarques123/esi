using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using SAEA.Movimentacao.buscas;
using SAEA.associativa;

namespace SAEA.Movimentacao
{
    //fazer: associativa com funcionarios, selecao do funcionario responsavel
    //fazer: associativa com cliente
    public partial class frmGerenciamentoProcessos : Form
    {
        string titulo = "Gerenciamento de Processos";
        DataTable funcionarios = new DataTable();
        DataTable clientes = new DataTable();

        public frmGerenciamentoProcessos()
        {
            InitializeComponent();
            Banco banco = new Banco();
            GerenciamentoProcessos consul = new GerenciamentoProcessos(banco);
            banco.conecta();
            //DataTable funcionarios = consul.listarFuncionarios();
            cbbAdvogadoResponsavel.DisplayMember = "Fun_Nome";
            cbbAdvogadoResponsavel.ValueMember = "Fun_Codigo";
            //cbbAdvogadoResponsavel.DataSource = funcionarios;
            cbbAdvogadoResponsavel.Enabled = false;
            //preencheComboAdvResp();
            habilitar("N");

        }


        private void inicializar()
        {
            habilitar("N");
            Gerais.clearControlValues(grbDados);

        }

        private void habilitar(string acao) //I, A, N, V  (N = neutro)
        {
            switch (acao)
            {
                case "I": Text = titulo + " (INCLUINDO)"; break;
                case "A": Text = titulo + " (ALTERANDO)"; break;
                case "V": Text = titulo + " (VISUALIZANDO)"; break;
                case "N": Text = titulo + " - AlvesMarques Advogados"; break;
            }

            grbDados.Enabled = "IA".IndexOf(acao) >= 0;
            btnNovo.Enabled = acao == "N";
            btnAlterar.Enabled = acao == "V";
            btnExcluir.Enabled = acao == "V";
            btnGravar.Enabled = "IA".IndexOf(acao) >= 0;
            btnCancelar.Enabled = "IAV".IndexOf(acao) >= 0;
            btnLocalizar.Enabled = "NV".IndexOf(acao) >= 0;
            cbbAdvogadoResponsavel.Enabled = "A".IndexOf(acao) >= 0;
        }


        

        private void grbDados_Enter(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            inicializar();
            habilitar("I");
            ttbNumeroProcesso.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitar("A");
            ttbNumeroProcesso.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializar();
            habilitar("N");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
              Banco banco = new Banco();
                GerenciamentoProcessos cadastro = new GerenciamentoProcessos(banco);
                banco.conecta();
               
            if (ttbNumeroProcesso.Text == "")
                MessageBox.Show("Digite o número do processo");
            else if (ttbNumeroProcesso.Enabled && cadastro.verificaExistenciaProcesso(ttbNumeroProcesso.Text))
                MessageBox.Show("Este número de processo já existe!");
            else if (ttbVara.Text == "")
                MessageBox.Show("Digite a Vara do processo");
            else if (ttbAreaAcao.Text == "")
                MessageBox.Show("Digite a Área de ação");
            else if (ttbTipoAcao.Text == "")
                MessageBox.Show("Digite o tipo de ação");
            else if (cbbAdvogadoResponsavel.SelectedIndex == -1)
                MessageBox.Show("Selecione o advogado responsável");
            else if (cbbNivelAcesso.SelectedIndex == -1)
                MessageBox.Show("Selecione o nivel de acesso");
            else
            {
                char escolha;
                if (ccbClientePHon.Checked)
                    escolha = 'S';
                else
                    escolha = 'N';

               if (cadastro.verificaExistenciaProcesso(ttbNumeroProcesso.Text))
                {
                    if (cadastro.alterar(ttbNumeroProcesso.Text, ttbVara.Text, ttbForum.Text, ttbTipoAcao.Text, ttbSituacao.Text, ttbDescricao.Text, ttbJuiz.Text, ttbAreaAcao.Text, ttbLocalTramite.Text, dateTimePicker1.Value, cbbNivelAcesso.SelectedIndex, int.Parse(cbbAdvogadoResponsavel.SelectedValue.ToString()), escolha))
                    {

                        banco.conecta();
                        cadastro.excluirAssociaFuncionarioProcesso(ttbNumeroProcesso.Text);
                        foreach (DataRow i in funcionarios.Rows)
                        {
                            cadastro.associarFuncionariosProcesso(int.Parse(i["Fun_codigo"].ToString()), ttbNumeroProcesso.Text);
                        }
                        banco.conecta();
                        cadastro.excluirAssociaClienteProcesso(ttbNumeroProcesso.Text);
                        foreach (DataRow i in clientes.Rows)
                        {
                            cadastro.associarClientesProcesso(int.Parse(i["cli_codigo"].ToString()), ttbNumeroProcesso.Text);
                        }

                        MessageBox.Show("Alteração realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                else if (cadastro.incluir(ttbNumeroProcesso.Text, ttbVara.Text, ttbForum.Text, ttbTipoAcao.Text, ttbSituacao.Text, ttbDescricao.Text, ttbJuiz.Text, ttbAreaAcao.Text, ttbLocalTramite.Text, dateTimePicker1.Value, cbbNivelAcesso.SelectedIndex, int.Parse(cbbAdvogadoResponsavel.SelectedValue.ToString()), escolha))
                {

                    banco.conecta();
                    cadastro.excluirAssociaFuncionarioProcesso(ttbNumeroProcesso.Text);
                    foreach (DataRow i in funcionarios.Rows)
                    {
                        cadastro.associarFuncionariosProcesso(int.Parse(i["Fun_codigo"].ToString()), ttbNumeroProcesso.Text);
                    }
                    banco.conecta();
                    cadastro.excluirAssociaClienteProcesso(ttbNumeroProcesso.Text);
                    foreach (DataRow i in clientes.Rows)
                    {
                        cadastro.associarClientesProcesso(int.Parse(i["cli_codigo"].ToString()), ttbNumeroProcesso.Text);
                    }

                    MessageBox.Show("Cadastro realizado com sucesso");
                    inicializar();
                }
                else
                    MessageBox.Show("Cadastro não realizado");
                banco.desconecta();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ttbNumeroProcesso.Text == "")
            {
                MessageBox.Show("Digite o número do processo.");
            }
            else
            {
                //arrumar o nivel de acesso dentro do form de sele;áo de advogados ?
                FrmAssociaProcessoFuncionario janela = new FrmAssociaProcessoFuncionario();
                janela.setProcesso(ttbNumeroProcesso.Text, cbbAdvogadoResponsavel.Text, ttbVara.Text, ttbTipoAcao.Text);
                if(cbbAdvogadoResponsavel.SelectedValue != null)
                    janela.setResponsavel(int.Parse(cbbAdvogadoResponsavel.SelectedValue.ToString()));
                else
                    janela.setResponsavel(-1);

                Banco banco = new Banco();
                GerenciamentoProcessos gere = new GerenciamentoProcessos(banco);
                banco.conecta();
                funcionarios = gere.listarProcessosFuncionarios(ttbNumeroProcesso.Text);

                DataTable backup = funcionarios.Clone();
                backup = funcionarios.Copy();

                janela.setFuncionarios(funcionarios);
                janela.ShowDialog();
                if (!janela.getConfirmar())
                {
                    funcionarios = backup.Clone();
                    funcionarios = backup.Copy();
                }
                if (funcionarios.Rows.Count > 0)
                {
                    cbbAdvogadoResponsavel.Enabled = true;
                    cbbAdvogadoResponsavel.DataSource = funcionarios;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (ttbNumeroProcesso.Text != "")
            {
                if (MessageBox.Show("Confirma exclusão? As associações com clientes e funiconários também serão removidas",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    Banco banco = new Banco();
                    banco.conecta();
                    GerenciamentoProcessos com = new GerenciamentoProcessos(banco);
                    com.excluirAssociaClienteProcesso(ttbNumeroProcesso.Text);
                    com.excluirAssociaFuncionarioProcesso(ttbNumeroProcesso.Text);

                    if (!com.verificaExistenciaProcesso(ttbNumeroProcesso.Text))
                        MessageBox.Show("Não é possível excluir, este processo não está cadastrado.");
                    else if (com.excluir(ttbNumeroProcesso.Text))
                    {
                        MessageBox.Show("Exclusão realizada com sucesso");
                        inicializar();
                    }
                    else
                        MessageBox.Show("Falha na exclusão! Verifique se não existem associações com este processo");
                    banco.desconecta();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmBuscaProcessos janela = new FrmBuscaProcessos();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbNumeroProcesso.Text = selecao["pro_numero"].ToString();
                ttbVara.Text = selecao["pro_vara"].ToString();
                ttbForum.Text = selecao["pro_forum"].ToString();
                ttbTipoAcao.Text = selecao["pro_tipo"].ToString();
                ttbAreaAcao.Text = selecao["pro_area"].ToString();
                ttbLocalTramite.Text = selecao["pro_local"].ToString();
                ttbDescricao.Text = selecao["pro_descricao"].ToString();
                ttbSituacao.Text= selecao["pro_situacao"].ToString();
                ttbJuiz.Text = selecao["pro_juiz"].ToString();
                
                try {
                    if(selecao["pro_clientenpcusto"].ToString()[0] == 'S')
                        ccbClientePHon.Checked = true;
                    else
                        ccbClientePHon.Checked = false;
                    }
                    catch (Exception ex) {
                        ccbClientePHon.Checked = false;
                    }
                cbbNivelAcesso.SelectedIndex = int.Parse(selecao["pro_nivelacesso"].ToString());
                preencheComboAdvRespBusca();
                selecionaFuncionarioCBB(selecao["fun_advresp"].ToString());
                dateTimePicker1.Value = DateTime.Parse(selecao["pro_datadistribuicao"].ToString());
                habilitar("V");
            }
        }

        void selecionaFuncionarioCBB(string codigo)
        {
            preencheComboAdvResp();
            int saida = -1;
            for (int i = 0; i < cbbAdvogadoResponsavel.Items.Count; i++)
            {
                cbbAdvogadoResponsavel.SelectedIndex = i;
                if (cbbAdvogadoResponsavel.SelectedValue.ToString() == codigo)
                    saida = i;
            }
            cbbAdvogadoResponsavel.SelectedIndex = saida;
        }

        private void preencheComboAdvResp()
        {
            if (ttbNumeroProcesso.Text != "")
            {
                //if (funcionarios.Rows.Count == 0)
                //{
                    Banco banco = new Banco();
                    GerenciamentoProcessos gere = new GerenciamentoProcessos(banco);
                    banco.conecta();
                    funcionarios = gere.listarProcessosFuncionarios(ttbNumeroProcesso.Text);
                    cbbAdvogadoResponsavel.DisplayMember = "Fun_Nome";
                    cbbAdvogadoResponsavel.ValueMember = "Fun_Codigo";
                    cbbAdvogadoResponsavel.DataSource = funcionarios;
                //}
            }
        }

        private void preencheComboAdvRespBusca()
        {
            if (ttbNumeroProcesso.Text != "")
            {
                Banco banco = new Banco();
                GerenciamentoProcessos gere = new GerenciamentoProcessos(banco);
                banco.conecta();
                funcionarios = gere.listarProcessosFuncionarios(ttbNumeroProcesso.Text);
                cbbAdvogadoResponsavel.DisplayMember = "Fun_Nome";
                cbbAdvogadoResponsavel.ValueMember = "Fun_Codigo";
                cbbAdvogadoResponsavel.DataSource = funcionarios;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ttbNumeroProcesso.Text == "")
            {
                MessageBox.Show("Digite o número do processo.");
            }
            else
            {
                FrmAssociaProcessoCliente janela = new FrmAssociaProcessoCliente();
                janela.setProcesso(ttbNumeroProcesso.Text, cbbAdvogadoResponsavel.Text, ttbVara.Text, ttbTipoAcao.Text);
                Banco banco = new Banco();
                GerenciamentoProcessos gere = new GerenciamentoProcessos(banco);
                banco.conecta();
                clientes = gere.listarProcessosClientes(ttbNumeroProcesso.Text);
                janela.setCliente(clientes);
                DataTable backup = clientes.Clone();
                backup = clientes.Copy();

                janela.ShowDialog();
                
                if (!janela.getConfirmar())
                {
                    clientes = backup.Clone();
                    clientes = backup.Copy();
                }
            }
        }
    }
}
