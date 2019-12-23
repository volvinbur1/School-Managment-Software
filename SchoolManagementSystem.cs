using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class SchoolManagementSystem : Form
    {
        private readonly LogForm _logForm;
        private readonly string _name;
        public SchoolManagementSystem(LogForm obj, string name)
        {
            InitializeComponent();
            _logForm = obj;
            _name = name;
        }
    
        private void SchoolManagementSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logForm.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            _logForm.Close();
        }

        private void SchoolManagementSystem_Load(object sender, EventArgs e)
        {
            Welcome_label.Text += _name;
            SelectTable_comboBox.DisplayMember = "table";
            SelectTable_comboBox.ValueMember = "sql";

            SelectTable_comboBox.SelectedItem = null;

            SelectTable_comboBox.DataSource = new List<object>
            {
                new {sql = "pupils", table = "Pupils"}, new {sql = "teachers", table = "Teachers"},
                new {sql = "subjects", table = "Subjects"}, new {sql = "cabinets", table = "Cabinets"},
                new {sql = "progress", table = "Pupils progress"}, new {sql = "groups", table = "Groups"}
            };

            SelectTable_comboBox.Text = @"Choose table to display";
        }

        private void PrintTableWithJoinStatement()
        {
            var subjects = SelectDataFromDataBase.SelectSubjectList();
            string qColumn = "";
            foreach (var pair in subjects)
            {
                qColumn += $", `progress`.`{pair.Value}`";
            }

            TablePreview_dataGridView.DataSource = SelectDataFromDataBase.SelectAllFromTable(
                $"SELECT `progress`.`id`, `pupils`.`name`, `pupils`.`surname`{qColumn} FROM `progress` INNER JOIN `pupils` ON `progress`.`pupilID` = `pupils`.`id`;",
                FormColumnsList(subjects));

            TablePreview_dataGridView.AutoResizeColumns();
            TablePreview_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TablePreview_dataGridView.Refresh();
        }

        private List<string> FormColumnsList(Dictionary<string, string> subjects)
        {
            List<string> list = new List<string>
            {
                "id",
                "name",
                "surname"
            };
            foreach (var pair in subjects)
            {
                list.Add(pair.Value);
            }
            return list;
        }

        private void addPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddForm addForm = new AddForm(AddForm.AddOperationMode.AddPupil)
            {
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            addForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddForm addForm = new AddForm(AddForm.AddOperationMode.AddTeacher)
            {
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            addForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void addCabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddForm addForm = new AddForm(AddForm.AddOperationMode.AddCabinet)
            {
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            addForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddForm addForm = new AddForm(AddForm.AddOperationMode.AddSubject)
            {
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            addForm.Show();
            Cursor.Current = Cursors.Default;
        }


        private void SelectTable_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectTable_comboBox.SelectedIndex > -1)
            {
                if (SelectTable_comboBox.SelectedValue.ToString() == "progress")
                    PrintTableWithJoinStatement();
                else
                {
                    TablePreview_dataGridView.DataSource =
                        SelectDataFromDataBase.SelectAllFromTable(SelectTable_comboBox.SelectedValue.ToString());
                    TablePreview_dataGridView.AutoResizeColumns();
                    TablePreview_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    TablePreview_dataGridView.Refresh();
                }
            }
        }

        private void deletePupleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DeleteForm form = new DeleteForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            Cursor.Current = Cursors.Default;
        }

        private void viewProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ProgressFrom form = new ProgressFrom
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            Cursor.Current = Cursors.Default;
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BackUpRestore backup = new BackUpRestore())
            {
                backup.CreateBackup();
            }
        }

        private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BackUpRestore restore = new BackUpRestore())
            {
                restore.RestoreBackup();
            }
        }
    }
}
