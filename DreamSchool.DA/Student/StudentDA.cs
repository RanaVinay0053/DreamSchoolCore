using DreamSchool.BO.Master;
using DreamSchool.BO.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.Student
{
    public class StudentDA : BaseDA
    {
        public int SaveStudent(StudentBO objStudentBO)
        {
            int result = 0;
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_SaveStudent", connection))
                {
                    connection.Open();

                    DateTime EnrollmentDate = Convert.ToDateTime(objStudentBO.EnrollmentDate);
                    DateTime DateOfBirth = Convert.ToDateTime(objStudentBO.DateOfBirth);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id", objStudentBO.Id);
                    cmd.Parameters.AddWithValue("Name", objStudentBO.Name);
                    cmd.Parameters.AddWithValue("FatherName", objStudentBO.FatherName);
                    cmd.Parameters.AddWithValue("Address", objStudentBO.Address);
                    cmd.Parameters.AddWithValue("BatchYear", objStudentBO.BatchYear);
                    cmd.Parameters.AddWithValue("Class", objStudentBO.Class);
                    cmd.Parameters.AddWithValue("ClassType", objStudentBO.ClassType);
                    cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("EnrollmentDate", EnrollmentDate);
                    cmd.Parameters.AddWithValue("Gender", objStudentBO.Gender);
                    cmd.Parameters.AddWithValue("ImagePath", objStudentBO.ImagePath);
                    cmd.Parameters.AddWithValue("SignatureImage", objStudentBO.SignatureImage);
                    cmd.Parameters.AddWithValue("MobileNumber", objStudentBO.MobileNumber);
                    cmd.Parameters.AddWithValue("PrimaryEmail", objStudentBO.PrimaryEmail);
                    cmd.Parameters.AddWithValue("ProgrammeDuration", objStudentBO.ProgrammeDuration);
                    cmd.Parameters.AddWithValue("RegistrationNumber", objStudentBO.RegistrationNumber);
                    cmd.Parameters.AddWithValue("LoggedInUserId", "C6868463-6968-41B4-BD59-55F50BD70F8B");
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    result = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    connection.Close();
                }
            }
            return result;
        }

        public List<StudentBO> GetStudents()
        {
            List<StudentBO> listStudents = new List<StudentBO>();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetStudents", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("ItemTypeID", ItemTypeID);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    listStudents = Common.ConvertDataTable<StudentBO>(ds.Tables[0]);
                    connection.Close();
                }
            }
            return listStudents;
        }

        public MasterClass GetMasterClass()
        {
            MasterClass objMasterClass = new MasterClass();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetMasterClass", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("ItemTypeID", ItemTypeID);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    objMasterClass.listClasses = Common.ConvertDataTable<Classes>(ds.Tables[0]);
                    objMasterClass.listClassTypes = Common.ConvertDataTable<ClassTypes>(ds.Tables[1]);
                    connection.Close();
                }
            }
            return objMasterClass;
        }

        public StudentBO GetStudentById(string id)
        {
            StudentBO objStudent = new StudentBO();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetStudentById", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    objStudent = Common.GetItem<StudentBO>(ds.Tables[0].Rows[0]);
                    connection.Close();
                }
            }
            return objStudent;
        }
    }
}

