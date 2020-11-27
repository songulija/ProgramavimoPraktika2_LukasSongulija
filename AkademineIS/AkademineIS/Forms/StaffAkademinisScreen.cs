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
using System.Globalization;

namespace AkademineIS.Forms
{
    public partial class StaffAkademinisScreen : Form
    {
        Staff staff;
        UsersRepository repository;
        GroupsRepository groupRepository;

        public StaffAkademinisScreen(Staff staff)//constructor
        {
            InitializeComponent();
            this.staff = staff;//this class staff will be equal to staff OBJECT that we provide when we go to this screen
            repository = new UsersRepository();
            groupRepository = new GroupsRepository();
        }

        private void RegisterStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create student object out of textbox values
                Student student = new Student();
                student.FirstName = RegisterStudentFName.Text;
                student.LastName = RegisterStudentLastN.Text;
                student.Username = RegisterStudentFName.Text;
                student.Password = RegisterStudentLastN.Text;
                student.GroupId = int.Parse(RegisterStudentGroup.Text);
                repository.RegisterStudent(student);


                //clear all fealds
                RegisterStudentFName.Clear();
                RegisterStudentLastN.Clear();

                RegisterStudentGroup.Clear();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Register of student succesful");

        }

        private void RegisterStaffButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create student object out of textbox values
                Staff staff = new Staff();
                staff.FirstName = RegisterStaffFName.Text;
                staff.LastName = RegisterStaffLName.Text;
                staff.Username = RegisterStaffFName.Text;
                staff.Password = RegisterStaffLName.Text;
                staff.TypeId = 1;//we can register only Teachers not admins, so Type id always will be 1(Teacher)
                repository.RegisterStaff(staff);

                //clear all fealds
                RegisterStaffFName.Clear();
                RegisterStaffLName.Clear();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Register of staff succesful");
        }
        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentId = int.Parse(DeleteStudentTextbox.Text);
                repository.DeleteStudent(StudentId);

            }catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            MessageBox.Show("Delete of student succesful");

        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int StaffId = int.Parse(DeleteStaffTextbox.Text);
                repository.DeleteStaff(StaffId);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            MessageBox.Show("Delete of student succesful");
        }

        private void RegisterStudButtonShow_Click(object sender, EventArgs e)
        {
            DeleteStudentPanel.Visible = false;
            DeleteStaffPanel.Visible = false;
            RegisterStaffPanel.Visible = false;
            RegisterStudentPanel.Visible = true;
        }

        private void RegisterStaffButtonShow_Click(object sender, EventArgs e)
        {
            DeleteStudentPanel.Visible = false;
            DeleteStaffPanel.Visible = false;
            RegisterStudentPanel.Visible = false;
            RegisterStaffPanel.Visible = true;
        }

        private void DisplayStudentsGrid_Click(object sender, EventArgs e)
        {
            DataTable dta = repository.DisplayStudents();
            dataGridView1.DataSource = dta;
        }

        private void DisplayStaffGrid_Click(object sender, EventArgs e)
        {
            DataTable dta = repository.DisplayStaff();
            dataGridView1.DataSource = dta;
        }

        
        private void DeleteStudentShow_Click(object sender, EventArgs e)
        {
            RegisterStudentPanel.Visible = false;
            RegisterStaffPanel.Visible = false;
            DeleteStaffPanel.Visible = false;
            DeleteStudentPanel.Visible = true;


        }

        private void DeleteStaffShow_Click(object sender, EventArgs e)
        {
            RegisterStudentPanel.Visible = false;
            RegisterStaffPanel.Visible = false;
            DeleteStudentPanel.Visible = false;
            DeleteStaffPanel.Visible = true;
        }

        private void DisplayGroupsButton_Click(object sender, EventArgs e)
        {
            DataTable dta = groupRepository.DisplayGroups();
            dataGridView2.DataSource = dta;
        }

        private void AddGroupShow_Click(object sender, EventArgs e)
        {
            DeleteGroupPanel.Visible = false;
            AddGroupPanel.Visible = true;
        }

        private void DeleteGroupShow_Click(object sender, EventArgs e)
        {
            AddGroupPanel.Visible = false;
            DeleteGroupPanel.Visible = true;
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                //create new group object and provide it for function to insert new group to database
                Group group = new Group();
                group.Name = AddGroupTextbox.Text;
                groupRepository.InsertGroup(group);
                AddGroupTextbox.Clear();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            MessageBox.Show("Insert of Group succesful");
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                //create new group object and provide it for function to insert new group to database
                Group group = new Group();
                group.GroupId = int.Parse(DeleteGroupTexbox.Text);
                groupRepository.DeleteGroup(group);
                DeleteGroupTexbox.Clear();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            MessageBox.Show("Delete of Group succesful");
        }

        private void StaffMainScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffMainScreen akadScreen = new StaffMainScreen(staff);
            akadScreen.Show();
        }
    }
}
