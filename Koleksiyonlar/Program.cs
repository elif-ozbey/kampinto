﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Elif", "Ahmet", "Melek", "Esad"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "Ipek";
            //Console.WriteLine(isimler[4]);//hata verir cunku 4 nolu elemni listeye eklemedik

            //isimler = new string[5]; // new dediginiz anda yeni bir alan acildi ve bulana sadece Ipek atandi digerler elemanlar diger adreste kaldi
            //isimler[4] = "Ipek";
            //Console.WriteLine(isimler[4]); //Ipek olarak gelir
            //Console.WriteLine(isimler[0]); // bos gelir

            //Aray yerine koleksiyonlar kullanilir

            List<string> isimler2 = new List<string> { "Elif", "Ahmet", "Melek", "Esad" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ipek");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}