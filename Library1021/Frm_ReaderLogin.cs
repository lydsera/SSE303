using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1021
{
    public partial class Frm_ReaderLogin : Form
    {
        public Frm_ReaderLogin()
        {
            InitializeComponent();
        }
        public string mid;
        private void Frm_ReaderLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        int bnum;
        int bday;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_rid.Text=="")
            {
                MessageBox.Show("请输入读者ID！");
                txt_rid.Focus();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = string.Format("select * from reader_info where rid={0} ", txt_rid.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)//如果查询结果不为空
                {
                    if(DateTime.Compare(Convert.ToDateTime(dt.Rows[0]["valdate"]), DateTime.Now) < 0) MessageBox.Show("对不起，该读者已过有效期！");
                    else if(dt.Rows[0]["islost"].ToString()=="True") MessageBox.Show("对不起，该读者账号已挂失！");
                    else
                    {
                        this.Hide();//隐藏登陆窗体（因为是程序启动窗体，此时不能关闭）

                        Frm_ReaderSelect frm = new Frm_ReaderSelect();//实例化窗体
                        NumAndDay(dt.Rows[0]["rtid"].ToString());
                        frm.bday = bday;
                        frm.bnum = bnum;
                        frm.rid = txt_rid.Text;
                        frm.mid = this.mid;
                        txt_rid.Text = "";
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                    }

                    
                }
                else
                {
                    MessageBox.Show("对不起，读者ID不正确！");
                }
            }
        }
        void NumAndDay(string rtid)
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = string.Format("select * from reader_type where rtid={0} ", rtid);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bnum = Convert.ToInt32(dt.Rows[0]["bnum"]);
            bday = Convert.ToInt32(dt.Rows[0]["bday"]);
        }
        private void Frm_ReaderLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
