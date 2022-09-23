using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class TamGiac : HINH
    {
        private int a;
        private int b, c;


        public TamGiac():base()
        {

        }

        public TamGiac(String tenhinh, int a, int b, int c):base(tenhinh)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double tinhChuVi()
        {
            return (this.a + this.b + this.c);
        }
        public double tinhDienTich()
        {
            double p = this.tinhChuVi() / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }

        public void NhapTamgGiac()
        {
            Console.WriteLine("Nhap canh a: ");
            this.a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            this.b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh c: ");
            this.c = Int32.Parse(Console.ReadLine());
        }


        public void XuatTamGiac()
        {
            Console.WriteLine("canh a: " + this.a);
            Console.WriteLine("canh b: " + this.b);
            Console.WriteLine("canh c: " + this.c);
            Console.WriteLine("Chu vi: " + this.tinhChuVi());
            Console.WriteLine("Dien tich: " + this.tinhDienTich());
        }


    }
}
