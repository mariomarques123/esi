using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class AtualizacaoHonorario
    {
        Banco banco;

        public AtualizacaoHonorario(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string Pro_Numero, DateTime Hon_DataInicial, double Hon_ValorTotal, char Hon_Parcelado, int Hon_QuantidadeParcelas, string Hon_Descricao, int Hon_NivelAcesso, int Hon_diasParcelas)
        {
            string sql;
            sql = "INSERT INTO Honorarios (Pro_Numero,Hon_DataInicial,Hon_ValorTotal,Hon_Parcelado,Hon_QuantidadeParcelas,Hon_Descricao,Hon_NivelAcesso,Hon_diasParcelas) " +
                    " VALUES (@Pro_Numero,@Hon_DataInicial,@Hon_ValorTotal,@Hon_Parcelado,@Hon_QuantidadeParcelas,@Hon_Descricao,@Hon_NivelAcesso,@Hon_diasParcelas) ";

            return banco.executeNonQuery(sql,
                                            "@Pro_Numero",Pro_Numero,
                                            "@Hon_DataInicial",Hon_DataInicial,
                                            "@Hon_ValorTotal",Hon_ValorTotal,
                                            "@Hon_Parcelado",Hon_Parcelado,
                                            "@Hon_QuantidadeParcelas",Hon_QuantidadeParcelas,
                                            "@Hon_Descricao",Hon_Descricao,
                                            "@Hon_NivelAcesso",Hon_NivelAcesso,
                                            "@Hon_diasParcelas", Hon_diasParcelas

                                        );
        }

        public bool alterar(int Hon_Codigo, string Pro_Numero, DateTime Hon_DataInicial, double Hon_ValorTotal, char Hon_Parcelado, int Hon_QuantidadeParcelas, string Hon_Descricao, int Hon_NivelAcesso, int Hon_diasParcelas)
        {
            string sql;
            sql = "UPDATE Honorarios SET Pro_Numero=@Pro_Numero, Hon_DataInicial=@Hon_DataInicial, Hon_ValorTotal=@Hon_ValorTotal, Hon_Parcelado=@Hon_Parcelado, Hon_QuantidadeParcelas=@Hon_QuantidadeParcelas, Hon_Descricao=@Hon_Descricao, Hon_NivelAcesso=@Hon_NivelAcesso, Hon_diasParcelas=@Hon_diasParcelas WHERE Hon_Codigo=@Hon_Codigo";

            return banco.executeNonQuery(sql,
                                            "@Pro_Numero",Pro_Numero,
                                            "@Hon_DataInicial",Hon_DataInicial,
                                            "@Hon_ValorTotal",Hon_ValorTotal,
                                            "@Hon_Parcelado",Hon_Parcelado,
                                            "@Hon_QuantidadeParcelas",Hon_QuantidadeParcelas,
                                            "@Hon_Descricao",Hon_Descricao,
                                            "@Hon_NivelAcesso",Hon_NivelAcesso,
                                            "@Hon_diasParcelas", Hon_diasParcelas,
                                            "@Hon_Codigo",Hon_Codigo
                                        );
        }


        public DataTable localizarPorNumeroProcesso(string Pro_Numero)
        {
            DataTable dt;
            string sql = "SELECT * FROM Honorarios " +
                " WHERE Pro_numero  =@Pro_Numero " +
                " ORDER BY Pro_Numero";
            banco.executeQuery(sql, out dt, "@Pro_Numero", Pro_Numero);
            return dt;
        }

        public DataTable localizarPorNumeroProcessoRelat(string Pro_Numero)
        {
            DataTable dt;
            string sql = "SELECT * FROM empresa, Honorarios " +
                " WHERE Pro_numero  =@Pro_Numero " +
                " ORDER BY Pro_Numero";
            banco.executeQuery(sql, out dt, "@Pro_Numero", Pro_Numero);
            return dt;
        }

        public DataTable localizarPorCodigo(int Hon_Codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Honorarios " +
                " WHERE Hon_Codigo  = @Hon_Codigo " +
                " ORDER BY Hon_Codigo";
            banco.executeQuery(sql, out dt, "@Hon_Codigo", Hon_Codigo);
            return dt;
        }

        public DataTable listarHonorarios()
        {
            DataTable dt;
            string sql = "SELECT * FROM Honorarios ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable listarHonorariosRelat()
        {
            DataTable dt;
            string sql = "SELECT * FROM Honorarios, empresa ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int Hon_Codigo)
        {
            string sql;
            sql = "DELETE Honorarios WHERE Hon_Codigo = @Hon_Codigo";
            return banco.executeNonQuery(sql, "@Hon_Codigo", Hon_Codigo);
        }

        public bool lancamentoRecebimento(int codigoHonorario, DateTime dataVencimento)
        {
            bool saida = false ;

            return saida;
        }

        public bool verificaExistenciaRecebPago(int Hon_Codigo)
        {
            string sql;
            sql = "SELECT COUNT(*) as CONTAGEM FROM Recebimentos WHERE Recebimentos.Hon_Codigo = @Hon_Codigo AND Recebimentos.rece_dataReceb IS not NULL";
            DataTable saida;
            banco.executeQuery(sql, out saida, "@Hon_Codigo", Hon_Codigo);
            int quantidade = int.Parse(saida.Rows[0]["CONTAGEM"].ToString());
            if (quantidade > 0)
                return true;
            else
                return false;
        }

        public bool excluirRecebimentos(int Hon_Codigo)
        {
            string sql;
            sql = "DELETE FROM Recebimentos WHERE Hon_Codigo = @Hon_Codigo";
            return banco.executeNonQuery(sql, "@Hon_Codigo", Hon_Codigo);
        }



        public DataTable listarHonorarioPeriodo(DateTime dateTime, DateTime dateTime_2)
        {
            DataTable saida;
            string sql;
            sql = "SELECT     Hon_Codigo, Pro_Numero, Hon_DataInicial, Hon_ValorTotal, Hon_Parcelado, Hon_QuantidadeParcelas, Hon_Descricao, Hon_NivelAcesso, Hon_diasParcelas ,  Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade"+
                    " FROM         Honorarios, empresa " +
                    " WHERE     (Hon_DataInicial BETWEEN @data1 AND @data2)";
            banco.executeQuery(sql, out saida, "@data1", dateTime, "@data2", dateTime_2);
            return saida;
        }

        public DataTable listarHonorarioCliente(string p)
        {
            DataTable saida;
            string sql;
            sql = "SELECT     Honorarios.Hon_Codigo, Honorarios.Pro_Numero, Honorarios.Hon_DataInicial, Honorarios.Hon_ValorTotal, Honorarios.Hon_Parcelado, "+
                        "   Honorarios.Hon_QuantidadeParcelas, Honorarios.Hon_Descricao, Honorarios.Hon_NivelAcesso, Honorarios.Hon_diasParcelas, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade " +
                        " FROM     empresa,    Honorarios INNER JOIN "+
                        "                      Processos ON Processos.Pro_Numero = Honorarios.Pro_Numero INNER JOIN "+
                        "                      Processos_Clientes ON Processos_Clientes.Pro_Numero = Processos.Pro_Numero INNER JOIN "+
                        "                      Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo "+
                        " WHERE     (Clientes.Cli_Nome = @nome)";
            banco.executeQuery(sql, out saida, "@nome", p);
            return saida;
        }
    }


}


