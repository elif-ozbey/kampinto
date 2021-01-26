using System;

namespace GenericsInro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ipek"); //isimler string olrak tanimlandigi icin string bir deger verdik
        }
    }
}
