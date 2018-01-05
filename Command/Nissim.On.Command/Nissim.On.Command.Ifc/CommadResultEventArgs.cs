using System;

namespace Nissim.On.Command.Ifc
{
    public class CommadResultEventArgs : EventArgs
    {
        public CommadResultEventArgs(string p_result, bool p_work)
        {
            Result = p_result;
            Work = p_work;
        }

        public string Result { get; private set; }
        public bool Work { get; private set; }
    }
}
