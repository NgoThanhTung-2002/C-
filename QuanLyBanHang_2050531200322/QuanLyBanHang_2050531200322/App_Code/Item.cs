using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang_2050531200322.App_Code
{
    public class Item
    {
        // LUU Y 2 chinh lai theo data mo xoa me cai dong vi tinh di ong ko biet dau
        private String idmon; // ID MON
        private String tenmon; // TEN MON
        private double dongia;
        private int soluong;
        private String hinhanh;
        public double THANHTIEN
        {
            get { return this.soluong * this.dongia; }
        }
        public Item(string idmon, string tenmon, double dongia, int soluong, string hinhanh)
        {
            this.idmon = idmon;
            this.tenmon = tenmon;
            this.Dongia = dongia;
            this.Soluong = soluong;
            this.Hinhanh = hinhanh;
        }

        public string Idmon { get => idmon; set => idmon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public Item()
        {
        }

    }
}