using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Square> s = new List<Square>
            {
                new Square() {Side=10, СolorFilling="green", СolorLine="yellow"},
                new Square() {Side=10, СolorFilling="blue", СolorLine="yellow"},
                new Square() {Side=20, СolorFilling="green", СolorLine="yellow"},
                new Square() {Side=20, СolorFilling="blue", СolorLine="blue"},
               // new Square() {Side=0, СolorFilling="blue", СolorLine="blue"}
            };


            foreach (var temp in s)
            {
                Console.WriteLine($"Квадрат со стороной {temp.Side}, нарисованный {temp.СolorLine} карандашом, закрашенный {temp.СolorFilling} цветом");
                //temp.Perimeter();
                //temp.Area();                
            };

            List<Square> s1 = s.Where(t => t.Side == 10).ToList();
            Console.WriteLine("Отсортированный список содержит:");
            foreach (var temp in s1)
            {
                Console.WriteLine($"Квадрат со стороной {temp.Side}, нарисованный {temp.СolorLine} карандашом, закрашенный {temp.СolorFilling} цветом");
            }

        }
    }
}        