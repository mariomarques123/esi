using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroContas
    {
        Banco banco;

        public CadastroContas(Banco banco)
        {
            this.banco = banco;
        }

        /// <summary>
        /// Método para incluir uma entrada no banco de dados na tabela de contas_banco com os valores passados por parâmetro
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="nomeBanco"></param>
        /// <param name="codigoBanco"></param>
        /// <param name="numeroAgencia"></param>
        /// <returns>Retorna verdadeiro se a transação ocorreu com sucesso, senão falso</returns>
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

        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT ban_codigo, Con_Codigo, Contas_Banco.ban_codigoChave, Con_Numero, Con_NumeroAgencia, Ban_nome FROM Contas_Banco join Bancos ON bancos.ban_codigoChave = Contas_Banco.ban_codigoChave";
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
            sql = "DELETE FROM Contas_Banco WHERE con_codigo = @cod";
            return banco.executeNonQuery(sql, "@cod", codigo);
        }

        

    }
}
