using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroTiposCusto
    {
        Banco banco;

        public CadastroTiposCusto(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string descricao, double valor)
        {
            string sql;
            sql = "INSERT INTO TiposCusto (tic_descricao, tic_valor) " +
                    " VALUES (@tic_descricao,@tic_valor) ";

            return banco.executeNonQuery(sql,
                "@tic_descricao", descricao,
                "@tic_valor", valor
                );
        }

        public bool alterar(int codigo, string descricao, double tic_valor)
        {

            string sql;
            sql = "UPDATE TiposCusto SET tic_descricao=@tic_descricao, tic_valor = @tic_valor " +
                    " WHERE tic_codigo = @tic_codigo";

            return banco.executeNonQuery(sql,
                "@tic_codigo", codigo,
                "@tic_descricao", descricao,
                "@tic_valor", tic_valor
                );
        }


        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM TiposCusto " +
                " WHERE tic_codigo = @tic_codigo" +
                " ORDER BY tic_codigo";
            banco.executeQuery(sql, out dt, "@tic_codigo", codigo);
            return dt;
        }

        public DataTable localizarDescricao(string descricao)
        {
            DataTable dt;
            string sql = "SELECT * FROM TiposCusto" +
                         " WHERE tic_descricao LIKE @tic_descricao " +
                         " ORDER BY tic_descricao";
            descricao += "%";
            banco.executeQuery(sql, out dt, "@tic_descricao", descricao);
            return dt;
        }


        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT * FROM TiposCusto ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        /// <summary>
        /// Método para excluir um cadastro do banco de dados conforme o código
        /// passado por parâmetro
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE TiposCusto WHERE tic_codigo = @cod";
            return banco.executeNonQuery(sql, "@cod", codigo);
        }
    }
}
