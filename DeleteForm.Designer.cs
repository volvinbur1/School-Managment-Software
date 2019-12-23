namespace SchoolManagementSystem
{
    partial class DeleteForm
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
            this.PupilList_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PupilList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PupilList_dataGridView
            // 
            this.PupilList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PupilList_dataGridView.Location = new System.Drawing.Point(2, 2);
            this.PupilList_dataGridView.Name = "PupilList_dataGridView";
            this.PupilList_dataGridView.Size = new System.Drawing.Size(615, 400);
            this.PupilList_dataGridView.TabIndex = 0;
            this.PupilList_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PupilList_dataGridView_CellClick);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 406);
            this.Controls.Add(this.PupilList_dataGridView);
            this.Name = "DeleteForm";
            this.Text = "Delete pupil";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PupilList_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PupilList_dataGridView;
    }
}