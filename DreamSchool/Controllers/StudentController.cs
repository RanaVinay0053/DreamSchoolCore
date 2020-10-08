using DreamSchool.BL.Student;
using DreamSchool.BO.Student;
using DreamSchool.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace DreamSchool.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public StudentController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: Student
        public ActionResult Index()
        {
            List<StudentBO> _listStudents = new StudentBL().GetStudents();
            return View(_listStudents);
        }

        public ActionResult AddStudent(string Id)
        {
            StudentViewModel obj;
            if (string.IsNullOrEmpty(Id))
            {
                obj = new StudentViewModel();
            }
            else
            {
                StudentBO _objStudent = new StudentBL().GetStudentById(Id);
                obj = new StudentViewModel();
                obj.Id = _objStudent.Id;
                obj.Name = _objStudent.Name;
                obj.FatherName = _objStudent.FatherName;
                obj.Address = _objStudent.Address;
                obj.BatchYear = _objStudent.BatchYear;
                obj.ClassId = Convert.ToInt32(_objStudent.Class);
                obj.ClassTypeId = Convert.ToInt32(_objStudent.ClassType);
                obj.DateOfBirth = _objStudent.DateOfBirth;
                obj.EnrollmentDate = _objStudent.EnrollmentDate;
                obj.Gender = _objStudent.Gender;
                obj.ImagePath = _objStudent.ImagePath;
                obj.SignatureImagePath = _objStudent.SignatureImage;
                obj.MobileNumber = _objStudent.MobileNumber;
                obj.PrimaryEmail = _objStudent.PrimaryEmail;
                obj.ProgrammeDuration = _objStudent.ProgrammeDuration;
                obj.RegistrationNumber = _objStudent.RegistrationNumber;                
            }
            return View(obj);
        }

        [HttpPost]
        public ActionResult SaveStudent(StudentViewModel objStudentViewModel)
        {
            if (ModelState.IsValid)
            {
                string strPath =  _hostingEnvironment.ContentRootPath; 
                string ImageFilename = string.Empty;
                string SignatureImageFilename = string.Empty;
                if (objStudentViewModel.Image != null)
                {
                    ImageFilename = "UserImage" + objStudentViewModel.Name.Replace(" ", "") + DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    ImageFilename = "\\Images\\Students\\" + ImageFilename + Path.GetExtension(objStudentViewModel.Image.FileName);
                    using (FileStream fs = System.IO.File.Create(strPath + "\\wwwroot" + ImageFilename))
                    {
                        objStudentViewModel.Image.CopyTo(fs);
                        fs.Flush();
                    }
                }
                if (objStudentViewModel.SignatureImage != null)
                {
                    SignatureImageFilename = "SignatureImage" + objStudentViewModel.Name.Replace(" ", "") + DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    SignatureImageFilename = "\\Images\\Students\\" + SignatureImageFilename + Path.GetExtension(objStudentViewModel.SignatureImage.FileName);
                    using (FileStream fs = System.IO.File.Create(strPath + "\\wwwroot" + SignatureImageFilename))
                    {
                        objStudentViewModel.SignatureImage.CopyTo(fs);
                        fs.Flush();
                    }
                }
                if (string.IsNullOrEmpty(ImageFilename))
                {
                    ImageFilename = string.IsNullOrEmpty(objStudentViewModel.ImagePath) ?
                        "\\Images\\avatar.jpg" : objStudentViewModel.ImagePath;
                }
                if (string.IsNullOrEmpty(SignatureImageFilename))
                {
                    SignatureImageFilename = string.IsNullOrEmpty(objStudentViewModel.SignatureImagePath) ?
                        "\\Images\\signature.png" : objStudentViewModel.SignatureImagePath;
                }


                var objStudentBO = new StudentBO()
                {
                    Id = objStudentViewModel.Id,
                    Name = objStudentViewModel.Name,
                    FatherName = objStudentViewModel.FatherName,
                    Address = objStudentViewModel.Address,
                    BatchYear = objStudentViewModel.BatchYear,
                    Class = objStudentViewModel.ClassId.ToString(),
                    ClassType = objStudentViewModel.ClassTypeId.ToString(),
                    DateOfBirth = objStudentViewModel.DateOfBirth.ToString(),
                    EnrollmentDate = objStudentViewModel.EnrollmentDate.ToString(),
                    Gender = objStudentViewModel.Gender,
                    ImagePath = ImageFilename,
                    SignatureImage = SignatureImageFilename,
                    MobileNumber = objStudentViewModel.MobileNumber,
                    PrimaryEmail = objStudentViewModel.PrimaryEmail,
                    ProgrammeDuration = objStudentViewModel.ProgrammeDuration,
                    RegistrationNumber = objStudentViewModel.RegistrationNumber
                };
                int _result = new StudentBL().SaveStudent(objStudentBO);
                if (_result >= 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AddStudent", objStudentViewModel);
                }
            }
            else
            {
                return View("AddStudent", objStudentViewModel);
            }

        }
    }
}