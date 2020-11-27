namespace AkademineIS.Forms
{
    partial class TeachersSubjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddSubjectPanel = new System.Windows.Forms.Panel();
            this.AddSubject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSubjectTitleTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteSubjectPanel = new System.Windows.Forms.Panel();
            this.DeleteSubject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteSubjectTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddSubjectShow = new System.Windows.Forms.Button();
            this.DeleteSubjectShow = new System.Windows.Forms.Button();
            this.DisplaySubjects = new System.Windows.Forms.Button();
            this.StaffMainScreenButton = new System.Windows.Forms.Button();
            this.DisplayGroups = new System.Windows.Forms.Button();
            this.AddSubjectTeacherShow = new System.Windows.Forms.Button();
            this.SubjectTeacherPanel = new System.Windows.Forms.Panel();
            this.AddSubjectTeacher = new System.Windows.Forms.Button();
            this.AddSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddGroupComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSubjectTeacherShow = new System.Windows.Forms.Button();
            this.DeleteSubjectTeacherPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.SubTeacherIdTextbox = new System.Windows.Forms.TextBox();
            this.DeleteSubjectTeacher = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.AddSubjectPanel.SuspendLayout();
            this.DeleteSubjectPanel.SuspendLayout();
            this.SubjectTeacherPanel.SuspendLayout();
            this.DeleteSubjectTeacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(279, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject Teacher";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(283, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(600, 219);
            this.dataGridView2.TabIndex = 2;
            // 
            // AddSubjectPanel
            // 
            this.AddSubjectPanel.Controls.Add(this.AddSubject);
            this.AddSubjectPanel.Controls.Add(this.label4);
            this.AddSubjectPanel.Controls.Add(this.AddSubjectTitleTextbox);
            this.AddSubjectPanel.Controls.Add(this.label3);
            this.AddSubjectPanel.Location = new System.Drawing.Point(12, 302);
            this.AddSubjectPanel.Name = "AddSubjectPanel";
            this.AddSubjectPanel.Size = new System.Drawing.Size(134, 147);
            this.AddSubjectPanel.TabIndex = 4;
            this.AddSubjectPanel.Visible = false;
            // 
            // AddSubject
            // 
            this.AddSubject.Location = new System.Drawing.Point(5, 91);
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.Size = new System.Drawing.Size(120, 40);
            this.AddSubject.TabIndex = 3;
            this.AddSubject.Text = "Add Subject";
            this.AddSubject.UseVisualStyleBackColor = true;
            this.AddSubject.Click += new System.EventHandler(this.AddSubject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject Title";
            // 
            // AddSubjectTitleTextbox
            // 
            this.AddSubjectTitleTextbox.Location = new System.Drawing.Point(6, 65);
            this.AddSubjectTitleTextbox.Name = "AddSubjectTitleTextbox";
            this.AddSubjectTitleTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddSubjectTitleTextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Subject";
            // 
            // DeleteSubjectPanel
            // 
            this.DeleteSubjectPanel.Controls.Add(this.DeleteSubject);
            this.DeleteSubjectPanel.Controls.Add(this.label5);
            this.DeleteSubjectPanel.Controls.Add(this.DeleteSubjectTextbox);
            this.DeleteSubjectPanel.Controls.Add(this.label6);
            this.DeleteSubjectPanel.Location = new System.Drawing.Point(152, 302);
            this.DeleteSubjectPanel.Name = "DeleteSubjectPanel";
            this.DeleteSubjectPanel.Size = new System.Drawing.Size(125, 147);
            this.DeleteSubjectPanel.TabIndex = 5;
            this.DeleteSubjectPanel.Visible = false;
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.Location = new System.Drawing.Point(5, 91);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Size = new System.Drawing.Size(120, 40);
            this.DeleteSubject.TabIndex = 3;
            this.DeleteSubject.Text = "Delete Subject";
            this.DeleteSubject.UseVisualStyleBackColor = true;
            this.DeleteSubject.Click += new System.EventHandler(this.DeleteSubject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject Id";
            // 
            // DeleteSubjectTextbox
            // 
            this.DeleteSubjectTextbox.Location = new System.Drawing.Point(6, 65);
            this.DeleteSubjectTextbox.Name = "DeleteSubjectTextbox";
            this.DeleteSubjectTextbox.Size = new System.Drawing.Size(100, 20);
            this.DeleteSubjectTextbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(5, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Delete Subject";
            // 
            // AddSubjectShow
            // 
            this.AddSubjectShow.Location = new System.Drawing.Point(103, 261);
            this.AddSubjectShow.Name = "AddSubjectShow";
            this.AddSubjectShow.Size = new System.Drawing.Size(96, 34);
            this.AddSubjectShow.TabIndex = 6;
            this.AddSubjectShow.Text = "Add Subject";
            this.AddSubjectShow.UseVisualStyleBackColor = true;
            this.AddSubjectShow.Click += new System.EventHandler(this.AddSubjectShow_Click);
            // 
            // DeleteSubjectShow
            // 
            this.DeleteSubjectShow.Location = new System.Drawing.Point(205, 261);
            this.DeleteSubjectShow.Name = "DeleteSubjectShow";
            this.DeleteSubjectShow.Size = new System.Drawing.Size(72, 34);
            this.DeleteSubjectShow.TabIndex = 7;
            this.DeleteSubjectShow.Text = "Delete Subject";
            this.DeleteSubjectShow.UseVisualStyleBackColor = true;
            this.DeleteSubjectShow.Click += new System.EventHandler(this.DeleteSubjectShow_Click);
            // 
            // DisplaySubjects
            // 
            this.DisplaySubjects.Location = new System.Drawing.Point(12, 262);
            this.DisplaySubjects.Name = "DisplaySubjects";
            this.DisplaySubjects.Size = new System.Drawing.Size(85, 34);
            this.DisplaySubjects.TabIndex = 8;
            this.DisplaySubjects.Text = "Display Subjects";
            this.DisplaySubjects.UseVisualStyleBackColor = true;
            this.DisplaySubjects.Click += new System.EventHandler(this.DisplaySubjects_Click);
            // 
            // StaffMainScreenButton
            // 
            this.StaffMainScreenButton.Location = new System.Drawing.Point(680, 7);
            this.StaffMainScreenButton.Name = "StaffMainScreenButton";
            this.StaffMainScreenButton.Size = new System.Drawing.Size(108, 23);
            this.StaffMainScreenButton.TabIndex = 9;
            this.StaffMainScreenButton.Text = "Staff Main Screen";
            this.StaffMainScreenButton.UseVisualStyleBackColor = true;
            this.StaffMainScreenButton.Click += new System.EventHandler(this.StaffMainScreenButton_Click);
            // 
            // DisplayGroups
            // 
            this.DisplayGroups.Location = new System.Drawing.Point(287, 262);
            this.DisplayGroups.Name = "DisplayGroups";
            this.DisplayGroups.Size = new System.Drawing.Size(117, 34);
            this.DisplayGroups.TabIndex = 10;
            this.DisplayGroups.Text = "DisplayGroups";
            this.DisplayGroups.UseVisualStyleBackColor = true;
            this.DisplayGroups.Click += new System.EventHandler(this.DisplayGroups_Click);
            // 
            // AddSubjectTeacherShow
            // 
            this.AddSubjectTeacherShow.Location = new System.Drawing.Point(410, 262);
            this.AddSubjectTeacherShow.Name = "AddSubjectTeacherShow";
            this.AddSubjectTeacherShow.Size = new System.Drawing.Size(117, 34);
            this.AddSubjectTeacherShow.TabIndex = 18;
            this.AddSubjectTeacherShow.Text = "Add Subject Teacher";
            this.AddSubjectTeacherShow.UseVisualStyleBackColor = true;
            this.AddSubjectTeacherShow.Click += new System.EventHandler(this.AddSubjectTeacherShow_Click);
            // 
            // SubjectTeacherPanel
            // 
            this.SubjectTeacherPanel.Controls.Add(this.AddSubjectTeacher);
            this.SubjectTeacherPanel.Controls.Add(this.AddSubjectComboBox);
            this.SubjectTeacherPanel.Controls.Add(this.label9);
            this.SubjectTeacherPanel.Controls.Add(this.AddTeacherComboBox);
            this.SubjectTeacherPanel.Controls.Add(this.label8);
            this.SubjectTeacherPanel.Controls.Add(this.label7);
            this.SubjectTeacherPanel.Controls.Add(this.AddGroupComboBox);
            this.SubjectTeacherPanel.Location = new System.Drawing.Point(287, 302);
            this.SubjectTeacherPanel.Name = "SubjectTeacherPanel";
            this.SubjectTeacherPanel.Size = new System.Drawing.Size(156, 166);
            this.SubjectTeacherPanel.TabIndex = 19;
            this.SubjectTeacherPanel.Visible = false;
            // 
            // AddSubjectTeacher
            // 
            this.AddSubjectTeacher.Location = new System.Drawing.Point(17, 133);
            this.AddSubjectTeacher.Name = "AddSubjectTeacher";
            this.AddSubjectTeacher.Size = new System.Drawing.Size(123, 23);
            this.AddSubjectTeacher.TabIndex = 24;
            this.AddSubjectTeacher.Text = "Add Subject Teacher";
            this.AddSubjectTeacher.UseVisualStyleBackColor = true;
            this.AddSubjectTeacher.Click += new System.EventHandler(this.AddSubjectTeacher_Click);
            // 
            // AddSubjectComboBox
            // 
            this.AddSubjectComboBox.FormattingEnabled = true;
            this.AddSubjectComboBox.Location = new System.Drawing.Point(17, 105);
            this.AddSubjectComboBox.Name = "AddSubjectComboBox";
            this.AddSubjectComboBox.Size = new System.Drawing.Size(123, 21);
            this.AddSubjectComboBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Choose Subject";
            // 
            // AddTeacherComboBox
            // 
            this.AddTeacherComboBox.FormattingEnabled = true;
            this.AddTeacherComboBox.Location = new System.Drawing.Point(17, 65);
            this.AddTeacherComboBox.Name = "AddTeacherComboBox";
            this.AddTeacherComboBox.Size = new System.Drawing.Size(123, 21);
            this.AddTeacherComboBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Choose Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Choose group";
            // 
            // AddGroupComboBox
            // 
            this.AddGroupComboBox.FormattingEnabled = true;
            this.AddGroupComboBox.Location = new System.Drawing.Point(19, 25);
            this.AddGroupComboBox.Name = "AddGroupComboBox";
            this.AddGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddGroupComboBox.TabIndex = 18;
            // 
            // DeleteSubjectTeacherShow
            // 
            this.DeleteSubjectTeacherShow.Location = new System.Drawing.Point(533, 262);
            this.DeleteSubjectTeacherShow.Name = "DeleteSubjectTeacherShow";
            this.DeleteSubjectTeacherShow.Size = new System.Drawing.Size(104, 34);
            this.DeleteSubjectTeacherShow.TabIndex = 20;
            this.DeleteSubjectTeacherShow.Text = "Delete Subject Teacher";
            this.DeleteSubjectTeacherShow.UseVisualStyleBackColor = true;
            this.DeleteSubjectTeacherShow.Click += new System.EventHandler(this.DeleteSubjectTeacherShow_Click);
            // 
            // DeleteSubjectTeacherPanel
            // 
            this.DeleteSubjectTeacherPanel.Controls.Add(this.label10);
            this.DeleteSubjectTeacherPanel.Controls.Add(this.SubTeacherIdTextbox);
            this.DeleteSubjectTeacherPanel.Controls.Add(this.DeleteSubjectTeacher);
            this.DeleteSubjectTeacherPanel.Controls.Add(this.label12);
            this.DeleteSubjectTeacherPanel.Location = new System.Drawing.Point(449, 302);
            this.DeleteSubjectTeacherPanel.Name = "DeleteSubjectTeacherPanel";
            this.DeleteSubjectTeacherPanel.Size = new System.Drawing.Size(156, 166);
            this.DeleteSubjectTeacherPanel.TabIndex = 25;
            this.DeleteSubjectTeacherPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "SubTeacherId";
            // 
            // SubTeacherIdTextbox
            // 
            this.SubTeacherIdTextbox.Location = new System.Drawing.Point(6, 44);
            this.SubTeacherIdTextbox.Name = "SubTeacherIdTextbox";
            this.SubTeacherIdTextbox.Size = new System.Drawing.Size(136, 20);
            this.SubTeacherIdTextbox.TabIndex = 25;
            // 
            // DeleteSubjectTeacher
            // 
            this.DeleteSubjectTeacher.Location = new System.Drawing.Point(6, 79);
            this.DeleteSubjectTeacher.Name = "DeleteSubjectTeacher";
            this.DeleteSubjectTeacher.Size = new System.Drawing.Size(123, 23);
            this.DeleteSubjectTeacher.TabIndex = 24;
            this.DeleteSubjectTeacher.Text = "Delete Subject Teacher";
            this.DeleteSubjectTeacher.UseVisualStyleBackColor = true;
            this.DeleteSubjectTeacher.Click += new System.EventHandler(this.DeleteSubjectTeacher_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Delete Subject Teacher";
            // 
            // TeachersSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 470);
            this.Controls.Add(this.DeleteSubjectTeacherPanel);
            this.Controls.Add(this.DeleteSubjectTeacherShow);
            this.Controls.Add(this.SubjectTeacherPanel);
            this.Controls.Add(this.AddSubjectTeacherShow);
            this.Controls.Add(this.DisplayGroups);
            this.Controls.Add(this.StaffMainScreenButton);
            this.Controls.Add(this.DisplaySubjects);
            this.Controls.Add(this.DeleteSubjectShow);
            this.Controls.Add(this.AddSubjectShow);
            this.Controls.Add(this.DeleteSubjectPanel);
            this.Controls.Add(this.AddSubjectPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeachersSubjects";
            this.Text = "TeachersSubjects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.AddSubjectPanel.ResumeLayout(false);
            this.AddSubjectPanel.PerformLayout();
            this.DeleteSubjectPanel.ResumeLayout(false);
            this.DeleteSubjectPanel.PerformLayout();
            this.SubjectTeacherPanel.ResumeLayout(false);
            this.SubjectTeacherPanel.PerformLayout();
            this.DeleteSubjectTeacherPanel.ResumeLayout(false);
            this.DeleteSubjectTeacherPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel AddSubjectPanel;
        private System.Windows.Forms.Button AddSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddSubjectTitleTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DeleteSubjectPanel;
        private System.Windows.Forms.Button DeleteSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeleteSubjectTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddSubjectShow;
        private System.Windows.Forms.Button DeleteSubjectShow;
        private System.Windows.Forms.Button DisplaySubjects;
        private System.Windows.Forms.Button StaffMainScreenButton;
        private System.Windows.Forms.Button DisplayGroups;
        private System.Windows.Forms.Button AddSubjectTeacherShow;
        private System.Windows.Forms.Panel SubjectTeacherPanel;
        private System.Windows.Forms.Button AddSubjectTeacher;
        private System.Windows.Forms.ComboBox AddSubjectComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AddTeacherComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddGroupComboBox;
        private System.Windows.Forms.Button DeleteSubjectTeacherShow;
        private System.Windows.Forms.Panel DeleteSubjectTeacherPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SubTeacherIdTextbox;
        private System.Windows.Forms.Button DeleteSubjectTeacher;
        private System.Windows.Forms.Label label12;
    }
}