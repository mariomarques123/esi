using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
class FuncionariosAlter
{
    Banco banco;

    public FuncionariosAlter(Banco banco)
    {
        this.banco = banco;
    }
        
    public bool incluir(string nome, string rg, string cpf, char tipo, string telefone, string celular, string email, string endereco, string numero, string cidade, string bairro)
    {
        string sql = "INSERT INTO Funcionarios" +
                    "        (fun_nome,fun_rg,fun_cpf,fun_tipo,fun_telefone,fun_celular,fun_email,fun_endereco,fun_numero,fun_cidade,fun_bairro)" +
                    " VALUES (@nome,@rg,@cpf,@tipo,@telefone,@celular,@email,@endereco,@numero,@cidade,@bairro) ";

        return banco.executeNonQuery(sql,   "@nome", nome,
                                            "@rg", rg,
                                            "@cpf", cpf,
                                            "@tipo", tipo,
                                            "@telefone", telefone,
                                            "@celular", celular,
                                            "@email", email,
                                            "@endereco", endereco,
                                            "@numero", numero,
                                            "@cidade", cidade,
                                            "@bairro", bairro);
    }

    public bool alterar(int codigo,string nome, string rg, string cpf, char tipo, string telefone, string celular, string email, string endereco, string numero, string cidade, string bairro)
    {
        string sql = "UPDATE Funcionarios " +
                        "   SET fun_nome = @nome," +
                        "       fun_rg = @rg," +
                        "       fun_cpf = @cpf," +
                        "       fun_tipo = @tipo," +
                        "       fun_telefone = @telefone," +
                        "       fun_celular = @celular," +
                        "       fun_email = @email," +
                        "       fun_endereco = @endereco," +
                        "       fun_numero = @numero," +
                        "       fun_cidade = @cidade," +
                        "       fun_bairro = @bairro" +
                        " WHERE fun_codigo = @codigo ";

        return banco.executeNonQuery(sql, "@codigo",codigo,
                                            "@nome", nome,
                                            "@rg", rg,
                                            "@cpf", cpf,
                                            "@tipo", tipo,
                                            "@telefone", telefone,
                                            "@celular", celular,
                                            "@email", email,
                                            "@endereco", endereco,
                                            "@numero", numero,
                                            "@cidade", cidade,
                                            "@bairro", bairro);
    }

    public bool excluir(int codigo)
    {
        string sql = "DELETE Funcionarios WHERE fun_codigo = @codigo";

        return banco.executeNonQuery(sql, "@codigo", codigo);
    }

    public DataTable localizarPor(string coluna, string chave)
    {
        DataTable dtt;

        string SQL = "SELECT * FROM Funcionarios" +
                        " WHERE " + coluna + " LIKE @chave" +
                        " ORDER BY " + coluna;

        banco.executeQuery(SQL, out dtt, "@chave", chave + "%");

        return dtt;
    }
}
}
