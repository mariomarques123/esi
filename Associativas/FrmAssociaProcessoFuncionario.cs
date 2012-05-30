using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;

namespace SAEA.associativa
{
    public partial class FrmAssociaProcessoFuncionario : Form
    {
        int codigoResponsavel;
        bool confirmar = false;
        DataTable funcionarios;
        public FrmAssociaProcessoFuncionario()
        {
            InitializeComponent();
            Banco banco = new Banco();
            GerenciamentoProcessos gere = new GerenciamentoProcessos(banco);
            banco.conecta();
            DataTable funcionarios = gere.listarFuncionarios();
            cbbAdvogadoResponsavel.DisplayMember = "Fun_Nome";
            cbbAdvogadoResponsavel.ValueMember = "Fun_Codigo";
            cbbAdvogadoResponsavel.DataSource = funcionarios;
        }

        public void setResponsavel(int codigo)
        {
            this.codigoResponsavel = codigo;
        }

        public void setProcesso(string numeroProcesso, string advogadoResponsavel, string vara, string tipoAcao)
        {
            ttbNumero.Text = numeroProcesso;
            ttbAdvogado.Text = advogadoResponsavel;
            ttbVara.Text = vara;
            ttbAcao.Text = tipoAcao;
        }


        public void setFuncionarios(DataTable funcionarios)
        {
            this.funcionarios = funcionarios;
            dgvResultado.DataSource = this.funcionarios;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            confirmar = true;
            Close();
        }

        public bool getConfirmar()
        {
            return confirmar;
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            if (cbbAdvogadoResponsavel.SelectedIndex == -1)
                MessageBox.Show("Selecione um funcionario");
            else if (ttbNumero.Text == "")
                MessageBox.Show("Selecione um processo");
            else
            {
                int selecionado;
                bool validar = true;
                selecionado = Convert.ToInt32(cbbAdvogadoResponsavel.SelectedValue.ToString());
                foreach (DataRow i in funcionarios.Rows)
                {
                    if (i["fun_codigo"].ToString() == selecionado.ToString())
                    {
                        validar = false;
                    }
                }
                if (validar)
                {
                    DataRow nova = funcionarios.NewRow();
                    nova["fun_codigo"] = int.Parse(cbbAdvogadoResponsavel.SelectedValue.ToString());
                    nova["fun_nome"] = cbbAdvogadoResponsavel.Text;
                    funcionarios.Rows.Add(nova);
                }
                else
                    MessageBox.Show("Este funcionário já foi inserido.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count != 1)
                MessageBox.Show("Selecione um campo para excluir", "Campo inválido");
            else if( dgvResultado.SelectedRows[0].Cells["Column1"].Value.ToString() == codigoResponsavel.ToString()) 
            {
                MessageBox.Show("Não é permitida a exclusão do advogado responsavel", "Não é possível excluir");
            }
            else if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                DataRow exclusao = null;
                foreach (DataRow i in funcionarios.Rows)
                {
                    if (i["fun_codigo"].ToString() == dgvResultado.SelectedRows[0].Cells["Column1"].Value.ToString())
                        exclusao = i;
                }
                if (exclusao != null)
                    funcionarios.Rows.Remove(exclusao);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count == 0)
                MessageBox.Show("Nenhum item para ser exluido", "Campo inválido");
            else if (dgvResultado.SelectedRows[0].Cells["Column1"].Value.ToString() == codigoResponsavel.ToString())
            {
                MessageBox.Show("Não é permitida a exclusão do advogado responsavel", "Não é possível excluir");
            }
            else if (MessageBox.Show("Confirma exclusão?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                funcionarios.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
