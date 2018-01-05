using System;

namespace Nissim.On.Bridge
{
    class WebServiceSenderConcreteImplementor : IMessageSenderImplementor
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        }
    }
}
