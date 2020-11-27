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
    class UsersRepository
    {
        string connectionString= "Data Source=DESKTOP-6DB6D8B;Initial Catalog=akademineIS;Integrated Security=True";
        SqlConnection cnn;


        public Staff LoginStaffUser(string username, string password)
        {
            Staff staff = new Staff();

            try
            {
                //select user from database if password and username matches
                cnn = new SqlConnection(connectionString);//create new sql connection
                SqlCommand cmd = new SqlCommand("Select StaffId,FirstName,LastName,TypeId FROM StaffTable WHERE Username=@Username AND Password=@Password", cnn);
                //parametrised Sql Command, have to provide values that we wrote
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cnn.Open();//have to open connection, execute command and then we can close connection
                SqlDataReader reader = cmd.ExecuteReader();//we want to read rows that we get with this command
                while (reader.Read())//while reader can read, while there is information/rows of data
                {
                    //get all values from row
                    int StaffId = int.Parse(reader["StaffId"].ToString());
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    int TypeId = int.Parse(reader["TypeId"].ToString());

                    //create Staff object
                    
                    staff.StaffId = StaffId;
                    staff.FirstName = FirstName;
                    staff.LastName = LastName;
                    staff.Username = username;
                    staff.Password = password;
                    staff.TypeId = TypeId;
                    
                }

                cnn.Close();
                return staff;

            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            
        }

        public Student LoginStudent(string username, string password)
        {
            Student student = new Student();
            try
            {
                
                //STUDENT
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select StudentId,FirstName,LastName,GroupId FROM StudentsTable where Username=@Username AND Password=@Password",cnn);
                //parametrised Sql Command, have to provide values that we wrote
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//we want to read rows that we get with this command
                while (reader.Read())//while reader can read, while there is information/rows of data
                {
                    //get all values from row
                    int StudentId = int.Parse(reader["StudentId"].ToString());
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    int GroupId = int.Parse(reader["GroupId"].ToString());

                    //create Student object

                    student.StudentId = StudentId;
                    student.FirstName = FirstName;
                    student.LastName = LastName;
                    student.Username = username;
                    student.Password = password;
                    student.GroupId = GroupId;

                }

                cnn.Close();
                Console.WriteLine(student.Password);
                return student;
                
            }catch(Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            
        }


        //REGISTER STUDENT
        public Student RegisterStudent(Student student)//provide student object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new SqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                SqlCommand cmd = new SqlCommand("Select * from StudentsTable where Username=@Username", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Username", student.Username);
                SqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))//if dataReader.Read is true then it means that it found User with that Username
                {
                    //then User with that Username already exists
                    Console.WriteLine("User with that Username already exists");
                    return null;//if username exist than it will not watch script bellow, it will just return
                }

                else//there is no user with that Username that we want to register
                {
                    //so we can register user
                    Console.WriteLine("Username is free so you can register");
                }
                dataReader.Close();//close data reader when it finishes work

                SqlCommand cmd1 = new SqlCommand("Insert into StudentsTable (FirstName,LastName,GroupId,Username,Password) VALUES(@FirstNAme,@LastName,@GroupId,@Username,@Password)", cnn);
                cmd1.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd1.Parameters.AddWithValue("@LastName", student.LastName);
                cmd1.Parameters.AddWithValue("@GroupId", student.GroupId);
                cmd1.Parameters.AddWithValue("@Username", student.Username);
                cmd1.Parameters.AddWithValue("@Password", student.Password);

                cmd1.ExecuteNonQuery();
                cnn.Close();
                
            }catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
            return student;//return 
        }


        //REGISTER STAFF
        public Staff RegisterStaff(Staff staff)//provide student object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new SqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                SqlCommand cmd = new SqlCommand("Select * from StaffTable where Username=@Username", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Username", staff.Username);
                SqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))//if dataReader.Read is true then it means that it found User with that Username
                {
                    //then User with that Username already exists
                    Console.WriteLine("Staff with that Username already exists");
                    return null;//if username exist than it will not watch script bellow, it will just return
                }

                else//there is no user with that Username that we want to register
                {
                    //so we can register user
                    Console.WriteLine("Staff Username is free so you can register");
                }
                dataReader.Close();//close data reader when it finishes work

                SqlCommand cmd1 = new SqlCommand("Insert into StaffTable (FirstName,LastName,Username,Password,TypeId) VALUES(@FirstNAme,@LastName,@Username,@Password,@TypeId)", cnn);
                cmd1.Parameters.AddWithValue("@FirstName", staff.FirstName);
                cmd1.Parameters.AddWithValue("@LastName", staff.LastName);
                cmd1.Parameters.AddWithValue("@Username", staff.Username);
                cmd1.Parameters.AddWithValue("@Password", staff.Password);
                cmd1.Parameters.AddWithValue("@TypeId", staff.TypeId);

                cmd1.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return staff;//return 
        }




        public void DeleteStudent(int StudentId)
        {
            try
            {
                cnn = new SqlConnection(connectionString);

                string newSql = ("Delete from StudentsTable where StudentsTable.StudentId=@id ");
                newSql += ("Delete from MarksTable where MarksTable.StudentId=@id");

                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@id", StudentId);
                cmd.ExecuteNonQuery();//execute function

                cnn.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
            
        }
        public void DeleteStaff(int StaffId)
        {
            try
            {
                cnn = new SqlConnection(connectionString);

                string newSql = ("Delete from StaffTable where StaffTable.StaffId=@id ");
                newSql += ("Delete from SubjectTeacherTable where SubjectTeacherTable.StaffId=@id");

                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@id", StaffId);
                cmd.ExecuteNonQuery();//execute function

                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }

        public DataTable DisplayStudents()
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

            SqlCommand cmd = new SqlCommand("Select * from StudentsTable", cnn);//select all from newTestTable
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }
        public DataTable DisplayStaff()
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

            SqlCommand cmd = new SqlCommand("Select * from StaffTable", cnn);//select all from newTestTable
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }


        public List<Staff> GetJustStaff()
        {
            List<Staff> staffList = new List<Staff>();
            try
            {

                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from StaffTable", cnn);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//read all rows of data that we get from database
                while (reader.Read())//while reader can read, while there are rows of data it will read
                {
                    int StaffId = int.Parse(reader["StaffId"].ToString());
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();


                    Staff newStaff = new Staff();
                    newStaff.StaffId = StaffId;
                    newStaff.FirstName = FirstName;
                    newStaff.LastName = LastName;

                    staffList.Add(newStaff);
                }
                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            return staffList;


        }


        



    }
}
