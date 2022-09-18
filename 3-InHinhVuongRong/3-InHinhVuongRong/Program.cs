using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_InHinhVuongRong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write("* ");
                    }
                    else {
                        if (j == 1 || j == n)
                        {
                            Console.Write("* ");
                        }
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
