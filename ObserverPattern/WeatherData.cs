using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers; // store the observers 
        // here instead of list we can also use hashmap to support the insert and deletion in O(1)

        // private fields for the state observation
        private float temperatures;
        private float humidity;
        private float pressure;

        // constructor initializing the observer list
        public WeatherData()
        {
            observers = new List<Observer>();
        }

        // when observer registers will be added to the list
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        // remove observer 
        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void notifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperatures, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperatures = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}
