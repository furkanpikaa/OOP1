﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Furkan");
        }
    }
}
