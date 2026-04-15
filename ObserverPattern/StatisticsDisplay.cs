using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StatisticsDisplay : Observer, Display
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if(temp > maxTemp)
            {
                maxTemp = temp;
            }

            if(temp < minTemp)
            {
                minTemp = temp;
            }

            display();
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperatures = {0}/{1}/{2}", (tempSum / numReadings), maxTemp, minTemp);
        }
    }
}
