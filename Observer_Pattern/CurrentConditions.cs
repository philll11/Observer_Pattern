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
    public partial class CurrentConditions : Form, IObserver, IDisplay
    {
        private ISubject _weatherData;

        public CurrentConditions(ISubject weatherData)
        {
            _weatherData = weatherData;
            InitializeComponent();
        }
        void IObserver.Update()
        {
            Display();
        }
        public void Display()
        {
            displayTempLbl.Text = WeatherData._wdo.GetTemp.ToString();
            displayHumidityLbl.Text = WeatherData._wdo.Humidity.ToString();
            displayPressureLbl.Text = WeatherData._wdo.Pressure.ToString();
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
