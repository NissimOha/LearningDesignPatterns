namespace Nissim.On.Bridge
{
    class SystemMessageRefinedAbstraction : MessageAbstraction
    {
        public SystemMessageRefinedAbstraction(string p_subject, string p_body)
            : base(p_subject, p_body) { }

        public override void Send()
        {
            MessageSenderImplementor.SendMessage(Subject, Body);
        }
    }
}
