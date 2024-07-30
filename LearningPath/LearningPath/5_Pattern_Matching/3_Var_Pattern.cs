namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Var_Pattern {
    //Eldeki veriyi “var” değişken tipiyle elde etmemizi sağlayan desendir. Hemen aşağıdaki örneği inceleyiniz.
    // It is a pattern that allows us to obtain the data with the "var" variable type. Please see the example below.
    static void Main(string[] args)
    {
        object x = "Türkiye";
        if (x is var a)
        {
            Console.WriteLine(a);
        }
 
        Console.Read(); 
        
        //Burada “x” değişkenini “var” ile elde edilerek “a” değişkenine atanmakta /
        //Here, the "x" variable is obtained with "var" and assigned to the "a" variable
    }
}