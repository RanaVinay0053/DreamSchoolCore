using DreamSchool.BO.DomainModels.MasterWebsite;
using DreamSchool.DA.MasterWebsite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamSchool.BL.MasterWebsite
{
 public   class NoticeBL
    {
        public List<NoticeBO> GetNotices()
        {
            return new NoticeDA().GetNotices();
        }
    }
}
