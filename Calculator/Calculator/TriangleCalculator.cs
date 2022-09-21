using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Calculator
{
    class TriangleCalculator
    {

        //one of the angles is 90º
        public bool IsRight()
        {
            return false;
        }
        //P = a + b + c
        public bool getPerimeter()
        {
            return false;
        }
        /*
         * if ( i % 2 == 0 )
            {
                cout << i <<" ";
            }	
         */
        public void printEvenNumbers(int perimeter)
        {
            for(int i = 0; i <= perimeter; i++)
            {
                if(i% 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public double convertCoodinatesToDistance(double x1, double y1, double x2, double y2)
        {
           double tosqrt = (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
           double distance = Math.Sqrt(tosqrt );

           return distance;
        }

        //all sides equal and angles
        internal bool IsEquilateral(double ab, double bc, double ca)
        {
            return (ab == bc && bc == ca);
        }

        internal bool IsIsosceles(double ab, double bc, double ca)
        {
            return (ab == bc || ab == bc || bc == ca);
        }

        internal bool IsRight(double ab, double bc, double ca, double delta)
        {
            Console.WriteLine(Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ca, 2)));

            return Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ca, 2)) <= delta;
        }

        internal bool isCollinear( double coordinateXA,  double coordinateYA,  double coordinateXB,  double coordinateYB,  double coordinateXC,  double coordinateYC)
        {
            return (coordinateYB - coordinateYA) * (coordinateXC - coordinateXB) == (coordinateYC - coordinateYB) * (coordinateXB - coordinateXA);
        }
    }
}
