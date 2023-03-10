using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Library1021
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_UserName.Text.Trim()=="")
            {
                MessageBox.Show("请输入账号！");
                txt_UserName.Focus();
            }
            else if(txt_Password.Text.Trim()=="")
            {
                MessageBox.Show("请输入密码！");
                txt_Password.Focus();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = string.Format("select * from manager_info where Account='{0}' and Password='{1}'", txt_UserName.Text, txt_Password.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)//如果查询结果不为空，说明用户名密码正确
                {
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    this.Hide();//隐藏登陆窗体（因为是程序启动窗体，此时不能关闭）

                    Frm_Main frm = new Frm_Main();//实例化项目主窗体
                    frm.mid = dt.Rows[0]["mid"].ToString();
                    //Console.WriteLine(frm.mid);
                    if(frm.ShowDialog()==DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("对不起，用户名或密码不正确！");
                }
            }
        }
    }
}
