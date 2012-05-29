using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEA.Ferramentas;
using CrystalDecisions.CrystalReports.Engine;
using SAEA.Classes;
using SAEA.Relatorios.Crystal;

namespace SAEA.Relatorios
{
    public partial class FrmRelatorioClientes : Form
    {
        private  DataTable tabelaDados;
        private  TipoRelatorioGerado tipoRelatorio;

        enum TipoRelatorioGerado { RelGrupoCidade, RelCidadeUnica, RelTodos, RelAndamento };


        public FrmRelatorioClientes()
        {
            InitializeComponent();
            tipoRelatorio = TipoRelatorioGerado.RelTodos;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conecta();
            CadastroCliente consulta = new CadastroCliente(banco);


            if (rbSem.Checked)
            {
                tabelaDados = consulta.listarR12(false);
                tipoRelatorio = TipoRelatorioGerado.RelTodos;
            }
            else if (rbAndamento.Checked)
            {
                tabelaDados = consulta.listarR12(true);
                tipoRelatorio = TipoRelatorioGerado.RelAndamento;
            }

            else if (rbGrupoCidade.Checked)
            {
                tabelaDados = consulta.listarR34(true, null);
                tipoRelatorio = TipoRelatorioGerado.RelGrupoCidade;
            }

            else if (rbBuscaCidade.Checked)
            {
                if (ttbNome.Text != "")
                {
                    tabelaDados = consulta.listarR34(false, ttbNome.Text);
                    tipoRelatorio = TipoRelatorioGerado.RelCidadeUnica;
                }
                else
                    MessageBox.Show("Digite uma cidade para buscar");
            }
            else //se não faz o sem filtro
            {
                tabelaDados = consulta.listarR12(false);
                tipoRelatorio = TipoRelatorioGerado.RelTodos;
            }

            banco.desconecta();
            if(tabelaDados != null)
                dgvResultado.DataSource = tabelaDados;

           

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (tabelaDados == null)
            {
                MessageBox.Show("Realize uma Consulta antes de gerar o relatório");
            }
            else if(rbSem.Checked && tipoRelatorio != TipoRelatorioGerado.RelTodos)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbGrupoCidade.Checked && tipoRelatorio != TipoRelatorioGerado.RelGrupoCidade)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbAndamento.Checked && tipoRelatorio != TipoRelatorioGerado.RelAndamento)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            else if(rbBuscaCidade.Checked && tipoRelatorio != TipoRelatorioGerado.RelCidadeUnica)
                MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
            //else if(!clienteSelecionado)
            //    MessageBox.Show("Realize a seleção do cliente e realize a Consulta para corrigir os dados para a geração do relatório");            
            //else if (tipoRelatorio == TipoRelatorioGerado.RelNenhum)
            //    MessageBox.Show("Realize novamente a Consulta para corrigir os dados para a geração do relatório");            
           
            else
            {
                ReportDocument crDocument;// = new FCRRelatorioProcessosGCliente();

                switch (tipoRelatorio)
                {
                    default:
                    case TipoRelatorioGerado.RelAndamento:
                    case TipoRelatorioGerado.RelTodos:
                        //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioClientes.rpt");
                        crDocument = new FCRRelatorioClientes();
                        break;

                    case TipoRelatorioGerado.RelGrupoCidade:
                    case TipoRelatorioGerado.RelCidadeUnica:
                        //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioClientesAgrupado.rpt");
                        crDocument = new FCRRelatorioClientesAgrupado();
                        break;
                }
        
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessosGCliente.rpt");
                //crDocument.Load(Application.StartupPath + @"\..\..\Relatorios\Crystal\FCRRelatorioProcessos.rpt");

                crDocument.SetDataSource(tabelaDados);
                FrmTelaCrystalReports janela = new FrmTelaCrystalReports();
                janela.carregar(crDocument);
                janela.alterarTitulo("Relatório de Clientes");
                janela.ShowDialog();
                janela.Dispose();
            }
        }

        private void rbBuscaCidade_CheckedChanged(object sender, EventArgs e)
        {
            ttbNome.Enabled = rbBuscaCidade.Checked;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
