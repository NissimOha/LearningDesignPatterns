using System;

namespace Nissim.On.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //A large folder (on my computer).
            const string path = @"C:\Program Files\MATLAB";

            //Using the RealFileRepository: creation take long time 
            //(not necessary if we just want to know if exist)
            var realFileRepository = new RealFolderRepository(path);

            //Using the Proxy:
            var lazeFolderRepositoryProxy = new LazyFolderRepositoryProxy(path);
            if(lazeFolderRepositoryProxy.IsExist())
                Console.WriteLine("The Folder Exist");
        }
    }
}
