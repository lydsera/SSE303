using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library1021
{
    public partial class Frm_Return : Form
    {
        public Frm_Return()
        {
            InitializeComponent();
        }
        public string rid;
        public string mid;
        public int bnum;
        public int bday;
        string selected_boid;
        string selected_bid;
        int selected_retimes;
        DateTime selected_should;
        private void Frm_Return_Load(object sender, EventArgs e)
        {
            lbl_rid.Text = "读者ID：" + rid;
            lbl_bnum.Text = "可借书数：" + bnum.ToString();
            lbl_bday.Text = "可借天数：" + bday.ToString();
            DataBind_Reader();
            DataBind_Borrow();
        }
        protected void DataBind_Reader()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select curbnum from reader_info where rid=" + rid;
            //Console.WriteLine("here");
            //Console.WriteLine(rid);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow dr = dt.Rows[0];
            lbl_borrowed1.Text = dr["curbnum"].ToString();
        }
        protected void DataBind_Borrow()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            
            //查借阅记录
            string str = "select * from book_borrow where rid="+rid+" and isreturn=0";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            lv_Borrow.Items.Clear();//先清空列表视图控件中现有行

            foreach (DataRow dr in dt.Rows)
            {
                
                ListViewItem myitem = new ListViewItem(dr["boid"].ToString());//创建一个ListViewItem项，并为第1列赋值
                string bid = dr["bid"].ToString();
                myitem.SubItems.Add(bid);
                string tmpstr = "select isbn from book_info where bid=" + bid;
                MySqlDataAdapter da1 = new MySqlDataAdapter(tmpstr, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string isbn = dt1.Rows[0]["isbn"].ToString();
                myitem.SubItems.Add(isbn);
                myitem.SubItems.Add(dr["mid"].ToString());
                myitem.SubItems.Add(dr["botime"].ToString());
                myitem.SubItems.Add(dr["shouldretime"].ToString());
                myitem.SubItems.Add(dr["renewtimes"].ToString());
                
                lv_Borrow.Items.Add(myitem);//将新建项添加到ListView控件中

            }
            conn.Close();
        }

        private void Frm_Return_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lv_Borrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Borrow.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Borrow.SelectedItems[0];

                selected_boid = item.SubItems[0].Text;
                selected_bid  = item.SubItems[1].Text;
                selected_retimes = Convert.ToInt32(item.SubItems[6].Text);
                selected_should = Convert.ToDateTime(item.SubItems[5].Text);
            }
        }

        public static bool ExcuteTransactionSQL(List<string> strSQL)
        {
            using (MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?"))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                try
                {
                    for (int n = 0; n < strSQL.Count; n++)
                    {
                        string strsql = strSQL[n];
                        //Console.WriteLine(strsql);
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //cmd.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    conn.Close();
                    return false;
                }
            }


        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (selected_boid == "")
            {
                MessageBox.Show("请先选择要归还的图书!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要归还选中的图书？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                    conn.Open();
                    string str = String.Format("select shouldretime from book_borrow where boid = {0}", selected_boid);
                    MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    DataRow dr = dt.Rows[0];
                    DateTime shouldretime = Convert.ToDateTime(dr["shouldretime"].ToString());

                    string s1 = "update book_borrow set isreturn=1 where boid="+selected_boid;
                    string s2 = String.Format("update book_info set bcondition=0 where bid={0}", selected_bid);
                    string s3 = String.Format("update reader_info " +
                        "set CurBNum=(select count(boid) as cnt " +
                        "from book_borrow " +
                        "where isreturn=0 and rid={0}) " +
                        "where rid={0}", rid);
                    string s7 = String.Format("update reader_info " +
                        "set totBNum=(select count(boid) as cnt " +
                        "from book_borrow " +
                        "where rid={0}) " +
                        "where rid={0}", rid);
                    string s4 = String.Format("insert into book_return values(null,{0},{1},{2},'{3}')", mid, selected_bid, rid, DateTime.Now);
                    List<string> tmp = new List<string>();
                    tmp.Add(s1);
                    tmp.Add(s2);
                    tmp.Add(s3);
                    tmp.Add(s4);
                    tmp.Add(s7);
                    TimeSpan ts = shouldretime - DateTime.Now;
                    int out_days = ts.Days;
                    out_days = -out_days;
                    string s5 = String.Format("insert into out_fine values(null,{0},{1},{2},{3},0,null,'超时{4}天')", selected_bid, rid, mid, 20 + 15 * out_days, out_days);//0表示还未交罚款
                    string s6 = String.Format("update reader_info " +
                        "set vioNum=(select count(fid) as cnt " +
                        "from out_fine " +
                        "where rid={0}) " +
                        "where rid={0}", rid);
                    if (DateTime.Compare(shouldretime, DateTime.Now) < 0) { tmp.Add(s5);tmp.Add(s6); }

                    if (ExcuteTransactionSQL(tmp))
                    {
                        if(DateTime.Compare(shouldretime, DateTime.Now) < 0) MessageBox.Show("超时归还，记得交罚款!");
                        else MessageBox.Show("归还成功!");
                        selected_bid = "";
                        selected_boid = "";
                        selected_retimes = 0;
                        selected_should = DateTime.Now;
                        DataBind_Borrow();
                        DataBind_Reader();
                        
                        
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("归还失败!");
                    }
                    

                }


            }
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            if(selected_boid=="") MessageBox.Show("请先选择要续借的图书!");
            else if(selected_retimes>=2) MessageBox.Show("续借次数已达上限!");
            else
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = String.Format("update book_borrow set shouldretime='{0}',renewtimes={2} where boid={1}",selected_should.AddDays(15),selected_boid,selected_retimes+1);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("续借成功!");
                    selected_bid = "";
                    selected_boid = "";
                    selected_retimes = 0;
                    selected_should=DateTime.Now;
                    DataBind_Borrow();
                }
                else
                {
                    MessageBox.Show("续借失败!");
                }
            }
            
        }
    }
}
