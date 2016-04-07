using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace SDIT.DBHelper
{
    public class OracleDataAccess : IDataAccess
    {
        string InitedConnectionString = "";
        public OracleDataAccess()
        {

        }

        public OracleDataAccess(string connStr)
        {
            this.InitedConnectionString = connStr;
        }

        public DataTable GetDataTable(string sql, string connectionString)
        {
            try
            {
                OracleDataAdapter oda = new OracleDataAdapter(sql, connectionString);
                DataTable dt = new DataTable();
                oda.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Excute(string sql, string connectionString)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = new OracleCommand(sql, conn);

                    conn.Open();

                    int r = cmd.ExecuteNonQuery();

                    conn.Close();

                    return r >= 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
