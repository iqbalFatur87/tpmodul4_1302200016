﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> dataGeneric = new DataGeneric<string>("1302200016");

            dataGeneric.PrintData();   
        }
    }
}
