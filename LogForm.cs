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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void Leave_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (UserVerifications.VerifyPassword(Username_textBox.Text, Password_textBox.Text))
            {
                if (UserVerifications.Admin)
                {
                    SchoolManagementSystem smsForm =
                        new SchoolManagementSystem(this, UserVerifications.GetUserName(Username_textBox.Text));
                    smsForm.Show();

//                var form = new AddForm(AddForm.AddOperationMode.AddTeacher);
//                form.Show();
                    Hide();


                    Username_textBox.Clear();
                    Password_textBox.Clear();
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show(UserVerifications.ObtainTextOfError(Username_textBox.Text));
                Password_textBox.Clear();
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
