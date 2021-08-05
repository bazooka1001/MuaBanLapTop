using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Demo1.DB_Layer
{
    class DBMain
    {
        string strConnectionString = "Data Source=DESKTOP-TQC863O;Initial Catalog=DoAnBanLaptop;Integrated Security=True";
     /*       "Data Source=DESKTOP-342LFLL;" +
        "Initial Catalog=DoAnBanLaptop;" +
        "Integrated Security=True";*/

        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(strConnectionString);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public int MyExecuteScalar(string strSQL, CommandType ct, ref string error)
        {
            int k = 0;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                k = Int32.Parse(comm.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return k;
        }

        public SqlDataReader MyExecuteReader(string strSQL)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataReader dataReader = null;
            comm.CommandText = strSQL;
            dataReader = comm.ExecuteReader();
            
            return dataReader;
        }
        public DataSet MyLoadDataCmb(string B, string SqlString, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = SqlString;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, B);
            return ds;
        }
        public int ExecuteScalarInt(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            int s = (int)comm.ExecuteScalar();
            return s;
        }
    }
}
