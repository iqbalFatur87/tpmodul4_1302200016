using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nama : Muhamad Iqbal F
// NIM : 1302200016
// Kelas : SE4402

namespace tpmodul4_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> dataGeneric = new DataGeneric<string>("1302200016");
            HaloGeneric<String> haloGeneric = new HaloGeneric<string>();

            dataGeneric.PrintData();   
            haloGeneric.SapaUser("Iqbal");
        }
    }
}
