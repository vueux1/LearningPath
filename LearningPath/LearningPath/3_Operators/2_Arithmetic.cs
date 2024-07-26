namespace LearningPath.Operators;

public class Arithmetic
{
    static void Main(string[] args)
    {
        #region Aritmatik Operatörler / Arithmetic Operators
        // +
        // -
        // *
        // /
        // %
        #region Aritmetik Operatörler Geriye Dönüş Değeri / Arithmetic Operators Return Value
        //Aritmetik operatörler, iki sayısal değer üzeirnde işlem yapan operatörler oldukları için işlem neticesinde geriye "uygun türde" sonuç dönerler.
        //Arithmetic operators, as operators that perform operations on two numerical values, return a result of the "appropriate type" as a result of the operation.
        #region İnceleme 1
        int sonuc = 3 + 5;
        #endregion
        #region İnceleme 2
        int x = 3, y = 5;
        int y = 5;
        int sonuc = x * y;
        #endregion
        #region İnceleme 3
        double s1 = 123;
        double s2 = 321;
        double sonuc = s1 + s2;
        #endregion
        #region İnceleme 4
        decimal s1 = 123123;
        decimal s2 = 3214532;
        decimal sonuc = s1 % s2;
        #endregion
        #endregion
        #region (int) * (int) = ?
        int s1 = 123;
        int s2 = 3213;
        int sonuc = s1 / s2;
        #endregion
        #region (int) * (double) = ?
        //İki farklı türde sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç büyük olan türde dönecektir.
        //Arithmetic operations performed on two numerical values of different types will result in a value of the larger type.
        int s1 = 10;
        double s2 = 5;
        double sonuc = s1 + s2;
        #endregion
        #region (byte) * (int) = ?
        int s1 = 3;
        byte s2 = 123;
        int sonuc = s1 - s2;
        #endregion
        #region (byte) * (byte) = ?  (İstisna! - Mülakat!!!)
        byte s1 = 10;
        byte s2 = 5;
        int sonuc = s1 - s2;
        #endregion
        #endregion
    }
}