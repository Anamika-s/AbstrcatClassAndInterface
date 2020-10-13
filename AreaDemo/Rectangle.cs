using System;

     class Rectangle : Figure
    {
        int length, width;
        public  override void GetDimensions()
        {
            Console.WriteLine("Enter Value of Length");
            length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Value of Width");
            width = Convert.ToInt16(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = length * width;

        }
    
    }

