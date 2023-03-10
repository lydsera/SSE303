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
    public partial class Frm_Fine : Form
    {
        public Frm_Fine()
        {
            InitializeComponent();
        }
        public string rid;
        string selected_fid;
        string selected_fineprice;
        string selected_isfin;
        private void Frm_Fine_Load(object sender, EventArgs e)
        {
            lbl_rid.Text = "读者ID：" + rid;
            DataBind_Fine();
        }
        protected void DataBind_Fine()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();

            //查借阅记录
            string str = "select * from out_fine where rid=" + rid;//0表示未罚款
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Fine.Items.Clear();//先清空列表视图控件中现有行

            foreach (DataRow dr in dt.Rows)
            {

                ListViewItem myitem = new ListViewItem(dr["fid"].ToString());//创建一个ListViewItem项，并为第1列赋值
                
                myitem.SubItems.Add(dr["bid"].ToString());
                
                myitem.SubItems.Add(dr["mid"].ToString());
                myitem.SubItems.Add(dr["fineprice"].ToString());
                //Console.WriteLine(dr["isfin"].ToString());
                myitem.SubItems.Add(dr["isfin"].ToString() == "False"?"否":"是");
                myitem.SubItems.Add(dr["finetime"].ToString());
                myitem.SubItems.Add(dr["remark"].ToString());

                lv_Fine.Items.Add(myitem);//将新建项添加到ListView控件中

            }
            
        }

        private void Frm_Fine_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lv_Fine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Fine.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Fine.SelectedItems[0];

                selected_fid = item.SubItems[0].Text;
                selected_fineprice = item.SubItems[3].Text;
                selected_isfin = item.SubItems[4].Text;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if(selected_fid=="") MessageBox.Show("请先选择要交纳的罚款!");
            else if(selected_isfin=="是") MessageBox.Show("该罚款已交纳，不可重复提交!");
            else
            {
                DialogResult result = MessageBox.Show("确定要交纳罚款"+selected_fineprice+"元？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                    conn.Open();
                    string str = String.Format("update out_fine set isfin=1,finetime='{0}' where fid={1}",DateTime.Now,selected_fid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("交纳成功!");
                        selected_fid = "";
                        selected_fineprice = "";
                        selected_isfin = "";
                        DataBind_Fine();
                    }
                    else
                    {
                        MessageBox.Show("交纳失败!");
                    }
                }
            }
            
        }
    }
}
