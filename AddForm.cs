using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddForm : Form
    {
        public enum AddOperationMode
        {
            AddPupil = 0,
            AddTeacher = 1,
            AddSubject = 2,
            AddCabinet = 3
        }

        private readonly AddOperationMode _mode;

        public AddForm(AddOperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void AddPupil_button_Click(object sender, EventArgs e)
        {
            if (PupilName_textBox.Text != "" && PupilSurname_textBox.Text != "" && Group_comboBox.SelectedIndex > -1)
            {
                try
                {
                    bool result = AddDataToDataBase.AddPupil(PupilName_textBox.Text, PupilSurname_textBox.Text,
                        PupilEmail_textBox.Text,
                        Group_comboBox.SelectedValue.ToString(),
                        DateTime.Parse(PupilEntraceYear_dateTimePicker.Value.ToString(CultureInfo.InvariantCulture)).Year
                            .ToString());

                    if (result)
                    {
                        PupilName_textBox.Clear();
                        PupilSurname_textBox.Clear();
                        PupilEmail_textBox.Clear();
                        UpdateAddPupilCombobox();
                        PupilEntraceYear_dateTimePicker.Value = new DateTime(2019, 1, 1);
                        MessageBox.Show(@"Pupil has been added.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show(@"Fill all gaps");
            }
        }

        private void AddTeacher_button_Click(object sender, EventArgs e)
        {
            if (TeacherName_textBox.Text != "" && TeacherSurname_textBox.Text != "" &&
                Subject_comboBox.SelectedIndex > -1 && Cabinet_comboBox.SelectedIndex > -1)
            {
                try
                {
                    bool result = AddDataToDataBase.AddTeacher(TeacherName_textBox.Text, TeacherSurname_textBox.Text,
                        Subject_comboBox.SelectedValue.ToString(), Cabinet_comboBox.SelectedValue.ToString());

                    if (result)
                    { 
                        TeacherName_textBox.Clear();
                        TeacherSurname_textBox.Clear();
                        UpdateAddTeacherComboboxes();
                        MessageBox.Show(@"Teacher has been added.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show(@"Fill all gaps");
            }
        }

        private void UpdateAddTeacherComboboxes()
        {
            var container = SelectDataFromDataBase.SelectSubjectList();
            Subject_comboBox.DisplayMember = "Subject";
            Subject_comboBox.ValueMember = "Id";

            var dataSource = new List<object>();
            foreach (var pair in container)
            {
                dataSource.Add(new { Id = pair.Key, Subject = pair.Value });
            }

            Subject_comboBox.DataSource = dataSource;

            container = SelectDataFromDataBase.SelectCabinetList();
            Cabinet_comboBox.DisplayMember = "Cabinet";
            Cabinet_comboBox.ValueMember = "Id";

            dataSource = new List<object>();

            foreach (var pair in container)
            {
                dataSource.Add(new {Id = pair.Key, Cabinet = pair.Value});
            }

            Cabinet_comboBox.DataSource = dataSource;

            Subject_comboBox.SelectedItem = null;
            Cabinet_comboBox.SelectedItem = null;

            Subject_comboBox.Text = @"Choose subject";
            Cabinet_comboBox.Text = @"Choose cabinet";
        }

        private void UpdateAddPupilCombobox()
        {
            var container = SelectDataFromDataBase.SelectGroupList();
            Group_comboBox.DisplayMember = "Group";
            Group_comboBox.ValueMember = "Id";

            var dataSource = new List<object>();
            foreach (var pair in container)
            {
                dataSource.Add(new { Id = pair.Key, Group = pair.Value });
            }

            Group_comboBox.DataSource = dataSource;
            
            Group_comboBox.SelectedItem = null;

            Group_comboBox.Text = @"Choose group";
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case AddOperationMode.AddPupil:
                    AddPupil_groupBox.Visible = true;
                    AddPupil_groupBox.Location = new Point(0, 0);
                    Size = AddPupil_groupBox.Size;
                    UpdateAddPupilCombobox();
                    break;
                case AddOperationMode.AddTeacher:
                    AddTeacher_groupBox.Visible = true;
                    AddTeacher_groupBox.Location = new Point(0, 0);
                    Size = AddTeacher_groupBox.Size;
                    UpdateAddTeacherComboboxes();
                    break;
                case AddOperationMode.AddSubject:
                    AddSubject_groupBox.Visible = true;
                    AddSubject_groupBox.Location = new Point(0, 0);
                    Size = AddSubject_groupBox.Size;
                    break;
                case AddOperationMode.AddCabinet:
                    AddCabinet_groupBox.Visible = true;
                    AddCabinet_groupBox.Location = new Point(0, 0);
                    Size = AddCabinet_groupBox.Size;
                    break;
            }
            
        }

        private void AddSubject_button_Click(object sender, EventArgs e)
        {
            if (SubjectName_textBox.Text != "")
            {
                try
                {
                    var result = AddDataToDataBase.AddSubject(SubjectName_textBox.Text);
                    if (result)
                    {
                        SubjectName_textBox.Clear();
                        MessageBox.Show(@"Subject has been added.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show(@"Enter subject name.");
            }
        }

        private void AddCabinet_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CabinetNumber_textBox.Text, out int cabinet)) {
                try
                {
                    var result = AddDataToDataBase.AddCabinet(cabinet);
                    if (result)
                    {
                        CabinetNumber_textBox.Clear();
                        MessageBox.Show(@"Cabinet has been added.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show(@"Enter cabinet number correctly.");
            }
        }
    }
}
