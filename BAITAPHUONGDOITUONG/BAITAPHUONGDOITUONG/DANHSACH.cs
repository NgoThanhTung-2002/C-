using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPHUONGDOITUONG
{
    class DANHSACH
    {
        List<HINH> list;
        public DANHSACH()
        {
            this.list = new List<HINH>();
        }
        public void Nhap()
        {
            char c = ' ';
            Console.Write("Nhap cac ky tu dai dien cho ten hinh tam giac(t), hinh tron (c), chu nhat (r)):");
            c = Convert.ToChar(Console.ReadLine().ToLower());
            while (c == 't' || c == 'r' || c == 'c')
            {
                HINH hinh = null;
                switch (c)
                {
                    case 't':
                        {
                            hinh = new TAMGIAC();
                            break;
                        }

                    case 'r':
                        {
                            hinh = new CHUNHAT();
                            break;
                        }
                    case 'c':
                        {
                            hinh = new TRON();
                            break;
                        }
                }
                hinh.Nhap();
                list.Add(hinh);
                Console.Write("Nhap cac ky tu dai dien cho ten hinh tam giac(t), hinh tron (c), chu nhat (r)):");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
        public void Xuat()
        {
            foreach (HINH hinh in list)
                hinh.Xuat();
        }
    }
}
