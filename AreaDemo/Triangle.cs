using System;

class Triangle : Figure
{
    int height,Base;
    public override void CalculateArea()
    {
        area = (int).5 * Base * height;
    }

    public override void GetDimensions()
    {
        Console.WriteLine("Enter Value of Base");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value of Height");
        height  = Convert.ToInt32(Console.ReadLine());
    }
}
 
