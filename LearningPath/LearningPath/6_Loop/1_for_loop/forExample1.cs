namespace LearningPath.LearningPath._6_Loop._1_for_loop;

public class ForExample1
{
    //for ( variable initialization; condition; increment/decrement) : loop body
    //1 ile 40 arasındaki çift sayıları toplayıp sonucu ekrana yazdıran program
    // A program that adds even numbers between 1 and 40 and writes the result to the screen
    public static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 40; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    
    
    
}