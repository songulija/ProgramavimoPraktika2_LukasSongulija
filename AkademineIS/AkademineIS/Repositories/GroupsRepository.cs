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
    class GroupsRepository
    {
        SqlConnection cnn;
        string connectionString = "Data Source=DESKTOP-6DB6D8B;Initial Catalog=akademineIS;Integrated Security=True";
        public DataTable DisplayGroups()
        {
            cnn = new SqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
            cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

            SqlCommand cmd = new SqlCommand("Select * from GroupsTable", cnn);//select all from newTestTable
            cmd.ExecuteNonQuery();//execute function
            DataTable dta = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dta);

            cnn.Close();
            return dta;
        }

        public void InsertGroup(Group group)
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Insert into GroupsTable(Name) VALUES(@Name)", cnn);
                cmd.Parameters.AddWithValue("@Name", group.Name);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
            

        }

        
        public void DeleteGroup(Group group)
        {
            try
            {
                cnn = new SqlConnection(connectionString);

                string newSql = ("Delete from GroupsTable where GroupsTable.GroupId=@id ");
                newSql += ("Delete from StudentsTable where StudentsTable.GroupId=@id ");
                newSql += ("Delete from SubjectTeacherTable where SubjectTeacherTable.GroupId=@id");

                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                SqlCommand cmd = new SqlCommand(newSql, cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@id", group.GroupId);
                cmd.ExecuteNonQuery();//execute function

                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }


        public List<Group> GetJustGroups()
        {
            List<Group> groupsList = new List<Group>();
            try
            {
                
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from GroupsTable", cnn);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//read all rows of data that we get from database
                while (reader.Read())//while reader can read, while there are rows of data it will read
                {
                    int GroupId = int.Parse(reader["GroupId"].ToString());
                    string Name = reader["Name"].ToString();
                    Group newGroup = new Group();
                    newGroup.GroupId = GroupId;
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
    }
}
