using System;

internal class Circle : Figure
{
    public int Radius { get; set; }
    public override void Area()
    {
        double pi = 3.14;
        double a = Radius * Radius * pi;
        Console.WriteLine($"Площадь круга равна {a}");
    }

    public override void Perimeter()
    {
        double pi = 3.14;
        double a = 2 * Radius * pi;
        Console.WriteLine($"Длина окружности равна {a}");
    }
    public override void Draw()
    {
        Console.WriteLine($"Вы нарисовали круг с радиусом =  {Radius}");
    }
    public Circle (int r)
    {
        Radius = r;       
    }
}
