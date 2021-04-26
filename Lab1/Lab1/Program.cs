using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array sorting program

            int[] massive = new int[8];
            Random rand = new Random();
            for (int i = 0; i < massive.Length; i++)
                massive[i] = rand.Next(-100, 100);

            Console.WriteLine("Исходный массив, заполненный случайными числами");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
            Console.WriteLine("Для сортировки массива нажмите Enter");
            Console.ReadLine();

            int temp;
            for (int i = 0; i < massive.Length - 1; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;
                    }
                }
            }

            Console.WriteLine("Отсортированный по возрастанию массив, приведенный выше");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
            Console.ReadLine();

            // Simple console calculator

            double FirstNumber;
            double SecondNumber;
            double Result;
            char Operator;

            Console.WriteLine("Введите первое число, нажмите Enter:");
            FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите математический оператор (+ - / *), нажмите Enter :");
            Operator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число, нажмите Enter:");
            SecondNumber = Convert.ToDouble(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    {
                        Result = FirstNumber + SecondNumber;
                        Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + Result);
                        break;
                    }
                case '-':
                    {
                        Result = FirstNumber - SecondNumber;
                        Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " + Result);
                        break;
                    }
                case '*':
                    {
                        Result = FirstNumber * SecondNumber;
                        Console.WriteLine(FirstNumber + " * " + SecondNumber + " = " + Result);
                        break;
                    }
                case '/':
                    {
                        if (SecondNumber == 0)
                        { Console.WriteLine("Деление на 0 невозможно"); }
                        else
                        {
                            Result = FirstNumber / SecondNumber;
                            Console.WriteLine(FirstNumber + " / " + SecondNumber + " = " + Result);
                        }

                        break;
                    }
            }
        }
    }
}
