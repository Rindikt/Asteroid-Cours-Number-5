using System.Collections.Generic;
using UnityEngine;


namespace Asteroid
{
    internal class ActiveElement : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();


        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }


        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update(Time.deltaTime);
            }
        }

        public void NewData()
        {
            Notify();
        }
    }
}
