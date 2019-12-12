using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    internal delegate List<List<string>> ExecuteQueryWithoutClassInstance(bool parameters, string query,
        Dictionary<string, string> list, bool returnValues);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogForm());
        }
    }
}
