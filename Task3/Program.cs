using System.Drawing;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Triangle(3, 4, 5);
            fig.Print();
            Console.WriteLine($"Площадь: {fig.Area2}");
        }
    }
}