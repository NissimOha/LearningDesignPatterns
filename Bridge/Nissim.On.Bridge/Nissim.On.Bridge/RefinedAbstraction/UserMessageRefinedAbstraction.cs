namespace Nissim.On.Bridge
{
    class UserMessageRefinedAbstraction : MessageAbstraction
    {
        public UserMessageRefinedAbstraction(string p_subject, string p_body)
            : base(p_subject, p_body) { }

        public override void Send()
        {
            var subject = Subject + " " + AddOn;
            MessageSenderImplementor.SendMessage(subject, Body);
        }

        public string AddOn { get; set; }
    }
}
