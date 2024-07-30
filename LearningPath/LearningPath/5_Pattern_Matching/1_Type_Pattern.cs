namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Type_Pattern {
    // Type Pattern’den önce, / Before Type Pattern
    static void Main(string[] args)
    {
        object x = 125;
        if (x is string)
        {
            string xx = x as string;
            Console.WriteLine($"x değişkeni string tipindedir.");
        }
        else if (x is int)
        {
            int xx = (int)x;
            Console.WriteLine($"x değişkeni int tipindedir.");
        }
        Console.Read();
        
        //Type Pattern’den sorna / After Type Pattern
        
        static void Main(string[] args)
        {
            object x = 125;
 
            if (x is string xx)
                Console.WriteLine($"x değişkeni string tipindedir.");
            else if (x is int xx)
                Console.WriteLine($"x değişkeni int tipindedir.");
 
            Console.Read();
        }
        
    }
}