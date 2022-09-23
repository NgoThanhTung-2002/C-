using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class HINH
    {
        private String tenhinh;
        protected String TenHinh
        {
            get { return tenhinh; }
            set { tenhinh = value; }
        }

        public HINH()
        {

        }

        public HINH(String tenhinh)
        {
            this.tenhinh = tenhinh;
        }

        public void NhapHinh()
        {
            Console.Write("Nhap ten hinh:");
            this.tenhinh = Console.ReadLine();
        }
        public void XuatHinh()
        {
            Console.Write("Nhap ten hinh:" + this.tenhinh); 
        }
    }
}
