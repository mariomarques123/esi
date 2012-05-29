using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class GerenciamentoRecebimentos
    {
        Banco banco;

        public GerenciamentoRecebimentos(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluirCusta(int Cus_Codigo, int Hon_Codigo, string Pro_Numero,Nullable<DateTime> Rece_DataReceb, string Rece_Descricao, double Rece_Valor, DateTime Rece_DataVenc, double Rece_valorRecebido)
        {
            string sql;
            sql = "INSERT INTO Recebimentos (Cus_Codigo,Hon_Codigo,Pro_Numero,Rece_DataReceb,Rece_Descricao,Rece_Valor,Rece_DataVenc,Rece_valorRecebido) " +
                    " VALUES (@Cus_Codigo, @Hon_Codigo, @Pro_Numero, @Rece_DataReceb, @Rece_Descricao, @Rece_Valor, @Rece_DataVenc,@Rece_valorRecebido) ";

            if (!Rece_DataReceb.HasValue)
            {
                return banco.executeNonQuery(sql,
                                                "@Cus_Codigo", Cus_Codigo,
                                                "@Hon_Codigo", DBNull.Value,
                                                "@Pro_Numero", Pro_Numero,
                                                "@Rece_DataReceb", DBNull.Value,
                                                "@Rece_Descricao", Rece_Descricao,
                                                "@Rece_Valor", Rece_Valor,
                                                "@Rece_DataVenc", Rece_DataVenc,
                                                "@Rece_valorRecebido", DBNull.Value
                                            );
            }
            else
            {
                return banco.executeNonQuery(sql,
                                                "@Cus_Codigo", Cus_Codigo,
                                                "@Hon_Codigo", DBNull.Value,
                                                "@Pro_Numero", Pro_Numero,
                                                "@Rece_DataReceb", Rece_DataReceb,
                                                "@Rece_Descricao", Rece_Descricao,
                                                "@Rece_Valor", Rece_Valor,
                                                "@Rece_DataVenc", Rece_DataVenc,
                                                "@Rece_valorRecebido", Rece_valorRecebido
                                            );
            }
        }

        public bool incluirHonorario(int Hon_Codigo, string Pro_Numero, Nullable<DateTime> Rece_DataReceb, string Rece_Descricao, double Rece_Valor, DateTime Rece_DataVenc, double Rece_valorRecebido)
        {
            string sql;
            sql = "INSERT INTO Recebimentos (Cus_Codigo,Hon_Codigo,Pro_Numero,Rece_DataReceb,Rece_Descricao,Rece_Valor,Rece_DataVenc, Rece_valorRecebido) " +
                    " VALUES (@Cus_Codigo, @Hon_Codigo, @Pro_Numero, @Rece_DataReceb, @Rece_Descricao, @Rece_Valor, @Rece_DataVenc, @Rece_valorRecebido) ";

            if (!Rece_DataReceb.HasValue)
            {
                return banco.executeNonQuery(sql,
                                           "@Cus_Codigo", DBNull.Value,
                                           "@Hon_Codigo", Hon_Codigo,
                                           "@Pro_Numero", Pro_Numero,
                                           "@Rece_DataReceb", DBNull.Value,
                                           "@Rece_Descricao", Rece_Descricao,
                                           "@Rece_Valor", Rece_Valor,
                                           "@Rece_DataVenc", Rece_DataVenc,
                                           "@Rece_valorRecebido", DBNull.Value
                                       );
            }
            else
            {
                return banco.executeNonQuery(sql,
                                           "@Cus_Codigo", DBNull.Value,
                                           "@Hon_Codigo", Hon_Codigo,
                                           "@Pro_Numero", Pro_Numero,
                                           "@Rece_DataReceb", Rece_DataReceb.Value,
                                           "@Rece_Descricao", Rece_Descricao,
                                           "@Rece_Valor", Rece_Valor,
                                           "@Rece_DataVenc", Rece_DataVenc,
                                           "@Rece_valorRecebido", Rece_valorRecebido
                                       );
            }
        }

        public bool alterarHonorario(int Rece_Codigo, int Hon_Codigo, string Pro_Numero, Nullable<DateTime> Rece_DataReceb, string Rece_Descricao, double Rece_Valor, DateTime Rece_DataVenc, double Rece_valorRecebido)
        {
            string sql;
            sql = "UPDATE Recebimentos SET Cus_Codigo=@Cus_Codigo, Hon_Codigo=@Hon_Codigo, Pro_Numero=@Pro_Numero, Rece_DataReceb=@Rece_DataReceb, Rece_Descricao=@Rece_Descricao, Rece_Valor=@Rece_Valor, Rece_DataVenc=@Rece_DataVenc, Rece_valorRecebido=@Rece_valorRecebido WHERE Rece_Codigo=@Rece_Codigo";

            if (!Rece_DataReceb.HasValue)
            {
                return banco.executeNonQuery(sql,
                                           "@Rece_Codigo", Rece_Codigo,
                                           "@Cus_Codigo", DBNull.Value,
                                           "@Hon_Codigo", Hon_Codigo,
                                           "@Pro_Numero", Pro_Numero,
                                           "@Rece_DataReceb", DBNull.Value,
                                           "@Rece_Descricao", Rece_Descricao,
                                           "@Rece_Valor", DBNull.Value,
                                           "@Rece_DataVenc", Rece_DataVenc,
                                           "@Rece_valorRecebido", DBNull.Value
                                       );
            }
            else
            {
                return banco.executeNonQuery(sql,
                                           "@Rece_Codigo", Rece_Codigo,
                                           "@Cus_Codigo", DBNull.Value,
                                           "@Hon_Codigo", Hon_Codigo,
                                           "@Pro_Numero", Pro_Numero,
                                           "@Rece_DataReceb", Rece_DataReceb.Value,
                                           "@Rece_Descricao", Rece_Descricao,
                                           "@Rece_Valor", Rece_Valor,
                                           "@Rece_DataVenc", Rece_DataVenc,
                                           "@Rece_valorRecebido", Rece_valorRecebido
                                       );
            }
        }

        public bool alterarCusta(int Rece_Codigo, int Cus_Codigo, string Pro_Numero, Nullable<DateTime> Rece_DataReceb, string Rece_Descricao, double Rece_Valor, DateTime Rece_DataVenc, double Rece_valorRecebido)
        {
            string sql;
            sql = "UPDATE Recebimentos SET Cus_Codigo=@Cus_Codigo, Hon_Codigo=@Hon_Codigo, Pro_Numero=@Pro_Numero, Rece_DataReceb=@Rece_DataReceb, Rece_Descricao=@Rece_Descricao, Rece_Valor=@Rece_Valor, Rece_DataVenc=@Rece_DataVenc, Rece_valorRecebido=@Rece_valorRecebido WHERE Rece_Codigo=@Rece_Codigo";

            if (!Rece_DataReceb.HasValue)
            {
                return banco.executeNonQuery(sql,
                                           "@Rece_Codigo", Rece_Codigo,
                                                "@Cus_Codigo", Cus_Codigo,
                                                "@Hon_Codigo", DBNull.Value,
                                                "@Pro_Numero", Pro_Numero,
                                                "@Rece_DataReceb", DBNull.Value,
                                                "@Rece_Descricao", Rece_Descricao,
                                                "@Rece_Valor", Rece_Valor,
                                                "@Rece_DataVenc", Rece_DataVenc,
                                                "@Rece_valorRecebido", DBNull.Value
                                            );
            }
            else
            {
                return banco.executeNonQuery(sql,
                                           "@Rece_Codigo", Rece_Codigo,
                                                "@Cus_Codigo", Cus_Codigo,
                                                "@Hon_Codigo", DBNull.Value,
                                                "@Pro_Numero", Pro_Numero,
                                                "@Rece_DataReceb", Rece_DataReceb.Value,
                                                "@Rece_Descricao", Rece_Descricao,
                                                "@Rece_Valor", Rece_Valor,
                                                "@Rece_DataVenc", Rece_DataVenc,
                                                "@Rece_valorRecebido", Rece_valorRecebido
                                            );
            }
        }


        public DataTable localizarTodos()
        {
            DataTable dt;
            string sql = "SELECT * from Recebimentos ORDER BY Rece_Codigo ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable granLocaliza(string criterio, int primeiraOp, int segundaOp, int terceiraOp)
        {
            DataTable dt;
            string sql;

            if (terceiraOp == 1) 
            { //cliente 
                sql = "SELECT    DISTINCT  Recebimentos.Rece_Codigo, Recebimentos.Cus_Codigo, Recebimentos.Hon_Codigo, Recebimentos.Pro_Numero, Recebimentos.Rece_DataReceb,  " +
                " Recebimentos.Rece_Descricao, Recebimentos.Rece_Valor, Recebimentos.Rece_DataVenc, Recebimentos.Rece_ValorRecebido "+
                " FROM         Clientes INNER JOIN "+
                "                    Processos_Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo INNER JOIN "+
                "                    Processos ON Processos.Pro_Numero = Processos_Clientes.Pro_Numero INNER JOIN "+
                "                    Recebimentos ON Processos.Pro_Numero = Recebimentos.Pro_Numero "+
                " WHERE     Clientes.Cli_Nome LIKE @criterio ";
            }
            else if(terceiraOp == 2)//processo
                sql = "SELECT * FROM Recebimentos WHERE Recebimentos.Pro_Numero = @criterio ";
            else
                sql = "SELECT * from Recebimentos ";

            //0 ignora a condição

            if (primeiraOp == 1 && terceiraOp == 0) //honorario
                sql += " WHERE Recebimentos.Hon_Codigo IS NOT NULL ";
            else if (primeiraOp == 2 && terceiraOp == 0) //custa de processo
                sql += " WHERE Recebimentos.Cus_Codigo IS NOT NULL ";
            else if (primeiraOp == 1) //honorario
                sql += " AND Recebimentos.Hon_Codigo IS NOT NULL ";
            else if (primeiraOp == 2) //custa de processo
                sql += " AND Recebimentos.Cus_Codigo IS NOT NULL ";

            //0 ignora a condição
            if (segundaOp == 1 && terceiraOp == 0 && primeiraOp == 0) //recebido
                sql += " WHERE Recebimentos.Rece_DataReceb IS NOT NULL ";
            else if (segundaOp == 2 && terceiraOp == 0 && primeiraOp == 0)//não recebido
                sql += " WHERE Recebimentos.Rece_DataReceb IS NULL ";
            else if (segundaOp == 1) //recebido
                sql += " AND  Recebimentos.Rece_DataReceb IS NOT NULL ";
            else if (segundaOp == 2)//não recebido
                sql += " AND  Recebimentos.Rece_DataReceb IS NULL ";


            if(terceiraOp == 1) {
                criterio += "%";
                banco.executeQuery(sql, out dt, "@criterio", criterio);
            }
            else if(terceiraOp == 2) {
                if(criterio == "")
                    banco.executeQuery(sql, out dt, "@criterio", 0);
                else
                    banco.executeQuery(sql, out dt, "@criterio", int.Parse(criterio));
            }
            else
                banco.executeQuery(sql, out dt);
            
            return dt;
        }

        public bool efetivar(int Rece_Codigo, DateTime Rece_DataReceb, double Rece_valorRecebido)
        {
            string sql;
            sql = "UPDATE Recebimentos SET Rece_DataReceb=@Rece_DataReceb, Rece_valorRecebido=@Rece_valorRecebido WHERE Rece_Codigo=@Rece_Codigo";

                return banco.executeNonQuery(sql,
                                           "@Rece_Codigo", Rece_Codigo,
                                           "@Rece_DataReceb", Rece_DataReceb,
                                           "@Rece_valorRecebido", Rece_valorRecebido
                                       );
        }

        //public bool excluirAssociaFuncionarioProcesso(int numeroProcesso)
        //{
        //    string sql;
        //    sql = "DELETE Processos_Funcionarios WHERE Pro_Numero =  @Pro_Numero  ";
        //    return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso);
        //}

        //public bool excluirAssociaClienteProcesso(int numeroProcesso)
        //{
        //    string sql;
        //    sql = "DELETE Processos_Clientes WHERE Pro_Numero =  @Pro_Numero ";
        //    return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso);
        //}
    }
}
