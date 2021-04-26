using System;

abstract class Figure
{
	public string СolorLine { get; set; }
	public string СolorFilling { get; set; }
	
	public abstract void Perimeter();
	public abstract void Area();
	public abstract void Draw();
	public void Paint()
	{
		Console.WriteLine($"Вы обвели свою фигуру {СolorLine} цветом и закрасили {СolorFilling} цветом");
		Console.ReadLine();
	}

	
}
