using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers(); // this is called to notify observers when subject state is changed.
    }
}
