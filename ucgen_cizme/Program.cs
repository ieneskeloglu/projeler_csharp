using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgen_cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen yüksekliğini giriniz: ");
            int n=Int32.Parse(Console.ReadLine());
            UcgenCizme(n+1);
            Console.ReadKey();

        }
        private static void UcgenCizme(int n){
            for(int i=1;i<n;i++){
                for(int j=0;j<i;j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
