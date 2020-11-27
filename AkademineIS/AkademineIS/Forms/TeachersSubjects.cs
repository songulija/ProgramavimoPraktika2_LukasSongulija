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
    public partial class TeachersSubjects : Form
    {
        Staff staff;
        SubjectsTeachersRepository repository;
        GroupsRepository groupsRepository;
        UsersRepository usersRepository;
        List<Group> groups = new List<Group>();
        List<Staff> teachers = new List<Staff>();
        List<Subject> subjects = new List<Subject>();
        public TeachersSubjects(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            repository = new SubjectsTeachersRepository();
            groupsRepository = new GroupsRepository();
            usersRepository = new UsersRepository();

            groups = groupsRepository.GetJustGroups();
            teachers = usersRepository.GetJustStaff();

            for (int a = 0; a < groups.Count; a++)
            {
                AddGroupComboBox.Items.Add(groups[a].Name);
            }


            for (int a = 0; a < teachers.Count; a++)
            {
                AddTeacherComboBox.Items.Add(teachers[a].FirstName + " " + teachers[a].LastName);
            }
        }

        private void AddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = new Subject();
                subject.Title = AddSubjectTitleTextbox.Text;
                repository.InsertSubject(subject);
                AddSubjectTitleTextbox.Clear();


            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Subject succesfully added");
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = new Subject();
                subject.SubjectId = int.Parse(DeleteSubjectTextbox.Text);
                repository.DeleteSubject(subject);
                DeleteSubjectTextbox.Clear();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Subject succesfully deleted");
        }

        private void StaffMainScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffMainScreen akadScreen = new StaffMainScreen(staff);
            akadScreen.Show();
        }

        private void DisplaySubjects_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = repository.DisplaySubjects();
                dataGridView1.DataSource = dta;

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void AddSubjectShow_Click(object sender, EventArgs e)
        {
            DeleteSubjectPanel.Visible = false;
            AddSubjectPanel.Visible = true;
        }

        private void DeleteSubjectShow_Click(object sender, EventArgs e)
        {
            AddSubjectPanel.Visible = false;
            DeleteSubjectPanel.Visible = true;
        }

        private void DisplayGroups_Click(object sender, EventArgs e)
        {
            subjects = repository.GetJustSubjects();
            for (int a = 0; a < subjects.Count; a++)
            {
                AddSubjectComboBox.Items.Add(subjects[a].Title);
            }
            //DISPLAY TEACHER SUBJECTS
            try
            {
                DataTable dta = repository.DisplaySubjectTeachers();
                dataGridView2.DataSource = dta;

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }

        private void AddSubjectTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                
                int groupSelectedIndex = AddGroupComboBox.SelectedIndex;
                int GroupId = groups[groupSelectedIndex].GroupId;

                int teacherSelectedIndex = AddTeacherComboBox.SelectedIndex;
                int TeacherId = teachers[teacherSelectedIndex].StaffId;

                int subjectSelectedIndex = AddSubjectComboBox.SelectedIndex;
                int SubjectId = subjects[subjectSelectedIndex].SubjectId;
                Console.WriteLine("Group Id:" + GroupId + " Teacher Id:" + TeacherId + " Subject Id:" + SubjectId);

                repository.InsertSubjectTeacher(SubjectId, TeacherId, GroupId);

                groups = groupsRepository.GetJustGroups();
                teachers = usersRepository.GetJustStaff();
                subjects = repository.GetJustSubjects();


            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Succesfully Inserted SubjectTeacher");


        }

        private void AddSubjectTeacherShow_Click(object sender, EventArgs e)
        {
            SubjectTeacherPanel.Visible = true;
        }

        private void DeleteSubjectTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int subjectTeacherId = int.Parse(SubTeacherIdTextbox.Text);
                repository.DeleteSubjectTeacher(subjectTeacherId);
                SubTeacherIdTextbox.Clear();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("SubjectTeacher succesfully deleted");
        }

        private void DeleteSubjectTeacherShow_Click(object sender, EventArgs e)
        {
            SubjectTeacherPanel.Visible = false;
            DeleteSubjectTeacherPanel.Visible = true;
        }
    }
}
