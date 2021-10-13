using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PRG282_Project
{
    class DataHandler
    {
        public DataHandler() { }

        #region Connection
        string conn = "Data Source=(LocalDB);Initial Catalog=BelgiumCampus;Integrated Security=True";

        #endregion

        #region DisplayModule
        public DataTable DisplayModule()
        {
            SqlConnection connection = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModule", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion

        #region AddModule
        public void InsertModule(string Code, string Name, string Description, string Link)
        {
            using(SqlConnection connection = new SqlConnection())
            {
                SqlCommand command = new SqlCommand("spAddModule", connection);
                command.Parameters.AddWithValue("@ModuleCode", Code);
                command.Parameters.AddWithValue("@ModuleName", Name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Link", Link);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        #endregion

        #region UpdateModule
        public void UpdateModule(string Code, string Name, string Description, string Link)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                SqlCommand command = new SqlCommand("spUpdateModule", connection);
                command.Parameters.AddWithValue("@ModuleCode", Code);
                command.Parameters.AddWithValue("@ModuleName", Name);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Link", Link);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        #endregion

        #region DeleteModule
        public void DeleteModule(string Code)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                SqlCommand command = new SqlCommand("spDeleteModule", connection);
                command.Parameters.AddWithValue("@ModuleCode", Code);
                ;
                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        #endregion

        #region SearchModule
        public DataTable SearchModule(string Code)
        {
            using(SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand("spSearchModule", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ModuleCode", Code);
                connection.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        #endregion
    }
}
