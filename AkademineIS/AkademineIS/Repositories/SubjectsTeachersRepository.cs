using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AkademineIS.Classes;

namespace AkademineIS.Repositories
{
    class SubjectsTeachersRepository
    {
        string connectionString = "Data Source=DESKTOP-6DB6D8B;Initial Catalog=akademineIS;Integrated Security=True";
        SqlConnection cnn;
        public void InsertSubject(Subject subject)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Insert into SubjectsTable(Title) VALUES(@Title)", cnn);
                cmd.Parameters.AddWithValue("@Title", subject.Title);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }


        }

        public void DeleteSubject(Subject subject)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                string newSql = ("Delete from SubjectsTable where SubjectsTable.SubjectId=@id ");
                newSql += ("Delete from MarksTable where MarksTable.SubjectId=@id ");
                newSql += ("Delete from SubjectTeacherTable where SubjectTeacherTable.SubjectId=@id ");

                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@id", subject.SubjectId);

                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        public DataTable DisplaySubjects()
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

            SqlCommand cmd = new SqlCommand("Select * from SubjectsTable", cnn);//select all from newTestTable
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }


        public List<Subject> GetJustSubjects()
        {
            List<Subject> subjectList = new List<Subject>();
            try
            {

                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from SubjectsTable", cnn);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//read all rows of data that we get from database
                while (reader.Read())//while reader can read, while there are rows of data it will read
                {
                    int SubjectId = int.Parse(reader["SubjectId"].ToString());
                    string Title = reader["Title"].ToString();


                    Subject newSubject = new Subject();
                    newSubject.SubjectId = SubjectId;
                    newSubject.Title = Title;


                    subjectList.Add(newSubject);
                }
                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            return subjectList;


        }



        public void InsertSubjectTeacher(int SubjectId, int StaffId, int GroupId)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Insert INTO SubjectTeacherTable(SubjectId,StaffId,GroupId) VALUES(@SubjectId,@StaffId,@GroupId)", cnn);
                cmd.Parameters.AddWithValue("@SubjectId", SubjectId);
                cmd.Parameters.AddWithValue("@StaffId", StaffId);
                cmd.Parameters.AddWithValue("@GroupId", GroupId);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
            
        }

        public DataTable DisplaySubjectTeachers()
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
            string sqlCommand = "Select SubjectTeacherTable.SubTeacherId, SubjectTeacherTable.SubjectId, SubjectTeacherTable.StaffId, SubjectTeacherTable.GroupId, FirstName, LastName, Name, Title from SubjectTeacherTable inner join StaffTable on SubjectTeacherTable.StaffId= StaffTable.StaffId inner join GroupsTable on SubjectTeacherTable.GroupId= GroupsTable.GroupId inner join SubjectsTable on SubjectTeacherTable.SubjectId= SubjectsTable.SubjectId";
            SqlCommand cmd = new SqlCommand(sqlCommand, cnn);//select all from newTestTable
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }


        public void DeleteSubjectTeacher(int SubjectTeacherId)//provide id
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                SqlCommand cmd = new SqlCommand("Delete from SubjectTeacherTable where SubTeacherId=@SubTeacherId", cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@SubTeacherId", SubjectTeacherId);
                cmd.ExecuteNonQuery();//execute function

                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }


        public List<Group> GetGroupsOfStaff(int StaffId)
        {
            List<Group> groupsList = new List<Group>();
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select GroupsTable.GroupId,Name from GroupsTable inner join SubjectTeacherTable on GroupsTable.GroupId=SubjectTeacherTable.GroupId where StaffId=@Id", cnn);
                cmd.Parameters.AddWithValue("@Id", StaffId);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int groupId = int.Parse(reader["GroupId"].ToString());
                    string Name = reader["Name"].ToString();
                    Group newGroup = new Group();
                    newGroup.GroupId = groupId;
                    newGroup.Name = Name;
                    groupsList.Add(newGroup);
                }
                cnn.Close();
            }catch(Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }

            return groupsList;

        }

        public List<Subject> GetSubjectsOfStaff(int StaffId)
        {
            List<Subject> subjectsList = new List<Subject>();
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select SubjectsTable.SubjectId, Title from SubjectsTable inner join SubjectTeacherTable on SubjectsTable.SubjectId=SubjectTeacherTable.SubjectId where StaffId=@Id", cnn);
                cmd.Parameters.AddWithValue("@Id", StaffId);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int SubjectId = int.Parse(reader["SubjectId"].ToString());
                    string Title = reader["Title"].ToString();
                    Subject newSubject = new Subject();
                    newSubject.SubjectId = SubjectId;
                    newSubject.Title = Title;
                    subjectsList.Add(newSubject);
                }
                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }

            return subjectsList;
        }


        public List<Student> GetStudentsOfGroup(int GroupId)
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select StudentId, FirstName,LastName from StudentsTable inner join GroupsTable on StudentsTable.GroupId=GroupsTable.GroupId where StudentsTable.GroupId=@Id", cnn);
                cmd.Parameters.AddWithValue("@Id", GroupId);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//execute command and read rows of data that we get
                while (reader.Read())//while reader can read, while there are rows of data that it can read
                {
                    int StudentId = int.Parse(reader["StudentId"].ToString());
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    Student newStudent = new Student();
                    newStudent.StudentId = StudentId;
                    newStudent.FirstName = FirstName;
                    newStudent.LastName = LastName;
                    studentsList.Add(newStudent);
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            return studentsList;
        }




    }
}
