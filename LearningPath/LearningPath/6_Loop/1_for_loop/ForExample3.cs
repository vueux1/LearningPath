namespace LearningPath.LearningPath._6_Loop._1_for_loop;

public class ForExample3
{
    //klavyeden girilen sayının faktöriyelini hesaplayan program
    // A program that calculates the factorial of the number entered from the keyboard
    public void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine()); // enter 8 
        int factorial = 1;
        string sum = "";
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
            if (i == 1)
            {
                sum += i + "=";
            }
            else
            {
                sum += i + "*";
            }
        }
        Console.WriteLine(sum + factorial); // 1*2*3*4*5*6*7*8=40320
    }
}