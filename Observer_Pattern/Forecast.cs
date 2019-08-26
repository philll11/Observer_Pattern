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
    public partial class Forecast : Form, IObserver, IDisplay
    {
        ISubject _weatherData;
        public Forecast(ISubject weatherData)
        {
            InitializeComponent();
            _weatherData = weatherData;
        }

        void IObserver.Update()
        {
            Display();
        }

        public void Display()
        {
            DisplayForecast(WeatherData._wdo.Pressure);
        }

        public void DisplayForecast(float pressure)
        {
            if(pressure > 1000)
            {
                displayExpConLbl.Text = "Sunshine";
            } else
            {
                displayExpConLbl.Text = "Rain";
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            _weatherData.RegisterObserver(this);
        }

        private void DeRegBtn_Click(object sender, EventArgs e)
        {
            _weatherData.RemoveObserver(this);
        }
    }
}
