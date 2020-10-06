using System.Collections.Generic;

namespace DreamSchool.BO.Master
{
    public class MasterBO
    {
    }

    public class MasterClass
    {
        public IEnumerable<ClassTypes> listClassTypes { get; set; }
        public IEnumerable<Classes> listClasses { get; set; }
    }

    public class ClassTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Classes
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
