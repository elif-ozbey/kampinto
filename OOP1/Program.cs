using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product produt1 = new Product();
            produt1.Id = 1;
            produt1.CategoryId = 2;
            produt1.ProductName = "Masa";
            produt1.UnitPrice = 500;
            produt1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, CategoryId= 5, UnitsInStock=5,ProductName="Kalem", UnitPrice=25 };

            ProductManager productManager = new ProductManager(); //product manager tipinde olan productManeger () = ProductManager da yer alir (heap)
            productManager.Add(produt1);
            Console.WriteLine(produt1.ProductName);

           // productManager.Topla2(3,6); //topla2 yardimiyla ekrana yazma calisti ama sonuc dondurmedigi icin fakli bir yerde kullanilamadi. Topla2 nin void olarak tanimlanmasi
            //int toplamaSonucu = productManager.Topla(3,6);
            //Console.WriteLine(toplamaSonucu*2); //int olan toplama sonucunu aldi (fonksiyondan return ile donen deger ve 2 ile carpipip yazdirdi

        }
    }
}
