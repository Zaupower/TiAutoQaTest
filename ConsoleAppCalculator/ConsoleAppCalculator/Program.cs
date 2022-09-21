// See https://aka.ms/new-console-template for more information
//Notes there are coordinates because the triangle is being defined on 2d plan
class  Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");

        int coordinateXA = 0; 
        int coordinateYA = 0; 
        int coordinateXB = 0; 
        int coordinateYB = 0; 
        int coordinateXC = 0; 
        int coordinateYC = 0; 

        double ab = 0.0;
        double bc = 0.0;
        double ca = 0.0;

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
    }
    
}
