using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;

namespace SchoolManagementSystem
{
    class BackUpRestore : DBCommunication
    {
        public void CreateBackup()
        {
            string folder = DateTime.Now.Date.ToString("yyyy-MM-dd");
            var root = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) ?? throw new InvalidOperationException(), "Database backup");
            var newFolderPath = Path.Combine(root, folder);

            if (!Directory.Exists(newFolderPath))
                Directory.CreateDirectory(newFolderPath);

            string newFileFolderPath = Path.Combine(newFolderPath, $"sqlBackup_time{DateTime.Now:hh-mm-ss}.sql");

            Cursor.Current = Cursors.WaitCursor;
            try
            {                
                using (MySqlBackup backup = new MySqlBackup(new MySqlCommand("", _connection)))
                {
                    backup.ExportToFile(newFileFolderPath);
                    MessageBox.Show(@"Backup created.");
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(e.ToString());
            }

        }

        private string FileDialog()
        {
            string filePath = "";

            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory =
                    Path.Combine(
                        Path.GetDirectoryName(Application.ExecutablePath) ?? throw new InvalidOperationException(),
                        "Database backup");
                dialog.Filter = @"MySql backups(*.sql) | *.sql | All files(*.*) | *.*";
                dialog.FilterIndex = 2;

                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                    filePath = dialog.FileName;
            }

            return filePath;
        }

        public void RestoreBackup()
        {
            string filePath = FileDialog();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (MySqlBackup backup = new MySqlBackup(new MySqlCommand("", _connection)))
                {
                    backup.ImportFromFile(filePath);
                    MessageBox.Show(@"Backup uploaded.");
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
