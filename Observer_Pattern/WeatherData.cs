using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public sealed partial class WeatherData : Form, ISubject
    {
        private List<IObserver> _observers;
        public static WeatherDataObject _wdo;

        public WeatherData()
        {
            InitializeComponent();
            _observers = new List<IObserver>();
            _wdo = new WeatherDataObject();

            CurrentConditions currentConditions = new CurrentConditions(this);
            currentConditions.Show();

            Forecast forecast = new Forecast(this);
            forecast.Show();

            WeatherStats weatherStats = new WeatherStats(this);
            weatherStats.Show();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers) {
                observer.Update();
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        private void PressureTB_Leave(object sender, EventArgs e)
        {
            float.TryParse(pressureTB.Text, out float pressure);
            _wdo.Pressure = pressure;
            NotifyObservers();
        }

        private void HumidityTB_Leave(object sender, EventArgs e)
        {
            float.TryParse(humidityTB.Text, out float humidity);
            _wdo.Humidity = humidity;
            NotifyObservers();
        }

        private void TempTB_Leave(object sender, EventArgs e)
        {
            float.TryParse(tempTB.Text, out float temp);
            _wdo.SetTemp(temp);
            NotifyObservers();
        }
    }
}
