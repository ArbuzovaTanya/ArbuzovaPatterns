using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    public class Woman : IObservable
    {
        private readonly WomanInfo _info;
        private readonly List<IObserver> _observers;

        public Woman(WomanInfo info)
        {
            _info = info;
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
                item.Update(_info);

            Thread.Sleep(1000);
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);

            if (o is Man man)
                Console.WriteLine($"'{man.Name}' подписался на '{_info.Name}'");

            Thread.Sleep(1000);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);

            if (o is Man man)
                Console.WriteLine($"'{man.Name}' отписался от '{_info.Name}'");

            Thread.Sleep(1000);
        }

        public void Say(string message)
        {
            _info.Messages.Add(message);
            NotifyObservers();
        }
    }
}
