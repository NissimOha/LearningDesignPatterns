using System.Collections.Generic;

namespace Nissim.On.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITargetAdapter> myAdapters = new List<ITargetAdapter>()
            {
                new UniversalAdapter(UniversalAdapter.Adapter.Canada),
                new UniversalAdapter(UniversalAdapter.Adapter.Uk)
            };

            System.Console.WriteLine(@"First");
            foreach(var myAdapter in myAdapters)
            {
                myAdapter.Request();
            }

            System.Console.WriteLine(@"Second");
            myAdapters.Add(new UniversalAdapter(UniversalAdapter.Adapter.Usa));

            foreach (var myAdapter in myAdapters)
            {
                myAdapter.Request();
            }
        }
    }
}
