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
    class MarksRepository
    {
        SqlConnection cnn;
        string connectionString = "Data Source=DESKTOP-6DB6D8B;Initial Catalog=akademineIS;Integrated Security=True";

        public DataTable DisplayStudentMarks(int studentId)
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
            string newSql = "Select StudentsTable.StudentId, FirstName, LastName, Mark, Date, MarksTable.SubjectId, Title from StudentsTable inner join MarksTable on StudentsTable.StudentId= MarksTable.StudentId inner join SubjectsTable on MarksTable.SubjectId= SubjectsTable.SubjectId where StudentsTable.StudentId=@Id ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
            cmd.Parameters.AddWithValue("@Id", studentId);
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }


        public DataTable DisplayStudentsMarksForTeacher(int SubjectId,int GroupId)
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
            string newSql = "Select MarksTable.MarkId,Title,FirstName,LastName,Mark from MarksTable inner join StudentsTable on MarksTable.StudentId=StudentsTable.StudentId inner join SubjectsTable on MarksTable.SubjectId = SubjectsTable.SubjectId where SubjectsTable.SubjectId=@goodSubjectId and StudentsTable.GroupId=@goodGroupId";
            SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
            cmd.Parameters.AddWithValue("@goodSubjectId", SubjectId);
            cmd.Parameters.AddWithValue("@goodGroupId", GroupId);
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }

        public void InsertMark(Marks mark)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Insert into MarksTable(StudentId,SubjectId,Date,Mark) VALUES(@StudentId,@SubjectId,@Date,@Mark)", cnn);
                cmd.Parameters.AddWithValue("@StudentId", mark.StudentId);
                cmd.Parameters.AddWithValue("@SubjectId", mark.SubjectId);
                cmd.Parameters.AddWithValue("@Date", mark.Date);
                cmd.Parameters.AddWithValue("@Mark", mark.Mark);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }catch(Exception exc)
            {
                Console.WriteLine(exc);
            }

        }


        public void UpdateMark(int MarkId, int Mark)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Update MarksTable SET Mark=@Mark WHERE MarkId=@MarkId", cnn);
                cmd.Parameters.AddWithValue("@Mark", Mark);
                cmd.Parameters.AddWithValue("@MarkId", MarkId);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
            

        }



    }
}
