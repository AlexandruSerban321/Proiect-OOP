using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form2 : Form
    {
        private Database database;

        public Form2()
        {
            InitializeComponent();
            database = new Database();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (SQLiteCommand command = new SQLiteCommand(query, database.Connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                database.Connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    // Username and password match a row in the database
                    MessageBox.Show("Login successful!");

                    // Close the connection after use in the first query
                    database.Connection.Close();

                    // Get the user's roles
                    var roles = GetUserRoles(username);

                    // Check if the user has the 'admin' role
                    if (roles.Contains("admin"))
                    {
                        adminView admin = new adminView();
                        admin.Show();
                        this.Hide();
                    }

                    // Check if the user has the 'secretar' role
                    if (roles.Contains("secretar"))
                    {
                        // User is a secretar
                        secretarView secreatarForm = new secretarView();
                        secreatarForm.Show();
                        this.Hide();
                    }

                    // Check if the user has the 'cadru_didactic' role
                    if (roles.Contains("cadru_didactic"))
                    {
                        // User is a cadru_didactic
                        MessageBox.Show("User is considered profesor!");
                    }
                }
                else
                {
                    // Username and password do not match
                    MessageBox.Show("Invalid username or password!");
                }

                // Close the connection after use in the second query
                database.Connection.Close();
            }
        }

        private List<string> GetUserRoles(string username)
        {
            string query = "SELECT secretar, cadru_didactic, administrator FROM users WHERE username = @username";

            using (SQLiteCommand command = new SQLiteCommand(query, database.Connection))
            {
                command.Parameters.AddWithValue("@username", username);
                database.Connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        List<string> roles = new List<string>();

                        if (Convert.ToInt32(reader["secretar"]) == 1)
                            roles.Add("secretar");

                        if (Convert.ToInt32(reader["cadru_didactic"]) == 1)
                            roles.Add("cadru_didactic");

                        if (Convert.ToInt32(reader["administrator"]) == 1)
                            roles.Add("admin");

                        return roles;
                    }
                }
            }

            return new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    internal class Database
    {
        public SQLiteConnection Connection;

        public Database()
        {
            Connection = new SQLiteConnection("Data Source=UniCatalog.sqlite3");
            if (!File.Exists("UniCatalog.sqlite3"))
            {
                SQLiteConnection.CreateFile("UniCatalog.sqlite3");
                Console.WriteLine("Database file created");
            }
        }
    }
}
