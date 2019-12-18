using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public class DBCommunication : IDisposable
    {
        private readonly string _username = "root";
        private readonly string _password = "ch@ng!ng_th!s_W0R1D";
        private readonly string _server = "localhost";
        private readonly string _database = "school_management_system";

        private readonly MySqlConnection _connection;

        private event ExecuteQueryWithoutClassInstance ExecuteEvent;

        public DBCommunication()
        {
            try
            {
                _connection = new MySqlConnection($@"Server={_server};UserId={_username};Password={_password};Database={_database}");
                _connection.Open();

                this.ExecuteEvent += new ExecuteQueryWithoutClassInstance(this.ExecuteQuery);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<List<string>> InvokeEvent(bool parameters, string query, Dictionary<string, string> list, bool returnValues)
        {
            return ExecuteEvent?.Invoke(parameters, query, list, returnValues);
        }

        protected List<List<string>> ExecuteQuery(bool parameters, string query, Dictionary<string, string> list, bool returnValues)
        {
            try
            {
                List<List<string>> returnList = new List<List<string>>();

                MySqlCommand command = new MySqlCommand(query, _connection);

                if (parameters)
                {
                    foreach (var pair in list)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                }

                if (returnValues)
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        List<string> rowList = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rowList.Add(reader.GetString(i));
                        }
                        returnList.Add(rowList);
                    }

                    reader.Close();
                }
                else
                    command.ExecuteNonQuery();

                return returnList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        protected List<List<string>> ExecuteQuery(string query, bool returnValues)
        {
            try
            {
                List<List<string>> returnList = new List<List<string>>();

                MySqlCommand command = new MySqlCommand(query, _connection);

                if (returnValues)
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        List<string> rowList = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rowList.Add(reader.GetString(i));
                        }

                        returnList.Add(rowList);
                    }

                    reader.Close();
                }
                else
                    command.ExecuteNonQuery();

                return returnList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public List<string> GetTableColumnsNames(string table)
        {
            try
            {
                List<string> columnNames = new List<string>();

                string query = $"SELECT * FROM `{table}` WHERE `id` = 1;";
                MySqlCommand command = new MySqlCommand(query, _connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    for (int i = 0; i < reader.FieldCount; i++)
                        columnNames.Add(reader.GetName(i));

                reader.Close();

                return columnNames;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public void Dispose()
        {
            _connection.Close();
        }

        ~DBCommunication()
        {
            _connection.Close();
        }
    }
}