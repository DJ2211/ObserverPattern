using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Observer
    {
        public void update(float temp, float humidity, float pressure);

    }
}
