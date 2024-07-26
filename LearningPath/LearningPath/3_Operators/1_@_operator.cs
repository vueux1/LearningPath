namespace LearningPath.Operators;

public class __operator
{
    static void Main(string[] args)
    {
        /*
        Değişken isimlerinde programatik keywordler kullanılamaz.
        Eğerki programtik bir kayword kullanmak istiyorsak @ işareti ile kullanabiliriz.
        Programmatic keywords cannot be used in variable names. 
        If we want to use a programmatic keyword, we can do so by prefixing it with the @ symbol.
        */
        int @int = 5;
        Console.WriteLine(@int);
    }
    
}