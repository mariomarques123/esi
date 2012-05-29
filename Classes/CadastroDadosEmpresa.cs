using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace SAEA.Classes
{
    class CadastroDadosEmpresa
    {

        Banco banco;

        public CadastroDadosEmpresa(Banco banco)
        {
            this.banco = banco;
        }

        public bool incluir(string nome, string cnpj, string descricao, string telefone, string cep, string endereco, byte[] logo, string email, string numero, string celular1, string celular2, string uf, string bairro, string cidade)
        {
            string sql;
            sql = "INSERT INTO Empresa (emp_nome, emp_cnpj, emp_descricao, emp_telefone, emp_cep, emp_endereco, emp_logo, emp_email, emp_numero, emp_celular1, emp_celular2, emp_uf, emp_bairro, emp_cidade) " +
                    " VALUES (@emp_nome, @emp_cnpj, @emp_descricao, @emp_telefone, @emp_cep, @emp_endereco, @emp_logo, @emp_email, @emp_numero, @emp_celular1, @emp_celular2, @emp_uf, @emp_bairro, @emp_cidade) ";

            if(logo == null)
                return banco.executeNonQuery(sql,
                "@emp_nome", nome,
                "@emp_cnpj", cnpj,
                "@emp_descricao", descricao,
                "@emp_telefone", telefone,
                "@emp_cep", cep,
                "@emp_endereco",endereco,
                "@emp_logo", DBNull.Value,
                "@emp_email", email,
                "@emp_numero", numero,
                "@emp_celular1", celular1,
                "@emp_celular2", celular2,
                "@emp_uf", uf,
                "@emp_bairro", bairro,
                "@emp_cidade", cidade
                );
            else
                return banco.executeNonQuery(sql,
                "@emp_nome", nome,
                "@emp_cnpj", cnpj,
                "@emp_descricao", descricao,
                "@emp_telefone", telefone,
                "@emp_cep", cep,
                "@emp_endereco",endereco,
                "@emp_logo", logo,
                "@emp_email", email,
                "@emp_numero", numero,
                "@emp_celular1", celular1,
                "@emp_celular2", celular2,
                "@emp_uf", uf,
                "@emp_bairro", bairro,
                "@emp_cidade", cidade
                );
        }

        public bool alterar(int codigo, string nome, string cnpj, string descricao, string telefone, string cep, string endereco, byte[] logo, string email, string numero, string celular1, string celular2, string uf, string bairro, string cidade)
        {

            string sql;
            sql = "UPDATE Empresa SET "+
            "emp_nome=@emp_nome,                   " +
            "emp_cnpj=@emp_cnpj,                   " +
            "emp_descricao= @emp_descricao,        " +
            "emp_telefone = @emp_telefone,         " +
            "emp_cep= @emp_cep,                    " +
            "emp_endereco=@emp_endereco,           " +
            "emp_logo=@emp_logo ,                  " +
            "emp_email=@emp_email,                 " +
            "emp_numero=@emp_numero,               " +
            "emp_celular1=@emp_celular1,           " +
            "emp_celular2=@emp_celular2,           " +
            "emp_uf=@emp_uf,                       " +
            "emp_cidade = @emp_cidade, " +
            "emp_bairro=@emp_bairro" +
                    " WHERE emp_cod = @emp_cod";

            if (logo == null)
                return banco.executeNonQuery(sql,
                    "@emp_cod", codigo,
                    "@emp_nome", nome,
                    "@emp_cnpj", cnpj,
                    "@emp_descricao", descricao,
                    "@emp_telefone", telefone,
                    "@emp_cep", cep,
                    "@emp_endereco", endereco,
                    "@emp_logo", DBNull.Value,
                    "@emp_email", email,
                    "@emp_numero", numero,
                    "@emp_celular1", celular1,
                    "@emp_celular2", celular2,
                    "@emp_uf", uf,
                    "@emp_bairro", bairro,
                    "@emp_cidade", cidade
                    );
            else
                return banco.executeNonQuery(sql,
                "@emp_cod", codigo,
                "@emp_nome", nome,
                "@emp_cnpj", cnpj,
                "@emp_descricao", descricao,
                "@emp_telefone", telefone,
                "@emp_cep", cep,
                "@emp_endereco", endereco,
                "@emp_logo", logo,
                "@emp_email", email,
                "@emp_numero", numero,
                "@emp_celular1", celular1,
                "@emp_celular2", celular2,
                "@emp_uf", uf,
                "@emp_bairro", bairro,
                "@emp_cidade", cidade
                );
        }


        public DataTable buscar()
        {
            DataTable dt;
            string sql = "SELECT * FROM Empresa ";
            banco.executeQuery(sql, out dt);
            return dt;
        }

        public DataTable buscar(int codigo)
        {
            DataTable dt;
            string sql = "SELECT * FROM Empresa " +
                " WHERE emp_cod = @emp_cod";
            banco.executeQuery(sql, out dt, "@emp_cod", codigo);
            return dt;
        }

        public bool verificaPrimeiroAcesso()
        {
            DataTable dt;
            string sql = "SELECT * FROM Empresa";
            banco.executeQuery(sql, out dt);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
    }
}
