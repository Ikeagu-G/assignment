using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdAfrica

  
{
    class Trapezium
    {
        public double side_a;
        public double side_b;
        public double height;

        public Trapezium(double aside_a,double aside_b,double aheight)
        {
            side_a = aside_a;
            side_b = aside_b;
            height = aheight;


        }
        public double Area()
        {
            double tay = 0.5 * height;
            double Area= tay *(side_a + side_b);
            return Area;
        }




    }  
}
