namespace AkademineIS.Forms
{
    partial class LoginScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentLoginButton = new System.Windows.Forms.Button();
            this.StudentPasswordTextbox = new System.Windows.Forms.TextBox();
            this.StudentUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StaffLogin = new System.Windows.Forms.Button();
            this.StaffPasswordTextbox = new System.Windows.Forms.TextBox();
            this.StaffUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowStaffPanel = new System.Windows.Forms.Button();
            this.StudentPanelShow = new System.Windows.Forms.Button();
            this.StudentPanel.SuspendLayout();
            this.StaffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "VILNIAUS KOLEGIJA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(287, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "AKADEMINE INFORMACIJOS SISTEMA";
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.label5);
            this.StudentPanel.Controls.Add(this.StudentLoginButton);
            this.StudentPanel.Controls.Add(this.StudentPasswordTextbox);
            this.StudentPanel.Controls.Add(this.StudentUsernameTextbox);
            this.StudentPanel.Controls.Add(this.label4);
            this.StudentPanel.Controls.Add(this.label3);
            this.StudentPanel.Location = new System.Drawing.Point(220, 137);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(248, 213);
            this.StudentPanel.TabIndex = 7;
            this.StudentPanel.Visible = false;
            // 
            // StudentLoginButton
            // 
            this.StudentLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentLoginButton.Location = new System.Drawing.Point(45, 132);
            this.StudentLoginButton.Name = "StudentLoginButton";
            this.StudentLoginButton.Size = new System.Drawing.Size(127, 42);
            this.StudentLoginButton.TabIndex = 11;
            this.StudentLoginButton.Text = "Prisijungti";
            this.StudentLoginButton.UseVisualStyleBackColor = true;
            this.StudentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // StudentPasswordTextbox
            // 
            this.StudentPasswordTextbox.Location = new System.Drawing.Point(45, 106);
            this.StudentPasswordTextbox.Name = "StudentPasswordTextbox";
            this.StudentPasswordTextbox.Size = new System.Drawing.Size(159, 20);
            this.StudentPasswordTextbox.TabIndex = 10;
            // 
            // StudentUsernameTextbox
            // 
            this.StudentUsernameTextbox.Location = new System.Drawing.Point(45, 59);
            this.StudentUsernameTextbox.Name = "StudentUsernameTextbox";
            this.StudentUsernameTextbox.Size = new System.Drawing.Size(159, 20);
            this.StudentUsernameTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(45, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slaptazodis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vartotojo vardas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(63, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Login";
            // 
            // StaffPanel
            // 
            this.StaffPanel.Controls.Add(this.label6);
            this.StaffPanel.Controls.Add(this.StaffLogin);
            this.StaffPanel.Controls.Add(this.StaffPasswordTextbox);
            this.StaffPanel.Controls.Add(this.StaffUsernameTextbox);
            this.StaffPanel.Controls.Add(this.label7);
            this.StaffPanel.Controls.Add(this.label8);
            this.StaffPanel.Location = new System.Drawing.Point(474, 137);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(248, 213);
            this.StaffPanel.TabIndex = 13;
            this.StaffPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(63, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Staff Login";
            // 
            // StaffLogin
            // 
            this.StaffLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StaffLogin.Location = new System.Drawing.Point(45, 132);
            this.StaffLogin.Name = "StaffLogin";
            this.StaffLogin.Size = new System.Drawing.Size(127, 42);
            this.StaffLogin.TabIndex = 11;
            this.StaffLogin.Text = "Prisijungti";
            this.StaffLogin.UseVisualStyleBackColor = true;
            this.StaffLogin.Click += new System.EventHandler(this.StaffLogin_Click);
            // 
            // StaffPasswordTextbox
            // 
            this.StaffPasswordTextbox.Location = new System.Drawing.Point(45, 106);
            this.StaffPasswordTextbox.Name = "StaffPasswordTextbox";
            this.StaffPasswordTextbox.Size = new System.Drawing.Size(159, 20);
            this.StaffPasswordTextbox.TabIndex = 10;
            // 
            // StaffUsernameTextbox
            // 
            this.StaffUsernameTextbox.Location = new System.Drawing.Point(45, 59);
            this.StaffUsernameTextbox.Name = "StaffUsernameTextbox";
            this.StaffUsernameTextbox.Size = new System.Drawing.Size(159, 20);
            this.StaffUsernameTextbox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(45, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Slaptazodis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(45, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vartotojo vardas:";
            // 
            // ShowStaffPanel
            // 
            this.ShowStaffPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowStaffPanel.Location = new System.Drawing.Point(22, 172);
            this.ShowStaffPanel.Name = "ShowStaffPanel";
            this.ShowStaffPanel.Size = new System.Drawing.Size(165, 64);
            this.ShowStaffPanel.TabIndex = 14;
            this.ShowStaffPanel.Text = "Staff Login";
            this.ShowStaffPanel.UseVisualStyleBackColor = true;
            this.ShowStaffPanel.Click += new System.EventHandler(this.ShowStaffPanel_Click);
            // 
            // StudentPanelShow
            // 
            this.StudentPanelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentPanelShow.Location = new System.Drawing.Point(22, 253);
            this.StudentPanelShow.Name = "StudentPanelShow";
            this.StudentPanelShow.Size = new System.Drawing.Size(165, 64);
            this.StudentPanelShow.TabIndex = 15;
            this.StudentPanelShow.Text = "Student Login";
            this.StudentPanelShow.UseVisualStyleBackColor = true;
            this.StudentPanelShow.Click += new System.EventHandler(this.StudentPanelShow_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffPanel);
            this.Controls.Add(this.StudentPanelShow);
            this.Controls.Add(this.ShowStaffPanel);
            this.Controls.Add(this.StudentPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            this.StaffPanel.ResumeLayout(false);
            this.StaffPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Button StudentLoginButton;
        private System.Windows.Forms.TextBox StudentPasswordTextbox;
        private System.Windows.Forms.TextBox StudentUsernameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel StaffPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StaffLogin;
        private System.Windows.Forms.TextBox StaffPasswordTextbox;
        private System.Windows.Forms.TextBox StaffUsernameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowStaffPanel;
        private System.Windows.Forms.Button StudentPanelShow;
    }
}