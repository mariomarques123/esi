using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
class DocumentoDigital
{
    BancoM banco;

    public DocumentoDigital(BancoM banco)
    {
        this.banco = banco;
    }

    public bool incluir(int pro_numero, string dod_localizacao, string dod_descricao)
    {
        string SQL = "INSERT INTO Documento_digital"+
                    " (pro_numero,dod_localizacao,dod_descricao) VALUES (@pro_numero,@dod_localizacao,@dod_descricao)";

        return banco.executeNonQuery(SQL,   "@pro_numero", pro_numero,
                                            "@dod_localizacao", dod_localizacao,
                                            "@dod_descricao",dod_descricao);
    }

    public bool alterar(int dod_codigo, string dod_localizacao, string dod_descricao)
    {
        string sql = "UPDATE Documento_digital " +
                            "  SET  dod_localizacao = @dod_localizacao," +
                            "       dod_descricao = @dod_descricao"+
                            " WHERE dod_codigo = @dod_codigo";

        return banco.executeNonQuery(sql,   "@dod_codigo", dod_codigo,
                                            "@dod_localizacao", dod_localizacao,
                                            "@dod_descricao", dod_descricao);
    }

    public bool excluirAnexo(int dod_codigo, int pro_numero)
    {
        string sql = "DELETE Documento_digital WHERE dod_codigo = @dod_codigo AND pro_numero = @pro_numero";

        return banco.executeNonQuery(sql, "@dod_codigo",dod_codigo,
                                          "@pro_numero", pro_numero);
    }

    public DataTable localizarPor(string coluna, int codigo)
    {
        DataTable dtt;
        string SQL = "SELECT * FROM Documento_digital WHERE " + coluna + " = @codigo ORDER BY "+coluna;
        banco.executeQuery(SQL, out dtt, "@codigo", codigo);
        return dtt;
    }
}
}
