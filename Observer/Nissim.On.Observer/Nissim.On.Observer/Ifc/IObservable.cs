using Nissim.On.Observer.Ifc;

namespace Nissim.On.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver p_observer);
        void RemoveObserver(IObserver p_observer);
        void Notify();
    }
}
