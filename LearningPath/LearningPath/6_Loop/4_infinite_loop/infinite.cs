namespace LearningPath.LearningPath._6_Loop._4_infinite_loop;

public class infinite
{
    static void Main(string[] args)
    {
        //for
        bool loop = true;
        for (; loop;)
        {
            if (true)
            {
                loop = !loop;
            }
        }
        
        //while
        bool loop1 = false;
        while (!loop1)
        {
            if (true)
            {
                loop1 = !loop1;
            }
        }
        
        //do while
        bool loop2 = true;
        do
        {
            
            if (true)
            {
                loop2 = !loop2;
            }
            
        } while (loop);
    }
}