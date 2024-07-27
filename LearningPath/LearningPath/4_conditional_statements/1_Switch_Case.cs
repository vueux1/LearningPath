namespace LearningPath.LearningPath._4_conditional_statements;

public class Switch_Case {
    /*
     * Switch() parantezin içine yazılan ifade,değeri kontrol edilecek olan ifadedir.
     * Case’den sonra bu ifadenin alabileceği bir değer yazılır.Eğer ifade bu değere sahipse “Case-Break” arası çalışır.
     * Burada “Case-Break” arası bir nevi Scope arasına benzer.
     * Eğer hiç bir ifade hiç bir case deki değerleri uymuyorsa,”Default-Break” arası çalışır
     * .Default-break komutunuda bir nevi Else’ye benzetebiliriz.
     */
    
    public void SwitchCaseExample() {
        int number = 5;
        switch (number) {
            case 1:
                Console.WriteLine("Number is 1");
                break; // break komutu olmazsa diğer case’lerdeki kodlarında çalıştırılacağını unutmayın. / If there is no break command, remember that the code in other cases will also be executed.
            case 2:
                Console.WriteLine("Number is 2");
                break;
            case 3:
                Console.WriteLine("Number is 3");
                break;
            case 4:
                Console.WriteLine("Number is 4");
                break;
            case 5:
                Console.WriteLine("Number is 5");
                break;
            default:
                Console.WriteLine("Number is not 1,2,3,4,5"); 
                break; //
        }
        /*
         * Bunların dışında goto case deyimi ile bir durumda diğer durumların komutlarını çalıştırabiliyoruz.
         * Bu deyimin kullanımı ise şu şekilde:
         * 
         *  Besides these, with the `goto case` statement, we can execute the commands of other cases in one case.
         * The usage of this statement is as follows:
         */
        
        switch (sayi)
        {
            case 1: sonuc = "10"; break;
            case 2: sonuc = "20"; break;
            case 3: sonuc = "30"; break;
            case 4: goto case 1; //sonuc değeri 10 olacak / the result value will be 10
        }
}