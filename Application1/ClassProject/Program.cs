using System;

namespace ClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adSoyad = "çiğdem ay";
            int ogrNo = 11252;
            Personel personel1=new Personel();
            personel1.PersonelAdSoyad = "çiğdem AY";
            personel1.PersonelTelefon = "54372727";
            personel1.PersonelTC = 122345;
            personel1.PersonelAdres = "";
            personel1.PersonelDogumTarihi = new DateTime(1988, 12, 4);
            personel1.PersonelBasariOrtalama = 9.4;


            Personel[] personeller = new Personel[] { personel1 };
            foreach (var personel in personeller)
            {
                Console.WriteLine(personel.PersonelAdSoyad);
            }
            Console.WriteLine(personel1.PersonelAdSoyad + "" + personel1.PersonelAdres);

        }
        class Personel
        {
            public string PersonelAdSoyad { get; set; }
            public string PersonelTelefon { get; set; }
            public long PersonelTC { get; set; }
            public string PersonelAdres{ get; set; }
            public DateTime PersonelDogumTarihi { get; set; }
            public double PersonelBasariOrtalama { get; set; }

           
        }
    }
}
