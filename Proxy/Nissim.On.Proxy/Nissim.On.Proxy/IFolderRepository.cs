namespace Nissim.On.Proxy
{
    interface IFolderRepository
    {
        //Method that take a long time
        int GetNumberOfLines();
        //Regular method
        bool IsExist();
    }
}
