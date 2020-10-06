using DreamSchool.BL.Student;
using DreamSchool.BO.Master;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamSchool.Models
{
    public class ClassViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Name should be of 1 to 200 Characters.")]
        public string ClassName { get; set; }
        [Required]
        public int NumericalValue { get; set; }
        [Required(ErrorMessage = "Class Type is Required")]
        public int ClassType { get; set; }
        [Required]
        public decimal Fees { get; set; }
        public IEnumerable<ClassTypes> listClassTypes = new StudentBL().GetMasterClass().listClassTypes;
    }

    
}