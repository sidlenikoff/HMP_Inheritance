using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle : Figure
    {
        private int a, b, c;
        public Triangle(int _a, int _b, int _c,string name = "Треугольник") : base(name)
        {
            SetABC(_a, _b, _c);
        }

        public void SetABC(int _a, int _b, int _c)
        {
            if (_a <= 0 || _b <= 0 || _c <= 0
                || !((_a + _b >= _c) && (_a + _c >= _b) && (_b + _c >= _a)))
                throw new ArgumentException("Некорректные значения длин сторон");

            a = _a;
            b = _b;
            c = _c;
        }

        public void GetABC(out int _a, out int _b, out int _c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override float Area2 => Area();

        protected override float Area()
        {
            float p = (a + b + c) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"a = {a}\tb = {b}\tc = {c}");
        }
    }
}
