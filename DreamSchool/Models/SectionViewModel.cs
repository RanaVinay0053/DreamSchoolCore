using DreamSchool.BL.Class;
using DreamSchool.BO.Class;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamSchool.Models
{
    public class SectionViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Name should be of 1 to 200 Characters.")]
        public string SectionName { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Batch Start Year is Required")]
        public int BatchStartYear { get; set; }
        [Required(ErrorMessage = "Class Type is Required")]
        public Int32? ClassTeacher { get; set; }
        public string RoomName { get; set; }                 
        [Required]
        public int Class { get; set; }
        public IEnumerable<ClassBO> listClasses = new ClassBL().GetClasses();
        public IEnumerable<SelectListItem> BatchYears = GetBatchYears();
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

    
}