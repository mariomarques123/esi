using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class CadastroCliente
    {
        Banco banco;

        public CadastroCliente(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string Cli_Nome	,string Cli_CPF	,string Cli_CNPJ	,string Cli_RG	,string Cli_Endereco	,string Cli_Numero	,string Cli_Bairro	,string Cli_CEP	,string Cli_Cidade	,string Cli_UF	,string Cli_Email	,string Cli_Telefone	,string Cli_TelefoneComercial	,string Cli_Celular	)
        {
            string sql;
            sql = "INSERT INTO Clientes (Cli_Nome	,Cli_CPF	,Cli_CNPJ	,Cli_RG	,Cli_Endereco	,Cli_Numero	,Cli_Bairro	,Cli_CEP	,Cli_Cidade	,Cli_UF	,Cli_Email	,Cli_Telefone	,Cli_TelefoneComercial	,Cli_Celular) " +
                    " VALUES (@Cli_Nome	,@Cli_CPF	,@Cli_CNPJ	,@Cli_RG	,@Cli_Endereco	,@Cli_Numero	,@Cli_Bairro	,@Cli_CEP	,@Cli_Cidade	,@Cli_UF	,@Cli_Email	,@Cli_Telefone	,@Cli_TelefoneComercial	,@Cli_Celular) ";

            return banco.executeNonQuery(sql,
                "@Cli_Nome", Cli_Nome,
                "@Cli_CPF", Cli_CPF,
                "@Cli_CNPJ", Cli_CNPJ,
                "@Cli_RG", Cli_RG,
                "@Cli_Endereco", Cli_Endereco,
                "@Cli_Numero", Cli_Numero,
                "@Cli_Bairro", Cli_Bairro,
                "@Cli_CEP", Cli_CEP,
                "@Cli_Cidade", Cli_Cidade,
                "@Cli_UF", Cli_UF,
                "@Cli_Email", Cli_Email,
                "@Cli_Telefone", Cli_Telefone,
                "@Cli_TelefoneComercial", Cli_TelefoneComercial,
                "@Cli_Celular", Cli_Celular
                );
        }

        public bool alterar(int codigo, string Cli_Nome, string Cli_CPF, string Cli_CNPJ, string Cli_RG, string Cli_Endereco, string Cli_Numero, string Cli_Bairro, string Cli_CEP, string Cli_Cidade, string Cli_UF, string Cli_Email, string Cli_Telefone, string Cli_TelefoneComercial, string Cli_Celular)
        {
 

            string sql;
            sql = "UPDATE Clientes SET 	Cli_Nome	=@Cli_Nome	,Cli_CPF	=@Cli_CPF	,Cli_CNPJ	=@Cli_CNPJ	,Cli_RG	=@Cli_RG	,Cli_Endereco	=	@Cli_Endereco	,Cli_Numero	=	@Cli_Numero	,Cli_Bairro	=	@Cli_Bairro	,Cli_CEP	=	@Cli_CEP	,Cli_Cidade	=	@Cli_Cidade	,Cli_UF	=	@Cli_UF	,Cli_Email	=	@Cli_Email	,Cli_Telefone	=	@Cli_Telefone	,Cli_TelefoneComercial	=	@Cli_TelefoneComercial	,Cli_Celular	=	@Cli_Celular " +
                    " WHERE Cli_Codigo	= @Cli_Codigo";

            return banco.executeNonQuery(sql,
                "@Cli_Codigo", codigo,
                "@Cli_Nome", Cli_Nome,
                "@Cli_CPF", Cli_CPF,
                "@Cli_CNPJ", Cli_CNPJ,
                "@Cli_RG", Cli_RG,
                "@Cli_Endereco", Cli_Endereco,
                "@Cli_Numero", Cli_Numero,
                "@Cli_Bairro", Cli_Bairro,
                "@Cli_CEP", Cli_CEP,
                "@Cli_Cidade", Cli_Cidade,
                "@Cli_UF", Cli_UF,
                "@Cli_Email", Cli_Email,
                "@Cli_Telefone", Cli_Telefone,
                "@Cli_TelefoneComercial", Cli_TelefoneComercial,
                "@Cli_Celular", Cli_Celular
                );
        }


        public DataTable localizarPorCodigo(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Clientes " +
                " WHERE Cli_Codigo = @Cli_Codigo" +
                " ORDER BY Cli_Codigo";
            banco.executeQuery(sql, out dt, "@Cli_Codigo",	codigo	);
            return dt;
        }

        public DataTable localizarPorNome(string nome)
        {
            DataTable dt;
            string sql = "SELECT * FROM Clientes" +
                         " WHERE Cli_Nome LIKE @Cli_Nome " +
                         " ORDER BY Cli_Nome";
            nome += "%";
            banco.executeQuery(sql, out dt, "@Cli_Nome", nome);
            return dt;
        }


        public DataTable listarTodas()
        {
            DataTable dt;
            string sql = "SELECT * FROM Clientes ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public bool excluir(int codigo)
        {
            string sql;
            sql = "DELETE Clientes WHERE Cli_Codigo = @Cli_Codigo";
            return banco.executeNonQuery(sql, "@Cli_Codigo", codigo);
        }

        //relatorio

        public DataTable listarR12(bool andamento)
        {
            DataTable dt;
            string sql;
            if(andamento) 
                sql = "SELECT     Clientes.Cli_Codigo, Clientes.Cli_Nome, Clientes.Cli_CPF, Clientes.Cli_CNPJ, Clientes.Cli_RG, Clientes.Cli_Endereco, Clientes.Cli_Numero, Clientes.Cli_Bairro, "+
                        "          Clientes.Cli_CEP, Clientes.Cli_Cidade, Clientes.Cli_UF, Clientes.Cli_Email, Clientes.Cli_Telefone, Clientes.Cli_TelefoneComercial, Clientes.Cli_Celular,  Emp_nome, Emp_CNPJ,  Emp_telefone, Emp_CEP, Emp_endereco, Emp_email, Emp_numero, Emp_UF, Emp_Cidade " +
                        " FROM         Clientes INNER JOIN "+
                        "                    Processos_Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo INNER JOIN "+
                        "                   Pastas ON Pastas.Pro_Numero = Processos_Clientes.Pro_Numero, empresa";
            else
                sql = "SELECT * FROM Clientes, empresa ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable listarR34(bool agrupado, string chave)
        {
            DataTable dt;
            string sql;
            if(agrupado)
                sql = "SELECT     Clientes.Cli_Codigo, Clientes.Cli_Nome, Clientes.Cli_CPF, Clientes.Cli_CNPJ, Clientes.Cli_RG, Clientes.Cli_Endereco, Clientes.Cli_Numero, Clientes.Cli_Bairro, "+
                        "      Clientes.Cli_CEP, Clientes.Cli_Cidade, Clientes.Cli_UF, Clientes.Cli_Email, Clientes.Cli_Telefone, Clientes.Cli_TelefoneComercial, Clientes.Cli_Celular, Emp_nome, Emp_CNPJ,  Emp_telefone, Emp_CEP, Emp_endereco, Emp_email, Emp_numero, Emp_UF, Emp_Cidade, COUNT(*)  " +
                        "               AS total "+
                        " FROM        empresa, Clientes INNER JOIN "+
                        "                    Processos_Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo INNER JOIN "+
                        "                    Pastas ON Pastas.Pro_Numero = Processos_Clientes.Pro_Numero "+
                        " GROUP BY Clientes.Cli_Cidade, Clientes.Cli_Codigo, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade, Clientes.Cli_Nome, Clientes.Cli_CPF, Clientes.Cli_CNPJ, Clientes.Cli_RG, Clientes.Cli_Endereco, Clientes.Cli_Numero, " +
                        "              Clientes.Cli_Bairro, Clientes.Cli_CEP, Clientes.Cli_UF, Clientes.Cli_Email, Clientes.Cli_Telefone, Clientes.Cli_TelefoneComercial, Clientes.Cli_Celular ";
            else
                sql = "SELECT     Clientes.Cli_Codigo, Clientes.Cli_Nome, Clientes.Cli_CPF, Clientes.Cli_CNPJ, Clientes.Cli_RG, Clientes.Cli_Endereco, Clientes.Cli_Numero, Clientes.Cli_Bairro,  "+
                            "                      Clientes.Cli_CEP, Clientes.Cli_Cidade, Clientes.Cli_UF, Clientes.Cli_Email, Clientes.Cli_Telefone, Clientes.Cli_TelefoneComercial, Clientes.Cli_Celular, Emp_nome, Emp_CNPJ,  Emp_telefone, Emp_CEP, Emp_endereco, Emp_email, Emp_numero, Emp_UF, Emp_Cidade, COUNT(*)  " +
                            "                      AS total "+
                            " FROM      empresa,   Clientes INNER JOIN "+
                            "                     Processos_Clientes ON Clientes.Cli_Codigo = Processos_Clientes.Cli_Codigo INNER JOIN "+
                            "                     Pastas ON Pastas.Pro_Numero = Processos_Clientes.Pro_Numero "+
                            " WHERE     (Clientes.Cli_Cidade = @chave) "+
                            " GROUP BY Clientes.Cli_Cidade, Clientes.Cli_Codigo, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero, Empresa.Emp_UF, Empresa.Emp_Cidade,Clientes.Cli_Nome, Clientes.Cli_CPF, Clientes.Cli_CNPJ, Clientes.Cli_RG, Clientes.Cli_Endereco, Clientes.Cli_Numero, " +
                            "                    Clientes.Cli_Bairro, Clientes.Cli_CEP, Clientes.Cli_UF, Clientes.Cli_Email, Clientes.Cli_Telefone, Clientes.Cli_TelefoneComercial, Clientes.Cli_Celular ";
            banco.executeQuery(sql, out dt, "@chave", chave);
            return dt;
        }
    }
}
