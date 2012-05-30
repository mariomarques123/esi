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
using SAEA.Cadastros.Consultas;

namespace SAEA.Cadastros
{
    public partial class FrmAssociaFuncionarioContaBancaria : Form
    {
        DataTable contasAssociadas;// = new DataTable();

        public FrmAssociaFuncionarioContaBancaria()
        {
            InitializeComponent();
            
        }

        public FrmAssociaFuncionarioContaBancaria(string codigo,string nome, string cpf, string rg)
        {
            InitializeComponent();
            dgvResultado.DataSource = contasAssociadas;
            ttbCodigo.Text = codigo;
            ttbNome.Text =  nome;
            ttbCPF.Text =   cpf;
            ttbRG.Text = rg;
            btnLocalizarFuncionario.Enabled = false;

            Banco banco = new Banco();
            AssociaFuncionarioContaBanco cadastro = new AssociaFuncionarioContaBanco(banco);
            banco.conecta();
            contasAssociadas = cadastro.localizarPorCodigoFuncionarioFiltrado(int.Parse(codigo));
            dgvResultado.DataSource = contasAssociadas;
            banco.desconecta();
        }

        public FrmAssociaFuncionarioContaBancaria(int codigo, string numero, int agencia, string nomeBanco, int codigoBanco)
        {
            InitializeComponent();
            dgvResultado.DataSource = contasAssociadas;
            ttbCodigoBanco.Text = codigo.ToString();
            ttbNumeroConta.Text = numero;
            ttbNumeroConta.Text = agencia.ToString();
            ttbNomeBanco.Text = nomeBanco;
            ttbCodigoBanco.Text = codigoBanco.ToString();
            btnLocalizarFuncionario.Enabled = true;
            btnLocalizaConta.Enabled = false;

            Banco banco = new Banco();
            AssociaFuncionarioContaBanco cadastro = new AssociaFuncionarioContaBanco(banco);
            banco.conecta();
            //contasAssociadas = cadastro.localizarPorCodigoClienteFiltrado(int.Parse(codigo));
            dgvResultado.DataSource = contasAssociadas;
            banco.desconecta();
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionarios janela = new frmConsultaFuncionarios();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodigo.Text = selecao["fun_codigo"].ToString();
                ttbNome.Text =      selecao["fun_nome"].ToString();
                ttbCPF.Text =       selecao["fun_cpf"].ToString();
                ttbRG.Text =        selecao["fun_rg"].ToString();
                Banco banco = new Banco();
                AssociaFuncionarioContaBanco cadastro = new AssociaFuncionarioContaBanco(banco);
                banco.conecta();
                contasAssociadas = cadastro.localizarPorCodigoFuncionarioFiltrado(int.Parse(ttbCodigo.Text));
                dgvResultado.DataSource = contasAssociadas;
                banco.desconecta();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscaCadastroContaBancaria janela = new frmBuscaCadastroContaBancaria();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                ttbCodConta.Text = selecao["con_codigo"].ToString();
                ttbNomeBanco.Text = selecao["ban_nome"].ToString();
                ttbCodigoBanco.Text = selecao["ban_codigo"].ToString();
                ttbNumAgencia.Text = selecao["con_numeroagencia"].ToString();
                ttbNumeroConta.Text = selecao["con_numero"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            if (ttbCodigo.Text == "")
                MessageBox.Show("Selecione um cliente");
            else if(ttbCodConta.Text == "")
                MessageBox.Show("Selecione uma conta");
            else
            {
                int i = 0, selecionado;
                bool validar = true;
                selecionado = Convert.ToInt32(ttbCodConta.Text);
                for (i = 0; i < dgvResultado.Rows.Count; i++)
                {
                    if (contasAssociadas.Rows[i]["con_codigo"].ToString() == selecionado.ToString())
                    {
                        validar = false;
                    }
                }
                if (validar)
                {
                    Banco banco = new Banco();
                    AssociaFuncionarioContaBanco cadastro = new AssociaFuncionarioContaBanco(banco);
                    banco.conecta();
                    if (cadastro.incluir(ttbCodConta.Text, int.Parse(ttbCodigo.Text)))
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                        contasAssociadas = cadastro.localizarPorCodigoFuncionarioFiltrado(int.Parse(ttbCodigo.Text));
                        dgvResultado.DataSource = contasAssociadas;
                    }
                    else
                        MessageBox.Show("Cadastro não realizada");
                    banco.desconecta();
                }
                else
                    MessageBox.Show("Conta já associada a este cliente");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 1)
                MessageBox.Show("Selecione um campo para excluir", "Campo inválido");
            else if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                Banco banco = new Banco();
                banco.conecta();
                AssociaFuncionarioContaBanco com = new AssociaFuncionarioContaBanco(banco);
                if (com.excluir(int.Parse(ttbCodigo.Text), int.Parse(dgvResultado.SelectedRows[0].Cells["Column2"].Value.ToString())))
                {
                    MessageBox.Show("Exclusão realizada com sucesso");
                    contasAssociadas = com.localizarPorCodigoFuncionarioFiltrado(int.Parse(ttbCodigo.Text));
                    dgvResultado.DataSource = contasAssociadas;
                }
                else
                    MessageBox.Show("Falha na exclusão!");
                banco.desconecta();
            }

        }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count == 0)
                MessageBox.Show("Não existem registros para serem excluidos");
            else if (MessageBox.Show("Confirma exclusão? Serão excluido todas as ocorrências",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                Banco banco = new Banco();
                banco.conecta();
                AssociaFuncionarioContaBanco com = new AssociaFuncionarioContaBanco(banco);
                if (com.excluirTodas(int.Parse(ttbCodigo.Text)))
                {
                    MessageBox.Show("Exclusão realizada com sucesso");
                    contasAssociadas = com.localizarPorCodigoFuncionarioFiltrado(int.Parse(ttbCodigo.Text));
                    dgvResultado.DataSource = contasAssociadas;
                }
                else
                    MessageBox.Show("Falha na exclusão!");
                banco.desconecta();
            }
        }
        
    }
}
