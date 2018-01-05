using System;

namespace Nissim.On.Composite
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class Employee : IWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int p_id, string p_name)
        {
            Id = p_id;
            Name = p_name;
        }

        public void ShowHierarchy()
        {
            for (int i = 0; i < Manager.s_mCounter-1 ; i++) Console.Write("\t");
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "\t" + Id + ": " + Name;
        }
    }
}
