using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Interface_Inheritance_class
{
    public class Square:IArea
    {
       
        public void CalculateArea()
        {
            Double length = 25;
            Console.WriteLine("Square length is= " + length);
            double SquareArea = length * length;
            Console.WriteLine("Square Areais= " + SquareArea);
        }
    }
}
