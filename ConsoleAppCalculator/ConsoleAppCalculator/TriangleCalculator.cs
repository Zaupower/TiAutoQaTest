
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    class TriangleCalculator
    {
        internal void printEvenNumbers(int perimeter)
        {
            for(int i = 0; i <= perimeter; i++)
            {
                if(i% 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        internal double convertCoodinatesToDistance(double x1, double y1, double x2, double y2)
        {
            // Function to calculate distance
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                             Math.Pow(y2 - y1, 2) * 1.0);
        }
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
            double[] sides = { ab, bc, ca };
            int longestSideIdx = 0;
            int[] shortSideIdx = new int[2];
            
            //find longest side
            for (int i = 1; i < sides.Length; i++)
            {
                if (sides[longestSideIdx] < sides[i])
                {
                    longestSideIdx = i;
                }
            }
            //Find other sides
            int prt = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                if (!(sides[longestSideIdx] == sides[i]))
                {
                    shortSideIdx[prt++] = i;
                }
            }
            return Math.Abs( Math.Pow(sides[longestSideIdx], 2) - (Math.Pow(sides[shortSideIdx[0]], 2) + Math.Pow(sides[shortSideIdx[1]], 2))) <= delta;
        }
        internal bool isCollinear( double coordinateXA,  double coordinateYA,  double coordinateXB,  double coordinateYB,  double coordinateXC,  double coordinateYC)
        {
            return (coordinateYB - coordinateYA) * (coordinateXC - coordinateXB) == (coordinateYC - coordinateYB) * (coordinateXB - coordinateXA);
        }
    }
}
