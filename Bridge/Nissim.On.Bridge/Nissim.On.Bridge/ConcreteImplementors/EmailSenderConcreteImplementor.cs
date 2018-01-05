using System;

namespace Nissim.On.Bridge
{
    class EmailSenderConcreteImplementor : IMessageSenderImplementor
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
        }
    }
}
