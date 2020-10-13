using System;

     class Rectangle
    {
        int length, width, area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of Length");
            length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Value of Width");
            width = Convert.ToInt16(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = length * width;

        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }

    }

