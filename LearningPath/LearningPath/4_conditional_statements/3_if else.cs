using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi = Console.ReadLine();

            if (kullaniciAdi == "abc - 123 - 236 - cmk")
            {
                Console.WriteLine("Kullanıcı girişi başarılı");
            }

            else if (kullaniciAdi == "hhh - bbb - mmm")
            {
                Console.WriteLine("Kullanıcı girişiniz kitlenmiştir");
            }

            else { Console.WriteLine("Hatalı Kullanıcı Kodu"); }
        }
    }
}
