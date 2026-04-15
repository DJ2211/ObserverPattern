using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public  class CurrentConditionsDisplay : Observer, Display 
    {
        private float temp;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temp = temperature;
            this.humidity = humidity;
            display();
        }

        public void display() {
            Console.WriteLine("Current Conditions: {0} Temperature and {1} humidity");
        }
    }
}
