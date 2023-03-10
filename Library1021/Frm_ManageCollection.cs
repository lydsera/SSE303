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
    public partial class Frm_ManageCollection : Form
    {
        public Frm_ManageCollection()
        {
            InitializeComponent();
        }

        private void Frm_ManageCollection_Load(object sender, EventArgs e)
        {
            
            DataBind_Collection();
            DataBind_ISBN();
            ClearTexBox();
        }
        string selected_bid = "";
        string selected_bcondition = "";
        protected void ClearTexBox()
        {
            txt_bid.Text = "";
            lbl_Status.Text = "添加";
            selected_bid = "";
            selected_bcondition = "";
            cbBox_isbn.SelectedIndex = 0;
            rbtn_on.Checked = true;
            lbl_Status.Text = "添加";
            dateTime_ware.Value = DateTime.Now;
        }
        protected void DataBind_ISBN()
        {

            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select isbn from book_basicinfo";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbBox_isbn.DataSource = dt;
            cbBox_isbn.DisplayMember = "isbn";
            cbBox_isbn.ValueMember = "isbn";

        }
        protected void DataBind_Collection()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select * from book_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Collection.Items.Clear();//先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                
                ListViewItem myitem = new ListViewItem(dr["bid"].ToString());//创建一个ListViewItem项，并为第1列赋值
                myitem.SubItems.Add(dr["isbn"].ToString());
                //Console.WriteLine(dr["bcondition"]);
                myitem.SubItems.Add(dr["bcondition"].ToString() == "False" ? "在架" : "外借");//0为在架，1为外借
                myitem.SubItems.Add(dr["waretime"].ToString());
                


                lv_Collection.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Frm_ManageCollection_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lv_Collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Collection.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Collection.SelectedItems[0];
                selected_bid = item.SubItems[0].Text;
                txt_bid.Text = selected_bid;
                cbBox_isbn.Text = item.SubItems[1].Text;
                selected_bcondition = item.SubItems[2].Text;
                rbtn_on.Checked = item.SubItems[2].Text=="在架"?true:false;
                rbtn_out.Checked = item.SubItems[2].Text == "外借" ? true : false;
                dateTime_ware.Value = DateTime.Parse(item.SubItems[3].Text);
                lbl_Status.Text = "修改";
                
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lbl_note.Text = "";
        }
        //未测试
        private void btn_Save_Click(object sender, EventArgs e)
        {

            string bcondition = rbtn_on.Checked == true ? "0" : "1";//在架上为0，外借了为1

            string isbn = cbBox_isbn.SelectedValue.ToString();//ISBN
            string waretime = dateTime_ware.Value.ToString(); //入库时间
            
            if (isbn == "")
            {
                lbl_note.Text = "ISBN不能为空!";
                lbl_note.ForeColor = Color.Red;
                cbBox_isbn.Focus();
            }
            //isbn不超18？？？？？？？
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = String.Format("insert into book_info" +
                    " values(null," +
                    "'{0}',{1},'{2}')",
                    isbn, bcondition, waretime);
                //Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，馆藏信息添加成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Collection();
                }
                else
                {
                    lbl_note.Text = "对不起，馆藏信息添加失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
            else if (lbl_Status.Text == "修改")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = string.Format("update book_Info set " +
                    "isbn = '{0}',bcondition = {1}, " +
                    "waretime = '{2}'" +
                    "where bid = {3}",
                    isbn, bcondition, waretime, selected_bid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，馆藏信息修改成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Collection();
                }
                else
                {
                    lbl_note.Text = "对不起，馆藏信息修改失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (selected_bid == "")
            {
                MessageBox.Show("请先选择要删除的馆藏信息!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的馆藏信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (selected_bcondition == "外借")
                    {
                        MessageBox.Show("该书已被外借，不得删除！");
                    }
                    else
                    {
                         MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                        conn.Open();
                        String str = String.Format("delete from book_Info where bid={0}", selected_bid);
                        MySqlCommand cmd = new MySqlCommand(str, conn);
                        try
                        {
                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i > 0)
                            {
                                lbl_note.Text = "恭喜您，馆藏信息删除成功！";
                                lbl_note.ForeColor = Color.Blue;
                                ClearTexBox();
                                DataBind_Collection();
                            }
                            else
                            {
                                lbl_note.Text = "对不起，馆藏信息删除失败！";
                                lbl_note.ForeColor = Color.Red;
                            }
                        }
                        catch(MySqlException)
                        {
                            MessageBox.Show("馆藏信息已被占用，暂时无法删除！");
                        }
                        
                    }
                    
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
