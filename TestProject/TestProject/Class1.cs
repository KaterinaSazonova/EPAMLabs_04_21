using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class ExpectedResult
    {
        public static int GetAreaSquare(int a)
        {
            var areaSquare = a * a;
            return areaSquare;
        }

        public static int GetLengthSquare(int a)
        {
            var lengthSquare = a * 4;
            return lengthSquare;
        } 
        
        public static int GetAreaRectangle(int a, int b)
        {
            var areaRectangle = a * b;
            return areaRectangle;
        }

        public static int GetLengthRectangle(int a, int b)
        {
            var PR = (a + b) * 2;
            return PR;
        }
               
        public static double GetAreaTriangle(int a, int b, int c)
        {
            var p = 0.5 * (a + b + c);
            var aT = p * (p - a) * (p - b) * (p - c);
            double areaTreangle = Math.Sqrt(aT);
            return areaTreangle;
        }

        public static int GetLengthTriangle(int a, int b, int c)
        {
            var lengthTreangle = a + b + c;
            return lengthTreangle;
        }
    }
}

