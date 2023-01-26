using System;

namespace MyApp
{
    class Program
    {
        static double EnterNumber(string str)
        {
            Console.Write(str);
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            return number;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            double r = EnterNumber("Введите радиус для нахождения площади круга: ");

            Circle circle = new Circle(r);
            circle.FindSquare();

            double length = EnterNumber("Введите длину для нахождения площади квадрата: ");
            double width = EnterNumber("Введите ширину для нахождения площади квадрата: ");

            Square square = new Square(length, width);
            square.FindSquare();

            double length1 = EnterNumber("Введите длину для нахождения площади прямоугольника: ");
            double width1 = EnterNumber("Введите ширину для нахождения площади прямоугольника: ");

            Rectangle rectangle = new Rectangle(length1, width1);
            rectangle.FindSquare();
        }
    }
}