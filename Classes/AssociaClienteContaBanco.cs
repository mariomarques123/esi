using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class AssociaClienteContaBanco
    {
        Banco banco;

        public AssociaClienteContaBanco(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string con_codigo, int cli_codigo)
        {
            string sql;
            sql = "INSERT INTO Contas_Clientes (con_codigo, cli_codigo) " +
                    " VALUES (@con_codigo,@cli_codigo)";

            return banco.executeNonQuery(sql,
                "@con_codigo", con_codigo,
                "@cli_codigo", cli_codigo
                );
        }

        public DataTable localizarPorCodigoClienteFiltrado(int cli_codigo)
        {
            DataTable dt;
            string sql = "SELECT     Contas_banco.con_codigo, Contas_banco.con_numero, clientes.cli_codigo, clientes.cli_nome " +
                            "FROM         Contas_Clientes INNER JOIN " +
                            "                      Clientes ON clientes.cli_codigo = Contas_Clientes.cli_codigo INNER JOIN " +
                            "                      Contas_Banco ON contas_banco.con_codigo = Contas_Clientes.con_codigo " +
                            "WHERE     (Clientes.cli_codigo = @cli_codigo) " +
                            "ORDER BY con_codigo";
            banco.executeQuery(sql, out dt, "@cli_codigo", cli_codigo);
            return dt;
        }

        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_Clientes ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluirTodas(int cli_codigo)
        {
            string sql;
            sql = "DELETE FROM Contas_Clientes WHERE cli_codigo = @cli_codigo";
            return banco.executeNonQuery(sql, "@cli_codigo", cli_codigo);
        }

        public bool excluir(int cli_codigo, int con_codigo)
        {
            string sql;
            sql = "DELETE FROM Contas_Clientes WHERE cli_codigo = @cli_codigo and con_codigo = @con_codigo";
            return banco.executeNonQuery(sql, "@cli_codigo", cli_codigo, "@con_codigo", con_codigo);
        }

    }
}
