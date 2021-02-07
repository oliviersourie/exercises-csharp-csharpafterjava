namespace ClassLib
{
    public class Student: Person
    {
        public int StudentID { get; set; }
        public string TrajectoryName { get; set; }

        public Student(string firstName, string lastName, int Id, string trajectory)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = Id;
            TrajectoryName = trajectory;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"Student {FullName}";
        }

    }
}
