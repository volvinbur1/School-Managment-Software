using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Engines;

namespace SchoolManagementSystem
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            RefreshReviewTable();
        }

        private void RefreshReviewTable()
        {
            PupilList_dataGridView.Columns.Clear();

            PupilList_dataGridView.DataSource = SelectDataFromDataBase.SelectAllFromTable("pupils");

            var btc = new DataGridViewButtonColumn
            {
                Name = @"Delete_button",
                HeaderText = @"Delete pupil",
                Text = @"Delete",
                UseColumnTextForButtonValue = true
            };

            PupilList_dataGridView.Columns.Add(btc);

            PupilList_dataGridView.AutoResizeColumns();
            PupilList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PupilList_dataGridView.Refresh();
        }

        private void PupilList_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PupilList_dataGridView.Columns[e.ColumnIndex].Name == "Delete_button")
                {
                    if (!DeleteDataFromDatabase.DeletePupilFromDb(PupilList_dataGridView[0, e.RowIndex].Value.ToString()))
                        MessageBox.Show("Pupil was not deleted.\nSomething went wrong.");
                    else
                        RefreshReviewTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Don`t press this button.");
            }
        }
    }
}
