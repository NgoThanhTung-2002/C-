using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class CHUNHAT:HINH
    {
        private int a, b;
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
        public CHUNHAT() : base()
        { }
        public CHUNHAT(String tenhinh, int a, int b) : base(tenhinh)
        {
            this.a = a;
            this.b = b;

        }
        public int tinhChuvi()
        {
            return 2 * (this.a + this.b);
        }
        public int tinhDienTich()
        {
            return (this.a * this.b);
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Canh a:");
            this.a = Int32.Parse(Console.ReadLine());
            Console.Write("Canh b:");
            this.b = Int32.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Canh a:" + this.a);
            Console.WriteLine("Canh b:" + this.b);
            Console.WriteLine("Chu vi:" + this.tinhChuvi());
            Console.WriteLine("Dien tich:" + this.tinhDienTich());
        }

    }
}
