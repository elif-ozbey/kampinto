using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManeger konutKrediManeger = new KonutKrediManeger();


            //IKrediMeneger ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediMeneger tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediMeneger konutKrediManeger = new KonutKrediManeger();

            IKrediMeneger ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediMeneger tasitKrediManager = new TasitKrediManager();
            IKrediMeneger konutKrediManeger = new KonutKrediManeger();

            ILoggerservıce databaseLoggerService = new DatebaseLoggerService ();

            ILoggerservıce filebaseLoggerService = new FileLoggerService();
            //List<ILoggerservıce> loggers = new List<ILoggerservıce> {new SMSLoggerService(), new FileLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManeger(), new SMSLoggerService()); //hangi krediyi gonderirsem onun hesaplasi calisiyor
            //basvuruManager.BasvuruYap(konutKrediManeger);

            List<IKrediMeneger> krediler = new List<IKrediMeneger>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
