using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Itec_Mangement
{
    public class EventManager
    {
        public static bool AddEvent(string name, string description, string location)
        {
            try
            {
                // Check if fields are empty
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) ||
                    string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // SQL Query to insert data
                string query = $"INSERT INTO itec_editions VALUES ('{2}', '{2}', '{name}', '{description}')";

                // Execute the query
                int rowsAffected = DatabaseHelper.Instance.Update(query);

                // Return true if insertion was successful
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
