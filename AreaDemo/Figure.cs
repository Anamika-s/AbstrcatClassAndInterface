using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   abstract class Figure
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }


