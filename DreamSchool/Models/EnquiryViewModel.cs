using DreamSchool.BL.Student;
using DreamSchool.BO.Master;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamSchool.Models
{
    public class EnquiryViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Name should be of 1 to 200 Characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Father Name is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Father Name should be of 1 to 200 Characters.")]
        public string FatherName { get; set; }        
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Address should be of 1 to 500 Characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid Email Address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$",
                            ErrorMessage = "Enter a valid Phone.")]
        public string PhoneNumber { get; set; }
        public IEnumerable<ClassTypes> listClassTypes = new StudentBL().GetMasterClass().listClassTypes;
        [Required]
        public int ClassTypeId { get; set; }
        
    }

}