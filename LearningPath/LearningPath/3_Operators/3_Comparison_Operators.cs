namespace LearningPath.Operators;

public class Comparison_Operators {
    static void Main(string[] args)
    {
        #region Karşılaştırma Operatörleri / Comparison Operators
        //İki sayısal değer arasında büyüklük, küçüklük ve eşitlik durumuna göre karşılaştırma yapan operatörlerdir.
        //Comparison operators are operators that compare two numerical values based on their size, size, and equality.
        // <(küçüklük)/(less than)
        // >(büyüklük) / (greater than)
        // <=(küçük veya eşitlik) / <=(less than or equal to)
        // >=(büyük veya eşitlik) / >=(greater than or equal to)
        // ==(eşitlik) / ==(equality)
        #endregion
        #region Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri
        //Karşılaştırma operatörleri geriye her daim bool türde bir değer döndürecektir.
        //Comparison operators will always return a value of type bool.
        int i1 = 123;
        int i2 = 321;
 
        bool sonuc = i1 == i2; //false
        #endregion
    }
}