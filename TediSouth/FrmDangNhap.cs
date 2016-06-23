using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TediSouth
{
    public partial class FrmDangNhap : Form
    {
        public static string IDNhanVien;

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void click_DangNhap(object sender, EventArgs e)
        {
  
            if (tbTaiKhoan.Text == "" || tbMatKhau.Text == "")
            {
                this.lbLoiDangNhap.ForeColor = Color.Red;
                this.lbLoiDangNhap.Text = "Bạn chưa nhập tên hoặc mật khẩu! Vui lòng thử lại";
            }
            else
            {
                string username = ConfigurationManager.AppSettings["username"];
                string password = ConfigurationManager.AppSettings["password"];
                string lenh = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                if (tbTaiKhoan.Text.Trim() == username && tbMatKhau.Text == password)
                {
                    MessageBox.Show("Bạn đang là Admin", "Thông Báo");
                    QuanLyDuAn m = (QuanLyDuAn)this.MdiParent;
                    IDNhanVien = "admin";
                    m.Sender(IDNhanVien);
                    m.Admin();
                    this.Close();
                }
                else
                {
                    //lbLoiDangNhap.Text = "Sai mật khẩu vui lòng nhập lại.";
                    //tbTaiKhoan.Clear();
                    //tbMatKhau.Clear();

                    SqlConnection con = new SqlConnection(lenh);
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt2 = new DataTable();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "select * from dbo.CheckName(@name)";
                    cmd2.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = tbTaiKhoan.Text;
                    da.SelectCommand = cmd2;
                    da.Fill(dt2);
                    if (dt2.Rows.Count == 0)
                    {
                        lbLoiDangNhap.Text = "Tài Khoản không tồn tại.";
                        tbTaiKhoan.Clear();
                        tbMatKhau.Clear();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "select * from dbo.CheckTaiKhoan(@name,@pass)";
                        cmd.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = tbTaiKhoan.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar, 30).Value = tbMatKhau.Text;
                        da.SelectCommand = cmd;
                        da.Fill(dt);

                        if (dt.Rows.Count >= 1)
                        {
                            IDNhanVien = dt.Rows[0][2].ToString();
                            QuanLyDuAn m = (QuanLyDuAn)this.MdiParent;
                            m.Sender(IDNhanVien);
                            m.GiamDoc();
                            this.Close();
                        }
                        else
                        {
                            lbLoiDangNhap.Text = "Sai mật khẩu vui lòng nhập lại.";
                            tbTaiKhoan.Clear();
                            tbMatKhau.Clear();
                        }
                    }
                }
            }
               
        }

        private void Click_Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
