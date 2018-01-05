using System.Collections.Generic;
using Nissim.On.Observer.Ifc;

namespace Nissim.On.Observer.BL
{
    public class ObservableMessageStation : IObservable, IInfo
    {
        public ObservableMessageStation()
        {
            m_observers = new List<IObserver>();
        }

        public void AddObserver(IObserver p_observer)
        {
            m_observers.Add(p_observer);
        }

        public void Notify()
        {
            foreach (var observer in m_observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver p_observer)
        {
            m_observers.Remove(p_observer);
        }

        public int Info { get; set; }

        private List<IObserver> m_observers;
    }
}
