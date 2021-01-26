using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediMeneger krediMeneger, ILoggerservıce loggerService) //tum referanslari tuttugu icin parametre olarak bunu ekledik
        {
            //basvuran bilgilerinidegerlendirme
            //KonutKrediManeger konutKrediManeger = new KonutKrediManeger();
            //konutKrediManeger.Hesapla(); // bu sekilde yaparken tum kredi hesaplamalarini konut kredisine gore yaptik

            krediMeneger.Hesapla();
            loggerService.Log();
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediMeneger> krediler) //birden fazla kredinin hesabini yapmak istiyoruz
        {
            foreach (var kredi in krediler) //listedeki herbir kredinin hesabini yap
            {
                kredi.Hesapla();
            }
        }
    }
}
