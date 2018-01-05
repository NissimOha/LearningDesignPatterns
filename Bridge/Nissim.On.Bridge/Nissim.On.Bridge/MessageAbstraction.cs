namespace Nissim.On.Bridge
{
    abstract class MessageAbstraction
    {
        public MessageAbstraction(string p_subject, string p_body)
        { 
            Subject = p_subject;
            Body = p_body;
        }

        public abstract void Send();

        public IMessageSenderImplementor MessageSenderImplementor { get; set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }
    }
}
