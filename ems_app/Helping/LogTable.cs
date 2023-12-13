using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_app.Helping
{
    public class LogTable
    {
        public static void LogExceptionToDatabase(string errorMessage, string stackTrace, string additionalInfo)
        {
            // Your configuration class - replace this with your actual implementation
            Configuration configuration = Configuration.getInstance();
            string connectionString = configuration.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "LogException";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ErrorMessage", errorMessage);
                    command.Parameters.AddWithValue("@StackTrace", stackTrace);
                    command.Parameters.AddWithValue("@AdditionalInfo", additionalInfo);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
