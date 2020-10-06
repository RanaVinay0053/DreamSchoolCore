using DreamSchool.BO.Class;
using DreamSchool.DA.Class;
using System.Collections.Generic;

namespace DreamSchool.BL.Class
{
    public class SectionBL
    {
        public int SaveSection(SectionBO objSectionBO)
        {
            return new SectionDA().SaveSection(objSectionBO);
        }
        public List<SectionBO> GetSections()
        {
            return new SectionDA().GetSections();
        }
        public SectionBO GetSectionById(string id)
        {
            return new SectionDA().GetSectionById(id);
        }
        
    }
}
