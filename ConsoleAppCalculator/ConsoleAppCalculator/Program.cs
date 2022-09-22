// See https://aka.ms/new-console-template for more information
//Notes there are coordinates because the triangle is being defined on 2d plan

using ConsoleAppCalculator;

class  Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
/*Equilateral 
        double coordinateXA = 15; 
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 7.5; 
        double coordinateYC = 12.99; 
*/
//Right triangle
        double coordinateXA = 21.213;
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 10.607; 
        double coordinateYC = 10.607; 
        
        
        double ab = 0.0;
        double bc = 0.0;
        double ca = 0.0;

        /*
        // Ask the user to type the first number.
        Console.WriteLine("Enter coordinate x of dot A");
        coordinateXA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot A");
        coordinateYA = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter coordinate x of dot B");
        coordinateXB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot B");
        coordinateYB = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter coordinate x of dot C");
        coordinateXC = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter coordinate y of dot C");
        coordinateYC = Convert.ToInt32(Console.ReadLine());
        */

        TriangleCalculator Tc = new TriangleCalculator();
       
        /*
            if(Tc.isCollinear(coordinateXA, coordinateYA, coordinateXB, coordinateYB, coordinateXC, coordinateYC))
            {
                Console.WriteLine("Coordinates are collinear!!");
                return;
            }*/
        ab = Math.Round( Tc.convertCoodinatesToDistance(coordinateXA, coordinateYA, coordinateXB, coordinateYB), 2);
        bc = Math.Round( Tc.convertCoodinatesToDistance(coordinateXB, coordinateYB, coordinateXC, coordinateYC), 2);
        ca = Math.Round( Tc.convertCoodinatesToDistance(coordinateXC, coordinateYC, coordinateXA, coordinateYA), 2);

        bool isEquilateral = Tc.IsEquilateral(ab, bc, ca);
        bool IsIsosceles = Tc.IsIsosceles(ab, bc, ca);
        bool IsRight = Tc.IsRight(ab, bc, ca, 1.3);

        Console.WriteLine("ab: "+ab);
        Console.WriteLine("bc: "+ bc);
        Console.WriteLine("ca: "+ca);
        
        Console.WriteLine("isEquilateral: "+isEquilateral);
        Console.WriteLine("IsIsosceles: "+IsIsosceles);
        Console.WriteLine("IsRight: "+IsRight);
    }
}
