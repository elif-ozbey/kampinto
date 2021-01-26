using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //olusturdugumuz Product tipinde bir product
            //ProductManager icindedn cagiracaksin beni benim adim Add
        {
            Console.WriteLine(product.ProductName + "eklendi");

        }
         public void Update (Product product) //void ile belirtilen metodlar emir kipinde git ekle' git degistir' git sil gibi direk islemi yapiyor sonucunda herhangi bir deger donmuyor
        {
            Console.WriteLine(product.ProductName + "guncellendi");

        }

        //public int Topla (int sayi1, int sayi2)
        //{
           // return sayi1 + sayi2; 
        //}

       // public void Topla2(int sayi1, int sayi2)
      //  {
          //  Console.WriteLine(sayi1 + sayi2);
       // }
       
    }
}
