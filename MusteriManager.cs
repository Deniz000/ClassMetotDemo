using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //operasyon tutuyor demek - managerlar
        public static void Ekle(Musteri musteri)
        {
            musteri.Numarasi = 4385;
            Console.WriteLine("Eklenecek Kişinin Adı :");
            musteri.Ad = Console.ReadLine();

            Console.WriteLine("Eklenecek Kişinin Adı :");
            musteri.Soyad = Console.ReadLine();

            Console.WriteLine(musteri.Ad +" " + musteri.Soyad + " Eklendi!");
        }

        }
    }
