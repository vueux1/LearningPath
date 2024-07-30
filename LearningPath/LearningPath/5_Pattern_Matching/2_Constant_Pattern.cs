namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Constant_Pattern {
    
    //Elimizdeki veriyi bir sabit değer ile karşılaştırabiliyoruz.Örneğin; / We can compare the data we have with a constant value. For example;
    
    static void Main(string[] args)
    {
        object x = 125;
 
        if (x is 128)
            Console.WriteLine($"x değişkeninin değeri 128 / x variable value is 128");
        else if (x is 125)
            Console.WriteLine($"x değişkeninin değeri 125 / x variable value is 125");
        else if (x is 120)
            Console.WriteLine($"x değişkeninin değeri 120 / x variable value is 120");
 
        Console.Read(); // Çıktı: x değişkeninin değeri 125 / Output: x variable value is 125
        
       // Bir başka örnek; / Another example;
       static void Main(string[] args)
       {
           object x = "Alperen Tekin";
 
           if (x is "Alperen")
               Console.WriteLine($"Alperen");
           else if (x is null)
               Console.WriteLine($"null");
 
           Console.Read(); // Çıktı: Alperen / Output: Alperen
       }
        
    }
    
}