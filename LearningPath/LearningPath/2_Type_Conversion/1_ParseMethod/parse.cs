﻿namespace LearningPath._2_Type_Conversion._1_ParseMethod;

public class parse
{   //TODO ingilizce açıklama ekle 
    static void Main(string[] args)
    {
        #region Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi
        //Tür dönüşümlerinde dikkat edilmesi gereken tek bir husus vardır ki, o da ; dönüşüm yapılacak verinin türüne uygun bir hedef tür belirlenmelidir.
        #region Parse Metodu
        //Parse metodu sadece string dataları hedef türe dönüştürürken kullanılır!
        #region Örnek 1
        string x = "123";
        Console.WriteLine(x * 5);
        //string ve int değer çarpılamaz bu yüzden hata alıyoruz
        short x2 = short.Parse(x);
        Console.WriteLine(x2 * 5);
        Console.WriteLine(short.Parse(x) * 5);
        #endregion
        #region Örnek 2
        //Tür HATALI
        string a = "Ahmet";
        int a2 = int.Parse(a);
        Console.WriteLine(a2);
        #endregion
        #region Örnek 3
        string medeniHal = "false";
        bool medeniHal2 = bool.Parse(medeniHal);
        Console.WriteLine(medeniHal2);
        #endregion
        #region Örnek 4
        string x3 = "a";
        char x4 = char.Parse(x3);
        #endregion
        #endregion
        #region Convert Fonksiyonları
 
        #endregion
        #endregion
    }
}