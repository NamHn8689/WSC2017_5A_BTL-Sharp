using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnect
    {
        // class chua ket noi toi db, cac class khac se ke thu lai
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=localhost;Initial Catalog=Session5;Integrated Security=True");
        }
        protected DataTable GetTable(string selectCommand)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        protected void ExcuteNonQuery(string cmdText)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();
        }
    }
}
