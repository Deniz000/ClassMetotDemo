using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Numarasi = 1245;
            musteri1.Ad = "Cemile";
            musteri1.Soyad = "Yazmalı";

            Musteri musteri2 = new Musteri();
            musteri2.Numarasi = 4568;
            musteri2.Ad = "Hakkı";
            musteri2.Soyad = "Polat";

            Musteri musteri3 = new Musteri();
            MusteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2, musteri3}; // veritabanından alır

            //typesafe--tip güvenli : tipi olmak zorunda

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Numarasi + " " + musteri.Ad +" "+ musteri.Soyad );
            }
           

        }
    }
}
