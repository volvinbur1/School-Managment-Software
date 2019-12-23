namespace SchoolManagementSystem
{
    partial class SchoolManagementSystem
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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPupleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePupleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SelectTable_comboBox = new System.Windows.Forms.ComboBox();
            this.TablePreview_dataGridView = new System.Windows.Forms.DataGridView();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePreview_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPupleToolStripMenuItem,
            this.addTeacherToolStripMenuItem,
            this.addCabinetToolStripMenuItem,
            this.addToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addPupleToolStripMenuItem
            // 
            this.addPupleToolStripMenuItem.Name = "addPupleToolStripMenuItem";
            this.addPupleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addPupleToolStripMenuItem.Text = "Add pupil";
            this.addPupleToolStripMenuItem.Click += new System.EventHandler(this.addPupilToolStripMenuItem_Click);
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addTeacherToolStripMenuItem.Text = "Add teacher";
            this.addTeacherToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // addCabinetToolStripMenuItem
            // 
            this.addCabinetToolStripMenuItem.Name = "addCabinetToolStripMenuItem";
            this.addCabinetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addCabinetToolStripMenuItem.Text = "Add cabinet";
            this.addCabinetToolStripMenuItem.Click += new System.EventHandler(this.addCabinetToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.addToolStripMenuItem1.Text = "Add subject";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePupleToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deletePupleToolStripMenuItem
            // 
            this.deletePupleToolStripMenuItem.Name = "deletePupleToolStripMenuItem";
            this.deletePupleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deletePupleToolStripMenuItem.Text = "Delete pupil";
            this.deletePupleToolStripMenuItem.Click += new System.EventHandler(this.deletePupleToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProgressToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processToolStripMenuItem.Text = "Proccesses";
            // 
            // viewProgressToolStripMenuItem
            // 
            this.viewProgressToolStripMenuItem.Name = "viewProgressToolStripMenuItem";
            this.viewProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewProgressToolStripMenuItem.Text = "View progress ";
            this.viewProgressToolStripMenuItem.Click += new System.EventHandler(this.viewProgressToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDatabaseToolStripMenuItem,
            this.importDatabaseToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportDatabaseToolStripMenuItem.Text = "Export  database";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportDatabaseToolStripMenuItem_Click);
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.importDatabaseToolStripMenuItem.Text = "Import database";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.processToolStripMenuItem,
            this.dataBaseToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 385);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Welcome_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome_label.Location = new System.Drawing.Point(37, 100);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(193, 42);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Welcome, ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SelectTable_comboBox);
            this.tabPage2.Controls.Add(this.TablePreview_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Review";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SelectTable_comboBox
            // 
            this.SelectTable_comboBox.FormattingEnabled = true;
            this.SelectTable_comboBox.Location = new System.Drawing.Point(6, 6);
            this.SelectTable_comboBox.Name = "SelectTable_comboBox";
            this.SelectTable_comboBox.Size = new System.Drawing.Size(216, 21);
            this.SelectTable_comboBox.TabIndex = 1;
            this.SelectTable_comboBox.Text = "Select table";
            this.SelectTable_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectTable_comboBox_SelectedIndexChanged);
            // 
            // TablePreview_dataGridView
            // 
            this.TablePreview_dataGridView.AllowUserToAddRows = false;
            this.TablePreview_dataGridView.AllowUserToDeleteRows = false;
            this.TablePreview_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePreview_dataGridView.Location = new System.Drawing.Point(3, 33);
            this.TablePreview_dataGridView.Name = "TablePreview_dataGridView";
            this.TablePreview_dataGridView.ReadOnly = true;
            this.TablePreview_dataGridView.Size = new System.Drawing.Size(628, 323);
            this.TablePreview_dataGridView.TabIndex = 0;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // SchoolManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchoolManagementSystem";
            this.Text = "SchoolManagementSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchoolManagementSystem_FormClosing);
            this.Load += new System.EventHandler(this.SchoolManagementSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePreview_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPupleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePupleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.ComboBox SelectTable_comboBox;
        private System.Windows.Forms.DataGridView TablePreview_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}