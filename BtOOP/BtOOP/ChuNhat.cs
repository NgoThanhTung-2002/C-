using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class ChuNhat:HINH
    {
        private int a;
        private int b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public ChuNhat() : base()
        {

        }

        public ChuNhat(String tenhinh, int a, int b) : base(tenhinh)
        {
            this.a = a;
            this.b = b;
        }

        public double TinhChuVi()
        {
            return (this.a + this.b) * 2;
        }

        public double TinhDienTich()
        {
            return this.a * this.b;
        }


        public void NhapHinhChuNhat()
        {
            Console.WriteLine("Nhap chieu dai a: ");
            this.a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong b: ");
            this.b = Int32.Parse(Console.ReadLine());
        }


        public void XuatHinhChuNhat()
        {
            Console.WriteLine("Chieu dai a: " + this.a);
            Console.WriteLine("Chieu rong b: " + this.b);
            Console.WriteLine("Chu vi: " + this.TinhChuVi());
            Console.WriteLine("Dien tich: " + this.TinhDienTich());
        }

    }
}
