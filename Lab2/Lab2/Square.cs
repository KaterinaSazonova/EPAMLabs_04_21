using System;

 class Square : Figure
{
    private int side;
    public int Side { get { return side;  } set { this.side = value;  } }
	public override void Area()
    {
        int a = side * side;
        Console.WriteLine($"Площадь квадрата равна {a}");
    }
    public override void Perimeter()
    {
        int a = side * 4;
        Console.WriteLine($"Периметр квадрата равен {a}");
    }
    public override void Draw()
    {
        Console.WriteLine($"Вы нарисовали квадрат со стороной =  {side}");
    }
}

