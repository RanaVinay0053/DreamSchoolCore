using DreamSchool.BL.Student;
using DreamSchool.BO.Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamSchool.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Name should be of 1 to 200 Characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Father Name is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Father Name should be of 1 to 200 Characters.")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Registration Number is required.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Registration Number should be of 1 to 20 Characters.")]
        public string RegistrationNumber { get; set; }
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Address should be of 1 to 500 Characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid Email Address.")]
        public string PrimaryEmail { get; set; }
        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$",
                            ErrorMessage = "Enter a valid Phone.")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "Date Of Birth is required.")]
        public string DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int ClassTypeId { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public string BatchYear { get; set; }
        
        [Required(ErrorMessage = "Programme Duration is required.")]
        public string ProgrammeDuration { get; set; }
        [Required(ErrorMessage = "Enrollment Date is required.")]
        public string EnrollmentDate { get; set; }
        [DreamSchool.CustomValidator.FileExtensions("jpg,jpeg,png,gif", ErrorMessage = "Your error message.")]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public string srcImage
        {
            get
            {
                if (string.IsNullOrEmpty(ImagePath))
                    return "/Images/avatar.jpg";
                else
                    return ImagePath.Replace("\\", "/");
            }
        }

        [DreamSchool.CustomValidator.FileExtensions("jpg,jpeg,png,gif", ErrorMessage = "Your error message.")]
        public IFormFile SignatureImage { get; set; }
        public string SignatureImagePath { get; set; }
        public string srcSignatureImage
        {
            get
            {
                if (string.IsNullOrEmpty(SignatureImagePath))
                    return "/Images/signature.png";
                else
                    return SignatureImagePath.Replace("\\", "/");
            }
        }
        public IEnumerable<SelectListItem> BatchYears = GetBatchYears();
        public IEnumerable<ClassTypes> listClassTypes = new StudentBL().GetMasterClass().listClassTypes;
        public IEnumerable<Classes> listClasses = new StudentBL().GetMasterClass().listClasses;
        public IEnumerable<Gender> listGender = new List<Gender>()
        {
            new Gender(){Id = "Male" ,Name = "Male"},
            new Gender(){Id = "Female" ,Name = "Female"}
        };

        public static List<SelectListItem> GetBatchYears()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            int Year = DateTime.Now.Year + 5;
            for (int i = 0; i < 30; i++)
            {
                list.Add(new SelectListItem() { Text = Year.ToString(), Value = Year.ToString() });
                Year--;
            }
            return list;
        }
    }



    public class Gender
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

}