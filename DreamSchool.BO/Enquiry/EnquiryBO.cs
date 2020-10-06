using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamSchool.BO.Enquiry
{
    public class EnquiryBO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string TokenNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ClassType { get; set; }
        public string CreatedDate { get; set; }
    }

    public class SearchEnquiryBO
    {
        [Required]
        public Int64 token { get; set; }
        public List<EnquiryBO> listEnquiry { get; set; }
    }
}
