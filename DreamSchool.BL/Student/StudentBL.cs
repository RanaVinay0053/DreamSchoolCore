using DreamSchool.BO.Master;
using DreamSchool.BO.Student;
using DreamSchool.DA.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamSchool.BL.Student
{
    public class StudentBL
    {
        public List<StudentBO> GetStudents()
        {
            return new StudentDA().GetStudents();
        }

        public MasterClass GetMasterClass()
        {
            return new StudentDA().GetMasterClass();
        }

        public int SaveStudent(StudentBO objStudentBO)
        {
            return new StudentDA().SaveStudent(objStudentBO);
        }

        public StudentBO GetStudentById(string id)
        {
            return new StudentDA().GetStudentById(id);
        }


    }
}
