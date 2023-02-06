using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstraction.Problem_2
{
    internal class Seat : ICar
    {
        public string seatModel;
        public string seatColor;
        public string Model { get => seatModel; set => seatModel = value; }
        public string Color { get => seatColor; set => seatColor = value; }

        public Seat(string model, string color)
        {
            Model=model;
            Color=color;
        }

        public Seat()
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
            return $"{Color} {this.GetType().Name} {Model}" + "\n" + Start() +"\n" + Stop();
        }
    }
}
