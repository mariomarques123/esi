using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class ContasPagar
    {
        BancoM banco;

        public ContasPagar(BancoM banco)
        {
            this.banco = banco;
        }

        public bool registrar(string cop_descricao, DateTime cop_dataVenc, float cop_valor, int fun_codigo)
        {
            string sql = "INSERT INTO ContasPagar" +
                        "        (cop_descricao,cop_dataVenc,cop_valor,fun_codigo)" +
                        " VALUES (@cop_descricao,@cop_dataVenc,@cop_valor,@fun_codigo) ";

            if(fun_codigo != 0)
                return banco.executeNonQuery(sql, "@cop_descricao", cop_descricao,
                                                "@cop_dataVenc", cop_dataVenc,
                                                "@cop_valor", cop_valor,
                                                "@fun_codigo", fun_codigo);
            else
                return banco.executeNonQuery(sql, "@cop_descricao", cop_descricao,
                                                "@cop_dataVenc", cop_dataVenc,
                                                "@cop_valor", cop_valor,
                                                "@fun_codigo", DBNull.Value);
        }

        public DataTable UltimosVencimentos()
        {
            DataTable dt;
            string sql = "SELECT * FROM ContasPagar"+
                        " ORDER BY cop_dataVenc DESC";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable abertos()
        {
            DataTable dt;
            string sql = "SELECT * FROM ContasPagar" +
                        " WHERE cop_dataPag is null" +
                        " ORDER BY cop_dataVenc DESC";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable pagas()
        {
            DataTable dt;
            string sql = "SELECT * FROM ContasPagar" +
                        " WHERE cop_dataPag is not null" +
                        " ORDER BY cop_dataVenc DESC";

            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int cop_codigo)
        {
            string sql = "DELETE ContasPagar WHERE cop_codigo = @cop_codigo";
            return banco.executeNonQuery(sql, "@cop_codigo", cop_codigo);
        }

        public DataTable vencidas()
        {
            DataTable dt;
            string sql = "SELECT * FROM ContasPagar" +
                        " WHERE @agora > cop_dataVenc" +
                        " ORDER BY cop_dataVenc DESC";

            banco.executeQuery(sql, out dt, "@agora",DateTime.Now);
            return dt;
        }

        //public bool alterar(int mov_codigo, DateTime mov_data, float mov_valor, char mov_tipo, int con_codigo)
        //{
        //    string sql = "UPDATE Movimentacao " +
        //                    "   SET mov_data = @mov_data," +
        //                    "       mov_valor = @mov_valor," +
        //                    "       mov_tipo = @mov_tipo," +
        //                    "       con_codigo = @con_codigo" +
        //                    " WHERE mov_codigo = @mov_codigo ";

        //    return banco.executeNonQuery(sql, "@mov_codigo", mov_codigo,
        //                                      "@mov_data", mov_data,
        //                                        "@mov_valor", mov_valor,
        //                                        "@mov_tipo", mov_tipo,
        //                                        "@con_codigo", con_codigo);
        //}
    }
}
