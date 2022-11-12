using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Interface_Inheritance_class
{
    public class Rectangle:IArea
    {
        public void CalculateArea()
        {
            double length = 20;
            double width = 15;
            Console.WriteLine("Rectangle length is= " + length);
            Console.WriteLine("Rectangle width is= " + width);
            double RectangleArea = length * width;
            Console.WriteLine("Rectangle Areais= " + RectangleArea);
        }
    }
}
