using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Interface_Inheritance_class
{
    public class Circle:IArea
    {
        public void CalculateArea()
        {
            double radius = 34;
            Double Pi = 3.14;
            Console.WriteLine("Circle radius is = " + radius);
            Console.WriteLine("Circle Pi is = " + Pi);
            double CircleArea = Pi * radius * radius;
            Console.WriteLine("CircleArea  is = " + CircleArea);
        }
    }
}
