using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Classes;
using CrystalDecisions.CrystalReports.Engine;
using SAEA.Ferramentas;
using SAEA.Cadastros.buscas;
using SAEA.Relatorios.Crystal;

namespace SAEA.Relatorios
{

    public partial class frmRelatorioProcessos : Form
    {
        enum TipoRelatorioGerado { RelNenhum, RelSemFiltro, RelAgrupadoCliente, RelEmAndamento, RelArquivado, RelPorCliente };
        TipoRelatorioGerado tipoRelatorio;
        private DataTable tabelaDados;
        private bool clienteSelecionado;
        private int codigoCliente;

        public frmRelatorioProcessos()
        {
            InitializeComponent();
            tabelaDados = null;
            clienteSelecionado = false;
            tipoRelatorio = TipoRelatorioGerado.RelNenhum;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            

            Banco banco = new Banco();
            banco.conecta();
            GerenciamentoProcessos consulta = new GerenciamentoProcessos(banco);


            if (rbSemFiltro.Checked)
            {
                tabelaDados = consulta.listarProcessosR1();
                tipoRelatorio = TipoRelatorioGerado.RelSemFiltro;
            }
            else if (rbAndamento.Checked)
            {
                tabelaDados = consulta.listarProcessosR23(true);
                tipoRelatorio = TipoRelatorioGerado.RelEmAndamento;
            }

            else if (rbArquivado.Checked)
            {
                tabelaDados = consulta.listarProcessosR23(false);
                tipoRelatorio = TipoRelatorioGerado.RelArquivado;
            }

            else if (rbClienteUnico.Checked)
            {
                if (clienteSelecionado)
                {
                    tabelaDados = consulta.listarProcessosGrCliR45(true,codigoCliente);
                    tipoRelatorio = TipoRelatorioGerado.RelPorCliente;
                }
                else
                    MessageBox.Show("Selecione o cliente para prosseguir");
            }
            else if (rbCGrupoCliente.Checked)
            {
                tabelaDados = consulta.listarProcessosGrCliR45(false, null);
                tipoRelatorio = TipoRelatorioGerado.RelAgrupadoCliente;
            }
            else //se não faz o sem filtro
            {
                tabelaDados = consulta.listarProcessosR1();
                tipoRelatorio = TipoRelatorioGerado.RelSemFiltro;
            }

            banco.desconecta();
            if(tabelaDados != null)
                dataGridView1.DataSource = tabelaDados;

           

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (tabelaDados == null)
            {
                MessageBox.Show("Realize uma Consulta antes de gerar o relatório");
            }
            else if(rbSemFiltro.Checked && tipoRelatorio != TipoRelatorioGerado.RelSemFiltro)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbCGrupoCliente.Checked && tipoRelatorio != TipoRelatorioGerado.RelAgrupadoCliente)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbAndamento.Checked && tipoRelatorio != TipoRelatorioGerado.RelEmAndamento)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbArquivado.Checked && tipoRelatorio != TipoRelatorioGerado.RelArquivado)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbClienteUnico.Checked && tipoRelatorio != TipoRelatorioGerado.RelPorCliente)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            //else if(!clienteSelecionado)
            //    MessageBox.Show("Realize a seleção do cliente e realize a Consulta para corrigir os dados para a geração do relatório");            
            //else if (tipoRelatorio == TipoRelatorioGerado.RelNenhum)
            //    MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
           
            else
            {
                ReportDocument crDocument = new ReportDocument();

                switch (tipoRelatorio)
                {
                    case TipoRelatorioGerado.RelArquivado:
                    case TipoRelatorioGerado.RelEmAndamento:
                    case TipoRelatorioGerado.RelSemFiltro:
                        crDocument = new FCRRelatorioProcessos();
                        break;

                    case TipoRelatorioGerado.RelAgrupadoCliente:
                    case TipoRelatorioGerado.RelPorCliente:
                        crDocument = new FCRRelatorioProcessosGCliente();
                        break;
                }
        
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessosGCliente.rpt");
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessos.rpt");

                crDocument.SetDataSource(tabelaDados);
                FrmTelaCrystalReports janela = new FrmTelaCrystalReports();
                janela.carregar(crDocument);
                janela.alterarTitulo("Relatório de Processos");
                janela.ShowDialog();
                janela.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscaCliente janela = new frmBuscaCliente();
            janela.ShowDialog();
            DataRow selecao = janela.getLinhaSelecionada();
            janela.Dispose();
            if (selecao != null)
            {
                codigoCliente = int.Parse(selecao["cli_codigo"].ToString());
                ttbNome.Text = selecao["cli_nome"].ToString();
                clienteSelecionado = true;
            }
            else
                clienteSelecionado = false;


        }

        private void rbClienteUnico_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
