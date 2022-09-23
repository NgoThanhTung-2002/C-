using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class HINH
    {
        private String tenhinh;
        protected String Tenhinh
        {
            get { return tenhinh; }
            set { tenhinh = value; }
        }

        public HINH() { }

        public HINH(String tenhinh)
        {
            this.tenhinh = tenhinh;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten hinh: ");
            this.tenhinh = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write("Nhap ten hinh: " + this.tenhinh);
        }
            

    }
}
