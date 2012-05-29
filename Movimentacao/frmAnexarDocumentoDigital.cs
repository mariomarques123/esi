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

namespace SAEA.Movimentacao
{
public partial class frmAnexarDocumentoDigital : Form
{
    string anexos = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Anexos";

    public frmAnexarDocumentoDigital()
    {
        InitializeComponent();

        ttbCodigo.Enabled = false;
        ttbCodigo.MaxLength = 8;
        ttbDescricao.MaxLength = 100;

        CarregaProcessos();
        Inicializa();
    }

    private void CarregaProcessos()
    {
        ccbProcessos.DataSource = new Processos(new BancoM()).localizarPor("pro_numero", "%"); ;
        ccbProcessos.DisplayMember = "pro_descricao";
        ccbProcessos.ValueMember = "pro_numero";
    }

    private void Inicializa()
    {
        Funcoes.Limpar(pnlDados);
        ccbProcessos.SelectedIndex = -1;
        ttbLocalizacao.Enabled = false;
        try
        {
            for (int i = dgvAnexos.Rows.Count - 1; i >= 0; i--)
                dgvAnexos.Rows.Remove(dgvAnexos.Rows[i]);
        }catch { }
    }

    private void brnNovo_Click(object sender, EventArgs e)
    {
        ttbCodigo.Clear();
        ttbDescricao.Clear();
        ttbLocalizacao.Clear();
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

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void CarregarAnexos(object sender, EventArgs e)
    {
        if (ccbProcessos.SelectedIndex < 0)
        {
            MessageBox.Show("Selecione um processo");
            ccbProcessos.Focus();
        }
        else
        {
            DataTable dtt = new DocumentoDigital(new BancoM()).localizarPor("pro_numero", Convert.ToInt32(ccbProcessos.SelectedValue));
            for (int i = 0; i < dtt.Rows.Count; i++)
			{
                dtt.Rows[i]["dod_localizacao"] = System.IO.Path.Combine(anexos, dtt.Rows[i]["dod_localizacao"].ToString());
			}
            dgvAnexos.DataSource = dtt ;
        }
    }
    
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (ccbProcessos.SelectedIndex < 0)
        {
            MessageBox.Show("Selecione um processo");
            ccbProcessos.Focus();
        }
        else if (MessageBox.Show("Confirma exclusão de todos os anexos desde processo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
            int pro_numero = 0;
            int.TryParse(ccbProcessos.SelectedValue.ToString(), out pro_numero);

            DocumentoDigital doc = new DocumentoDigital(new BancoM());

            bool certo = true;
            for (int i = 0; i < dgvAnexos.Rows.Count; i++)
                if (doc.excluirAnexo(Convert.ToInt32(((DataRowView)dgvAnexos.Rows[i].DataBoundItem)["dod_codigo"]), pro_numero))
                {
                    System.IO.File.Delete(System.IO.Path.Combine(anexos, ((DataRowView)dgvAnexos.Rows[i].DataBoundItem)["dod_localizacao"].ToString()));
                }
                else
                    certo = false;

            if(certo)
                MessageBox.Show("Anexos excluidos!");
            else
                MessageBox.Show("Erro ao excluir!");

            Inicializa();
        }
    }

    private void dgvAnexos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            DataRowView currentDataRowView = (DataRowView)dgvAnexos.CurrentRow.DataBoundItem;
            ttbCodigo.Text = currentDataRowView.Row["dod_codigo"].ToString();
            ttbLocalizacao.Text = currentDataRowView.Row["dod_localizacao"].ToString();
            ttbDescricao.Text = currentDataRowView.Row["dod_descricao"].ToString();
        }
        catch
        {
            MessageBox.Show("Selecione um processo");
        }
    }

    private void btnAbrirImagem_Click(object sender, EventArgs e)
    {
        if (ofdAbrirImagem.ShowDialog() == DialogResult.OK)
            ttbLocalizacao.Text = ofdAbrirImagem.FileName;
    }

    private void btnAnexar_Click(object sender, EventArgs e)
    {
        try
        {
            int codigo = 0;

            int.TryParse(ttbCodigo.Text, out codigo);
            int pro_numero = Convert.ToInt32(ccbProcessos.SelectedValue);

            if (ccbProcessos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um processo");
                ccbProcessos.Focus();
            }
            else if (ttbLocalizacao.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um documento");
                ttbLocalizacao.Focus();
            }
            else
            {
                DocumentoDigital doc = new DocumentoDigital(new BancoM());

                string destino,origem;

                if (!System.IO.Directory.Exists(anexos))
                    System.IO.Directory.CreateDirectory(anexos);

                try
                {
                    destino = System.IO.Path.Combine(anexos, System.IO.Path.GetFileName(ttbLocalizacao.Text));
                    origem = ttbLocalizacao.Text;
                }
                catch
                {
                    destino = System.IO.Path.Combine(anexos,ttbLocalizacao.Text);
                    origem = destino;
                }

                try
                {
                    System.IO.File.Copy(origem, destino, true);
                }
                catch
                {
                }

                destino = System.IO.Path.GetFileName(destino);

                if (codigo == 0)
                {
                    if (doc.incluir(pro_numero, destino, ttbDescricao.Text))
                        CarregarAnexos(sender, e);
                    else
                        MessageBox.Show("Erro ao anexar");
                }
                else //Alteracao
                {
                    if (doc.alterar(codigo, destino, ttbDescricao.Text))
                        CarregarAnexos(sender, e);
                    else
                        MessageBox.Show("Erro ao anexar");
                }
                btnNovo.PerformClick();
            }
        }
        catch
        {
            MessageBox.Show("Erro ao anexar : "+ttbLocalizacao.Text);
        }
    }

    private void btnRemoverAnexo_Click(object sender, EventArgs e)
    {
        try
        {
            DataRowView currentDataRowView = (DataRowView)dgvAnexos.CurrentRow.DataBoundItem;

            if (currentDataRowView == null || ttbLocalizacao.Text.Trim() == "")
            {
                MessageBox.Show("Selecione uma linha");
                ccbProcessos.Focus();
            }
            else
            {
                int codigo = 0,pro_numero = 0;
                int.TryParse(currentDataRowView["dod_codigo"].ToString(), out codigo);
                int.TryParse(ccbProcessos.SelectedValue.ToString(), out pro_numero);

                if (new DocumentoDigital(new BancoM()).excluirAnexo(codigo, pro_numero))
                {
                    System.IO.File.Delete(System.IO.Path.Combine(anexos, ttbLocalizacao.Text));
                    CarregarAnexos(sender, e);
                }
                else
                    MessageBox.Show("Erro ao excluir o anexo");

                btnNovo.PerformClick();
            }
        }
        catch 
        {
            MessageBox.Show("Erro ao remover o anexo");
        }
    }

    private void ccbProcessos_SelectionChangeCommitted(object sender, EventArgs e)
    {
        CarregarAnexos(sender, e);
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
        try
        {
            string local = System.IO.Path.Combine(anexos, ttbLocalizacao.Text);
            if(System.IO.Path.GetFileName(local) == "Anexos")
                MessageBox.Show("Selecione um anexo");
            else
                System.Diagnostics.Process.Start(local);
        }
        catch
        {
            MessageBox.Show("Erro ao carregar o arquivo");
        }
    }
}
}
