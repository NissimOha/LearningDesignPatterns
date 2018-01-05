namespace Nissim.On.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSenderImplementor email = new EmailSenderConcreteImplementor();
            IMessageSenderImplementor web = new WebServiceSenderConcreteImplementor();

            MessageAbstraction message = new SystemMessageRefinedAbstraction(@"Test Message", @"Hi, This is a Test Message");

            message.MessageSenderImplementor = email;
            message.Send();
            message.MessageSenderImplementor = web;
            message.Send();

            UserMessageRefinedAbstraction usermsg = new UserMessageRefinedAbstraction(@"Test Message", "Hi, This is a Test Message");
            usermsg.AddOn = "I hope you are well";

            usermsg.MessageSenderImplementor = email;
            usermsg.Send();
            usermsg.MessageSenderImplementor = web;
            usermsg.Send();
        }
    }
}
