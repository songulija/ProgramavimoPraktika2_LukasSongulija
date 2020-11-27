namespace AkademineIS.Forms
{
    partial class StaffMainScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TvarkytiNaudotojusPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TvarkytiNaudotojus = new System.Windows.Forms.Button();
            this.SubjectTeacherPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EditTeachers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.AddMarkPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.AddMarkSubjectCombobox = new System.Windows.Forms.ComboBox();
            this.AddMarkGetStudents = new System.Windows.Forms.Button();
            this.AddMarkStudentsCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddMark = new System.Windows.Forms.Button();
            this.AddMarkMarkTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMarkGroupCombobox = new System.Windows.Forms.ComboBox();
            this.UpdateMarkpanel = new System.Windows.Forms.Panel();
            this.UpdateMarkIdtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pasasa = new System.Windows.Forms.Label();
            this.UpdateMark = new System.Windows.Forms.Button();
            this.UpdateMarktextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DisplayMarks = new System.Windows.Forms.Button();
            this.AddMarkShow = new System.Windows.Forms.Button();
            this.UpdateMarkShow = new System.Windows.Forms.Button();
            this.SubjectNameDisplaycomboBox = new System.Windows.Forms.ComboBox();
            this.GroupNameDisplaycomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TvarkytiNaudotojusPanel.SuspendLayout();
            this.SubjectTeacherPanel.SuspendLayout();
            this.AddMarkPanel.SuspendLayout();
            this.UpdateMarkpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // TvarkytiNaudotojusPanel
            // 
            this.TvarkytiNaudotojusPanel.Controls.Add(this.label1);
            this.TvarkytiNaudotojusPanel.Controls.Add(this.TvarkytiNaudotojus);
            this.TvarkytiNaudotojusPanel.Location = new System.Drawing.Point(563, 48);
            this.TvarkytiNaudotojusPanel.Name = "TvarkytiNaudotojusPanel";
            this.TvarkytiNaudotojusPanel.Size = new System.Drawing.Size(169, 79);
            this.TvarkytiNaudotojusPanel.TabIndex = 3;
            this.TvarkytiNaudotojusPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Users and Groups Edit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TvarkytiNaudotojus
            // 
            this.TvarkytiNaudotojus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TvarkytiNaudotojus.Location = new System.Drawing.Point(6, 39);
            this.TvarkytiNaudotojus.Name = "TvarkytiNaudotojus";
            this.TvarkytiNaudotojus.Size = new System.Drawing.Size(147, 37);
            this.TvarkytiNaudotojus.TabIndex = 3;
            this.TvarkytiNaudotojus.Text = "Edit";
            this.TvarkytiNaudotojus.UseVisualStyleBackColor = true;
            this.TvarkytiNaudotojus.Click += new System.EventHandler(this.TvarkytiNaudotojus_Click);
            // 
            // SubjectTeacherPanel
            // 
            this.SubjectTeacherPanel.Controls.Add(this.label2);
            this.SubjectTeacherPanel.Controls.Add(this.EditTeachers);
            this.SubjectTeacherPanel.Location = new System.Drawing.Point(563, 133);
            this.SubjectTeacherPanel.Name = "SubjectTeacherPanel";
            this.SubjectTeacherPanel.Size = new System.Drawing.Size(169, 111);
            this.SubjectTeacherPanel.TabIndex = 5;
            this.SubjectTeacherPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subjects and Subject Teachers Edit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditTeachers
            // 
            this.EditTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditTeachers.Location = new System.Drawing.Point(9, 67);
            this.EditTeachers.Name = "EditTeachers";
            this.EditTeachers.Size = new System.Drawing.Size(147, 41);
            this.EditTeachers.TabIndex = 3;
            this.EditTeachers.Text = "Edit Teachers Subjects";
            this.EditTeachers.UseVisualStyleBackColor = true;
            this.EditTeachers.Click += new System.EventHandler(this.EditTeachers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Welcome:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserName.Location = new System.Drawing.Point(97, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(54, 20);
            this.UserName.TabIndex = 14;
            this.UserName.Text = "Admin";
            // 
            // AddMarkPanel
            // 
            this.AddMarkPanel.Controls.Add(this.label14);
            this.AddMarkPanel.Controls.Add(this.AddMarkSubjectCombobox);
            this.AddMarkPanel.Controls.Add(this.AddMarkGetStudents);
            this.AddMarkPanel.Controls.Add(this.AddMarkStudentsCombobox);
            this.AddMarkPanel.Controls.Add(this.label8);
            this.AddMarkPanel.Controls.Add(this.AddMark);
            this.AddMarkPanel.Controls.Add(this.AddMarkMarkTextbox);
            this.AddMarkPanel.Controls.Add(this.label5);
            this.AddMarkPanel.Controls.Add(this.label4);
            this.AddMarkPanel.Controls.Add(this.label3);
            this.AddMarkPanel.Controls.Add(this.AddMarkGroupCombobox);
            this.AddMarkPanel.Location = new System.Drawing.Point(12, 319);
            this.AddMarkPanel.Name = "AddMarkPanel";
            this.AddMarkPanel.Size = new System.Drawing.Size(139, 270);
            this.AddMarkPanel.TabIndex = 15;
            this.AddMarkPanel.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Subject";
            // 
            // AddMarkSubjectCombobox
            // 
            this.AddMarkSubjectCombobox.FormattingEnabled = true;
            this.AddMarkSubjectCombobox.Location = new System.Drawing.Point(7, 43);
            this.AddMarkSubjectCombobox.Name = "AddMarkSubjectCombobox";
            this.AddMarkSubjectCombobox.Size = new System.Drawing.Size(121, 21);
            this.AddMarkSubjectCombobox.TabIndex = 23;
            // 
            // AddMarkGetStudents
            // 
            this.AddMarkGetStudents.Location = new System.Drawing.Point(6, 112);
            this.AddMarkGetStudents.Name = "AddMarkGetStudents";
            this.AddMarkGetStudents.Size = new System.Drawing.Size(122, 25);
            this.AddMarkGetStudents.TabIndex = 22;
            this.AddMarkGetStudents.Text = "Get Students";
            this.AddMarkGetStudents.UseVisualStyleBackColor = true;
            this.AddMarkGetStudents.Click += new System.EventHandler(this.AddMarkGetStudents_Click);
            // 
            // AddMarkStudentsCombobox
            // 
            this.AddMarkStudentsCombobox.FormattingEnabled = true;
            this.AddMarkStudentsCombobox.Location = new System.Drawing.Point(7, 156);
            this.AddMarkStudentsCombobox.Name = "AddMarkStudentsCombobox";
            this.AddMarkStudentsCombobox.Size = new System.Drawing.Size(121, 21);
            this.AddMarkStudentsCombobox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Add Mark";
            // 
            // AddMark
            // 
            this.AddMark.Location = new System.Drawing.Point(7, 222);
            this.AddMark.Name = "AddMark";
            this.AddMark.Size = new System.Drawing.Size(121, 31);
            this.AddMark.TabIndex = 19;
            this.AddMark.Text = "Add Mark";
            this.AddMark.UseVisualStyleBackColor = true;
            this.AddMark.Click += new System.EventHandler(this.AddMark_Click);
            // 
            // AddMarkMarkTextbox
            // 
            this.AddMarkMarkTextbox.Location = new System.Drawing.Point(7, 196);
            this.AddMarkMarkTextbox.Name = "AddMarkMarkTextbox";
            this.AddMarkMarkTextbox.Size = new System.Drawing.Size(121, 20);
            this.AddMarkMarkTextbox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group";
            // 
            // AddMarkGroupCombobox
            // 
            this.AddMarkGroupCombobox.FormattingEnabled = true;
            this.AddMarkGroupCombobox.Location = new System.Drawing.Point(7, 85);
            this.AddMarkGroupCombobox.Name = "AddMarkGroupCombobox";
            this.AddMarkGroupCombobox.Size = new System.Drawing.Size(121, 21);
            this.AddMarkGroupCombobox.TabIndex = 13;
            // 
            // UpdateMarkpanel
            // 
            this.UpdateMarkpanel.Controls.Add(this.UpdateMarkIdtextBox);
            this.UpdateMarkpanel.Controls.Add(this.label9);
            this.UpdateMarkpanel.Controls.Add(this.pasasa);
            this.UpdateMarkpanel.Controls.Add(this.UpdateMark);
            this.UpdateMarkpanel.Controls.Add(this.UpdateMarktextBox);
            this.UpdateMarkpanel.Controls.Add(this.label10);
            this.UpdateMarkpanel.Location = new System.Drawing.Point(166, 319);
            this.UpdateMarkpanel.Name = "UpdateMarkpanel";
            this.UpdateMarkpanel.Size = new System.Drawing.Size(140, 234);
            this.UpdateMarkpanel.TabIndex = 23;
            this.UpdateMarkpanel.Visible = false;
            // 
            // UpdateMarkIdtextBox
            // 
            this.UpdateMarkIdtextBox.Location = new System.Drawing.Point(7, 53);
            this.UpdateMarkIdtextBox.Name = "UpdateMarkIdtextBox";
            this.UpdateMarkIdtextBox.Size = new System.Drawing.Size(121, 20);
            this.UpdateMarkIdtextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mark Id";
            // 
            // pasasa
            // 
            this.pasasa.AutoSize = true;
            this.pasasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pasasa.Location = new System.Drawing.Point(3, 7);
            this.pasasa.Name = "pasasa";
            this.pasasa.Size = new System.Drawing.Size(101, 20);
            this.pasasa.TabIndex = 20;
            this.pasasa.Text = "Update Mark";
            // 
            // UpdateMark
            // 
            this.UpdateMark.Location = new System.Drawing.Point(7, 127);
            this.UpdateMark.Name = "UpdateMark";
            this.UpdateMark.Size = new System.Drawing.Size(121, 31);
            this.UpdateMark.TabIndex = 19;
            this.UpdateMark.Text = "Update Mark";
            this.UpdateMark.UseVisualStyleBackColor = true;
            this.UpdateMark.Click += new System.EventHandler(this.UpdateMark_Click);
            // 
            // UpdateMarktextBox
            // 
            this.UpdateMarktextBox.Location = new System.Drawing.Point(7, 101);
            this.UpdateMarktextBox.Name = "UpdateMarktextBox";
            this.UpdateMarktextBox.Size = new System.Drawing.Size(121, 20);
            this.UpdateMarktextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mark";
            // 
            // DisplayMarks
            // 
            this.DisplayMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DisplayMarks.Location = new System.Drawing.Point(312, 280);
            this.DisplayMarks.Name = "DisplayMarks";
            this.DisplayMarks.Size = new System.Drawing.Size(115, 31);
            this.DisplayMarks.TabIndex = 24;
            this.DisplayMarks.Text = "Display Marks";
            this.DisplayMarks.UseVisualStyleBackColor = true;
            this.DisplayMarks.Click += new System.EventHandler(this.DisplayMarks_Click);
            // 
            // AddMarkShow
            // 
            this.AddMarkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddMarkShow.Location = new System.Drawing.Point(312, 317);
            this.AddMarkShow.Name = "AddMarkShow";
            this.AddMarkShow.Size = new System.Drawing.Size(115, 31);
            this.AddMarkShow.TabIndex = 25;
            this.AddMarkShow.Text = "Add Mark";
            this.AddMarkShow.UseVisualStyleBackColor = true;
            this.AddMarkShow.Click += new System.EventHandler(this.AddMarkShow_Click);
            // 
            // UpdateMarkShow
            // 
            this.UpdateMarkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateMarkShow.Location = new System.Drawing.Point(312, 356);
            this.UpdateMarkShow.Name = "UpdateMarkShow";
            this.UpdateMarkShow.Size = new System.Drawing.Size(115, 31);
            this.UpdateMarkShow.TabIndex = 26;
            this.UpdateMarkShow.Text = "Update Mark";
            this.UpdateMarkShow.UseVisualStyleBackColor = true;
            this.UpdateMarkShow.Click += new System.EventHandler(this.UpdateMarkShow_Click);
            // 
            // SubjectNameDisplaycomboBox
            // 
            this.SubjectNameDisplaycomboBox.FormattingEnabled = true;
            this.SubjectNameDisplaycomboBox.Location = new System.Drawing.Point(12, 290);
            this.SubjectNameDisplaycomboBox.Name = "SubjectNameDisplaycomboBox";
            this.SubjectNameDisplaycomboBox.Size = new System.Drawing.Size(136, 21);
            this.SubjectNameDisplaycomboBox.TabIndex = 27;
            // 
            // GroupNameDisplaycomboBox
            // 
            this.GroupNameDisplaycomboBox.FormattingEnabled = true;
            this.GroupNameDisplaycomboBox.Location = new System.Drawing.Point(154, 290);
            this.GroupNameDisplaycomboBox.Name = "GroupNameDisplaycomboBox";
            this.GroupNameDisplaycomboBox.Size = new System.Drawing.Size(140, 21);
            this.GroupNameDisplaycomboBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Subject Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Group Name";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogoutButton.Location = new System.Drawing.Point(682, 7);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 35);
            this.LogoutButton.TabIndex = 31;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StaffMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GroupNameDisplaycomboBox);
            this.Controls.Add(this.SubjectNameDisplaycomboBox);
            this.Controls.Add(this.UpdateMarkShow);
            this.Controls.Add(this.AddMarkShow);
            this.Controls.Add(this.DisplayMarks);
            this.Controls.Add(this.UpdateMarkpanel);
            this.Controls.Add(this.AddMarkPanel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubjectTeacherPanel);
            this.Controls.Add(this.TvarkytiNaudotojusPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StaffMainScreen";
            this.Text = "StaffMainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TvarkytiNaudotojusPanel.ResumeLayout(false);
            this.TvarkytiNaudotojusPanel.PerformLayout();
            this.SubjectTeacherPanel.ResumeLayout(false);
            this.AddMarkPanel.ResumeLayout(false);
            this.AddMarkPanel.PerformLayout();
            this.UpdateMarkpanel.ResumeLayout(false);
            this.UpdateMarkpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel TvarkytiNaudotojusPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TvarkytiNaudotojus;
        private System.Windows.Forms.Panel SubjectTeacherPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditTeachers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel AddMarkPanel;
        private System.Windows.Forms.Button AddMarkGetStudents;
        private System.Windows.Forms.ComboBox AddMarkStudentsCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddMark;
        private System.Windows.Forms.TextBox AddMarkMarkTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AddMarkGroupCombobox;
        private System.Windows.Forms.Panel UpdateMarkpanel;
        private System.Windows.Forms.Label pasasa;
        private System.Windows.Forms.Button UpdateMark;
        private System.Windows.Forms.TextBox UpdateMarktextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DisplayMarks;
        private System.Windows.Forms.Button AddMarkShow;
        private System.Windows.Forms.Button UpdateMarkShow;
        private System.Windows.Forms.ComboBox SubjectNameDisplaycomboBox;
        private System.Windows.Forms.ComboBox GroupNameDisplaycomboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox AddMarkSubjectCombobox;
        private System.Windows.Forms.TextBox UpdateMarkIdtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button LogoutButton;
    }
}