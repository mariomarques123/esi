using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using SAEA.Ferramentas;
using SAEA.Classes;
using SAEA.Relatorios.Crystal;

namespace SAEA.Relatorios
{
    public partial class frmRelatorioMovimentacoes : Form
    {
        private DataTable tabelaDados;
        enum TipoRelatorioGerado { RelEntrada, RelSaida, RelAmbos };
        TipoRelatorioGerado tipoRelatorio;

        public frmRelatorioMovimentacoes()
        {
            InitializeComponent();
            tipoRelatorio = TipoRelatorioGerado.RelEntrada;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


            Banco banco = new Banco();
            banco.conecta();
            GerenciamentoMovimentacoes consulta = new GerenciamentoMovimentacoes(banco);


            if (rbSaida.Checked)
            {
                tabelaDados = consulta.listarMovimentacaoDebito(dtpInicio.Value, dtpFim.Value);
                tipoRelatorio = TipoRelatorioGerado.RelSaida;
                correcaoTabela();
            }

            else if (rbEntradaSaida.Checked)
            {
                tabelaDados = consulta.listarMovimentacaoTudo(dtpInicio.Value, dtpFim.Value);
                tipoRelatorio = TipoRelatorioGerado.RelAmbos;
                correcaoTabela();
            }
            else 
            {
                tabelaDados = consulta.listarMovimentacaoCredito(dtpInicio.Value, dtpFim.Value);
                tipoRelatorio = TipoRelatorioGerado.RelEntrada;
                correcaoTabela();
            }
             

            banco.desconecta();
            if (tabelaDados != null)
                dataGridView1.DataSource = tabelaDados;

           
        }

        private void correcaoTabela()
        {
            foreach (DataRow i in tabelaDados.Rows)
            {

                if (i["mov_tipo"].ToString() == "d")
                {
                    i["mov_tipo"] = "Débito";
                    i["mov_valor"] = -double.Parse(i["mov_valor"].ToString());
                }
                else
                    i["mov_tipo"] = "Crédito";

            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (tabelaDados == null)
            {
                MessageBox.Show("Realize uma Consulta antes de gerar o relatório");
            }
            else if (rbEntrada.Checked && tipoRelatorio != TipoRelatorioGerado.RelEntrada)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            else if (rbSaida.Checked && tipoRelatorio != TipoRelatorioGerado.RelSaida)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            else if (rbEntradaSaida.Checked && tipoRelatorio != TipoRelatorioGerado.RelAmbos)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");
            //else if(!clienteSelecionado)
            //    MessageBox.Show("Realize a seleção do cliente e realize a Consulta para corrigir os dados para a geração do relatório");            
            //else if (tipoRelatorio == TipoRelatorioGerado.RelNenhum)
            //    MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            

            else
            {
                ReportDocument crDocument = new ReportDocument();

                //switch (tipoRelatorio)
                //{
                //    case TipoRelatorioGerado.RelArquivado:
                //    case TipoRelatorioGerado.RelEmAndamento:
                //    case TipoRelatorioGerado.RelSemFiltro:
                crDocument = new FCRRelatorioMovimentacao();
                //        break;

                //    case TipoRelatorioGerado.RelAgrupadoCliente:
                //    case TipoRelatorioGerado.RelPorCliente:
                //        crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessosGCliente.rpt");
                //        break;
                //}

                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessosGCliente.rpt");
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessos.rpt");

                crDocument.SetDataSource(tabelaDados);
                FrmTelaCrystalReports janela = new FrmTelaCrystalReports();
                janela.carregar(crDocument);
                janela.alterarTitulo("Relatório de Movimentações");
                janela.ShowDialog();
                janela.Dispose();
            }
        }
    }
}
