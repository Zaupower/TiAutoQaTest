using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleCalculator Tc = new TriangleCalculator();

            double coordinateXA = 0;
            double coordinateYA = 0;
            double coordinateXB = 0;
            double coordinateYB = 0;
            double coordinateXC = 0;
            double coordinateYC = 0;

            double ab = 0.0;
            double bc = 0.0;
            double ca = 0.0;

            double delta = 1.4;
            // Ask the user to type the first number.
            Console.WriteLine("Enter coordinate x of dot A");
            Double.TryParse(Console.ReadLine(), out coordinateXA);

            Console.WriteLine("Enter coordinate y of dot A");
            Double.TryParse(Console.ReadLine(), out coordinateYA);

            Console.WriteLine("Enter coordinate x of dot B");
            Double.TryParse(Console.ReadLine(), out coordinateXB);

            Console.WriteLine("Enter coordinate y of dot B");
            Double.TryParse(Console.ReadLine(), out coordinateYB);

            Console.WriteLine("Enter coordinate x of dot C");
            Double.TryParse(Console.ReadLine(), out coordinateXC);

            Console.WriteLine("Enter coordinate y of dot C");
            Double.TryParse(Console.ReadLine(), out coordinateYC);

            /*
            if(Tc.isCollinear(coordinateXA, coordinateYA, coordinateXB, coordinateYB, coordinateXC, coordinateYC))
            {
                Console.WriteLine("Coordinates are collinear!!");
                return;
            }*/

            ab = Tc.convertCoodinatesToDistance(coordinateXA, coordinateYA, coordinateXB, coordinateYB);
            bc = Tc.convertCoodinatesToDistance(coordinateXB, coordinateYB, coordinateXC, coordinateYC);
            ca = Tc.convertCoodinatesToDistance(coordinateXC, coordinateYC, coordinateXA, coordinateYA);

            //perimeter
            double perimeter = ab + bc + ca;
            

            //is it equilateral triangle?
            bool isItEquilateral = Tc.IsEquilateral(ab, bc, ca);
            bool IsIsosceles = Tc.IsIsosceles(ab, bc, ca);
            bool IsItRight = Tc.IsRight(ab, bc, ca, delta);

            //the length of triangle sides
            Console.WriteLine("Length of AB is; " + ab);
            Console.WriteLine("Length of BC is: " + bc);
            Console.WriteLine("Length of CA is: " + ca);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Triangle " + (isItEquilateral == true ? "IS" : "IS NOT") + " Equilateral");
            Console.WriteLine("Triangle " + (IsIsosceles == true ? "IS" : "IS NOT") + " Isosceles");
            Console.WriteLine("Triangle " + (IsItRight == true ? "IS" : "IS NOT") + " Right");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Parity numbers in range from  0 to triangle perimeter ");
            Tc.printEvenNumbers((int)perimeter);

        }
    }
}
