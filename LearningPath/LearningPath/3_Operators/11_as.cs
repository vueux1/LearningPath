namespace LearningPath.Operators;

public class @as {
// "as" Operatörü  (as Operator)
//"as" operatörü, bir nesneyi belirli bir türe dönüştürmek için kullanılır.
//Eğer dönüşüm başarılı olursa nesne belirtilen türe dönüşür, aksi halde "null" değeri alır.
//Bu, hatalı dönüşümlerden kaçınmak için kullanışlıdır. Kullanımı şu şekildedir:
//The "as" operator is used to convert an object to a specific type.
//If the conversion is successful, the object is converted to the specified type, otherwise it takes the value "null".
//This is useful to avoid incorrect conversions. Usage is as follows:

    object deger = "5";

    int? sayi = deger as int?;

    if (sayi != null)

    {

        Console.WriteLine("Dönüşüm başarılı: " + sayi);

    }

    else

    {

        Console.WriteLine("Dönüşüm başarısız /.");

    }
}