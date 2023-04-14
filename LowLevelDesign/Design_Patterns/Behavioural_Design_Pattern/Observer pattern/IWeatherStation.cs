namespace LowLevelDesign.Design_Patterns.Behavioural_Design_Pattern.Observer_pattern
{
    
    // Define the Subject interface
    public interface IWeatherStation
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Define the Observer interface
    public interface IObserver
    {
        void Update(IWeatherStation weatherStation);
    }

    // Define a concrete implementation of the Subject interface
    public class WeatherStation : IWeatherStation
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    Notify();
                }
            }
        }

        public float Humidity
        {
            get { return _humidity; }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    Notify();
                }
            }
        }

        public float Pressure
        {
            get { return _pressure; }
            set
            {
                if (_pressure != value)
                {
                    _pressure = value;
                    Notify();
                }
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }

    // Define a concrete implementation of the Observer interface
    public class Display : IObserver
    {
        private string _name;

        public Display(string name)
        {
            _name = name;
        }

        public void Update(IWeatherStation weatherStation)
        {
            if (weatherStation is WeatherStation)
            {
                WeatherStation station = (WeatherStation)weatherStation;
                float temperature = station.Temperature;
                float humidity = station.Humidity;
                float pressure = station.Pressure;
                Console.WriteLine("{0} Display: Temperature is {1}F, Humidity is {2}%, Pressure is {3}in", _name, temperature, humidity, pressure);
            }
        }
    }

    // Example usage
    /*
     * 
     * WeatherStation weatherStation = new WeatherStation();
    Display display1 = new Display("Display 1");
    Display display2 = new Display("Display 2");
    weatherStation.Attach(display1);
    weatherStation.Attach(display2);

    weatherStation.Temperature = 70.5f; // outputs "Display 1 Display: Temperature is 70.5F, Humidity is 0%, Pressure is 0in, Display 2 Display: Temperature is 70.5F, Humidity is 0%, Pressure is 0in"
    weatherStation.Detach(display2);
    weatherStation.Humidity = 65f; // outputs "Display 1 Display: Temperature is 70.5F, Humidity is 65%, Pressure is 0in"
    
     */

}
