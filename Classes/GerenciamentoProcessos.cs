using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class GerenciamentoProcessos
    {
        Banco banco;

        public GerenciamentoProcessos(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string Pro_Numero, string Pro_Vara, string Pro_Forum, string Pro_Tipo, string Pro_Situacao, string Pro_Descricao, string Pro_Juiz, string Pro_Area, string Pro_Local, DateTime Pro_DataDistribuicao, int Pro_NivelAcesso, int Fun_AdvResp, char pro_clientenpcusto)
        {
            string sql;
            sql = "INSERT INTO Processos (Pro_Numero	,Pro_Forum	,Pro_Vara	,Pro_Tipo	,Pro_DataDistribuicao	,Pro_Area	,Pro_Local	,Pro_NivelAcesso	,Pro_Situacao	,Fun_AdvResp	,Pro_Descricao	,Pro_Juiz, pro_clientenpcusto) " +
                    " VALUES (@Pro_Numero, @Pro_Forum,@Pro_Vara,@Pro_Tipo,@Pro_DataDistribuicao,@Pro_Area,@Pro_Local,@Pro_NivelAcesso,@Pro_Situacao,@Fun_AdvResp,@Pro_Descricao,@Pro_Juiz,@pro_clientenpcusto) ";

            return banco.executeNonQuery(sql,
                                            "@Pro_Numero"	,	Pro_Numero	,
                                            "@Pro_Forum"	,	Pro_Forum	,
                                            "@Pro_Vara"	,	Pro_Vara	,
                                            "@Pro_Tipo"	,	Pro_Tipo	,
                                            "@Pro_DataDistribuicao"	,	Pro_DataDistribuicao	,
                                            "@Pro_Area"	,	Pro_Area	,
                                            "@Pro_Local"	,	Pro_Local	,
                                            "@Pro_NivelAcesso"	,	Pro_NivelAcesso	,
                                            "@Pro_Situacao"	,	Pro_Situacao	,
                                            "@Fun_AdvResp"	,	Fun_AdvResp	,
                                            "@Pro_Descricao"	,	Pro_Descricao,
                                            "@pro_clientenpcusto", pro_clientenpcusto,
                                            "@Pro_Juiz", Pro_Juiz
                                        );
        }

        public bool alterar(string Pro_Numero, string Pro_Vara, string Pro_Forum, string Pro_Tipo, string Pro_Situacao, string Pro_Descricao, string Pro_Juiz, string Pro_Area, string Pro_Local, DateTime Pro_DataDistribuicao, int Pro_NivelAcesso, int Fun_AdvResp, char pro_clientenpcusto)
        {
            string sql;
            sql = "UPDATE Processos SET Pro_Forum=@Pro_Forum, Pro_Vara=@Pro_Vara, Pro_Tipo=@Pro_Tipo,  Pro_DataDistribuicao=@Pro_DataDistribuicao, Pro_Area=@Pro_Area, Pro_Local=@Pro_Local, Pro_NivelAcesso=@Pro_NivelAcesso, Pro_Situacao=@Pro_Situacao, Fun_AdvResp=@Fun_AdvResp, Pro_Descricao=@Pro_Descricao, Pro_Juiz=@Pro_Juiz , pro_clientenpcusto= @pro_clientenpcusto WHERE Pro_Numero = @Pro_Numero";

            return banco.executeNonQuery(sql,
                                            "@Pro_Numero", Pro_Numero,
                                            "@Pro_Forum"	,	Pro_Forum	,
                                            "@Pro_Vara"	,	Pro_Vara	,
                                            "@Pro_Tipo"	,	Pro_Tipo	,
                                            "@Pro_DataDistribuicao"	,	Pro_DataDistribuicao	,
                                            "@Pro_Area"	,	Pro_Area	,
                                            "@Pro_Local"	,	Pro_Local	,
                                            "@Pro_NivelAcesso"	,	Pro_NivelAcesso	,
                                            "@Pro_Situacao"	,	Pro_Situacao	,
                                            "@Fun_AdvResp"	,	Fun_AdvResp	,
                                            "@Pro_Descricao"	,	Pro_Descricao,
                                            "@pro_clientenpcusto", pro_clientenpcusto,
                                            "@Pro_Juiz", Pro_Juiz
                                        );
        }

        public DataTable localizarPorNumero(string Pro_Numero)
        {
            DataTable dt;
            string sql = "SELECT Fun_Nome, Pro_Numero, Pro_Forum, pro_clientenpcusto, Pro_Vara, pro_Descricao, Pro_Tipo, pro_juiz, Pro_DataDistribuicao, Pro_Area, Pro_Local, Pro_NivelAcesso, Pro_Situacao, Fun_AdvResp  FROM Processos JOIN Funcionarios ON Funcionarios.Fun_codigo = Processos.fun_advresp " +
                " WHERE Pro_numero  =@Pro_Numero " +
                " ORDER BY Pro_Numero";
            banco.executeQuery(sql, out dt, "@Pro_Numero"	,	Pro_Numero	);
            return dt;
        }

        public bool verificaExistenciaProcesso(string Pro_Numero)
        {
            DataTable dt;
            string sql = "SELECT * FROM Processos " +
                " WHERE Pro_numero  = @Pro_Numero ";
            banco.executeQuery(sql, out dt, "@Pro_Numero", Pro_Numero);
            if(dt.Rows.Count != 0)
                return true;
            else
                return false;
        }
        
        public DataTable localizarAreaAtuacao(string Pro_Area)
        {
            DataTable dt;
            string sql = "SELECT Fun_Nome, Pro_Numero, Pro_Forum, pro_clientenpcusto, Pro_Vara, Pro_Tipo, Pro_DataDistribuicao, Pro_Area, Pro_Local, Pro_NivelAcesso, Pro_Situacao, Fun_AdvResp, pro_juiz, pro_Descricao  FROM Processos JOIN Funcionarios ON Funcionarios.Fun_codigo = Processos.fun_advresp" +
                         " WHERE Pro_Area LIKE @Pro_Area " +
                         " ORDER BY Pro_Area";
            Pro_Area += "%";
            banco.executeQuery(sql, out dt, "@Pro_Area"	, Pro_Area);
            return dt;
        }

        public DataTable listarProcessos()
        {
            DataTable dt;
            string sql = "SELECT Fun_Nome, Pro_Numero, Pro_Forum, Pro_Vara, pro_clientenpcusto, Pro_Tipo, Pro_DataDistribuicao, Pro_Area, Pro_Local, Pro_NivelAcesso, Pro_Situacao, Fun_AdvResp, pro_juiz, pro_Descricao  FROM Processos JOIN Funcionarios ON Funcionarios.Fun_codigo = Processos.fun_advresp";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable listarProcessosFuncionarios(string codigo)
        {
            DataTable dt;
            string sql = "SELECT Funcionarios.Fun_Nome, Funcionarios.Fun_codigo FROM  Processos_Funcionarios JOIN Funcionarios on Processos_Funcionarios.fun_codigo = Funcionarios.fun_codigo WHERE Pro_numero = @numero ";
            banco.executeQuery(sql, out dt,"@numero",codigo);
            return dt;
        }

        public DataTable listarProcessosClientes(string codigo)
        {
            DataTable dt;
            string sql = "SELECT Cli_Nome, Clientes.cli_codigo FROM  Processos_Clientes JOIN Clientes on Processos_Clientes.cli_codigo = Clientes.cli_codigo WHERE Pro_numero = @numero";
            banco.executeQuery(sql, out dt, "@numero", codigo);
            return dt;
        }

        public bool excluir(string Pro_Numero)
        {
            string sql;
            sql = "DELETE Processos WHERE Pro_Numero =  @Pro_Numero";
            return banco.executeNonQuery(sql, "@Pro_Numero", Pro_Numero);
        }

        public DataTable listarFuncionarios()
        {
            DataTable dt;
            string sql = "SELECT * FROM Funcionarios ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool associarFuncionariosProcesso(int codigoFuncionario, string numeroProcesso)
        {
            string sql;
            sql = "INSERT INTO Processos_Funcionarios (Pro_Numero, Fun_Codigo) VALUES (@Pro_Numero, @Fun_Codigo)";
            return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso, "@Fun_Codigo", codigoFuncionario);
        }

        public bool associarClientesProcesso(int codigoCliente, string numeroProcesso)
        {
            string sql;
            sql = "INSERT INTO Processos_Clientes (Pro_Numero, Cli_Codigo) VALUES (@Pro_Numero, @Cli_Codigo)";
            return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso, "@Cli_Codigo", codigoCliente);
        }

        public bool excluirAssociaFuncionarioProcesso(string numeroProcesso)
        {
            string sql;
            sql = "DELETE Processos_Funcionarios WHERE Pro_Numero =  @Pro_Numero  ";
            return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso);
        }

        public bool excluirAssociaClienteProcesso(string numeroProcesso)
        {
            string sql;
            sql = "DELETE Processos_Clientes WHERE Pro_Numero =  @Pro_Numero ";
            return banco.executeNonQuery(sql, "@Pro_Numero", numeroProcesso);
        }

        public bool verificaPermisaoInclusao(string Pro_Numero)
        {
            bool saida = false;
            DataTable dt;
            try
            {
                string sql = "SELECT pro_clientenpcusto FROM Processos where pro_numero = @pro_numero";
                banco.executeQuery(sql, out dt, "@pro_numero", Pro_Numero);
                if (dt.Rows[0]["pro_clientenpcusto"].ToString()[0] == 'S')
                    saida = true;
            }
            catch (Exception e)
            {
                saida = false;
            }
            return saida;
        }

        public string listarClientes(string Pro_Numero) 
        {
            DataTable dt;
            string saida = "";
            string sql = "SELECT Cli_Nome FROM  Processos_Clientes JOIN Clientes on Processos_Clientes.cli_codigo = Clientes.cli_codigo WHERE Pro_numero = @numero";
            banco.executeQuery(sql, out dt, "@numero", Pro_Numero);
            foreach(DataRow i in dt.Rows) 
            {
                saida = saida + i["cli_nome"].ToString() + ", ";
            }
            return saida;
        }


        ////Relatórios

        public DataTable listarProcessosR1()
        {
            DataTable dt;
            string sql = "SELECT Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Fun_Nome, Pro_Numero, Pro_Forum, Pro_Vara, pro_clientenpcusto, Pro_Tipo, Pro_DataDistribuicao, Pro_Area, Pro_Local, Pro_Situacao, pro_juiz, pro_Descricao  FROM empresa, Processos JOIN Funcionarios ON Funcionarios.Fun_codigo = Processos.fun_advresp";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable listarProcessosR23(bool modoAberto)
        {
            DataTable dt;
            string sql;
            if (modoAberto)
                 sql = " SELECT     Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, Processos.Pro_clientenpcusto, Processos.Pro_Tipo, "+
                        " Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, Processos.Pro_Juiz, Processos.Pro_Descricao " +
                       " FROM     empresa,    Processos INNER JOIN "+
                      " Funcionarios ON Funcionarios.Fun_Codigo = Processos.Fun_AdvResp RIGHT OUTER JOIN "+
                      " Pastas ON Pastas.Pro_Numero = Processos.Pro_Numero";
            else
                 sql = "SELECT     Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, Processos.Pro_clientenpcusto, Processos.Pro_Tipo, "+
                        " Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, Processos.Pro_Juiz, Processos.Pro_Descricao " +
                        " FROM  empresa, Pastas RIGHT OUTER JOIN "+
                        "   Processos ON Pastas.Pro_Numero = Processos.Pro_Numero INNER JOIN "+
                        "   Funcionarios ON Funcionarios.Fun_Codigo = Processos.Fun_AdvResp "+
                        " WHERE     (Pastas.Pro_Numero IS NULL)";
            banco.executeQuery(sql, out dt);
            return dt;
        }


        public DataTable listarProcessosGrCliR45(bool modoUnico, int? chave)
        {
            DataTable dt;
            string sql;
            if (modoUnico)
            {
                sql = " SELECT     Clientes.Cli_Nome, Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, Processos.Pro_clientenpcusto,  "+
"                      Processos.Pro_Tipo, Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, Processos.Pro_Juiz, "+
 "                  Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,  Processos.Pro_Descricao, COUNT(*) AS TOTAL " +
" FROM      empresa,    Processos INNER JOIN "+
"                      Funcionarios ON Funcionarios.Fun_Codigo = Processos.Fun_AdvResp INNER JOIN "+
 "                     Processos_Clientes ON Processos_Clientes.Pro_Numero = Processos.Pro_Numero INNER JOIN "+
  "                    Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo "+
 " WHERE     (Clientes.Cli_Codigo = @numero) "+
" GROUP BY Clientes.Cli_Codigo, Clientes.Cli_Nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, " +
  "                    Processos.Pro_clientenpcusto, Processos.Pro_Tipo, Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, "+
   "                   Processos.Pro_Juiz, Processos.Pro_Descricao";
                banco.executeQuery(sql, out dt, "@numero", chave);

            }
            else
            {

                sql = " SELECT     Clientes.Cli_Nome, Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, Processos.Pro_clientenpcusto, " +
             "         Processos.Pro_Tipo, Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, Processos.Pro_Juiz, "+
            "     Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Processos.Pro_Descricao, COUNT(*) AS TOTAL " +
" FROM   empresa,      Processos INNER JOIN "+
                      " Funcionarios ON Funcionarios.Fun_Codigo = Processos.Fun_AdvResp INNER JOIN "+
"                      Processos_Clientes ON Processos_Clientes.Pro_Numero = Processos.Pro_Numero INNER JOIN "+
 "                     Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo "+
" GROUP BY Clientes.Cli_Codigo, Clientes.Cli_Nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,Funcionarios.Fun_Nome, Processos.Pro_Numero, Processos.Pro_Forum, Processos.Pro_Vara, " +
 "                     Processos.Pro_clientenpcusto, Processos.Pro_Tipo, Processos.Pro_DataDistribuicao, Processos.Pro_Area, Processos.Pro_Local, Processos.Pro_Situacao, "+
  "                    Processos.Pro_Juiz, Processos.Pro_Descricao";
                banco.executeQuery(sql, out dt);
            }

            return dt;
        }








    }
}
