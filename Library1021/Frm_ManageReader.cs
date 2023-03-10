using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library1021
{
    public partial class Frm_ManageReader : Form
    {
        public Frm_ManageReader()
        {
            InitializeComponent();
        }

        private void Frm_ManageReader_Load(object sender, EventArgs e)
        {
            
            DataBind_ReaderType();
            DataBind_Reader();
            ClearTexBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string readerid = "";
        protected void ClearTexBox()
        {
            lbl_Status.Text = "添加";
            readerid = "";
            txt_Name.Text = "";
            cbBox_readertype.SelectedIndex = 0;
            txt_Telephone.Text = "";
            rbtn_isLost1.Checked = true;
            rbtn_Sex1.Checked = true;
            lbl_Status.Text = "添加";
            txt_totalbooknum.Text = "0";
            txt_curbooknum.Text = "0";
            txt_violatenum.Text = "0";
            txt_remark.Text = "";
            dateTime_register.Value= DateTime.Now;
            dateTime_valid.Value = DateTime.Now;
        }
        protected void DataBind_ReaderType()
        {
            
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select * from reader_type";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbBox_readertype.DataSource = dt;
            cbBox_readertype.DisplayMember= "rtname";
            cbBox_readertype.ValueMember= "rtid";

        }
        protected void DataBind_Reader()
        {
            MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
            conn.Open();
            string str = "select * from reader_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Reader.Items.Clear();//先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                string tmp=null;
                switch (dr["rtid"])
                {
                    case 1:
                        tmp = "教师";
                        break;
                    case 2:
                        tmp = "职工";
                        break;
                    case 3:
                        tmp = "学生";
                        break;
                }

                ListViewItem myitem = new ListViewItem(dr["rid"].ToString());//创建一个ListViewItem项，并为第1列赋值，读者种类编号
                myitem.SubItems.Add(tmp);
                myitem.SubItems.Add(dr["rname"].ToString());//第二列，姓名
                myitem.SubItems.Add(dr["Sex"].ToString()=="0"?"男":"女");//第三列，性别
                myitem.SubItems.Add(dr["phone"].ToString());//第四列，电话
                myitem.SubItems.Add(dr["redate"].ToString());//第五列，登记日期
                myitem.SubItems.Add(dr["valdate"].ToString());//第六列，有效日期
                myitem.SubItems.Add(dr["curbnum"].ToString());//第七列，现借书数
                myitem.SubItems.Add(dr["totbnum"].ToString());//第八列，总借书数
                myitem.SubItems.Add(dr["islost"].ToString()=="False"?"否":"是");//第九列，是否挂失
                myitem.SubItems.Add(dr["vionum"].ToString());//第十列，违规次数
                myitem.SubItems.Add(dr["remark"].ToString());//第十一列，备注
                lv_Reader.Items.Add(myitem);//将新建项添加到ListView控件中

            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();//姓名
            string sex = rbtn_Sex1.Checked == true ? "0" : "1";//性别，0是男，1是女
            string telephone = txt_Telephone.Text.Trim();//电话
            string rtid = cbBox_readertype.SelectedValue.ToString();//读者类别编号
            string redate = dateTime_register.Value.ToString(); //归还时间
            string valdate = dateTime_valid.Value.ToString();//有效时间
            string curbnum = txt_curbooknum.Text.Trim();//现借图书数
            string totbnum = txt_totalbooknum.Text.Trim();//总借书数
            string islost = rbtn_isLost1.Checked == true ? "1" : "0";//1为挂失
            string vionum = txt_violatenum.Text.Trim();//违规次数
            string remark = txt_remark.Text.Trim();//备注

            if (name == "")
            {
                lbl_note.Text = "姓名不能为空!";
                lbl_note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (telephone.Length != 11) MessageBox.Show("电话长度应为11!");
            
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                conn.Open();
                string str = String.Format("insert into Reader_Info" +
                    " values(null," +
                    "{0},'{1}',{2},'{3}','{4}','{5}',{6},{7},{8},{9},'{10}')",
                    rtid, name, sex, telephone, redate, valdate, curbnum, totbnum, islost, vionum, remark);
                //Console.WriteLine(str);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，读者信息添加成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Reader();
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
                string str = string.Format("update Reader_Info set " +
                    "rtid = {0},rname = '{1}', " +
                    "sex = {2}, phone ='{3}',redate = '{4}'," +
                    "valdate = '{5}',curbnum={6},totbnum={7}," +
                    "islost={8},vionum={9},remark='{10}' " +
                    "where rid = {11}",
                    rtid, name, sex, telephone, redate, valdate, curbnum, totbnum, islost, vionum, remark, readerid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_note.Text = "恭喜您，读者信息修改成功！";
                    lbl_note.ForeColor = Color.Blue;
                    ClearTexBox();
                    DataBind_Reader();
                }
                else
                {
                    lbl_note.Text = "对不起，读者信息修改失败！";
                    lbl_note.ForeColor = Color.Red;
                }
            }
        }
        

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if(readerid=="")
            {
                MessageBox.Show("请先选择要删除的读者信息!");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的读者信息？", "删除提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=?;database=?;UID=?;PWD=?;port=?");
                    conn.Open();
                    String str = String.Format("delete from Reader_Info where rid={0}", readerid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_note.Text = "恭喜您，读者信息删除成功！";
                        lbl_note.ForeColor = Color.Blue;
                        ClearTexBox();
                        DataBind_Reader();
                    }
                    else
                    {
                        lbl_note.Text = "对不起，读者信息删除失败！";
                        lbl_note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void lv_Reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_Reader.SelectedItems.Count>0)
            {
                ListViewItem item = lv_Reader.SelectedItems[0];
                readerid = item.SubItems[0].Text;
                cbBox_readertype.Text= item.SubItems[1].Text;
                txt_Name.Text = item.SubItems[2].Text;
                rbtn_Sex1.Checked = item.SubItems[3].Text == "男" ? true : false;
                rbtn_Sex2.Checked = item.SubItems[3].Text == "女" ? true : false;
                txt_Telephone.Text = item.SubItems[4].Text;
                dateTime_register.Value = DateTime.Parse(item.SubItems[5].Text);
                dateTime_valid.Value = DateTime.Parse(item.SubItems[6].Text);
                txt_curbooknum.Text = item.SubItems[7].Text;
                txt_totalbooknum.Text = item.SubItems[8].Text;
                rbtn_isLost1.Checked = item.SubItems[9].Text == "是" ? true : false;
                rbtn_isLost2.Checked = item.SubItems[9].Text == "否" ? true : false;
                txt_violatenum.Text = item.SubItems[10].Text;
                txt_remark.Text = item.SubItems[11].Text;
                lbl_Status.Text = "修改";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTexBox();
            lbl_note.Text = "";
        }

        private void Frm_ManageReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
