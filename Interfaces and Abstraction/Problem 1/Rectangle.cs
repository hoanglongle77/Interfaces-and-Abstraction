using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstraction.Problem_1
{
    internal class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width { get => width; set => width=value; }
        public int Height { get => height; set => height=value; }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width=width;
            Height=height;
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height - 1; ++i)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
