using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilimci yetistirme";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java kursu";

            string[] kurslar = new string[] { "Yazilimci yetistirme", "Temel Kurs", "Java kursu", "C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach bitti");
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
