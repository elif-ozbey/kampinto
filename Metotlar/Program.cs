using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("**************");

            }
            Console.WriteLine("------Metotlar------");

            SepetMeneger sepetMeneger = new SepetMeneger();
            sepetMeneger.Ekle(urun1);
            sepetMeneger.Ekle(urun2);

            SepetMeneger.Ekle2("Armut", "Yesil Armut", 12,8);


            





        }
        }
    }
}
