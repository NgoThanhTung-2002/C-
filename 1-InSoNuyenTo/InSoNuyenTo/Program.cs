using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSoNuyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.Write("n khong phai so nguyen to.");
            }
            else
            {
                for(int i = 1; i<= n; i++)
                    for(int j = 2; j <= Math.Sqrt(n); j++)
                    {
                        if (i % j != 0)
                        {
                            Console.Write("{0}",i);
                            Console.ReadLine();
                        }
                    }
                              
            }
        }
    }
}
