namespace SchoolManagementSystem
{
    partial class ProgressFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Progress_dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectSubject_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectProgress_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvarageValues_listBox = new System.Windows.Forms.ListBox();
            this.Unprecedent_groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.IdealValue_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeacherName_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Unprecedent_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Progress_dataGridView
            // 
            this.Progress_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Progress_dataGridView.Location = new System.Drawing.Point(2, 63);
            this.Progress_dataGridView.Name = "Progress_dataGridView";
            this.Progress_dataGridView.Size = new System.Drawing.Size(713, 382);
            this.Progress_dataGridView.TabIndex = 0;
            this.Progress_dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Progress_dataGridView_CellEndEdit);
            // 
            // SelectSubject_comboBox
            // 
            this.SelectSubject_comboBox.FormattingEnabled = true;
            this.SelectSubject_comboBox.Location = new System.Drawing.Point(6, 19);
            this.SelectSubject_comboBox.Name = "SelectSubject_comboBox";
            this.SelectSubject_comboBox.Size = new System.Drawing.Size(156, 21);
            this.SelectSubject_comboBox.TabIndex = 1;
            this.SelectSubject_comboBox.Text = "Select subject ";
            this.SelectSubject_comboBox.SelectionChangeCommitted += new System.EventHandler(this.SelectSubject_comboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "--->";
            // 
            // SubjectProgress_textBox
            // 
            this.SubjectProgress_textBox.Enabled = false;
            this.SubjectProgress_textBox.Location = new System.Drawing.Point(200, 19);
            this.SubjectProgress_textBox.Name = "SubjectProgress_textBox";
            this.SubjectProgress_textBox.Size = new System.Drawing.Size(32, 20);
            this.SubjectProgress_textBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectSubject_comboBox);
            this.groupBox1.Controls.Add(this.SubjectProgress_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress of selected subject";
            // 
            // AvarageValues_listBox
            // 
            this.AvarageValues_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvarageValues_listBox.FormattingEnabled = true;
            this.AvarageValues_listBox.ItemHeight = 20;
            this.AvarageValues_listBox.Location = new System.Drawing.Point(721, 63);
            this.AvarageValues_listBox.Name = "AvarageValues_listBox";
            this.AvarageValues_listBox.Size = new System.Drawing.Size(194, 384);
            this.AvarageValues_listBox.TabIndex = 5;
            // 
            // Unprecedent_groupBox
            // 
            this.Unprecedent_groupBox.Controls.Add(this.label4);
            this.Unprecedent_groupBox.Controls.Add(this.Amount_textBox);
            this.Unprecedent_groupBox.Controls.Add(this.IdealValue_textBox);
            this.Unprecedent_groupBox.Controls.Add(this.label3);
            this.Unprecedent_groupBox.Controls.Add(this.label2);
            this.Unprecedent_groupBox.Location = new System.Drawing.Point(304, 2);
            this.Unprecedent_groupBox.Name = "Unprecedent_groupBox";
            this.Unprecedent_groupBox.Size = new System.Drawing.Size(271, 55);
            this.Unprecedent_groupBox.TabIndex = 6;
            this.Unprecedent_groupBox.TabStop = false;
            this.Unprecedent_groupBox.Text = "Amount of pupils with unprecedented success";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "--->";
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Enabled = false;
            this.Amount_textBox.Location = new System.Drawing.Point(226, 29);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(39, 20);
            this.Amount_textBox.TabIndex = 3;
            // 
            // IdealValue_textBox
            // 
            this.IdealValue_textBox.Location = new System.Drawing.Point(153, 29);
            this.IdealValue_textBox.Name = "IdealValue_textBox";
            this.IdealValue_textBox.Size = new System.Drawing.Size(39, 20);
            this.IdealValue_textBox.TabIndex = 2;
            this.IdealValue_textBox.TextChanged += new System.EventHandler(this.IdealValue_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ideal value to measure the level of progress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeacherName_textBox);
            this.groupBox2.Location = new System.Drawing.Point(621, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher with lowers level of success";
            // 
            // TeacherName_textBox
            // 
            this.TeacherName_textBox.Enabled = false;
            this.TeacherName_textBox.Location = new System.Drawing.Point(41, 19);
            this.TeacherName_textBox.Name = "TeacherName_textBox";
            this.TeacherName_textBox.Size = new System.Drawing.Size(209, 20);
            this.TeacherName_textBox.TabIndex = 0;
            // 
            // ProgressFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Unprecedent_groupBox);
            this.Controls.Add(this.AvarageValues_listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Progress_dataGridView);
            this.Name = "ProgressFrom";
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.ProgressFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Progress_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Unprecedent_groupBox.ResumeLayout(false);
            this.Unprecedent_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Progress_dataGridView;
        private System.Windows.Forms.ComboBox SelectSubject_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubjectProgress_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox AvarageValues_listBox;
        private System.Windows.Forms.GroupBox Unprecedent_groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.TextBox IdealValue_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TeacherName_textBox;
    }
}