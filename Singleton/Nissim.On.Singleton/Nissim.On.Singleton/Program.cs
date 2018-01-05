using System;

namespace Nissim.On.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var god = GodSingleton.GetGodInstance();

            Console.WriteLine("Name: {0}\nIsGood: {1}", god.Name, god.IsGood);
        }
    }
}
