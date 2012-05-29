using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
class Usuarios
{
    BancoM banco;

    public Usuarios(BancoM banco)
    {
        this.banco = banco;
    }
        
    public bool incluir(string login, int nivelacesso, int funcod, string senha)
    {
        string sql = "INSERT INTO Usuarios" +
                    "        (usu_login,usu_nivelacesso,fun_codigo,usu_senha)" +
                    " VALUES (@login,@nivelacesso,@funcod,@senha) ";

        return banco.executeNonQuery(sql, "@login", login,
                                            "@nivelacesso", nivelacesso,
                                            "@funcod", funcod,
                                            "@senha", senha);
    }

    public bool alterar(string login, int nivelacesso, int funcod, string senha)
    {
        string sql = "UPDATE Usuarios " +
                        "   SET usu_nivelacesso = @nivelacesso," +
                        "       fun_codigo = @funcod," +
                        "       usu_senha = @senha" +
                        " WHERE usu_login = @login ";

        return banco.executeNonQuery(sql, "@login", login,
                                            "@nivelacesso", nivelacesso,
                                            "@funcod", funcod,
                                            "@senha", senha);
    }

    public bool alterarSenha(string login,string senha)
    {
        string sql = "UPDATE Usuarios " +
                        "   SET usu_senha = @senha" +
                        " WHERE usu_login = @login ";

        return banco.executeNonQuery(sql, "@login", login,
                                          "@senha", senha);
    }

    public bool excluir(string login)
    {
        string sql = "DELETE Usuarios WHERE usu_login = @login";

        return banco.executeNonQuery(sql, "@login", login);
    }

    public DataTable localizarPor(string coluna, string chave)
    {
        DataTable dtt = null;

        string SQL = "SELECT * FROM Usuarios" +
                        " WHERE " + coluna + " LIKE @chave" +
                        " ORDER BY " + coluna;

        banco.executeQuery(SQL, out dtt, "@chave", chave + "%");

        return dtt;
    }

    public DataTable localizarNivelAcesso(int nivelacesso)
    {
        DataTable dtt = null;
        string SQL = " SELECT U.usu_login, U.usu_nivelacesso, U.Fun_Codigo, U.usu_senha, F.Fun_Nome, 'Nivel' as usu_nomenivel" +
                        " FROM Usuarios AS U INNER JOIN Funcionarios AS F ON U.Fun_Codigo = F.Fun_Codigo" +
                        " WHERE U.usu_nivelacesso = @chave" +
                        " ORDER BY U.usu_nivelacesso";
        banco.executeQuery(SQL, out dtt, "@chave", nivelacesso);
        return dtt;
    }

    public DataTable localizarLogin(string login)
    {
        DataTable dtt = null;
        string SQL = " SELECT U.usu_login, U.usu_nivelacesso, U.Fun_Codigo, U.usu_senha, F.Fun_Nome, 'Nivel' as usu_nomenivel" +
                        " FROM Usuarios AS U INNER JOIN Funcionarios AS F ON U.Fun_Codigo = F.Fun_Codigo" +
                        " WHERE        (U.usu_login LIKE @chave)" +
                        " ORDER BY U.usu_login";

        banco.executeQuery(SQL, out dtt, "@chave", login + "%");
        return dtt;
    }

    public DataTable localizarLoginExato(string login)
    {
        DataTable dtt = null;
        string SQL = "SELECT * FROM Usuarios WHERE usu_nivelacesso LIKE @login ORDER BY usu_nivelacesso";
        banco.executeQuery(SQL, out dtt, "@login", login);
        return dtt;
    }
}
}
