using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class RelTransacoes
    {
        Banco banco;

        public RelTransacoes(Banco banco)
        {
            this.banco = banco;
        }

        public DataTable semFiltro()
        {
            DataTable dt;
            string sql = "SELECT C.Con_Numero, M.mov_data, M.mov_valor, M.mov_tipo,Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                         " FROM Movimentacao M, Contas_Banco C, Empresa" +
                         " WHERE M.Con_Codigo = C.Con_Codigo" +
                         " ORDER BY M.mov_data";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable porPeriodo(DateTime ini, DateTime fim)
        {
            DataTable dt;
            string sql = "SELECT C.Con_Numero, M.mov_data, M.mov_valor, M.mov_tipo,Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                         " FROM Movimentacao M, Contas_Banco C, Empresa" +
                         " WHERE M.Con_Codigo = C.Con_Codigo AND (M.mov_data BETWEEN @ini AND @fim)" +
                         " ORDER BY M.mov_data";

            banco.executeQuery(sql, out dt, "@ini", ini,
                                            "@fim", fim);
            return dt;
        }

        public DataTable porTipo(char mov_tipo)
        {
            DataTable dt;
            string sql = "SELECT C.Con_Numero, M.mov_data, M.mov_valor, M.mov_tipo,Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                         " FROM Movimentacao M, Contas_Banco C, Empresa" +
                         " WHERE M.Con_Codigo = C.Con_Codigo AND (M .mov_tipo = @mov_tipo)" +
                         " ORDER BY M.mov_data";

            banco.executeQuery(sql, out dt, "@mov_tipo", mov_tipo);
            return dt;
        }

        public DataTable porPeriodoTipo(DateTime ini, DateTime fim,char mov_tipo)
        {
            DataTable dt;
            string sql = "SELECT C.Con_Numero, M.mov_data, M.mov_valor, M.mov_tipo,Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                         " FROM Movimentacao M, Contas_Banco C, Empresa" +
                         " WHERE M.Con_Codigo = C.Con_Codigo AND (M .mov_tipo = @mov_tipo) AND (M.mov_data BETWEEN @ini AND @fim)" +
                         " ORDER BY M.mov_data";

            banco.executeQuery(sql, out dt,  "@ini", ini,
                                            "@fim", fim,
                                            "@mov_tipo", mov_tipo);
            return dt;
        }
    }
}
