using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkademineIS.Classes;
using AkademineIS.Repositories;

namespace AkademineIS.Forms
{
    public partial class AkademineisScreen : Form
    {
        Student student;
        MarksRepository repository;
        
        public AkademineisScreen(Student student)//constructor, when going to this screen we can provide values/objects to this screen
        {
            InitializeComponent();
            this.student = student;
            repository = new MarksRepository();//initialize repository
            StudentNameLabel.Text = student.FirstName + " " + student.LastName;

        }

        private void DisplayMarks_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = repository.DisplayStudentMarks(student.StudentId);
                dataGridView1.DataSource = dta;
                

            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen l = new LoginScreen();
            l.ShowDialog();
            this.Close();
        }
    }
}
