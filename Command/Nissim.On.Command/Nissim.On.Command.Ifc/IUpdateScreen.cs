using System;

namespace Nissim.On.Command.Ifc
{
    public interface IUpdateScreen
    {
        event EventHandler<CommadResultEventArgs> ExecuteFinished;
    }
}
