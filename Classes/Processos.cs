using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class Processos
    {
        BancoM banco;

        public Processos(BancoM banco)
        {
            this.banco = banco;
        }

        public DataTable localizarPor(string coluna, string chave)
        {
            DataTable dtt;

            string SQL = "SELECT * FROM Processos" +
                            " WHERE " + coluna + " LIKE @chave" +
                            " ORDER BY " + coluna;

            banco.executeQuery(SQL, out dtt, "@chave", chave + "%");

            return dtt;
        }
    }
}
