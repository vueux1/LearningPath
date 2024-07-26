namespace LearningPath._1_What_is_variable._11_ObjectandVar;

public class objectandvar
{
    /*
     * var tipi değişken;
    var tipi değişken tanımlarsanız eğer değişkenin tipini siz değil derleyici tanımlayacaktır.
    Derleyicinin tanımladığı tipe göre o veri RAM üzerin de o tiple saklanacaktır.
    Not:var değişken tipi,diller arası,databaseler arası entegrasyonu sağlarken veri tipleri uyuşmazlığını gidermek için oluşturulmuş bir tiptir.
    Yani C#’ta int ile tanımlanan bir değişken Delphi ‘de başka türlü tanımlanabilir.var değişken tipide bütün dillerde evrensellik özelliği taşımaktadır.
    Sizlere tavsiyem normal kodlamada verinizin tipine göre normal değişken tanımlayınız.

    The `var` keyword in variables;
    If you define a variable with the `var` type, the compiler, not you, will determine the type of the variable.
    The data will be stored in RAM according to the type defined by the compiler.
    Note: The `var` variable type has been created to resolve type mismatches during integration across languages and databases.
    That is, a variable defined as an `int` in C# can be defined differently in Delphi. The `var` variable type also carries universality across all languages.
    My advice to you is to define normal variables according to the type of your data in regular coding.
     */
    var a = 10.6; 
    var b = 20; 
    var c = "asd"; 
    var d = true; 
    
    /*
     * object tipi değişken;
     object olarak tanımlanan değişken her tipteki veriyi içinde saklayablir.
     Fakat object tipteki değişkene atanan değer Boxing(Kutulama) işlemine uğrar.
     Yani,object tipiyle oluşturduğumuz bir string değişken,RAM’e string olarak değilde object olarak kaydedilir.
     Tanımlanan object değişkeni kullanmak istediğimiz de,içinde saklanan verinin tipini elde ederek kullanmalıyız.
     Bunun içinde Unboxing(Kutudan Çıkarma) işlemi yapılır.
     Bu işlem sonucunda object içindeki asıl tipini almış oluruz.
     
    The `object` type variable;
    Variables defined as `object` can store data of any type. 
    However, when a value is assigned to a variable of type `object`, it undergoes a boxing process. 
    This means that a variable created as a string, for example, is stored in RAM not as a string but as an object. 
    When we want to use the defined object variable, we must retrieve the type of the stored data to use it. 
    This is done through an unboxing process. 
    As a result of this process, we obtain the original type of the data stored in the object.
     */
    
    object b=10; //Boxing
    int a = (int)b; //Unboxing
    
    object ahmet1 = "ahmet";//Boxing
    string ahmet2 = (string)ahmet1;//Unboxing
}