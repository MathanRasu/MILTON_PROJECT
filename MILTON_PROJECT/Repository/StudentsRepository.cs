using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MILTON_PROJECT.IRepository;
using MILTON_PROJECT.Models;
using MILTON_PROJECT.Repository.StoredProcedures;
using MILTON_PROJECT.Repository.UnitOfWorks;

namespace MILTON_PROJECT.Repository
{
    public class StudentsRepository : IStudents
    {
        //SqlConnection sqlConnection;
        //SqlCommand SqlCommand = new SqlCommand();
        Procedures_List Procedures_List = new Procedures_List();
        public static string Connectionstring = @"Data Source=HP_MATHAN;Initial Catalog = School_Management_System; User ID =Sa; Password = Password@123";



        public void AddNewStudent(Students students)
        {
            SqlConnection sqlConnection = new SqlConnection(Connectionstring);
            SqlCommand SqlCommand;
            string AddStudent = Procedures_List.AddStudent;
            SqlCommand = new SqlCommand(AddStudent, sqlConnection);
            SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCommand.Parameters.AddWithValue("@RegisterNo", students.RegisterNo);
            SqlCommand.Parameters.AddWithValue("@StudentName", students.StudentName);
            SqlCommand.Parameters.AddWithValue("@Class", students.Class);
            SqlCommand.Parameters.AddWithValue("@BloodGroup", students.BloodGroup);
            SqlCommand.Parameters.AddWithValue("@RelationType", students.RelationType);
            SqlCommand.Parameters.AddWithValue("@RelationName", students.RelationName);
            SqlCommand.Parameters.AddWithValue("@RelationContactNumber", students.RelationContactNumber);
            SqlCommand.Parameters.AddWithValue("@Address1", students.Address1);
            SqlCommand.Parameters.AddWithValue("@Address2", students.Address2);
            SqlCommand.Parameters.AddWithValue("@Permanent_Phone_Number", students.Permanent_Phone_Number);
            SqlCommand.Parameters.AddWithValue("@AlternativeNumber", students.AlternativeNumber);
            SqlCommand.ExecuteNonQuery();
            SqlCommand.Connection.Close();
            SqlCommand.Connection.Dispose();


        }

        public void AddStudentAttendance()
        {
            throw new NotImplementedException();
        }

        public void AddstudentMarksDetails()
        {
            throw new NotImplementedException();
        }

        public void GetStudentAttendanceDetails()
        {
            throw new NotImplementedException();
        }

        public void GetStudentDetails()
        {
            throw new NotImplementedException();
        }

        public void GetStudentMarks()
        {
            throw new NotImplementedException();
        }
    }
}