namespace LearningPath.LearningPath._6_Loop._2_while_loop;

public class WhileEx1
{
    static void Main(string[] args)
    //ekrana 10 kere Hello World! yazdıran program
    //a program that writes Hello World! to the screen 10 times
    {
        int i = 0;
        while (i <= 10)
        {
            i++;
            Console.WriteLine("Hello World!");
        }
    }
}