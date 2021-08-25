using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChangeHandler +=
                 heater.OnTemperatureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChangeHandler +=
                 heaterCuong.OnTemperatureChanged;

            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChangeHandler +=
                 cooler.OnTemperatureChanged;

            string temperature;
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();

        }
    }
}
