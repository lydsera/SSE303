using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1021
{
    public partial class Frm_ManageBook : Form
    {
        public Frm_ManageBook()
        {
            InitializeComponent();
        }
        protected void ClearTexBox()
        {
            lbl_Status.Text = "添加";
            txt_isbn.Text = "";
            txt_isbn.Enabled = true;
            selected_isbn = "";
            txt_bookname.Text = "";
            cbBox_press.SelectedIndex = 0;
            txt_writer.Text = "";
            txt_version.Text = "";
            txt_onnum.Text = "";
            txt_outnum.Text = "";
            txt_price.Text = "";
            txt_intro.Text = "";
            dateTime_pub.Value = DateTime.Now;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string isbn = txt_isbn.Text.Trim();
            string bname = txt_bookname.Text.Trim();//书名
            string press = cbBox_press.Text.Trim();//出版社
            string writer = txt_writer.Text.Trim();//作者
            string version = txt_version.Text.Trim();//版本
            string pubdate = dateTime_pub.Value.ToShortDateString();//出版日期
            string price = txt_price.Text.Trim();//价格
            //string onnum = txt_onnum.Text.Trim();//在架
            //string outnum = txt_outnum.Text.Trim();//外借
            string intro = txt_intro.Text.Trim();//简介
            //Console.WriteLine(press);
            DataRow[] drs = press_dt.Select("pname = '"+press+"'");
            //if(!(drs.Length > 0)) Console.WriteLine(drs.Length);
            string pid = drs[0]["pid"].ToString();
            //Console.WriteLine(redate);
            if (isbn == "")
            {
                lbl_note.Text = "ISBN不能为空!";
                lbl_note.ForeColor = Color.Red;
                txt_isbn.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = String.Format("insert into book_basicinfo" +
                    " values(" +
                    "'{0}',{1},'{2}','{3}',{4},'{5}',{6},'{7}')",
                    isbn, pid, bname, writer, version, pubdate, price, intro);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，图书信息添加成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Book();
                }
                else
                {
                    lbl_note.Text = "对不起，读者信息添加失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
            else if (lbl_Status.Text == "修改")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = string.Format("update book_basicinfo set " +
                    "pid = {1}, " +
                    "bname = '{2}', writer ='{3}',version = {4}," +
                    "pubdate = '{5}',price={6},intro='{7}'" +
                    " where isbn = {0}",
                    isbn, pid, bname, writer, version, pubdate, price, intro);
                //Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，图书信息修改成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Book();
                }
                else
                {
                    lbl_note.Text = "对不起，图书信息修改失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
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
            cbBox_press.DataSource = press_dt;
            cbBox_press.DisplayMember = "pname";
            cbBox_press.ValueMember = "pid";
            //Console.WriteLine("here");
            //Console.WriteLine(press_dt.Columns[0].DataType);
            //Console.WriteLine(press_dt.Columns[1].DataType);
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
            for(int i=0; i < dt1.Rows.Count; i++)
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
                DataRow[] drs = press_dt.Select("pid = "+dr["pid"].ToString());
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
        private void Frm_ManageBook_Load_1(object sender, EventArgs e)
        {
            DataBind_Press();
            DataBind_Book();
        }

        private void Frm_ManageBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lv_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Book.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Book.SelectedItems[0];
                txt_isbn.Text = item.SubItems[0].Text;
                selected_isbn = item.SubItems[0].Text;
                cbBox_press.Text = item.SubItems[2].Text;
                txt_bookname.Text = item.SubItems[1].Text;
                txt_writer.Text = item.SubItems[3].Text;
                txt_version.Text = item.SubItems[4].Text;
                dateTime_pub.Value = DateTime.Parse(item.SubItems[5].Text);
                txt_price.Text = item.SubItems[6].Text;
                txt_intro.Text = item.SubItems[7].Text;
                txt_onnum.Text = item.SubItems[8].Text;
                txt_outnum.Text = item.SubItems[9].Text;
                lbl_Status.Text = "修改";
                txt_isbn.Enabled = false;
                //txt_isbn.ReadOnly = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lbl_note.Text = "";
        }
        string selected_isbn="";
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (selected_isbn == "")
            {
                MessageBox.Show("请先选择要删除的图书信息!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的图书信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                    conn.Open();
                    String str = String.Format("delete from book_basicinfo where isbn={0}", selected_isbn);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i > 0)
                        {
                            lbl_note.Text = "恭喜您，图书信息删除成功！";
                            lbl_note.ForeColor = Color.Blue;
                            ClearTexBox();
                            DataBind_Book();
                        }
                        else
                        {
                            lbl_note.Text = "对不起，图书信息删除失败！";
                            lbl_note.ForeColor = Color.Red;
                        }
                    }
                    catch (MySqlException)
                    {
                        lbl_note.Text = "该图书信息已被引用，无法删除！";
                        lbl_note.ForeColor = Color.Red;
                    }
                    
                }
            }
        }
    }
}
