namespace LearningPath.Operators;

public class @is
{
    /*"is" operatörü, bir nesnenin belirli bir türe ait olup olmadığını test etmek için kullanılır.
    Bu operatör, bir ifadeyi ve bir türü alır ve ifadenin belirtilen türe ait olup olmadığını sorgular.
    Eğer ifade belirtilen türe aitse, "true" değerini döndürür, aksi halde "false" döndürür. Örnek kullanımı şu şekildedir:
    
    The "is" operator is used to test whether an object is of a certain type.
    This operator takes an expression and a type and queries whether the expression is of the specified type.
    If the expression is of the specified type, it returns "true", otherwise it returns "false". Example usage is as follows:
    */
    object deger = "Merhaba dünya";

    if (deger is string)
    {   

        Console.WriteLine("Deger bir string ifadedir.");

    }
}