using System.Collections.Generic;

namespace ClassLib
{
    public class Institute
    {
        public List<Group> Groups { get; set; }

        public override string ToString()
        {
            string listOfGroups = string.Empty;
            Groups.ForEach(group => listOfGroups += $"Group {group.Name} has {group.Students.Count} students\n");

            return listOfGroups;
        }
    }
}
