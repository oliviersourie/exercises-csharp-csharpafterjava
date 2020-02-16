namespace ClassLib
{
    public class Student: Person
    {
        protected int studentID;
        protected string trajectory;

        public Student(string firstName, string lastName, int Id, string trajectory)
            :base(firstName, lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = Id;
            this.trajectory = trajectory;
        }

        public override string ToString()
        {
            return $"Student {base.ToString()}";
        }

    }
}
