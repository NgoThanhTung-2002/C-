using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class TAMGIAC:HINH
    {
        private int a, b, c;
        protected int A
        {
            get { return a; }
            set { a = value; }
        }
        protected int B
        {
            get { return b; }
            set { b = value; }
        }
        protected int C
        {
            get { return c; }
            set { c = value; }
        }
        public TAMGIAC():base() { }
        public TAMGIAC(String tenhinh, int a, int b, int c) : base(tenhinh)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double tinhChuvi()
        {
            return this.a + this.b + this.c;
        }

        public double tinhDienTich()
        {
            double P = this.tinhChuvi() / 2;
            return Math.Sqrt(P * (P - this.a) * (P - this.b) * (P - this.c));
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap canh A: ");
            this.a = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap canh B: ");
            this.b = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap canh C: ");
            this.c = Int32.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Canh A: " + this.a);
            Console.WriteLine("Canh B: " + this.b);
            Console.WriteLine("Canh C: " + this.c);
            Console.WriteLine("Chu vi: " + this.tinhChuvi();
            Console.WriteLine("Dien tich: " + this.tinhDienTich();

        }
    }

}
