using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroBancos
    {

        Banco banco;

        public CadastroBancos(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string nomeBanco, int codigoBanco)
        {
            string sql;
            sql = "INSERT INTO Bancos (Ban_nome, Ban_codigo) " +
                    " VALUES (@Ban_nomebanco,@Ban_codigobanco) ";

            return banco.executeNonQuery(sql,
                "@Ban_nomebanco", nomeBanco,
                "@Ban_codigobanco", codigoBanco
                );
        }

        public bool alterar(int codigoChave, string nomeBanco, int codigoBanco)
        {

            string sql;
            sql = "UPDATE Bancos SET Ban_nome=@ban_nome, ban_codigo=@ban_codigo " +
                    " WHERE ban_codigochave = @ban_codigochave";

            return banco.executeNonQuery(sql,
                "@ban_codigochave", codigoChave,
                "@ban_nome", nomeBanco,
                "@ban_codigo", codigoBanco
                );
        }

        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Bancos " +
                " WHERE ban_codigochave = @ban_codigochave" +
                " ORDER BY ban_codigochave";
            banco.executeQuery(sql, out dt, "@ban_codigochave", codigo);
            return dt;
        }

        public DataTable localizarPorNome(string nome)
        {
            DataTable dt;
            string sql = "SELECT * FROM Bancos" +
                         " WHERE ban_nome LIKE @ban_nome " +
                         " ORDER BY ban_Nome";
            nome += "%";
            banco.executeQuery(sql, out dt, "@ban_nome", nome);
            return dt;
        }

        public DataTable listarTodos()
        {
            DataTable dt;
            string sql = "SELECT * FROM Bancos ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE FROM Bancos WHERE ban_codigochave = @ban_codigochave";
            return banco.executeNonQuery(sql, "@ban_codigochave", codigo);
        }

        public bool verificaCodigoBancoEx(int codigoBanco)
        {
            DataTable dt;
            string sql = "SELECT * FROM Bancos " +
                " WHERE Ban_codigo = @ban_codigo";
            banco.executeQuery(sql, out dt, "@ban_codigo", codigoBanco);
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;

        }
    }
}
