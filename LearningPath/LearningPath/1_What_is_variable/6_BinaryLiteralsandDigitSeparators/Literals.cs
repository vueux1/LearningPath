namespace LearningPath.What_is_variable._6_BinaryLiteralsandDigitSeparators;

public class Literals
{
    /*
     Binary literals are used to represent binary numbers. 
     They are prefixed with 0b or 0B. 
     Digit separators are used to separate digits in numeric literals. 
     They are represented by an underscore (_).
     
     Bianry literaller, Binary sayıları temsil etmek için kullanılır. 
     Bunlar 0b veya 0B ile öne alınır. 
     Sayısal literallerdeki rakamları ayırmak için basamak ayırıcıları kullanılır. 
     Bunlar alt çizgi (_) ile temsil edilir.
     */
    
    int Sayi1 = 1_000_000;
    double Sayi2 = 1_00;
    decimal Sayi3 = 00_112;
    float Sayi4 = 123_3211123123;
    
    int Binary1 = 0b1100;
    double Binary2 = 0b111001001;
    decimal Binary3 = 0b0;
    
    int Binary4 = 0b1_10_0;
    double Binary5 = 0b1_110_0100_1;
    decimal Binary6 = 0b0_0;
    decimal Binary7 = 0b111_000_111_000;
}