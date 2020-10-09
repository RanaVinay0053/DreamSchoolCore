using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSchool.BO.DomainModels.MasterWebsite
{
 public   class NoticeBO
    {
        public int Id { get; set; }
        public string NoticeName { get; set; }
        public string NoticeDescription { get; set; }
        public string NoticeDate { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
       
    }
}
