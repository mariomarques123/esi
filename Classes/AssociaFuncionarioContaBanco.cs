using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class AssociaFuncionarioContaBanco
    {
        Banco banco;

        public AssociaFuncionarioContaBanco(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string con_codigo, int fun_codigo)
        {
            string sql;
            sql = "INSERT INTO Contas_Funcionarios (con_codigo, fun_codigo) " +
                    " VALUES (@con_codigo,@fun_codigo)";

            return banco.executeNonQuery(sql,
                "@con_codigo", con_codigo,
                "@fun_codigo", fun_codigo
                );
        }

        public DataTable localizarPorCodigoFuncionarioFiltrado(int fun_codigo)
        {
            DataTable dt;
            string sql = "SELECT     Contas_banco.con_codigo, Contas_banco.con_numero, Funcionarios.fun_codigo, Funcionarios.fun_nome " +
                            "FROM         Contas_Funcionarios INNER JOIN " +
                            "                      Funcionarios ON Funcionarios.fun_codigo = Contas_Funcionarios.fun_codigo INNER JOIN " +
                            "                      Contas_Banco ON contas_banco.con_codigo = Contas_Funcionarios.con_codigo " +
                            "WHERE     (Funcionarios.fun_codigo = @fun_codigo) " +
                            "ORDER BY con_codigo";
            banco.executeQuery(sql, out dt, "@fun_codigo", fun_codigo);
            return dt;
        }

        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_Funcionarios ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluirTodas(int fun_codigo)
        {
            string sql;
            sql = "DELETE FROM Contas_Funcionarios WHERE fun_codigo = @fun_codigo";
            return banco.executeNonQuery(sql, "@fun_codigo", fun_codigo);
        }

        public bool excluir(int fun_codigo, int con_codigo)
        {
            string sql;
            sql = "DELETE FROM Contas_Funcionarios WHERE fun_codigo = @fun_codigo and con_codigo = @con_codigo";
            return banco.executeNonQuery(sql, "@fun_codigo", fun_codigo, "@con_codigo", con_codigo);
        }

    }
}
