using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionareParcari.Utils
{
    internal static class DatabaseHelper
    {
        private static string connectionString = "Server=DESKTOP-T924N09;Database=ParcariDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static void SetConnectionString(string conn)
        {
            connectionString = conn;
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();

                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();

                return cmd.ExecuteScalar();
            }
        }
    }
}
