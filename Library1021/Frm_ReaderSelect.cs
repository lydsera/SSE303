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
    public partial class Frm_ReaderSelect : Form
    {
        public Frm_ReaderSelect()
        {
            InitializeComponent();
        }

        private void Frm_ReaderSelect_Load(object sender, EventArgs e)
        {


        }
        public string rid;
        public string mid;
        public int bnum;
        public int bday;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Borrow frm = new Frm_Borrow();
            frm.rid = rid;
            frm.mid = mid;
            frm.bday = bday;        
            frm.bnum = bnum;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Frm_ReaderSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Return frm = new Frm_Return();
            frm.rid = rid;
            frm.mid = mid;
            frm.bday = bday;
            frm.bnum = bnum;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Fine frm = new Frm_Fine();
            frm.rid = rid;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
