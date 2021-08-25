using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS7._2
{
    class Thermostat
    {
        public delegate void TemperatureChangeHandler(float newTemperature);

        private TemperatureChangeHandler _OnTemperatureChangeHandler ;
        public TemperatureChangeHandler OnTemperatureChangeHandler
        {
            get { return _OnTemperatureChangeHandler; }
            set { _OnTemperatureChangeHandler = value; }
        }
        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set 
            { 
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if (OnTemperatureChangeHandler != null)
                    {
                        OnTemperatureChangeHandler(value);
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }
}
