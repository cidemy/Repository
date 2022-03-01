

using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable metodunu tetiklemek için kullanıır.
            //Variable();

            //People Class bilgisinden yeni bir kayıt oluşturur.
            People people = new People();

            //Parantez içerisindeki ifadeyi ekrana yazar. İmleci ifadenin sonunda bekletir.
            Console.Write("Merhaba ilk uygulama!");
            //Parantez içersindeki ifadeyi ekrana yazar. İmleci ifadenin alt satırında bekletir.
            Console.WriteLine("Merhaba WorkSpace!");

            WelcomeMessage("Ahmet");
            WelcomeMessage("Mehmet");
            WelcomeMessage("Ayşe");
            WelcomeMessage();

            int Result = Sum(100);
            //Console.WriteLine("Result: "+Result);
            int guncelBakiye = bakiyeGetir();


            string ogrenci1 = "SEHER";
            string ogrenci2 = "ALİ";
            string ogrenci3 = "SEZER";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            //Diziler (Arrays)
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "SEHER";
            ogrenciler[1] = "ALİ";
            ogrenciler[2] = "SEZER";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            //Tek satırda array tanımı, ve veri atama işlemi
            string[] cityArray1 = new[] { "İstanbul", "Ankara", "İzmir", "Trabzon" };
            string[] cityArray2 = new[] { "Bursa", "Eskişehir", "Adana", "Antalya" };

            //Array referans atama işlemi
            cityArray2 = cityArray1;

            //Array index değiştirme(atama) işlemi
            cityArray2[2] = "Samsun";

            Console.WriteLine("city2[2]: " + cityArray2[2]);

            Console.WriteLine("Lütfen Ad bilgisini yazınız: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Lütfen Soyad bilgisini yazınız: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Lütfen TC Kimlik bilgisini yazınız: ");
            long NationalIdentity = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Lütfen Doğum Yılı bilgisini yazınız: ");
            int DateOfBirthYear = Convert.ToInt32(Console.ReadLine());

            Person person1 = new Person();
            person1.FirstName = FirstName;
            person1.LastName = LastName;
            person1.NationalIdentity = NationalIdentity;
            person1.DateOfBirthYear = DateOfBirthYear;


            //Person person1 = new Person();
           // person1.FirstName = "çiğdem";
            //person1.LastName = "SOYSAL";
            //person1.NationalIdentity = 123456;
            //person1.DateOfBirthYear = 1980;


            Person person2 = new Person();
            person2.FirstName = "Mehmet";


            FirmaManager firmaManager = new FirmaManager(new PersonManager());
            firmaManager.GiveData(person1);

            //Kullanıcıdan bir yanıt bekler.
            Console.ReadLine();
        }

        static void WelcomeMessage(string Name = "Undefined")
        {
            Console.WriteLine("Merhaba, " + Name); //Çıktı: Merhaba, Mehmet

        }

        static int bakiyeGetir()
        {
            return 55;

        }

        static int Sum(int sayi1 = 0, int sayi2 = 0)
        {
            int Result = sayi1 + sayi2;
            Console.WriteLine("İşlem Sonucu: " + Result.ToString());

            return Result;
        }



        private static void Variable()
        {
            //String veri tipi içerinde yazısal ifadeler saklar.
            string message = "Merhaba Dünya!";
            //Double veri tipi içerisine ondalık ifadeler saklar.
            double money = 100000; //Veritabanında gelecek.

            //Bu tek satırlık bir açıklama satırıdır.
            /*
            Bu 1. açıklama satırıdır.
            Bu 2. açıklama satırıdır.
            Bu 3. açıklama satırıdır.
            */

            //Integer veri tipi içerisinde sadece tam sayı ifadeler saklar.
            int accountBalance = 99;

            //Boolean veri tipi içerisinde sadece true ve false değerleri saklar.
            bool isLogin = true;
            bool isCompleted = false;
            string welcomeMessage = "WorkSpace uygulamasına hoşgeldiniz.";


            string name = "Fatih";
            string surname = "Soysal";
            int birthYear = 1970;


            long TCNumber = 12345678900;



            // Console.WriteLine: Satır içerisine parantez içerisindeki bölümü yazar. Ve alt satıra iner.
            //Console.WriteLine(1000 * 1.92);
            //Console.WriteLine(money * 1.92);
        }
    }



    //Public class tipi class'ın farklı noktalardan erişilebilir olmasını sağlar.
    public class People
    {

        //public string name = "Fatih";

        //public string surname = "Soysal";
        //public int birthDate = 1970;
        //public long TCNumber = 12345678900;

        //Class içerisindeki attribute bilgilerini oluşturuyoruz.
        //Public olarak dışarıdan Set edilebilir, Veya içeriden get edilebilir durumda olacaklar.
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long TcNumber { get; set; }



    }
}
