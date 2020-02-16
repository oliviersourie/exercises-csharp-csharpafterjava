namespace ClassLib
{
    public class Person
    {
        protected string lastName;
        protected string firstName;

        public Person(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
