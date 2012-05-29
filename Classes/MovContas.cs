using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class MovContas
    {
        BancoM banco;

        public MovContas(BancoM banco)
        {
            this.banco = banco;
        }

        public bool registrar(DateTime mov_data, float mov_valor, char mov_tipo, int con_codigo)
        {
            string sql = "INSERT INTO Movimentacao" +
                        "        (mov_data,mov_valor,mov_tipo,con_codigo)" +
                        " VALUES (@mov_data,@mov_valor,@mov_tipo,@con_codigo) ";

            return banco.executeNonQuery(sql, "@mov_data", mov_data,
                                                "@mov_valor", mov_valor,
                                                "@mov_tipo", mov_tipo,
                                                "@con_codigo", con_codigo);
        }

        public DataTable UltimosLancamentos(int con_codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Movimentacao" +
                        " WHERE (con_codigo = @con_codigo)" +
                        " ORDER BY mov_data DESC";

            banco.executeQuery(sql, out dt, "@con_codigo", con_codigo);
            return dt;
        }

        public DataTable exibirTodos()
        {
            DataTable dt;
            string sql = "SELECT   M.mov_codigo,M.mov_data, M.mov_valor, M.mov_tipo,C.Con_Numero" +
                         " FROM    Movimentacao AS M INNER JOIN Contas_Banco AS C ON M.Con_Codigo = C.Con_Codigo" +
                         " ORDER BY M.mov_data DESC";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable RelSemFiltro()
        {
            DataTable dt;
            string sql = "SELECT   C.Con_Numero, M.mov_data, M.mov_valor, M.mov_tipo" +
                         " FROM    Movimentacao AS M INNER JOIN Contas_Banco AS C ON M.Con_Codigo = C.Con_Codigo" +
                         " ORDER BY M.mov_data DESC";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable porPeriodo(int con_codigo, DateTime ini, DateTime fim)
        {
            DataTable dt;
            string sql = "SELECT * FROM Movimentacao" +
                        " WHERE (con_codigo = @con_codigo) AND mov_data BETWEEN @ini AND @fim" +
                        " ORDER BY mov_data DESC";

            banco.executeQuery(sql, out dt, "@con_codigo", con_codigo,
                                            "@ini",ini,
                                            "@fim",fim);
            return dt;
        }

        public DataTable porPeriodo(DateTime ini, DateTime fim)
        {
            DataTable dt;
            string sql = "SELECT M.mov_codigo,M.mov_data, M.mov_valor, M.mov_tipo,C.Con_Numero" +
                            " FROM            Movimentacao AS M INNER JOIN Contas_Banco AS C ON M.Con_Codigo = C.Con_Codigo "+
                            " WHERE        (M.mov_data BETWEEN @ini AND @fim)" +
                            " ORDER BY M.mov_data DESC";

            banco.executeQuery(sql, out dt, "@ini", ini,
                                            "@fim", fim);
            return dt;
        }

        public DataTable porTipo(int con_codigo, char mov_tipo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Movimentacao" +
                        " WHERE con_codigo = @con_codigo AND mov_tipo = @mov_tipo" +
                        " ORDER BY mov_data DESC";

            banco.executeQuery(sql, out dt, "@con_codigo", con_codigo,
                                            "@mov_tipo", mov_tipo);
            return dt;
        }

        public DataTable porTipo(char mov_tipo)
        {
            DataTable dt;
            string sql = "SELECT M.mov_codigo,M.mov_data, M.mov_valor, M.mov_tipo,C.Con_Numero" +
                         " FROM Movimentacao as M, Contas_Banco as C" +
                         " WHERE M .mov_tipo = @mov_tipo AND M.con_codigo = C.con_codigo" +
                         " ORDER BY mov_data DESC";

            banco.executeQuery(sql, out dt, "@mov_tipo", mov_tipo);
            return dt;
        }

        public bool alterar(int mov_codigo, DateTime mov_data, float mov_valor, char mov_tipo, int con_codigo)
        {
            string sql = "UPDATE Movimentacao " +
                            "   SET mov_data = @mov_data," +
                            "       mov_valor = @mov_valor," +
                            "       mov_tipo = @mov_tipo," +
                            "       con_codigo = @con_codigo" +
                            " WHERE mov_codigo = @mov_codigo ";

            return banco.executeNonQuery(sql, "@mov_codigo", mov_codigo,
                                              "@mov_data", mov_data,
                                                "@mov_valor", mov_valor,
                                                "@mov_tipo", mov_tipo,
                                                "@con_codigo", con_codigo);
        }

        public bool excluir(int mov_codigo)
        {
            string sql = "DELETE Movimentacao WHERE mov_codigo = @mov_codigo";

            return banco.executeNonQuery(sql, "@mov_codigo", mov_codigo);
        }
    }
}
