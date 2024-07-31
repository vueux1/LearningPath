namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Logical_Patterns {
    //and, or ve not gibi mantıksal operatörler kullanılabilmektedir. Misal; / Logical operators such as and, or and not can be used. For example;

    string GetProduct(IProduct p) => p switch
    {
        Technologic or Computer => "Computer",
        Goggles => "Gözlük"
    };

     int number = 60;

     private string result = number switch
     {
         > 10 and < 50 => "10'dan büyük 50'den küçük / Greater than 10 and less than 50",
         > 50 and < 100 => "50'den büyük 100'den küçük / Greater than 50 and less than 100",
         _ => "Diğer / Other"
     };
}