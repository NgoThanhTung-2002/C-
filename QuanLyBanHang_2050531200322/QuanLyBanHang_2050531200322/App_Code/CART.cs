using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang_2050531200322.App_Code
{
    public class CART
    {
        Dictionary<string, Item> listcarts;
        public CART() {
            Listcarts = new Dictionary<string, Item>();
        }

        public Dictionary<string, Item> Listcarts { get => listcarts; set => listcarts = value; }

        public void Add(String idmon, string tenmon, double dongia, int soluong, string hinhanh)
        {
            Item item = new Item(idmon, tenmon, dongia, soluong, hinhanh);

            if (Listcarts.ContainsKey(item.Idmon))
            {
                Listcarts[item.Idmon].Soluong = item.Soluong;
            }
            Listcarts.Add(item.Idmon, item);
        }
        public void RemoveCart(String idmon)
        {
            Listcarts.Remove(idmon);
        }

        public double TotalBill()
        {
            double total = 0;
            foreach (Item item in Listcarts.Values)
                total += item.Soluong * item.Dongia;
            return total;
        }
    }
}