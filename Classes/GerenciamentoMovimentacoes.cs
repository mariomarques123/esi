using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    /// <summary>
    /// Classe 
    /// </summary>
    class GerenciamentoMovimentacoes
    {
        Banco banco;
        public GerenciamentoMovimentacoes(Banco banco)
        {
            this.banco = banco;
        }

        public DataTable listarMovimentacaoCredito(DateTime inicio, DateTime fim)
        {
            DataTable dt;
            string sql;
                 sql =  "SELECT     Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino, Movimentacao.mov_tipo,          "+
                        "         Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,             Movimentacao.Con_Codigo, SUM(Movimentacao.mov_valor) AS TOTAL                                                                                   " +
                        "FROM     empresa,    Movimentacao INNER JOIN                                                                                                                                  "+
                        "                      Contas_Funcionarios ON Contas_Funcionarios.Con_Codigo = Movimentacao.Con_Codigo                                                                 "+
                        "WHERE     (Movimentacao.mov_tipo = 'c') AND (Movimentacao.mov_data BETWEEN @inicio AND @fim)                                                                     "+
                        "GROUP BY Movimentacao.mov_tipo, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino,                                  " +
                        "                      Movimentacao.Con_Codigo";
            banco.executeQuery(sql, out dt, "@inicio", inicio, "@fim", fim);
            return dt;
        }

        public DataTable listarMovimentacaoDebito(DateTime inicio, DateTime fim)
        {
            DataTable dt;
            string sql;
            sql =   "SELECT     Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino, Movimentacao.mov_tipo,          " +
                    "           Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,           Movimentacao.Con_Codigo, SUM(Movimentacao.mov_valor) AS TOTAL                                                                                   " +
                    "FROM       empresa,   Movimentacao INNER JOIN                                                                                                                                  " +
                    "                      Contas_Funcionarios ON Contas_Funcionarios.Con_Codigo = Movimentacao.Con_Codigo                                                                 " +
                    "WHERE     (Movimentacao.mov_tipo = 'd') AND (Movimentacao.mov_data BETWEEN @inicio AND @fim)                                                                     " +
                    "GROUP BY Movimentacao.mov_tipo, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino,                                  " +
                    "                      Movimentacao.Con_Codigo";
            banco.executeQuery(sql, out dt, "@inicio", inicio, "@fim", fim);
            return dt;
        }

        public DataTable listarMovimentacaoTudo(DateTime inicio, DateTime fim) {
            
            DataTable dt;

            String sql = 
            "                SELECT     Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino, Movimentacao.mov_tipo, "+
            "               Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,       Movimentacao.Con_Codigo, SUM(Movimentacao.mov_valor) AS TOTAL                                                                    " +
            "FROM      empresa,   Movimentacao INNER JOIN                                                                                                                   "+
            "                      Contas_Funcionarios ON Contas_Funcionarios.Con_Codigo = Movimentacao.Con_Codigo                                                  "+
            "WHERE     (Movimentacao.mov_data BETWEEN @inicio AND @fim)                                                                                        "+
            "GROUP BY Movimentacao.mov_tipo, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Movimentacao.mov_codigo, Movimentacao.mov_data, Movimentacao.mov_valor, Movimentacao.mov_codDestino,                   " +
            "                      Movimentacao.Con_Codigo                                                                                                          "+
            "ORDER BY Movimentacao.mov_tipo ";
            banco.executeQuery(sql, out dt, "@inicio", inicio, "@fim", fim);
            return dt;
        }
    }
}
