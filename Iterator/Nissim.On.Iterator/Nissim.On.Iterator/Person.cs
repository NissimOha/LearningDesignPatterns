namespace Nissim.On.Iterator
{
    class Person
    {
        public Person(string p_firstName, string p_lastName)
        {
            FirstName = p_firstName;
            LastName = p_lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
