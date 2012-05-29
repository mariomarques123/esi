using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroContratos
    {

        Banco banco;

        public CadastroContratos(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string Cnt_Descricao)
        {
            string sql;
            sql = "INSERT INTO Contratos (Cnt_Descricao) " +
                    " VALUES (@Cnt_Descricao) ";

            return banco.executeNonQuery(sql,
                "@Cnt_Descricao", Cnt_Descricao
                );
        }

        public bool alterar(int codigo, string Cnt_Descricao)
        {

            string sql;
            sql = "UPDATE Contratos SET Cnt_Descricao=@Cnt_Descricao " +
                    " WHERE cnt_codigo = @cnt_codigo ";

            return banco.executeNonQuery(sql,
                "@Cnt_Descricao", Cnt_Descricao,
                "@cnt_codigo", codigo
                );
        }

        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Contratos " +
                " WHERE cnt_codigo = @cnt_codigo" +
                " ORDER BY cnt_codigo";
            banco.executeQuery(sql, out dt, "@cnt_codigo", codigo);
            return dt;
        }

        public DataTable listarTodos()
        {
            DataTable dt;
            string sql = "SELECT * FROM Contratos ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE FROM Contratos WHERE cnt_codigo = @cnt_codigo";
            return banco.executeNonQuery(sql, "@cnt_codigo", codigo);
        }

     }
}
