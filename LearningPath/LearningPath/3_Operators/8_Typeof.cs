namespace LearningPath.Operators;

public class Typeof
{

    /*
     * Verilen türün/değerin typeını/değerini döndürür.
     * ileri düzey programlamada reflection ile birlikte kullanılır.
     * Returns the type/value of the given type/value.
     * Used in advanced programming with reflection.
     */
    
    
        int a = 5;
        Console.WriteLine(typeof(a)); // System.Int32
        Console.WriteLine(typeof(int)); // System.Int32
    
}