using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using System.IO;

namespace SAEA.TelasPrincipais
{
    public partial class frmCadastroEmpresaInicial : Form
    {
        bool primeiraVez;
        int codigo;
        //nao precisa de titulo aqui

        public frmCadastroEmpresaInicial()
        {
            InitializeComponent();

            Banco banco = new Banco();
            banco.conecta();
            CadastroDadosEmpresa teste = new CadastroDadosEmpresa(banco);
            DataTable selecao = teste.buscar();
            if (selecao.Rows.Count != 0)
            {
                primeiraVez = false;
                setDados(selecao);

            }
            else
                primeiraVez = true;
            banco.desconecta();

        }

        private void setDados(DataTable selecao)
        {
            ttbNome.Text = selecao.Rows[0]["emp_nome"].ToString();
            ttbDescrição.Text = selecao.Rows[0]["emp_descricao"].ToString();
            ttbCNPJ.Text = selecao.Rows[0]["emp_cnpj"].ToString();
            ttbTelFixo.Text = selecao.Rows[0]["emp_telefone"].ToString();
            ttbCelular1.Text = selecao.Rows[0]["emp_celular1"].ToString();
            ttbCelular2.Text = selecao.Rows[0]["emp_celular2"].ToString();
            ttbEmail.Text = selecao.Rows[0]["emp_email"].ToString();
            ttbEndereco.Text = selecao.Rows[0]["emp_endereco"].ToString();
            ttbNumero.Text = selecao.Rows[0]["emp_numero"].ToString();
            ttbCEP.Text = selecao.Rows[0]["emp_cep"].ToString();
            ttbBairro.Text = selecao.Rows[0]["emp_bairro"].ToString();
            ttbCidade.Text = selecao.Rows[0]["emp_cidade"].ToString();

            cbbUF.SelectedIndex = Gerais.avaliaEstado(selecao.Rows[0]["emp_UF"].ToString());

            codigo = int.Parse(selecao.Rows[0]["emp_cod"].ToString());

            byte[] vetorImagem;
            if (selecao.Rows[0]["emp_logo"] == DBNull.Value)
                vetorImagem = null;
            else
            {
                vetorImagem = (byte[])selecao.Rows[0]["emp_logo"];
                MemoryStream ms = new MemoryStream(vetorImagem);
                pbxImagem.Image = Bitmap.FromStream(ms);
            }

        }

        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ttbNome.Clear();
            ttbDescrição.Clear();
            ttbCNPJ.Clear();
            ttbTelFixo.Clear();
            ttbCelular1.Clear();
            ttbCelular2.Clear();
            ttbEmail.Clear();
            ttbEndereco.Clear();
            ttbNumero.Clear();
            ttbCEP.Clear();
            ttbBairro.Clear();
            ttbCidade.Clear();
            cbbUF.SelectedIndex = 0;
            
        }

        private void ttbCelular2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            if (ofdAbrirImagem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbxImagem.Image = new Bitmap(ofdAbrirImagem.FileName);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ttbBairro.Clear();
            ttbCelular1.Clear();
            ttbCelular2.Clear();
            ttbCEP.Clear();
            ttbCidade.Clear();
            ttbCNPJ.Clear();
            ttbDescrição.Clear();
            ttbEmail.Clear();
            ttbEndereco.Clear();
            ttbNome.Clear();
            ttbNumero.Clear();
            ttbTelFixo.Clear();
            cbbUF.SelectedIndex = -1;

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ttbNome.Text == "")
                MessageBox.Show("Digite o nome da empresa");
            else if(ttbCidade.Text == "")
                MessageBox.Show("Digite o nome da cidade");
            else if (ttbDescrição.Text == "")
                MessageBox.Show("Digite a descrição da empresa");
            else if(ttbEndereco.Text == "")
                MessageBox.Show("Digite o endereço da empresa");
            else if(cbbUF.SelectedIndex == -1)
                MessageBox.Show("Selecione o estado");
            else if (ttbTelFixo.Text == "")
                MessageBox.Show("Digite o telefone da empresa");
            else
            {
                Banco banco = new Banco();
                banco.conecta();
                CadastroDadosEmpresa teste = new CadastroDadosEmpresa(banco);
                byte[] vetorImagem ;
                if (pbxImagem.Image != null)
                    vetorImagem = getByteArrImagem(pbxImagem.Image);
                else
                    vetorImagem = null;

                if (primeiraVez)
                {
                    if (teste.incluir(ttbNome.Text, ttbCNPJ.Text.Trim(), ttbDescrição.Text, ttbTelFixo.Text.Trim(), ttbCEP.Text.Trim(), ttbEndereco.Text, vetorImagem, ttbEmail.Text, ttbNumero.Text.Trim(), ttbCelular1.Text.Trim(), ttbCelular2.Text.Trim(), cbbUF.SelectedItem.ToString(), ttbBairro.Text, ttbCidade.Text))
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                        btnNovo.PerformClick();
                    }
                    else
                        MessageBox.Show("Cadastro não realizado");

                }//pbxImagem.Image
                else
                {
                    if (teste.alterar(codigo, ttbNome.Text, ttbCNPJ.Text.Trim(), ttbDescrição.Text, ttbTelFixo.Text.Trim(), ttbCEP.Text.Trim(), ttbEndereco.Text, vetorImagem, ttbEmail.Text, ttbNumero.Text.Trim(), ttbCelular1.Text.Trim(), ttbCelular2.Text.Trim(), cbbUF.SelectedItem.ToString(), ttbBairro.Text, ttbCidade.Text))
                    {
                        MessageBox.Show("Alteração realizada com sucesso");
                        btnNovo.PerformClick();
                    }
                    else
                        MessageBox.Show("Alteração não realizada");
                }
                banco.desconecta();
            }
        }

        private static byte[] getByteArrImagem(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


