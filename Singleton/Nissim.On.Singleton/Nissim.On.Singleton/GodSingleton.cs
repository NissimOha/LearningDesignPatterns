namespace Nissim.On.Singleton
{
    public class GodSingleton
    {
        private GodSingleton(string p_name, bool p_isGood)
        {
            Name = p_name;
            IsGood = p_isGood;
        }

        public static GodSingleton GetGodInstance()
        {
            if(GodInstance == null)
            {
                GodInstance = new GodSingleton("God", true);
            }
            return GodInstance;
        }

        private static GodSingleton GodInstance;
        public string Name { get; private set; }
        public bool IsGood { get; private set; }
    }
}
