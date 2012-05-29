using System;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;


namespace SAEA.Classes
{
    class Banco
    {
        private string strcon = @"Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\SAEA(Banco).sdf";
        private string strcon2 = @"Data Source=|DataDirectory|\SAEA(Banco).sdf";
        private SqlCeConnection con = null;
        private SqlCeTransaction trans = null;

        public bool conecta()
        {
            bool resultado = false;
            try
            {
                con = new SqlCeConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception ex)
            {
                try
                {
                    con = new SqlCeConnection(strcon2);
                    con.Open();
                    resultado = true;
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("{0} Exception Caught.", ex2);
                }
                //Console.WriteLine("{0} Exception Caught.", ex); 
            }
            return resultado;
        }

        public void desconecta() //con!=null existe uma conexao 
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public void beginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void commitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void rollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }
        //params combinação de dois valores [][]- 0 sera nome do parametro e outro valor
        public bool executeQuery(String sql, out DataTable dt, params Object[] parametros) //metodo que retorna v ou f joga pro adaptador e carrega no dataTable
        {
            dt = new DataTable();
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, con);
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
		
		public bool executeNonQuery(String sql, params Object[] parametros)//metodo com comando sql
        {
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(sql, con);
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery(); //não retorna dados so retorna se deu certo ou nao
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getIdentity()
        {
            SqlCeCommand cmd = new SqlCeCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }

        public int executeScalar(string sql)
        {
            SqlCeCommand cmd = new SqlCeCommand(sql, con);
            object o = cmd.ExecuteScalar();
            if (o != DBNull.Value)
                return (Convert.ToInt32(o) + 1);
            else
                return 1;
        }
    }
}
