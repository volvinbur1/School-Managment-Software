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
    public partial class ProgressFrom : Form
    {
        private readonly bool _admin = true;
        private readonly LogForm _logForm;
        public ProgressFrom()
        {
            InitializeComponent();
        }

        public ProgressFrom(bool admin, LogForm obj)
        {
            InitializeComponent();
            _admin = admin;
            _logForm = obj;
        }

        private readonly ObtainProgress _progress = new ObtainProgress();

        private void ProgressFrom_Load(object sender, EventArgs e)
        {
            if (!_admin)
            {
                Progress_dataGridView.ReadOnly = true;
            }

            Progress_dataGridView.AllowUserToAddRows = false;
            Progress_dataGridView.AllowUserToDeleteRows = false;

            PrepareSubjectCombobox();
            PrintTableToDataGridView();
            AverageListBox();
            TeacherWithLowestSuccess();
        }

        private void AverageListBox()
        {
            var dictionary = _progress.AverageForEachSubject();
            List<string> list = new List<string>();

            foreach (var item in dictionary)
            {
                list.Add(item.Key + "  -  " + $"{item.Value:0.00}");
            }

            AvarageValues_listBox.DataSource = list;
        }

        private void PrintTableToDataGridView()
        {
            var subjects = SelectDataFromDataBase.SelectSubjectList();
            string qColumn = "";
            foreach (var pair in subjects)
            {
                qColumn += $", `progress`.`{pair.Value}`";
            }

            Progress_dataGridView.DataSource = SelectDataFromDataBase.SelectAllFromTable(
                $"SELECT `progress`.`id`, `pupils`.`name`, `pupils`.`surname`{qColumn} FROM `progress` INNER JOIN `pupils` ON `progress`.`pupilID` = `pupils`.`id`;",
                FormColumnsList(subjects));

            Progress_dataGridView.AutoResizeColumns();
            Progress_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Progress_dataGridView.Refresh();
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

        private void TeacherWithLowestSuccess()
        {
            TeacherName_textBox.Text = _progress.TeacherWithLowerSuccessLevel();
        }

        private void PrepareSubjectCombobox()
        {
            var comboboxSource = SelectDataFromDataBase.SelectSubjectList();

//            SelectSubject_comboBox.DisplayMember = "subject";
//            SelectSubject_comboBox.ValueMember = "id";

            var dataSource = new List<object>();
            foreach (var list in comboboxSource)
            {
                dataSource.Add(list.Value); //new { id = list.Key, subject = list.Value });
            }

            SelectSubject_comboBox.DataSource = dataSource;
            SelectSubject_comboBox.SelectedItem = null;
            SelectSubject_comboBox.Text = @"Select subject";
        }

        private void SelectSubject_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (SelectSubject_comboBox.SelectedIndex > -1)
            {
                SubjectProgress_textBox.Text =
                    _progress.CalculateSubjectAverageValue(SelectSubject_comboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(@"Select subject.");
            }
        }

        private void IdealValue_textBox_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(IdealValue_textBox.Text, out var idealValue))
            {
                Amount_textBox.Text = _progress.AmountOfUnprecedentedPupils((int) idealValue).ToString();
            }
            else if(IdealValue_textBox.Text != "")
            {
                MessageBox.Show(@"Ideal value should be positive integer.");
            }
        }

        private void Progress_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2)
            {
                if (uint.TryParse(Progress_dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out var mark))
                {
                    if (mark <= 12)
                    {
                        _progress.UpdateMark(mark.ToString(),
                            Progress_dataGridView["id", e.RowIndex].Value.ToString(),
                            Progress_dataGridView.Columns[e.ColumnIndex].Name);

                        AverageListBox();
                        TeacherWithLowestSuccess();
                    }
                    else
                    {
                        MessageBox.Show(@"Mark should be between 0-12 range.");
                    }
                }
                else
                {
                    MessageBox.Show(@"Mark should be only positive integer.");
                }
            }

            PrintTableToDataGridView();
        }

        private void ProgressFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_admin)
            {
                _logForm.Show();
            }
        }
    }
}