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
    public partial class FrmDoanhSo : Form
    {
        public FrmDoanhSo()
        {
            InitializeComponent();
            
        }
        public void HamNam(int nam)
        {
            string lenh = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(lenh);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from dbo.DoanhSoNam(@nam)";
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            da.SelectCommand = cmd;
            da.Fill(dt);

            chartControl1.DataSource = dt;

            chartControl1.Series["Kinh Phí"].ArgumentDataMember = "Thang";
            chartControl1.Series["Kinh Phí"].ValueDataMembers.AddRange(new string[] { "KinhPhi" });

            chartControl1.Series["Dự Án"].ArgumentDataMember = "Thang";
            chartControl1.Series["Dự Án"].ValueDataMembers.AddRange(new string[] { "SoDuAn" });

            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }
        public void HamKhoang(DateTime d1, DateTime d2)
        {
            string lenh = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(lenh);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from dbo.DoanhSoKhoang(@n1, @n2)";
            cmd.Parameters.Add("@n1", SqlDbType.Date).Value = d1;
            cmd.Parameters.Add("@n2", SqlDbType.Date).Value = d2;
            da.SelectCommand = cmd;
            da.Fill(dt);

            chartControl1.DataSource = dt;

            chartControl1.Series["Kinh Phí"].ArgumentDataMember = "Thang";
            chartControl1.Series["Kinh Phí"].ValueDataMembers.AddRange(new string[] { "KinhPhi" });

            chartControl1.Series["Dự Án"].ArgumentDataMember = "Thang";
            chartControl1.Series["Dự Án"].ValueDataMembers.AddRange(new string[] { "SoDuAn" });

            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }
    }
}
