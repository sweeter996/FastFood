using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Configuration;

namespace DAO
{
    public class HP_SetConnect_DAO
    {
        string cnstr;
        public SqlConnection cn;
        public HP_SetConnect_DAO()
        {
            cnstr = System.Configuration.ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString; ;
            cn = new SqlConnection(cnstr);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public void DisConnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public SqlDataReader excuteNonquery(string query)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(query, cn);
            return cmd.ExecuteReader();
        }
        public int excuteNonquery(string query, CommandType type, List<SqlParameter> paras)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
                throw ex;
            }
        }

        public DataTable GetSelectDAO(string select, string from)
        {
            try
            {
                string query = "Select " + select + "From " + from;
                SqlDataAdapter adt = new SqlDataAdapter(query, cn);
                DataTable dtSelect = new DataTable();
                adt.Fill(dtSelect);
                return dtSelect;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                DisConnect();
            }

        }
        public int Lookup(string keyName, string field, string table)
        {
            Connect();
            string query = "Select Count(" + field + ") From " + table + " Where " + field + " = '" + keyName+"'";
            SqlCommand command = new SqlCommand(query, cn);
            command.Parameters.Add(new SqlParameter(field, keyName));
            int result = (int)command.ExecuteScalar();
            DisConnect();
            return result;
        }

    }
}
