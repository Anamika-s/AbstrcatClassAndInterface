using System;

    class Sqaure
    {
    int side, area;
    public void GetDimensions()
    {
        Console.WriteLine("Enter Value of Side");
        side = Convert.ToInt16(Console.ReadLine());

    }
    public void CalculateArea()
    {
        area = side * side; 

    }
    public void DisplayArea()
    {
        Console.WriteLine("Area is " + area);
    }

    }

