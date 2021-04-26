using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 10;
            square.СolorFilling = "green";
            square.СolorLine = "blue";

            square.Perimeter();
            square.Area();
            square.Draw();
            square.Paint();

            Circle circle = new Circle(5);
            circle.СolorFilling = "orange";
            circle.СolorLine = "red";

            circle.Perimeter();
            circle.Area();
            circle.Draw();
            circle.Paint();
        }
    }
}
