using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1021
{
    public partial class Frm_ManagePress : Form
    {
        public Frm_ManagePress()
        {
            InitializeComponent();
        }

        private void Frm_ManagePress_Load(object sender, EventArgs e)
        {
            DataBind_Press();
        }
        protected void ClearTexBox()
        {
            lbl_Status.Text = "添加";
            txt_address.Text = "";
            txt_pname.Text = "";
            txt_phone.Text = "";
            txt_contact.Text = "";
        }
        protected void DataBind_Press()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select * from press_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Press.Items.Clear();//先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                //Console.WriteLine(dr["PName"]);
                //Console.WriteLine(dr["contact"]);
                //Console.WriteLine(dr["Phone"]);
                //Console.WriteLine(dr["address"]);
                ListViewItem myitem = new ListViewItem(dr["pid"].ToString());//创建一个ListViewItem项，并为第1列赋值
                myitem.SubItems.Add(dr["pname"].ToString());
                myitem.SubItems.Add(dr["contact"].ToString());
                myitem.SubItems.Add(dr["phone"].ToString());
                myitem.SubItems.Add(dr["address"].ToString());
                
                
                lv_Press.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Frm_ManagePress_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lv_Press_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Press.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Press.SelectedItems[0];
                selected_pid = item.SubItems[0].Text;
                txt_pname.Text = item.SubItems[1].Text;
                txt_contact.Text = item.SubItems[2].Text;
                txt_phone.Text = item.SubItems[3].Text;
                txt_address.Text = item.SubItems[4].Text;
                lbl_Status.Text = "修改";
                //txt_isbn.ReadOnly = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lbl_note.Text = "";
        }
        string selected_pid = "";

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (selected_pid == "")
            {
                MessageBox.Show("请先选择要删除的出版社信息!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的出版社信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                    conn.Open();
                    String str = String.Format("delete from press_info where pid={0}", selected_pid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i > 0)
                        {
                            lbl_note.Text = "恭喜您，出版社信息删除成功！";
                            lbl_note.ForeColor = Color.Blue;
                            ClearTexBox();
                            DataBind_Press();
                        }
                        else
                        {
                            lbl_note.Text = "对不起，出版社信息删除失败！";
                            lbl_note.ForeColor = Color.Red;
                        }
                    }
                    catch(MySqlException)
                    {
                        lbl_note.Text = "PID="+selected_pid+"的出版社信息已被引用，无法删除！";
                        lbl_note.ForeColor = Color.Red;
                    }
                    
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string pname = txt_pname.Text.Trim();
            string contact = txt_contact.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string address = txt_address.Text.Trim();
            if (pname == "")
            {
                lbl_note.Text = "出版社名不能为空!";
                lbl_note.ForeColor = Color.Red;
                txt_pname.Focus();
            }
            else if (phone.Length != 11) MessageBox.Show("电话应为11位！");
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = String.Format("insert into press_info" +
                    " values(null," +
                    "'{0}','{1}','{2}','{3}')",
                    pname, contact, phone, address);
                Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，出版社信息添加成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Press();
                }
                else
                {
                    lbl_note.Text = "对不起，出版社信息添加失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
            else if (lbl_Status.Text == "修改")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = string.Format("update press_info set " +
                    "pname = '{1}', " +
                    "contact = '{2}', phone ='{3}',address = '{4}'" +
                    " where pid = {0}",
                    selected_pid, pname, contact, phone, address);
                //Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，出版社信息修改成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Press();
                }
                else
                {
                    lbl_note.Text = "对不起，出版社信息修改失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
        }
    }
}
