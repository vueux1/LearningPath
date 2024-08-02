namespace LearningPath.LearningPath._6_Loop._2_while_loop;

public class whileEx4
{
    //klavyeden girilen sayının faktöriyelini hesaplayalım
    //Let's calculate the factorial of the number entered from the keyboard.
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int factrorial = 1;
        while (number > 0)
        {
            factrorial *= number--;
        }
        Console.WriteLine(factrorial);
    }
}