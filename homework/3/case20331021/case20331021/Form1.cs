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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace case20331021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        protected void DataBind_Customer()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;database=DB_20331021;Integrated Security=SSPI");
            conn.Open();
            string str = "select * from Customer_Info";
            SqlDataAdapter da = new SqlDataAdapter(str,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();//先清空列表视图控件中现有行
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["CustomerID"].ToString());//创建一个ListViewItem项，并为第1列赋值，客户编号
                myitem.SubItems.Add(dr["CustomerName"].ToString());//第二列，姓名
                myitem.SubItems.Add(dr["Company"].ToString());//第三列，单位
                myitem.SubItems.Add(dr["Sex"].ToString());//第四列，性别
                myitem.SubItems.Add(dr["Age"].ToString());//第五列，年龄
                myitem.SubItems.Add(dr["Telephone"].ToString());//第六列，电话
                myitem.SubItems.Add(dr["Address"].ToString());//第七列，地址
                lv_Customer.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataBind_Customer();//加载客户信息
        }

        private void lbl_Note_Click(object sender, EventArgs e)
        {

        }
        //保存按钮
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();//姓名
            string company = txt_Company.Text.Trim();//公司
            string sex = rbtn_Sex1.Checked == true ? "男" : "女";//性别
            string age = nudown_Age.Value.ToString();//年龄
            string telephone = txt_Telephone.Text.Trim();//电话
            string address = txt_Address.Text.Trim();//地址
            if(name=="")//姓名为空
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if(lbl_Status.Text=="添加")//如果是“添加”状态
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost;database=DB_20331021;Integrated Security=SSPI");
                conn.Open();
                string str = string.Format("insert into Customer_Info values('{0}','{1}','{2}','{3}','{4}','{5}')", name, company, sex, age, telephone, address);
                SqlCommand cmd = new SqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i>0)
                {
                    lbl_Note.Text = "恭喜您，客户信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox();//调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息添加失败！";
                    lbl_Note.ForeColor= Color.Red;
                }
            }
            else //修改操作
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost;database=DB_20331021;Integrated Security = SSPI");
                conn.Open();
                string str = string.Format("update Customer_Info set CustomerName = '{0}', Company = '{1}', Sex = '{2}', Age ='{3}',Telephone = '{4}',Address = '{5}' where CustomerID = {6}", name, company, sex, age, telephone, address, customerid);
                SqlCommand cmd = new SqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }

        }
        protected void ClearTexBox()
        {
            txt_Name.Text = "";
            customerid = "";
            txt_Company.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            rbtn_Sex1.Checked = true;
            nudown_Age.Value = 0;
            lbl_Status.Text = "添加";
        }
        string customerid = "";//定义全局变量，用于存储客户编号
        //客户信息选中项改变事件
        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_Customer.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];//获取选中的第一行（一次只能选一行）
                customerid = myitem.SubItems[0].Text;//将选中的第一列的值赋值全局变量，客户编号
                txt_Name.Text = myitem.SubItems[1].Text; //第 2 列，姓名
                txt_Company.Text = myitem.SubItems[2].Text; //单位
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "男" ? true : false; //性别
                rbtn_Sex2.Checked = myitem.SubItems[3].Text == "女" ? true : false; //性别
                nudown_Age.Value = decimal.Parse(myitem.SubItems[4].Text); //年龄
                txt_Telephone.Text = myitem.SubItems[5].Text; //电话
                txt_Address.Text = myitem.SubItems[6].Text; //地址
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (customerid == "") //如果没有选中要删除的客户信息
            {
                MessageBox.Show("请先选择要删除的客户信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的客户信息？ ", "删除提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //如果确定删除
                {
                    SqlConnection conn = new SqlConnection("Data Source=localhost;database=DB_20331021; Integrated Security = SSPI");
                    conn.Open();


                    string str = string.Format("delete from Customer_Info where CustomerID ={0} ",customerid);




                    SqlCommand cmd = new SqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，客户信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTexBox(); //调用函数，清空各控件
                        DataBind_Customer(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，客户信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        //“取消”按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox(); //调用函数，清空各控件
            lbl_Note.Text = "";
        }
    }
}
