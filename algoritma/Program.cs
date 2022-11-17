using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime ve sayı giriniz (Algoritma,2)vb.");
            string metin=Console.ReadLine();
            IslemYap(metin);
            Console.ReadKey();
        }
        private static void IslemYap(string metin){
            int sayac=1;
            string[] ilkAyrim=metin.Split(',');
            string kelime = ilkAyrim[0];
            int deger=int.Parse(ilkAyrim[1]);
            
            Console.WriteLine(kelime);
        }
    }
}
