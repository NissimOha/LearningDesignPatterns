using System.Collections;
using System.Collections.Generic;

namespace Nissim.On.Iterator
{
    class People : IEnumerable
    {
        private List<Person> m_people;

        public People(List<Person> p_people)
        {
            m_people = p_people;
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(m_people);
        }
    }
}
