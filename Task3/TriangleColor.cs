using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TriangleColor : Triangle
    {
        private Color color;
        public Color Color
        {
            get => color;
            set
            {
                if (value == color)
                    return;
                color = value;
            }
        }

        public TriangleColor(int _a, int _b, int _c, Color _color,string name = "Цветной Треугольник") : base(_a, _b, _c, name)
        {
            Color = _color;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(Color.ToString());
        }
    }
}
