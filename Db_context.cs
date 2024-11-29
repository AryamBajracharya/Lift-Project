using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lift_Project

    // handles the connection to a Sql Server
{
    internal class Db_context
    {
        private string connectionString = @"Server=MSI; Database=aryam; Trusted_Connection=True;";

        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Logs(LogTime, EventDescription) VALUES(@Time, @Logs)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter()) //SqlData Adapter for mapping columns from DataTable (Time and Events)
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Logs", SqlDbType.NVarChar, 255, "Events");

                        conn.Open();
                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB: " + ex.Message);
            }
        }

        public void LoadLogsfromDB(DataTable dt, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT LogTime, EventDescription FROM Logs ORDER BY LogTime DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn)) // SqlDataAdapter to fill DataTable with query and updates DataGridView
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);
                        dataGridView.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();
                            dataGridView.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);
            }
        }

        // For clearing the Datable and DataGridView
        public void DeleteAllLogs(DataTable dt, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Logs";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        dt.Clear();
                        dataGridView.Rows.Clear();
                        MessageBox.Show("All records have been deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting records: " + ex.Message);
            }
        }
    }
}
