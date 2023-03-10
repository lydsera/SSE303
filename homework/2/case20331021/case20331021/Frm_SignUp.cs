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
namespace case20331021
{
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！");
                txt_UserName.Focus();//将焦点停留在“用户名”文本框

            }
            else if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                txt_Password.Focus();
            }
            else if (txt_RePassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入第二次密码！");
                txt_RePassword.Focus();
            }
            else if (txt_RePassword.Text.Trim()!= txt_Password.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致");
                txt_Password.Focus();
            }
            else
            {
                int sex = rbtn_Sex1.Checked == true ? 1 : 2;//性别
                
                MySqlConnection conn = new MySqlConnection("server=localhost;database=DB_20331021;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into User_Info values(NULL,'{0}','{1}',{2},{3})", txt_UserName.Text, txt_Password.Text, nudown_Age.Value.ToString(), sex);
                MySqlCommand cmd=new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                    MessageBox.Show("用户注册成功！");
                else
                    MessageBox.Show("用户注册失败！");
            }
        }
    }
}
