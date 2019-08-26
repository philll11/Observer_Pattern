using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WeatherDataObject
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        private float _totalTemps;
        private float _numOfTemps;
        private float _maxTemp;
        private float _minTemp;

        public void SetTemp(float temp) {
            _temp = temp;
            _totalTemps += temp;
            _numOfTemps += 1;

            SetMaxTemp(temp);
            SetMinTemp(temp);
        }
        public float GetTemp { get => _maxTemp; }
        public float Humidity { get => _humidity; set => _humidity = value; }
        public float Pressure { get => _pressure; set => _pressure = value; }
        public float GetAverageTemp()
        {
            if(_numOfTemps != 0)
            {
                return _totalTemps / _numOfTemps;
            } else
            {
                return _totalTemps;
            }
        }
        public float GetMaxTemp { get => _maxTemp; }
        public float GetMinTemp { get => _minTemp; }

        public void SetMaxTemp(float max)
        {
            if(_maxTemp < max)
            {
                _maxTemp = max;
            }
        }
        public void SetMinTemp(float min)
        {
            if (_minTemp > min)
            {
                _minTemp = min;
            }
        }
    }
}
