using System.Diagnostics;

namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Simple_Type {
    /*
     Bir değişkenin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir. 
     C# 9.0’dan önceki sürümlerde tür kontrolü yapılırken tür bildirimlerinin yanına değişken adı tanımlaması yahut Discard ifadesinin kullanılması zorunluydu.
     C# 9.0 ile bu gereksiz zorunluluk ortadan kaldırılmış ve direkt olarak tür kontrol işlemine odaklanılması sağlanmıştır.
    
     It is a pattern that allows us to quickly check whether a variable is of a certain type.
     In versions before C# 9.0, when type checking was done, it was mandatory to define the variable name next to the type declarations or to use the Discard expression.
     With C# 9.0, this unnecessary requirement has been eliminated and it has been ensured that the focus is directly on the type checking process.
     */
    
    //Before c# 9.0
    string GetProduct(IProduct p) => p Switch
    {
        Technologic _ =>"Teknolojik",
        Computer _ => "Bilgisayar",
        Goggles _ => "Gözlük",
    };
    
    
    //After c# 9.0
      string GetProduct(IProduct p) => p Switch
    {
       Technologic =>"Teknolojik",
           Computer => "Bilgisayar",
               Goggles => "Gözlük",
    };
    
}