using System;

    class Sqaure  : Figure
    {
    int side;
    public override void GetDimensions()
    {
        Console.WriteLine("Enter Value of Side");
        side = Convert.ToInt16(Console.ReadLine());

    }
    public  override void CalculateArea()
    {
        area = side * side; 

    }
    }

