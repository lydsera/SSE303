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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Library1021
{
    public partial class Frm_Borrow : Form
    {
        public Frm_Borrow()
        {
            InitializeComponent();
        }
        public string rid;
        public string mid;
        public int bnum;
        public int bday;
        string selected_isbn;
        int selected_num;
        private void Frm_Borrow_Load(object sender, EventArgs e)
        {
            lbl_rid.Text = "读者ID："+rid;
            lbl_bnum.Text = "可借书数："+bnum.ToString();
            lbl_bday.Text = "可借天数："+bday.ToString();
            DataBind_Press();
            DataBind_Book();
            DataBind_Reader();
        }
        protected void ClearTexBox()
        {
            selected_isbn = "";
            selected_num = 0;
            txt_isbn.Text = "";

            txt_bname.Text = "";
            
            txt_writer.Text = "";
        }
        protected void DataBind_Reader()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select curbnum from reader_info where rid="+rid;
            //Console.WriteLine("here");
            //Console.WriteLine(rid);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow dr = dt.Rows[0];
            lbl_borrowed1.Text = dr["curbnum"].ToString();
        }
        DataTable press_dt = new DataTable();
        protected void DataBind_Press()
        {

            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select pid,pname from press_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);

            da.Fill(press_dt);
            conn.Close();
            
        }
        protected void DataBind_Book()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            //先查出馆藏数目，用map存放
            string str1 = "select isbn,count(isbn) as '在架数目' from book_info where bcondition=0 group by isbn";//0表示在架上
            string str2 = "select isbn,count(isbn) as '外借数目' from book_info where bcondition=1 group by isbn";
            Dictionary<string, string> onnum = new Dictionary<string, string>();//用map存放
            Dictionary<string, string> outnum = new Dictionary<string, string>();
            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(str2, conn);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            da1.Fill(dt1);
            da2.Fill(dt2);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                onnum.Add(dt1.Rows[i]["isbn"].ToString(), dt1.Rows[i]["在架数目"].ToString());

            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                outnum.Add(dt2.Rows[i]["isbn"].ToString(), dt2.Rows[i]["外借数目"].ToString());

            }
            //在查图书信息
            string str = "select * from book_basicInfo";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Book.Items.Clear();//先清空列表视图控件中现有行

            foreach (DataRow dr in dt.Rows)
            {
                string isbn = dr["ISBN"].ToString();
                ListViewItem myitem = new ListViewItem(isbn);//创建一个ListViewItem项，并为第1列赋值
                myitem.SubItems.Add(dr["bname"].ToString());
                //Console.WriteLine("here");
                //Console.WriteLine(press_dt.Columns[1].ColumnName);
                DataRow[] drs = press_dt.Select("pid = " + dr["pid"].ToString());
                //Console.WriteLine(drs[0]["pname"].ToString());
                myitem.SubItems.Add(drs[0]["pname"].ToString());
                myitem.SubItems.Add(dr["writer"].ToString());
                myitem.SubItems.Add(dr["version"].ToString());
                myitem.SubItems.Add(Convert.ToDateTime(dr["pubdate"].ToString()).ToShortDateString());
                myitem.SubItems.Add(dr["price"].ToString());
                myitem.SubItems.Add(dr["intro"].ToString());
                if (onnum.ContainsKey(isbn)) myitem.SubItems.Add(onnum[isbn]);
                else myitem.SubItems.Add("0");
                if (outnum.ContainsKey(isbn)) myitem.SubItems.Add(outnum[isbn]);
                else myitem.SubItems.Add("0");
                lv_Book.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }

        private void Frm_Borrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lv_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Book.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Book.SelectedItems[0];
                
                selected_isbn = item.SubItems[0].Text;
                //Console.WriteLine("here");
                //Console.WriteLine(item.SubItems[8].Text);
                selected_num = Convert.ToInt32(item.SubItems[8].Text); 
                
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            DataBind_Book();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            if(selected_isbn=="")
            {
                MessageBox.Show("请先选择要借阅的图书!");
            }
            else if(lbl_borrowed1.Text==bnum.ToString())
            {
                MessageBox.Show("借阅数目已达上限!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要借阅选中的图书？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(selected_num<=0)
                    {
                        MessageBox.Show("此书已全被占用，暂无法借阅!");
                    }
                    else
                    {
                        MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                        conn.Open();
                        string str = String.Format("select bid from book_info where isbn = '{0}' and bcondition = 0",selected_isbn);
                        MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        conn.Close();
                        DataRow dr = dt.Rows[0];
                        string selected_bid = dr["bid"].ToString();

                        string s1 = String.Format("insert into book_borrow" +
                        " values(null," +
                        "{0},{1},{2},'{3}','{4}',{5},{6})",
                        selected_bid, rid, mid, DateTime.Now, DateTime.Now.AddDays(bday), 0, 0);
                        string s2 = String.Format("update book_info set bcondition=1 where bid={0}",selected_bid);
                        string s3 = String.Format("update reader_info " +
                            "set CurBNum=(select count(bid) as cnt " +
                            "from book_borrow " +
                            "where isreturn=0 and rid={0}) " +
                            "where rid={0}", rid);
                        List<string> tmp = new List<string>();
                        tmp.Add(s1);
                        tmp.Add(s2);
                        tmp.Add(s3);
                        if(ExcuteTransactionSQL(tmp))
                        {
                            MessageBox.Show("借阅成功!");
                            ClearTexBox();
                            DataBind_Book();
                            DataBind_Reader();
                        }
                        else
                        {
                            MessageBox.Show("借阅失败!");
                        }
                    }
                    
                }


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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Condition = "where 1=1 ";
            if(txt_isbn.Text.Trim().Length > 0)
            {
                string str = txt_isbn.Text;
                Condition += " and isbn like '%"+str+"%'";
            }
            if (txt_bname.Text.Trim().Length > 0)
            {
                string str = txt_bname.Text;
                Condition += " and bname like '%" + str + "%'";
            }
            if (txt_writer.Text.Trim().Length > 0)
            {
                string str = txt_writer.Text;
                Condition += " and writer like '%" + str + "%'";
            }
            string selectStr = "select * from book_basicinfo " + Condition;
            DataBind_Book1(selectStr);
        }
        protected void DataBind_Book1(string selectStr)
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            //先查出馆藏数目，用map存放
            string str1 = "select isbn,count(isbn) as '在架数目' from book_info where bcondition=0 group by isbn";//0表示在架上
            string str2 = "select isbn,count(isbn) as '外借数目' from book_info where bcondition=1 group by isbn";
            Dictionary<string, string> onnum = new Dictionary<string, string>();//用map存放
            Dictionary<string, string> outnum = new Dictionary<string, string>();
            MySqlDataAdapter da1 = new MySqlDataAdapter(str1, conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(str2, conn);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            da1.Fill(dt1);
            da2.Fill(dt2);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                onnum.Add(dt1.Rows[i]["isbn"].ToString(), dt1.Rows[i]["在架数目"].ToString());

            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                outnum.Add(dt2.Rows[i]["isbn"].ToString(), dt2.Rows[i]["外借数目"].ToString());

            }
            //在查图书信息
            
            MySqlDataAdapter da = new MySqlDataAdapter(selectStr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Book.Items.Clear();//先清空列表视图控件中现有行

            foreach (DataRow dr in dt.Rows)
            {
                string isbn = dr["ISBN"].ToString();
                ListViewItem myitem = new ListViewItem(isbn);//创建一个ListViewItem项，并为第1列赋值
                myitem.SubItems.Add(dr["bname"].ToString());
                //Console.WriteLine("here");
                //Console.WriteLine(press_dt.Columns[1].ColumnName);
                DataRow[] drs = press_dt.Select("pid = " + dr["pid"].ToString());
                //Console.WriteLine(drs[0]["pname"].ToString());
                myitem.SubItems.Add(drs[0]["pname"].ToString());
                myitem.SubItems.Add(dr["writer"].ToString());
                myitem.SubItems.Add(dr["version"].ToString());
                myitem.SubItems.Add(Convert.ToDateTime(dr["pubdate"].ToString()).ToShortDateString());
                myitem.SubItems.Add(dr["price"].ToString());
                myitem.SubItems.Add(dr["intro"].ToString());
                if (onnum.ContainsKey(isbn)) myitem.SubItems.Add(onnum[isbn]);
                else myitem.SubItems.Add("0");
                if (outnum.ContainsKey(isbn)) myitem.SubItems.Add(outnum[isbn]);
                else myitem.SubItems.Add("0");
                lv_Book.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }
    }
}
