using System;
using Nissim.On.Command.Ifc;

namespace Nissim.On.Command.BL
{
    public class Worker : IUpdateScreen
    {
        public event EventHandler<CommadResultEventArgs> ExecuteFinished;

        public void DoWork(string p_result, bool p_work)
        {
            //Here we can do calculaion or something..
            onDoWork(p_result, p_work);
        }

        private void onDoWork(string p_result, bool p_work)
        {
            if (ExecuteFinished != null)
                ExecuteFinished.Invoke(this,new CommadResultEventArgs(p_result, p_work));
        }
    }
}
