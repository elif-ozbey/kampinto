using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123456";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5432";
            musteri2.SirketAdi = ""Kodlama.io;
            musteri2.VergiNo = "123457";

            Musteri musteri3 = new GercekMusteri(); //Musteri hem gercek hem tuzel referansi tutabiliyor
            Musteri musteri4 = new TuzelMusteri();

            MusteriMeneger musteriMeneger = new MusteriMeneger();
            musteriMeneger.Ekle(musteri1);
            musteriMeneger.Ekle(musteri2);

        }
    }
}
