using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsInro
{
    class MyList<T> //T koydugumuzda ozel bir tip tanimlayacagimizi gosteriyor
    {
        T[] items;//metodun disinda yazdik cunku her yerden bu diziye erisebiliyor. clasin tum operasyonlari erisebiliyor
        //constructor clasi newlersen bu otomatik calisiyor. 
        public MyList() //ctor yazip tab tab yapinca blok geldi //clas ile ayni isimdeyse constracter oldugunu anliyoruz
        {
            items = new T[0]; //T items degerini klasi newledigimde olusturmak zorundayim.sifir elemenli bile olsa. Boylelikle kendi olusturdugum klasima yer aciyorum
        }
        
        public void Add( T item) //T olarak ne verirsem istedigim elemanin turude o dur. 
        {
            T[] tempArray = items; //asagidaki gosterimde newledigimizde eski arrayimizin referansi degisiyordu. Eski arrayimi tutacak bir gecici dizi tanimliyoruz
            items = new T[items.Length+1];
           for (int i = 0; i < tempArray.Length; i++)
        {
            items[i] = tempArray[i];
        }
        items[items.Length - 1] = item;
        }
    }
}
