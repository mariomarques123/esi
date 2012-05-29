using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class GerenciamentoCustasProcesso
    {

        Banco banco;

        public GerenciamentoCustasProcesso(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string Cus_descricao, double Cus_Valor, int tic_codigo)
        {
            string sql;
            sql = "INSERT INTO Custo (Cus_descricao, Cus_Valor, tic_codigo) " +
                    " VALUES (@Cus_descricao, @Cus_Valor, @tic_codigo) ";

            return banco.executeNonQuery(sql,
                "@Cus_descricao",Cus_descricao,
                "@Cus_Valor",Cus_Valor,
                "@tic_codigo",tic_codigo

                );
        }

        public bool alterar(int Cus_Codigo, string Cus_descricao, double Cus_Valor, int tic_codigo)
        {

            string sql;
            sql = "UPDATE Custo SET  Cus_descricao=@Cus_descricao, Cus_Valor=@Cus_Valor, tic_codigo=@tic_codigo " +
                    " WHERE Cus_Codigo=@Cus_Codigo";

            return banco.executeNonQuery(sql,
                "@Cus_Codigo",Cus_Codigo,
                "@Cus_descricao",Cus_descricao,
                "@Cus_Valor",Cus_Valor,
                "@tic_codigo",tic_codigo

                );
        }

        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Custo " +
                " WHERE Cus_Codigo = @Cus_Codigo" +
                " ORDER BY Cus_Codigo";
            banco.executeQuery(sql, out dt, "@Cus_Codigo", codigo);
            return dt;
        }

        public DataTable localizarPorNome(string nome)
        {
            DataTable dt;
            string sql = "SELECT * FROM Custo" +
                         " WHERE Cus_descricao LIKE @Cus_descricao " +
                         " ORDER BY Cus_descricao";
            nome += "%";
            banco.executeQuery(sql, out dt, "@Cus_descricao", nome);
            return dt;
        }

        public DataTable listarTodos()
        {
            DataTable dt;
            string sql = "SELECT * FROM Custo ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE FROM Custo WHERE Cus_Codigo = @Cus_Codigo";
            return banco.executeNonQuery(sql, "@Cus_Codigo", codigo);
        }

        public bool excluirRecebimentos(int codigo)
        {
            string sql;
            sql = "DELETE FROM Recebimentos WHERE Cus_Codigo = @Cus_Codigo";
            return banco.executeNonQuery(sql, "@Cus_Codigo", codigo);
        }

        public DataTable listarCustasProcesso(string codigoProcesso)
        {
            string sql;
            sql = "SELECT Custo.Cus_Codigo, Custo.Cus_Descricao , Custo.Tic_Codigo, Custo.Cus_Valor, Recebimentos.rece_valorrecebido  FROM Custo JOIN Recebimentos ON Custo.cus_codigo = Recebimentos.cus_codigo WHERE Recebimentos.Pro_numero = @Pro_numero";
            DataTable saida;
            banco.executeQuery(sql, out saida, "@Pro_numero", codigoProcesso);
            return saida;
        }

        public bool veirifcaPagamento(int codigoCusto) 
        {
            string sql;
            sql = "SELECT COUNT(*) as CONTAGEM FROM Recebimentos WHERE Recebimentos.Cus_Codigo = @Cus_Codigo AND Recebimentos.rece_dataReceb IS NULL";
            DataTable saida;
            banco.executeQuery(sql, out saida, "@Cus_Codigo", codigoCusto);
            if (saida.Rows[0]["CONTAGEM"].ToString() == 1.ToString())
                return true;
            else
                return false;
        }

        public int getNumeroProcesso(int codigoCusto)
        {
            int saida = -1;
            string sql;
            sql = "SELECT Recebimentos.pro_numero FROM Recebimentos WHERE Recebimentos.cus_codigo = @cus_codigo";
            DataTable busca;
            banco.executeQuery(sql, out busca, "@cus_codigo", codigoCusto);
            if (busca.Rows.Count > 0)
                saida = int.Parse(busca.Rows[0]["Pro_numero"].ToString());
            return saida;
        }
    }
}
