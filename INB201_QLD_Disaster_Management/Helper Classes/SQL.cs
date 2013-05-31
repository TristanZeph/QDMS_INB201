using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace INB201_QLD_Disaster_Management.Helper_Classes {
    /// <summary>
    /// This class handles the execution of database interaction.
    /// It allows DB connection and query functions.
    /// </summary>
    public class SQL {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Column names in the incident datatable
        public readonly string[]
            columnNameIncident = { "id", "address", "status", 
                                   "type", "latitude", "longitude", 
                                   "warnings", "start_date", "end_date" };

        // column names in the personnel datatable
        public readonly string[]
            columnNamePersonnel = { "id", "first_name", "last_name", 
                                    "type", "status", "working_hours", 
                                    "start_time", "end_time", "incident_id" };
        /// <summary>
        /// Construct the SQL object and initialise the database connection.
        /// </summary>
        public SQL() {
            Initialize();
        }

        /// <summary>
        /// Initialise the database connection
        /// </summary>
        private void Initialize() {
            server = "localhost";
            database = "incidentdb";
            uid = "root";
            password = "password";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + 
                                "DATABASE=" + database + ";" + 
                                "UID=" + uid + ";" + 
                                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open Connection to DB
        /// </summary>
        /// <returns>true if connection succeeds, else false</returns>
        private bool OpenConnection() {
            try {
                connection.Open();
                return true;
            } catch (MySqlException ex) {
                /* Display an error message if we fail to connect to the database.
                 * Error 0: Cannot connect to server.
                 * Error 1045: Invalid username and/or password. */
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Close the DB connection
        /// </summary>
        /// <returns>true if successful, else false</returns>
        private bool CloseConnection() {
            try {
                connection.Close();
                return true;
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Inserts data values based on the query passed
        /// </summary>
        public void Insert(string query) {
            if (this.OpenConnection() == true) {
                try {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                } catch (MySqlException ex) {
                    MessageBox.Show(ex.Message);
                    this.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Updates data values based on the query
        /// </summary>
        public void Update(string query) {
            if (this.OpenConnection() == true) {
                try {
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                } catch (MySqlException ex) {
                    MessageBox.Show(ex.Message);
                    this.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Delete data values based on the query
        /// </summary>
        public void Delete(string query) {
            if (this.OpenConnection() == true) {
                try {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                } catch (MySqlException ex) {
                    MessageBox.Show(ex.Message);
                    this.CloseConnection();
                }
            }
        }


        /// <summary>
        /// Select function that returns values from the incident table
        /// </summary>
        public List<string>[] SelectIncident(string query) {
            //Create a list to store the result
            List<string>[] list = new List<string>[columnNameIncident.Count()];
            for (int i = 0; i < list.Count(); i++)
                list[i] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true) {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read()) {
                    for (int i = 0; i < columnNameIncident.Count(); i++) {
                        string column = columnNameIncident[i];
                        list[i].Add(dataReader[column] + "");
                    }
                }

                // clean up
                dataReader.Close();
                this.CloseConnection();

                //return list to be displayed
                return list;
            } else {
                return list;
            }
        }

        /// <summary>
        /// Select function that returns values from the 
        /// personnel table
        /// </summary>
        public List<string>[] SelectPersonnel(string query) {
            //Create a list to store the result
            List<string>[] list = new List<string>[columnNamePersonnel.Count()];
            for (int i = 0; i < list.Count(); i++)
                list[i] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true) {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read()) {
                    for (int i = 0; i < columnNamePersonnel.Count(); i++) {
                        string column = columnNamePersonnel[i];
                        list[i].Add(dataReader[column] + "");
                    }
                }

                //clean up
                dataReader.Close();
                this.CloseConnection();

                //return list to be displayed
                return list;
            } else {
                return list;
            }
        }

        /// <summary>
        /// Returns a count based on the query passed
        /// </summary>
        public int Count(string query) {
            int Count = 0;

            //Open Connection
            if (this.OpenConnection() == true) {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            } else {
                return Count;
            }
        }
    }
}
