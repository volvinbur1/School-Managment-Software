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
        }
    }
}
