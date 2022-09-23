using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class TRON:HINH
    {
        private double r;
        public double R

        {
            get { return r; }
            set { r = value; }
        }
        public TRON() : base() { }
        public TRON(String tenhinh, double r) : base(tenhinh)
        {
            this.r = r;
        }
        public double tinhChuVi()
        {
            return (this.r * 2) * Math.PI;
        }
        public double tinhDienTich()
        {
            return (this.r * this.r) * Math.PI;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap r:");
            this.r = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ban kinh r:" + this.r);
            Console.WriteLine("Chu vi:" + this.tinhChuVi());
            Console.WriteLine("Dien tich:" + this.tinhDienTich());
        }
    }
}
