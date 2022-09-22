using ConsoleAppCalculator;

class  Program
{
    static void Main(string[] args)
    {
        
        double coordinateXA = 0; 
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 0; 
        double coordinateYC = 0; 
        /*
        //Equilateral 
        double coordinateXA = 15; 
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 7.5; 
        double coordinateYC = 12.99; 

        //Right triangle
        double coordinateXA = 21.213;
        double coordinateYA = 0; 
        double coordinateXB = 0; 
        double coordinateYB = 0; 
        double coordinateXC = 10.607; 
        double coordinateYC = -10.607; 
        */
        
        double ab = 0.0;
        double bc = 0.0;
        double ca = 0.0;

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
        TriangleCalculator Tc = new TriangleCalculator();

        if(Tc.isCollinear(coordinateXA, coordinateYA, coordinateXB, coordinateYB, coordinateXC, coordinateYC))
        {
            Console.WriteLine("Coordinates are collinear!!");
            return;
        }
            
        ab = Math.Round( Tc.convertCoodinatesToDistance(coordinateXA, coordinateYA, coordinateXB, coordinateYB), 2);
        bc = Math.Round( Tc.convertCoodinatesToDistance(coordinateXB, coordinateYB, coordinateXC, coordinateYC), 2);
        ca = Math.Round( Tc.convertCoodinatesToDistance(coordinateXC, coordinateYC, coordinateXA, coordinateYA), 2);

        double perimeter = ab + bc + ca;
        bool isItEquilateral = Tc.IsEquilateral(ab, bc, ca);
        bool isIsosceles = Tc.IsIsosceles(ab, bc, ca);
        bool isItRight = Tc.IsRight(ab, bc, ca, 1.3);

        Console.WriteLine("");
        Console.WriteLine("Length of AB is: " + ab);
        Console.WriteLine("Length of BC is: " + bc);
        Console.WriteLine("Length of CA is: " + ca);
        Console.WriteLine("");
        Console.WriteLine("Triangle " + (isItEquilateral == true ? "IS" : "IS NOT") + " Equilateral");
        Console.WriteLine("Triangle " + (isIsosceles == true ? "IS" : "IS NOT") + " Isosceles");
        Console.WriteLine("Triangle " + (isItRight == true ? "IS" : "IS NOT") + " Right");
        Console.WriteLine("");
        Console.WriteLine("Perimeter: " + perimeter);
        Console.WriteLine("");
        Console.WriteLine("Parity numbers in range from  0 to triangle perimeter ");
        Tc.printEvenNumbers((int)perimeter);
    }
}
