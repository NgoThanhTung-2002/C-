using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class Tron:HINH
    {
        private double r;

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public Tron() : base()
        {

        }

        public Tron(String tenhinh, double r) : base(tenhinh){
            this.r = r;
        }

        public double TinhChuVi()
        {
            return 2 * this.r * Math.PI;
        }

        public double TinhDienTich()
        {
            return Math.Pow(r,2) * Math.PI;
        }


        public void NhapHinhTron()
        {
            Console.WriteLine("Nhap ban kinh r: ");
            this.r = double.Parse(Console.ReadLine());

        }


        public void XuatHinhTron()
        {
            Console.WriteLine("Ban kinh r: " + this.r);
            Console.WriteLine("Chu vi: " + this.TinhChuVi());
            Console.WriteLine("Dien tich: " + this.TinhDienTich());
        }

    }
}
