using System.Collections.Generic;

namespace Nissim.On.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees
            var Or = new Employee(1, "Or");
            var David = new Employee(2, "David");
            var Kobi = new Employee(3, "Kobi");
            var Dana = new Employee(7, "Dana");
            var Shir = new Employee(8, "Shir");
            var Ken = new Employee(10, "Ken");
            var Tom = new Employee(11, "Tom");
            //Managers
            List<Manager> managers = new List<Manager>
            {
                new Manager(4, "Nissim"),
                new Manager(5, "Nir"),
            };
            //Sub-Manager
            var Moshe = new Manager(6, "Moshe");
            Moshe.AddSubordinate(Dana);
            Moshe.AddSubordinate(Shir);
            var Mor = new Manager(9, "Mor");
            Mor.AddSubordinate(Ken);
            Mor.AddSubordinate(Tom);
            Moshe.AddSubordinate(Mor);

            managers[0].AddSubordinate(Or);
            managers[0].AddSubordinate(David);
            managers[1].AddSubordinate(Moshe);
            managers[1].AddSubordinate(Kobi);

            foreach(var manager in managers)
            {
                manager.ShowHierarchy();
            }
        }
    }
}
