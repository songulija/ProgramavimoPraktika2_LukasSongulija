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
    public partial class StaffMainScreen : Form
    {
        Staff staff;
        MarksRepository repository;
        SubjectsTeachersRepository subteachRepository;
        List<Group> groupsList = new List<Group>();
        List<Subject> subjectsList = new List<Subject>();
        List<Student> studentsList = new List<Student>();

        public StaffMainScreen(Staff staff)//when going to this screen you have to provide staff object
        {
            InitializeComponent();
            this.staff = staff;
            repository = new MarksRepository();
            subteachRepository = new SubjectsTeachersRepository();

            if (staff.TypeId == 2)//if staff is ADMIN then show these panels, otherwise dont
            {
                TvarkytiNaudotojusPanel.Visible = true;
                SubjectTeacherPanel.Visible = true;
            }
            groupsList = subteachRepository.GetGroupsOfStaff(staff.StaffId);
            subjectsList = subteachRepository.GetSubjectsOfStaff(staff.StaffId);
            for (int a = 0; a < subjectsList.Count; a++)
            {
                SubjectNameDisplaycomboBox.Items.Add(subjectsList[a].Title);
            }


            for (int a = 0; a < groupsList.Count; a++)
            {
                GroupNameDisplaycomboBox.Items.Add(groupsList[a].Name);
            }

            UserName.Text = staff.Username + "" + staff.Password;

        }

        private void TvarkytiNaudotojus_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffAkademinisScreen akadScreen = new StaffAkademinisScreen(staff);
            akadScreen.Show();
        }

        private void EditTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersSubjects akadScreen = new TeachersSubjects(staff);
            akadScreen.Show();
        }

        private void DisplayMarks_Click(object sender, EventArgs e)
        {
            
            try
            {
                int groupSelectedIndex = GroupNameDisplaycomboBox.SelectedIndex;
                int GroupId = groupsList[groupSelectedIndex].GroupId;

                int subjectSelectedIndex = SubjectNameDisplaycomboBox.SelectedIndex;
                int SubjectId = subjectsList[subjectSelectedIndex].SubjectId;
                DataTable dta = repository.DisplayStudentsMarksForTeacher(SubjectId, GroupId);
                dataGridView1.DataSource = dta;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                
            }
        }

        private void AddMarkShow_Click(object sender, EventArgs e)
        {
            try
            {
                //Add mark subject COMBOBOX filling
                for (int a = 0; a < subjectsList.Count; a++)
                {
                    AddMarkSubjectCombobox.Items.Add(subjectsList[a].Title);
                }


                UpdateMarkpanel.Visible = false;
                AddMarkPanel.Visible = true;
                for (int a = 0; a < groupsList.Count; a++)
                {
                    AddMarkGroupCombobox.Items.Add(groupsList[a].Name);
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            

        }

        private void UpdateMarkShow_Click(object sender, EventArgs e)
        {
            AddMarkPanel.Visible = false;
            UpdateMarkpanel.Visible = true;
        }

        private void AddMarkGetStudents_Click(object sender, EventArgs e)
        {
            try
            {
                int groupAddSelectedIndex = AddMarkGroupCombobox.SelectedIndex;
                int GroupId = groupsList[groupAddSelectedIndex].GroupId;

                studentsList = subteachRepository.GetStudentsOfGroup(GroupId);
                for(int a = 0; a < studentsList.Count; a++)
                {
                    AddMarkStudentsCombobox.Items.Add(studentsList[a].FirstName + " " + studentsList[a].LastName);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }

        private void AddMark_Click(object sender, EventArgs e)
        {
            try
            {
                int groupAddSelectedIndex = AddMarkGroupCombobox.SelectedIndex;
                int GroupId = groupsList[groupAddSelectedIndex].GroupId;

                int StudentAddSelectedIndex = AddMarkStudentsCombobox.SelectedIndex;
                int StudentId = studentsList[StudentAddSelectedIndex].StudentId;

                int SubjectAddSelectedIndex = AddMarkSubjectCombobox.SelectedIndex;
                int SubjectId = subjectsList[SubjectAddSelectedIndex].SubjectId;

                Marks newMark = new Marks();
                newMark.StudentId = StudentId;
                newMark.SubjectId = SubjectId;
                newMark.Date = DateTime.Now.Date;
                newMark.Mark = int.Parse(AddMarkMarkTextbox.Text);

                //insert into database
                repository.InsertMark(newMark);
                AddMarkMarkTextbox.Clear();


            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void UpdateMark_Click(object sender, EventArgs e)
        {
            try
            {
                int UpdateMarkId = int.Parse(UpdateMarkIdtextBox.Text);
                int UpdateMark = int.Parse(UpdateMarktextBox.Text);
                repository.UpdateMark(UpdateMarkId, UpdateMark);
                UpdateMarkIdtextBox.Clear();
                UpdateMarktextBox.Clear();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
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
