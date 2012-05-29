using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroDespesasEscritorio
    {
        Banco banco;

        public CadastroDespesasEscritorio(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string nome, char tipo, int dataVencimento, double valor)
        {
            string sql;
            sql = "INSERT INTO Contas_escritorio (ces_nome, ces_tipo, ces_datamesvenc,ces_valor) " +
                    " VALUES (@ces_nome,@ces_tipo,@ces_datamesvenc,@ces_valor) ";

            return banco.executeNonQuery(sql,
                "@ces_nome", nome,
                "@ces_tipo", tipo,
                "@ces_valor", valor,
                "@ces_datamesvenc", dataVencimento
                );
        }

        public bool alterar(int codigo, string nome, char tipo, int dataVencimento, double ces_valor)
        {

            string sql;
            sql = "UPDATE Contas_Escritorio SET ces_nome=@ces_nome, ces_tipo=@ces_tipo, ces_datamesvenc=@ces_datamesvenc, ces_valor = @ces_valor " +
                    " WHERE ces_codigo = @ces_codigo";

            return banco.executeNonQuery(sql,
                "@ces_codigo", codigo,
                "@ces_nome", nome,
                "@ces_tipo", tipo,
                "@ces_valor", ces_valor,
                "@ces_datamesvenc", dataVencimento
                );
        }


        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_escritorio " +
                " WHERE ces_codigo = @ces_codigo" +
                " ORDER BY ces_codigo";
            banco.executeQuery(sql, out dt, "@ces_codigo", codigo);
            return dt;
        }

        public DataTable localizarPorNome(string nome)
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_escritorio" +
                         " WHERE ces_nome LIKE @ces_nome " +
                         " ORDER BY ces_nome";
            nome += "%";
            banco.executeQuery(sql, out dt, "@ces_nome", nome);
            return dt;
        }


        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_escritorio ";
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
            sql = "DELETE Contas_escritorio WHERE ces_codigo = @cod";
            return banco.executeNonQuery(sql, "@cod", codigo);
        }
    }
}
