using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Square ");
        Sqaure sqaure = new Sqaure();
        sqaure.GetDimensions();
        sqaure.CalculateArea();
        sqaure.DisplayArea();
        Console.WriteLine("Recatngle ");
        Rectangle rectangle = new Rectangle();
        rectangle.GetDimensions();
        rectangle.CalculateArea();
        rectangle.DisplayArea();
        }
    }

