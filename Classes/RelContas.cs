using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SAEA.Classes
{
    class RelContas
    {
        Banco banco;

        public RelContas(Banco banco)
        {
            this.banco = banco;
        }

        public DataTable semFiltro()
        {
            DataTable dtt;

            string SQL = "SELECT P.cop_descricao, P.cop_dataVenc, P.cop_valor, P.cop_dataPag, F.fun_nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                          " FROM ContasPagar P, Funcionarios F, Empresa"+
                          " WHERE P.Fun_Codigo = F.Fun_Codigo"+
                          " ORDER BY P.cop_dataVenc";

            banco.executeQuery(SQL, out dtt);

            return dtt;
        }

        public DataTable porDataVenc(DateTime ini, DateTime fim)
        {
            DataTable dtt;

            string SQL = "SELECT P.cop_descricao, P.cop_dataVenc, P.cop_valor, P.cop_dataPag, F.fun_nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                          " FROM ContasPagar P, Funcionarios F, Empresa" +
                          " WHERE P.Fun_Codigo = F.Fun_Codigo AND (P.cop_dataVenc BETWEEN @ini AND @fim)" +
                          " ORDER BY P.cop_dataVenc";

            banco.executeQuery(SQL, out dtt, "@ini", ini,
                                            "@fim", fim);

            return dtt;
        }

        public DataTable porPagas(string situacao)
        {
            DataTable dtt;

            string SQL = "SELECT P.cop_descricao, P.cop_dataVenc, P.cop_valor, P.cop_dataPag, F.fun_nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                          " FROM ContasPagar P, Funcionarios F, Empresa" +
                          " WHERE P.Fun_Codigo = F.Fun_Codigo";
                        if (situacao.ToUpper() == "PAGA")
                            SQL += " AND P.cop_dataPag is NOT NULL";
                        else if (situacao.ToUpper() == "NÃO PAGA")
                            SQL += " AND P.cop_dataPag is NULL";
                         SQL += " ORDER BY P.cop_dataVenc";

            banco.executeQuery(SQL, out dtt);

            return dtt;
        }

        public DataTable porDataVencPagas(DateTime ini, DateTime fim,string situacao)
        {
            DataTable dtt;

            string SQL = "SELECT P.cop_descricao, P.cop_dataVenc, P.cop_valor, P.cop_dataPag, F.fun_nome, Empresa.Emp_nome, Empresa.Emp_CNPJ, Empresa.Emp_telefone, Empresa.Emp_CEP, Empresa.Emp_endereco, Empresa.Emp_email, Empresa.Emp_numero,Empresa.Emp_cidade,Empresa.emp_UF" +
                          " FROM ContasPagar P, Funcionarios F, Empresa" +
                          " WHERE P.Fun_Codigo = F.Fun_Codigo AND (P.cop_dataVenc BETWEEN @ini AND @fim)";
                        if (situacao.ToUpper() == "PAGA")
                            SQL += " AND P.cop_dataPag is NOT NULL";
                        else if (situacao.ToUpper() == "NÃO PAGA")
                            SQL += " AND P.cop_dataPag is NULL";
                        SQL += " ORDER BY P.cop_dataVenc";

            banco.executeQuery(SQL, out dtt, "@ini", ini,
                                             "@fim", fim);

            return dtt;
        }
    }
}
