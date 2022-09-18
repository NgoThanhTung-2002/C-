using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHinhVuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
