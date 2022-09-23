using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class Program
    {
        static void Main(string[] args)
        {
            DANHSACH list = new DANHSACH();
            list.Nhap();
            list.Xuat();
            Console.ReadKey();
        }
    }
}
