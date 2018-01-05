using System;
using System.Collections;
using System.Collections.Generic;

namespace Nissim.On.Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Manager : IWorker, IEnumerable<IWorker>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<IWorker> m_subordinates;
        public static int s_mCounter;

        public Manager(int p_id, string p_name)
        {
            m_subordinates = new List<IWorker>();
            Id = p_id;
            Name = p_name;
        }

        public void ShowHierarchy()
        {
            for (int i = 0; i < s_mCounter; i++) Console.Write("\t");
            s_mCounter++;

            Console.WriteLine(this);
            foreach (var subordinate in m_subordinates)
            {
                subordinate.ShowHierarchy();
            }
            s_mCounter = 0;
        }

        public override string ToString()
        {
            return Id + ": " + Name;
        }

        public void AddSubordinate(IWorker p_subordinate)
        {
            m_subordinates.Add(p_subordinate);
        }

        public void RemoveSubordinate(IWorker p_subordinate)
        {
            m_subordinates.Remove(p_subordinate);
        }

        public IWorker GetWorker(int p_index)
        {
            if (p_index < m_subordinates.Count)
                return m_subordinates[p_index];
            return null;
        }

        public IEnumerator<IWorker> GetEnumerator()
        {
            foreach(var subordinate in m_subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
