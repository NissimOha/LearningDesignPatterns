namespace Nissim.On.Decorator
{
    public abstract class AddonDecorator : Beverage
    {
        public AddonDecorator()
        {
            Description = Consts.ADDONDESCRIPTION;
        }
    }
}
