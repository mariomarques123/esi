using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class Contas
    {
        BancoM banco;

        public Contas(BancoM banco)
        {
            this.banco = banco;
        }

        public bool incluir(string numero, int codigoBanco, int numeroAgencia)
        {
            string sql;
            sql = "INSERT INTO Contas_Banco (con_numero, Ban_codigoChave, con_numeroagencia) " +
                    " VALUES (@con_numero,@Ban_codigoChave,@con_numeroagencia) ";

            return banco.executeNonQuery(sql,
                "@con_numero", numero,
                "@Ban_codigoChave", codigoBanco,
                "@con_numeroagencia", numeroAgencia
                );
        }

        public bool alterar(int codigo, string numero, int codigoBanco, int numeroAgencia)
        {

            string sql;
            sql = "UPDATE Contas_Banco SET con_numero=@con_numero, Ban_codigoChave=@Ban_codigoChave, con_numeroagencia=@con_numeroagencia " +
                    " WHERE con_codigo = @con_codigo";

            return banco.executeNonQuery(sql,
                "@con_codigo", codigo,
                "@con_numero", numero,
                "@Ban_codigoChave", codigoBanco,
                "@con_numeroagencia", numeroAgencia
                );
        }

        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_Banco " +
                " WHERE con_codigo = @con_codigo" +
                " ORDER BY con_codigo";
                banco.executeQuery(sql, out dt, "@con_codigo", codigo);
            return dt;
        }

        public DataTable localizarPorNumeroContaCodigo(string numeroConta)
        {
            DataTable dt;
            string sql = "SELECT ban_codigo, Con_Codigo, Con_Numero, Con_NumeroAgencia, Ban_nome FROM Contas_Banco join Bancos ON bancos.ban_codigoChave = Contas_Banco.ban_codigoChave" +
                " WHERE con_numero = @con_numero" +
                " ORDER BY con_numero";
            banco.executeQuery(sql, out dt, "@con_numero", numeroConta);
            return dt;
        }

        public bool verificaExistConta(string numeroConta, int codigoAgencia, int codigoBanco)
        {
            DataTable dt;
            string sql = "SELECT * FROM Contas_Banco " +
                " WHERE con_numero = @con_numero AND Ban_codigoChave = @Ban_codigoChave AND con_numeroagencia = @con_numeroagencia";
            banco.executeQuery(sql, out dt,
                "@con_numero", numeroConta,
                "@Ban_codigoChave", codigoBanco,
                "@con_numeroagencia", codigoAgencia
            );
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;

        }

        public DataTable listar1()
        {
            DataTable dt;
            string sql = "SELECT Con_Codigo, Con_Numero, Con_NumeroAgencia FROM Contas_Banco";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable listarMenos1(int con_codigo)
        {
            DataTable dt;
            string sql = "SELECT Con_Codigo, Con_Numero, Con_NumeroAgencia FROM Contas_Banco WHERE con_codigo <> @con_codigo";
            banco.executeQuery(sql, out dt, "@con_codigo",con_codigo);
            return dt;
        }
        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE FROM Contas_Banco WHERE con_codigo = @cod";
            return banco.executeNonQuery(sql, "@cod", codigo);
        }

    }
}
