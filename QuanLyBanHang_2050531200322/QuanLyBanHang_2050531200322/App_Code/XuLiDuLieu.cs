using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyBanHang_2050531200322.App_Code
{
    public class XuLiDuLieu
    {
        SqlConnection conn;
        public XuLiDuLieu()
        {
            conn = new SqlConnection();
            // LUU Y 1 connect
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\QuanLyBanHang_2050531200322\QuanLyBanHang_2050531200322\App_Data\dbQuanLyNhaHang.mdf;Integrated Security=True";
        }

        public void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public DataTable getTable(String SQL)
        {
            MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, conn);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public DataTable getTable(String nameprocedurce, SqlParameter[] pr)
        {
            MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            DongKetNoi();
            return tb;
        }

        public void getDataSet(ref DataSet ds, String SQL)
        {
            ds.Tables.Add(this.getTable(SQL));
        }
        public void getDataSet(ref DataSet ds, String nameprocedurce, SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedurce, pr));
        }
        public int ExeCute(string SQL)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, this.conn);
            this.DongKetNoi();
            return (int)cmd.ExecuteNonQuery();
        }
        public int ExeCute(String nameprocedurce, SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            this.DongKetNoi();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            DongKetNoi();
            MoKetNoi();
            return (int)cmd.ExecuteNonQuery();

         
        } 
    }
}