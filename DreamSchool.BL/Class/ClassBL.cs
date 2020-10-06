using DreamSchool.BO.Class;
using DreamSchool.DA.Class;
using System.Collections.Generic;

namespace DreamSchool.BL.Class
{
    public class ClassBL
    {
        public int SaveClass(ClassBO objClassBO)
        {
            return new ClassDA().SaveClass(objClassBO);
        }
        public List<ClassBO> GetClasses()
        {
            return new ClassDA().GetClasses();
        }
        public ClassBO GetClassById(string id)
        {
            return new ClassDA().GetClassById(id);
        }
        
    }
}
