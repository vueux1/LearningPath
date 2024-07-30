namespace LearningPath.LearningPath._5_Pattern_Matching;

public class Relational_Patterns {
    //Desenlerde <, >, <= ve >= operatörleri kullanılabilmekte ve belirli karşılaştırmalar hızlıca gerçekleştirilebilmektedir. Örneğin;
    //In patterns, <, >, <=, and >= operators can be used and certain comparisons can be made quickly. For example;
    int number = 111;
    string result = number switch
    {
        < 100 => "100'den küçük / Less than 100",
        > 100 => "100'den büyük / Greater than 100",
        100 => "100'e eşit / Equal to 100",
    };
    //Lakin ihtimallerin hepsi değerlendirilmediği taktirde '_'(hiçbiri) operatörü kullanılabilmektedir.
    //However, if all possibilities are not evaluated, the '_' (none) operator can be used.
    
    string result2 = number switch
    {
        < 100 => "100'den küçük / Less than 100",
        > 100 => "100'den büyük / Greater than 100",
        _ => "Hiçbiri / None",
    };
    
}