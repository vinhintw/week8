using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WD3_銘傳二手專賣店
{
    public partial class _Default : Page
    {
        SqlConnection X;
        SqlCommand C;
        SqlDataReader R;
        string S;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            X = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\WD3~銘傳二手專賣店\WD3~銘傳二手專賣店\App_Data\mcu.mdf;Integrated Security=True");
            try
            {
                X.Open();
                Label1.Text = "速通成功!!";
                S = "";
                switch (DropDownList1.SelectedIndex)
                {
                    case 0: S = "select * from [table] where 1=1"; break;
                    case 1: S = "select * from [table] where 品名編號='A1'"; break;
                    case 2: S = "select * from [table] where 品名編號='A2'"; break;
                    case 3: S = "select * from [table] where 品名編號='B1'"; break;
                    case 4: S = "select * from [table] where 品名編號='B2'"; break;
                }
                string temp = "";
                switch (DropDownList2.SelectedIndex)
                {
                    case 0: temp = "AND (1=1)";break;
                    case 1: temp = "AND (價格 <= 500)"; break;
                    case 2: temp = "AND (價格 <= 5000)"; break;
                    case 3: temp = "AND (價格 <= 50000)"; break;
                }
                S = S + temp;
                switch (DropDownList3.SelectedIndex)
                {
                    case 0: temp = "AND (1=1)"; break;
                    case 1: temp = "AND (價格 >= 0)"; break;
                    case 2: temp = "AND (價格 >= 500)"; break;
                    case 3: temp = "AND (價格 >= 5000)"; break;
                }
                S = S + temp;
                Label2.Text = "SQL語言=" + S;
                C = new SqlCommand(S, X);
                C.ExecuteNonQuery();
                TextBox1.Text = "上架貨品";
                R = C.ExecuteReader();
                while (R.Read() == true)
                {
                    TextBox1.Text = TextBox1.Text + "\r\n" + R["貨品編號"] + " " + R["品名"] + " " + R["價格"] + "元";
                }
                X.Close();
            }
            catch (Exception)
            { Label1.Text = "連通失敗"; }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}