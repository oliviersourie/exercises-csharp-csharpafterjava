namespace ClassLib
{
    public abstract class Person
    {
        public Person()
        {
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
