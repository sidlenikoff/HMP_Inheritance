using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Tests
{
    [TestClass]
    public class Task3Tests
    {
        [TestMethod]
        public void CreateTriangle()
        {
            Triangle figure = new Triangle(3, 4, 5);

            Assert.IsInstanceOfType(figure, typeof(Triangle));
            int a, b, c;
            figure.GetABC(out a, out b, out c);
            Assert.AreEqual(3, a);
            Assert.AreEqual(4, b);
            Assert.AreEqual(5, c);
        }

        [TestMethod]
        public void CreateColorTriangle()
        {
            TriangleColor figure = new TriangleColor(3, 4, 5, System.Drawing.Color.WhiteSmoke);

            Assert.IsInstanceOfType(figure, typeof(Triangle));
            int a, b, c;
            figure.GetABC(out a, out b, out c);
            Assert.AreEqual(3, a);
            Assert.AreEqual(4, b);
            Assert.AreEqual(5, c);
            Assert.AreEqual(System.Drawing.Color.WhiteSmoke, figure.Color);

        }

        [TestMethod]
        public void SetIlligalABC()
        {
            Triangle figure = new Triangle(3, 4, 5);

            Assert.ThrowsException<ArgumentException>(() => figure.SetABC(3, 2, 6));
            Assert.ThrowsException<ArgumentException>(() => figure.SetABC(0, 2, 2));
            Assert.ThrowsException<ArgumentException>(() => figure.SetABC(0, 0, 0));
        }

        [TestMethod]
        public void SetABC()
        {
            Triangle figure = new Triangle(3, 4, 5);

            figure.SetABC(2, 3, 4);
            int a, b, c;
            figure.GetABC(out a, out b, out c);
            Assert.AreEqual(2, a);
            Assert.AreEqual(3, b);
            Assert.AreEqual(4, c);
        }

        [TestMethod]
        public void GetArea()
        {
            Triangle figure = new Triangle(3, 4, 5);
            Assert.AreEqual(6, figure.Area2);
        }
    }
}
