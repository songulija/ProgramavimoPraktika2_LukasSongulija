using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkademineIS.Repositories;
using AkademineIS.Classes;

namespace AkademineIS.Forms
{
    public partial class LoginScreen : Form
    {
        UsersRepository repository;
        public LoginScreen()
        {
            InitializeComponent();
            repository = new UsersRepository();//initialize repository 



        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            Student student = repository.LoginStudent(StudentUsernameTextbox.Text, StudentPasswordTextbox.Text);//LoginUser will return Staff object if it is succesful Login
            if (student.FirstName != null)//if staff is not equal to null means it returned user
            {
                this.Hide();
                AkademineisScreen akadScreen = new AkademineisScreen(student);
                akadScreen.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void ShowStaffPanel_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            StaffPanel.Visible = true;
        }

        private void StudentPanelShow_Click(object sender, EventArgs e)
        {
            StaffPanel.Visible = false;
            StudentPanel.Visible = true;
        }

        private void StaffLogin_Click(object sender, EventArgs e)
        {
            Staff staff = repository.LoginStaffUser(StaffUsernameTextbox.Text, StaffPasswordTextbox.Text);//LoginUser will return Staff object if it is succesful Login

            if (staff.FirstName != null)//if staff is not equal to null means it returned user
            {
                Console.WriteLine(staff.FirstName);
                
                this.Hide();
                StaffMainScreen akadScreen = new StaffMainScreen(staff);
                akadScreen.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
