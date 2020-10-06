using DreamSchool.BO.Enquiry;
using DreamSchool.DA.Enquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamSchool.BL.Enquiry
{
    public class EnquiryBL
    {
        public int SaveEnquiry(EnquiryBO objEnquiryBO)
        {
            objEnquiryBO.TokenNumber = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            return new EnquiryDA().SaveEnquiry(objEnquiryBO);
        }
        public EnquiryBO GetEnquiryByToken(string token)
        {
            return new EnquiryDA().GetEnquiryByToken(token);
        }
    }
}
