namespace LearningPath._2_Type_Conversion._2_Convert;

public class convert
{
    /*Sayısal verileri string’e çevirme
    MessageBox,label,textbox gibi bazı kontrollerin yazı özellikleri string olduğu için,bazı matematiksel hesaplama gibi benzer olayların sonuclarını bu kontrollerde gösterirken string tipine çevirmemiz gerekiyor.
    Elimizdeki int tipindeki sonucu,string özelliği gösteren bir kontrolde göstermek istiyorsak mecburen o int stringe convert edilmedilidir. 
    
    Converting numerical data to string
    Since the text properties of some controls like MessageBox, label, and textbox are strings, we need to convert the results of some mathematical calculations or similar events to string when displaying them in these controls.
    If we want to display an integer result in a control that shows string properties, we must convert that integer to a string.
    */
    
    int a = 10;
    textBox1.Text = Convert.ToString(a);
    //Yukarıda gördüğünüz gibi int tipindeki a değişkenini textbox.
    //Text özelliğine atarken string tipine dönüştürülerek atılmış.
    //Bunun sebebini artık biliyorsunuz.
    //string tipine dönüştürmenin farklı kalıpları vardır.
    //Biri yukarda gösterdiğimiz klasik biçimdir.
    
    // As you can see above, the integer variable `a` is assigned to the `Text` property of the textbox.
    // It is converted to a string when assigned to the `Text` property.
    // You now know the reason for this.
    // There are different patterns for converting to a string.
    // One of them is the classic form we showed above.
    
    
    //veya bu şekilde de yapabiliriz.
    
    // or we can do it this way.
    
    dodouble a;
    a = 10;
    textBox1.Text = a + "";
}