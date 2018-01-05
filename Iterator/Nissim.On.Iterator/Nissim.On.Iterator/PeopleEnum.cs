using System;
using System.Collections;
using System.Collections.Generic;

namespace Nissim.On.Iterator
{
    class PeopleEnum : IEnumerator
    {
        private List<Person> m_people;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        public PeopleEnum(List<Person> p_people)
        {
            m_people = p_people;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return m_people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            position++;
            return (position < m_people.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
