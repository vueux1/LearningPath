namespace LearningPath.LearningPath._6_Loop._2_while_loop;

public class whileEx2
{
    //klavyeden girilen sayıya kadar olan sayıları ekrana yazdıran program
    //a program that writes numbers up to the number entered from the keyboard to the screen
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        while (number >= 0)
        {
            number--;
            Console.WriteLine(number);
        }
    }
}