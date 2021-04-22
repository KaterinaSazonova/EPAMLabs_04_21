using System;

class Circle : Figure
{
	private int radius;
	public int Radius { get { return radius; } set { this.radius = value; } }
    public override void Area()
    {
        double pi = 3.14;
        double a = radius * radius * pi;
        Console.WriteLine($"Площадь круга равна {a}");
    }

    public override void Perimeter()
    {
        double pi = 3.14;
        double a = 2 * radius * pi;
        Console.WriteLine($"Длина окружности равна {a}");
    }
    public override void Draw()
    {
        Console.WriteLine($"Вы нарисовали круг с радиусом =  {radius}");
    }
    public Circle (int r)
    {
        radius = r;       
    }
}
