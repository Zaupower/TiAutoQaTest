// See https://aka.ms/new-console-template for more information
//Notes there are coordinates because the triangle is being defined on 2d plan

using ConsoleAppCalculator;

class  Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");

        double coordinateXA = 15; 
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 7.5; 
        double coordinateYC = 0; 

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
       
        ab = Tc.convertCoodinatesToDistance(coordinateXA, coordinateYA, coordinateXB, coordinateYB);
        bc = Tc.convertCoodinatesToDistance(coordinateXB, coordinateYB, coordinateXC, coordinateYC);
        ca = Tc.convertCoodinatesToDistance(coordinateXC, coordinateYC, coordinateXA, coordinateYA);
        Math.Round(ab, 2);
        Math.Round(bc, 2);
        Math.Round(ca, 2);
        
        Console.WriteLine("ab: "+ab);
        Console.WriteLine("bc: "+ab);
        Console.WriteLine("ca: "+ab);
    }
    
}
