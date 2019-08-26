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
    public partial class WeatherStats : Form, IObserver, IDisplay
    {
        private ISubject _weatherData;

        public WeatherStats(ISubject weatherData)
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
            DisplayAverage();
            DisplayMax();
            DisplayMin();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            _weatherData.RegisterObserver(this);
        }

        private void DeRegBtn_Click(object sender, EventArgs e)
        {
            _weatherData.RemoveObserver(this);
        }
        public void DisplayAverage()
        {
            displayAverageLbl.Text = WeatherData._wdo.GetAverageTemp().ToString();
        }
        public void DisplayMax()
        {
            displayMaxLbl.Text = WeatherData._wdo.GetMaxTemp.ToString();
        }
        public void DisplayMin()
        {
            displayMinLbl.Text = WeatherData._wdo.GetMinTemp.ToString();
        }

    }
}
