using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace SchoolManagementSystem
{
    public class SelectDataFromDataBase
    {
        public static Dictionary<string, string> SelectSubjectList()
        {
            Dictionary<string, string> returnDictionary = new Dictionary<string, string>();
            using (DBCommunication db = new DBCommunication())
            {
                var result = db.InvokeEvent(false, "SELECT * FROM `subjects`;", null, true);
                foreach (var list in result)
                {
                    returnDictionary.Add(list[0], list[1]);
                }
            }

            return returnDictionary;
        }

        public static Dictionary<string, string> SelectCabinetList()
        {
            Dictionary<string, string> returnDictionary = new Dictionary<string, string>();
            using (DBCommunication db = new DBCommunication())
            {
                var result = db.InvokeEvent(false, "SELECT * FROM `cabinets`;", null, true);
                foreach (var list in result)
                {
                    returnDictionary.Add(list[0], list[1]);
                }
            }

            return returnDictionary;
        }

        public static Dictionary<string, string> SelectGroupList()
        {
            Dictionary<string, string> returnDictionary = new Dictionary<string, string>();
            using (DBCommunication db = new DBCommunication())
            {
                var result = db.InvokeEvent(false, "SELECT `id`, `group_name` FROM `groups`;", null, true);
                foreach (var list in result)
                {
                    returnDictionary.Add(list[0], list[1]);
                }
            }

            return returnDictionary;
        }

        public static DataTable SelectAllFromTable(string table)
        {
            List<List<string>> result;
            List<string> columnNames;

            using (DBCommunication db = new DBCommunication())
            {
                result = db.InvokeEvent(false, $"SELECT * FROM `{table}`;", null, true);
                columnNames = db.GetTableColumnsNames(table);
            }

            if (result != null && result.Any())
            {
                DataTable dTable = new DataTable();

                foreach (var t in columnNames)
                {
                    DataColumn column = new DataColumn
                    {
                        DataType = typeof(string),
                        ColumnName = t
                    };

                    dTable.Columns.Add(column);
                }

                foreach (var rowList in result)
                {
                    DataRow row = dTable.NewRow();

                    for (int i = 0; i < rowList.Count; i++)
                    {
                        row[columnNames[i]] = rowList[i];
                    }

                    dTable.Rows.Add(row);
                }

                return dTable;
            }

            return null;
        }

        public static DataTable SelectAllFromTable(string table, string query)
        {
            List<List<string>> result;
            List<string> columnNames;

            using (DBCommunication db = new DBCommunication())
            {
                result = db.InvokeEvent(false, query, null, true);
                columnNames = db.GetTableColumnsNames(table);
            }

            if (result != null && result.Any())
            {
                DataTable dTable = new DataTable();

                foreach (var t in columnNames)
                {
                    DataColumn column = new DataColumn
                    {
                        DataType = typeof(string),
                        ColumnName = t
                    };

                    dTable.Columns.Add(column);
                }

                foreach (var rowList in result)
                {
                    DataRow row = dTable.NewRow();

                    for (int i = 0; i < rowList.Count; i++)
                    {
                        row[columnNames[i]] = rowList[i];
                    }

                    dTable.Rows.Add(row);
                }

                return dTable;
            }

            return null;
        }

        public static DataTable SelectAllFromTable(string query, List<string> columns)
        {
            List<List<string>> result;

            using (DBCommunication db = new DBCommunication())
            {
                result = db.InvokeEvent(false, query, null, true);
            }

            if (result != null && result.Any())
            {
                DataTable dTable = new DataTable();

                foreach (var t in columns)
                {
                    DataColumn column = new DataColumn
                    {
                        DataType = typeof(string),
                        ColumnName = t
                    };

                    dTable.Columns.Add(column);
                }

                foreach (var rowList in result)
                {
                    DataRow row = dTable.NewRow();

                    for (int i = 0; i < rowList.Count; i++)
                    {
                        row[columns[i]] = rowList[i];
                    }

                    dTable.Rows.Add(row);
                }

                return dTable;
            }

            return null;
        }
    }
}