using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
class Pastas
{
    BancoM banco;

    public Pastas(BancoM banco)
    {
        this.banco = banco;
    }

    public bool incluir(int pro_numero, string pas_locpasta)
    {
        if (pro_numero == 0)
        {
            string SQL = "INSERT INTO Pastas (pas_locpasta) VALUES (@pas_locpasta)";

            return banco.executeNonQuery(SQL, "@pas_locpasta", pas_locpasta);
        }
        else
        {
            string SQL = "INSERT INTO Pastas (pro_numero,pas_locpasta) VALUES (@pro_numero,@pas_locpasta)";

            return banco.executeNonQuery(SQL,   "@pro_numero", pro_numero,
                                                "@pas_locpasta", pas_locpasta);
        }
    }

    public bool alterar(int pas_codigo, int pro_numero, string pas_locpasta)
    {
        if (pro_numero == 0)
        {
            string sql = "UPDATE Pastas " +
                            "   SET pas_locpasta = @pas_locpasta," +
                                    " pro_numero = null"+
                            " WHERE pas_codigo = @pas_codigo ";

            return banco.executeNonQuery(sql, "@pas_codigo", pas_codigo,
                                                "@pas_locpasta", pas_locpasta);
        }
        else
        {
            string sql = "UPDATE Pastas " +
                            "   SET pro_numero = @pro_numero," +
                            "       pas_locpasta = @pas_locpasta" +
                            " WHERE pas_codigo = @pas_codigo ";

            return banco.executeNonQuery(sql, "@pas_codigo", pas_codigo,
                                                "@pro_numero", pro_numero,
                                                "@pas_locpasta", pas_locpasta);
        }
    }

    public bool excluir(int pas_codigo)
    {
        string sql = "DELETE Pastas WHERE pas_codigo = @pas_codigo";

        return banco.executeNonQuery(sql, "@pas_codigo", pas_codigo);
    }
    
    public DataTable localizarLocalizacao(string localizacao)
    {
        DataTable dtt;

        string SQL =    "SELECT Pas.pas_codigo, Pro.pro_descricao, Pas.pas_locpasta, Pro.pro_numero" +
                        " FROM Pastas AS Pas CROSS JOIN Processos AS Pro" +
                        " WHERE (pas_locpasta LIKE @localizacao) AND (Pas.pro_numero = Pro.pro_numero)" +
                        " ORDER BY pas_locpasta";

        banco.executeQuery(SQL, out dtt, "@localizacao", localizacao + "%");

        return dtt;
    }
    
    public DataTable localizarCodigo(int pas_codigo)
    {
        DataTable dtt;

        string SQL = "SELECT Pas.pas_codigo,Pro.pro_descricao,Pas.pas_locpasta,Pro.pro_numero" +
                        " FROM Pastas AS Pas CROSS JOIN Processos AS Pro"+
                        " WHERE (Pas.pas_codigo = @pas_codigo) AND (Pas.pro_numero = Pro.pro_numero)"+
                        " ORDER BY pas_codigo";

        banco.executeQuery(SQL, out dtt, "@pas_codigo", pas_codigo);

        return dtt;
    }

    public DataTable processoemPasta(int pro_numero)
    {
        DataTable dtt;
        string SQL = "SELECT Pro_Numero FROM Pastas WHERE Pro_Numero = @pro_numero";
        banco.executeQuery(SQL, out dtt, "@pro_Numero", pro_numero);
        return dtt;
    }

    public DataTable pastasDisponiveis(int pro_numero)
    {
        DataTable dtt;
        string SQL = "SELECT pas_codigo,pro_numero FROM Pastas WHERE"+
                    " (pro_numero is NULL OR pro_numero = @pro_numero)";

        banco.executeQuery(SQL, out dtt, "@pro_numero", pro_numero);
        return dtt;
    }

    public bool alterarprocesso(int pas_codigo, int pro_numero)
    {
        string sql = "UPDATE Pastas" +
                        "   SET pro_numero = @pro_numero" +
                        " WHERE pas_codigo = @pas_codigo ";

        return banco.executeNonQuery(sql,   "@pas_codigo", pas_codigo,
                                            "@pro_numero", pro_numero);
    }
    public bool esvaziapasta(int pas_codigo)
    {
        string sql = "UPDATE Pastas" +
                        "   SET pro_numero = @pro_numero" +
                        " WHERE pas_codigo = @pas_codigo ";

        return banco.executeNonQuery(sql, "@pas_codigo", pas_codigo,
                                            "@pro_numero", DBNull.Value);
    }
}
}
