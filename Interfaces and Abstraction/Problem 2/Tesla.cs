using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstraction.Problem_2
{
    internal class Tesla : ICar, IElectricCar
    {
        private string teslaModel;
        private string teslaColor;
        private int teslaBattery;

        public string Model { get => teslaModel; set => teslaModel = value; }
        public string Color { get => teslaColor; set => teslaColor = value; }
        public int Battery { get => teslaBattery; set => teslaBattery = value; }

        public Tesla(string model, string color, int battery)
        {
            Model=model;
            Color=color;
            Battery=battery;    
        }

        public Tesla()
        {
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string? ToString()
        {
            return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries" + "\n" + Start() +"\n" + Stop();
        }
    }
}
