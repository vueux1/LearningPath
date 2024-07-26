namespace LearningPath.What_is_variable._9_globalScope;

public class globalScope
{
    //Bir değişken class scope içerisine tanımlanıyorsa buna global değişken denir.
    //If a variable is defined within the class scope, it is called a global variable.
    int globalVariable = 10;
    static void Main(string[] args)
    {
        
        Console.WriteLine(globalVariable);
    }
}
