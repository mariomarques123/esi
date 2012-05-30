using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class RelProcesso
    {
        Banco banco;

        public RelProcesso(Banco banco)
        {
            this.banco = banco;
        }

        public DataTable semfiltro()
        {
            DataTable dtt;

            string SQL = "SELECT " +
                         " Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF," +
                         " C.Cli_Nome, PO.Pro_Numero, PO.Pro_Forum, PO.Pro_Tipo, PO.Pro_Area, PO.Pro_Situacao, PO.Pro_Juiz, PO.Pro_Descricao" +
                         " FROM Processos PO, Processos_Clientes PC, Clientes C, Empresa" +
                         " WHERE PO.pro_numero = PC.pro_numero and C.cli_codigo = PC.cli_codigo";

            banco.executeQuery(SQL, out dtt);

            return dtt;
        }

        public DataTable porNome(string nome)
        {
            DataTable dtt;

            string SQL = "SELECT " +
                         " Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF," +
                         " C.Cli_Nome, PO.Pro_Numero, PO.Pro_Forum, PO.Pro_Tipo, PO.Pro_Area, PO.Pro_Situacao, PO.Pro_Juiz, PO.Pro_Descricao" +
                         " FROM Processos PO, Processos_Clientes PC, Clientes C, Empresa" +
                         " WHERE PO.pro_numero = PC.pro_numero and C.cli_codigo = PC.cli_codigo"+
                         " AND C.cli_nome like @nome";

            banco.executeQuery(SQL, out dtt, "@nome", "%"+nome+"%");

            return dtt;
        }

        public DataTable emPasta()
        {
            DataTable dtt;

            string SQL = "";

            banco.executeQuery(SQL, out dtt);

            return dtt;
        }

        public DataTable arquivado()
        {
            DataTable dtt;

            string SQL = "";
            banco.executeQuery(SQL, out dtt);

            return dtt;
        }
    }
}
