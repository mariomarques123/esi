using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Movimentacao.buscas;
using SAEA.Cadastros.buscas;
using SAEA.Classes;
using CrystalDecisions.CrystalReports.Engine;
using SAEA.Ferramentas;
using SAEA.Relatorios.Crystal;

namespace SAEA.Movimentacao
{
    public partial class frmRelatorioHonorarios : Form
    {
        private int codigoCliente;
        private DataTable tabelaDados;
        private TipoRelatorioGerado tipoRelatorio;

        enum TipoRelatorioGerado { RelSemFiltro, RelCliente, RelProcesso, RelPeriodo };

        public frmRelatorioHonorarios()
        {
            InitializeComponent();
            tabelaDados = null;
            tipoRelatorio = TipoRelatorioGerado.RelSemFiltro;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


            Banco banco = new Banco();
            banco.conecta();
            AtualizacaoHonorario consulta = new AtualizacaoHonorario(banco);


            if (rbSem.Checked)
            {
                tabelaDados = consulta.listarHonorariosRelat();
                tipoRelatorio = TipoRelatorioGerado.RelSemFiltro;
            }
            else if (rbPeriodo.Checked)
            {
                tabelaDados = consulta.listarHonorarioPeriodo(dtpInicio.Value,dtpFim.Value);
                tipoRelatorio = TipoRelatorioGerado.RelPeriodo;
            }
            else if (rbCliente.Checked)
            {
                if (ttbCliente.Text != "")
                {
                    tabelaDados = consulta.listarHonorarioCliente(ttbCliente.Text);
                    tipoRelatorio = TipoRelatorioGerado.RelCliente;
                }
                else
                    MessageBox.Show("Selecione o cliente para prosseguir");
           
            }
            else if (rbProcesso.Checked)
            {
                if (ttbNumeroProcesso.Text != "")
                {
                    tabelaDados = consulta.localizarPorNumeroProcessoRelat(ttbNumeroProcesso.Text);
                    tipoRelatorio = TipoRelatorioGerado.RelProcesso;
                }
                else
                    MessageBox.Show("Selecione o processo para prosseguir");
            }
            else //se não faz o sem filtro
            {
                tabelaDados = consulta.listarHonorariosRelat();
                tipoRelatorio = TipoRelatorioGerado.RelSemFiltro;
            }

            banco.desconecta();
            if (tabelaDados != null)
                dgvResultado.DataSource = tabelaDados;

           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            FrmTelaCrystalReports janela = new FrmTelaCrystalReports();

            if (tabelaDados == null)
                MessageBox.Show("Realize uma Consulta antes de gerar o relatório");
            else if (rbSem.Checked && tipoRelatorio != TipoRelatorioGerado.RelSemFiltro)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            else if (rbPeriodo.Checked && tipoRelatorio != TipoRelatorioGerado.RelPeriodo)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            else if (rbProcesso.Checked && tipoRelatorio != TipoRelatorioGerado.RelProcesso)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            else if (rbCliente.Checked && tipoRelatorio != TipoRelatorioGerado.RelCliente)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            //else if(!clienteSelecionado)
            //    MessageBox.Show("Realize a seleção do cliente e realize a Consulta para corrigir os dados para a geração do relatório");            
            //else if (tipoRelatorio == TipoRelatorioGerado.RelNenhum)
            //    MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            

            else
            {
                ReportDocument crDocument = new ReportDocument();

                crDocument = new FCRRelatorioHonorarios();

                switch (tipoRelatorio)
                {
                    case TipoRelatorioGerado.RelPeriodo:
                        janela.alterarTitulo("Relatório de Honorários por período");
                        break;

                    case TipoRelatorioGerado.RelProcesso:
                        janela.alterarTitulo("Relatório de Honorários do processo Nº "+ ttbNumeroProcesso.Text);

                        break;
                    case TipoRelatorioGerado.RelCliente:
                        janela.alterarTitulo("Relatório de Honorários do cliente "+ ttbCliente.Text);

                        break;
                    case TipoRelatorioGerado.RelSemFiltro:
                        janela.alterarTitulo("Relatório de Honorários  Geral");

                        break;
                }

                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessosGCliente.rpt");
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessos.rpt");

                crDocument.SetDataSource(tabelaDados);
                janela.carregar(crDocument);
                janela.ShowDialog();
                janela.Dispose();
            }
        }

        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            grbPeriodo.Enabled = rbPeriodo.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscaProcessos janela = new FrmBuscaProcessos();
            janela.ShowDialog();
            DataRow linha = janela.getLinhaSelecionada();
            if (linha != null)
            {
                ttbNumeroProcesso.Text = linha["pro_numero"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscaCliente janela = new frmBuscaCliente();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                codigoCliente = int.Parse(selecao["cli_codigo"].ToString());
                ttbCliente.Text = selecao["cli_nome"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
