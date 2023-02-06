using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstraction.Problem_2
{
    internal interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }
        string Start();
        string Stop();

    }
}
