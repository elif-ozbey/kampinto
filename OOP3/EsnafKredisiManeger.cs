﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManeger : IKrediMeneger
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandi"); ;
        }
    }
}
