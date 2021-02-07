using System.Collections.Generic;

namespace ClassLib
{
    public class Group
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Group {Name} has teacher {Teacher.FullName}";
        }
    }
}
