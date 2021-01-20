using System;

namespace kampinto
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "Kategori";
            Console.WriteLine("kategoriler");
            int ogrencisayisi = 32000;
            double faizoani = 1.45;
            bool sistemegiris = false;
            double dolarbugun = 7.35;
            double dolardun = 7.45;

            if (dolarbugun > dolardun)
            {
                Console.WriteLine("artis butonu");
            }

            else if (dolarbugun < dolardun)
            {
                Console.WriteLine("azalis butonu");
            }

            else
            {
                Console.WriteLine("durum degismedi");
            }

            if (sistemegiris==true)
            {
                Console.WriteLine("sistem ayarlari butonu");
            }
            else 
            {
                Console.WriteLine("sisteme giris yap");
            }

        }
    }
}
