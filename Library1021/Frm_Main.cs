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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
        public string mid;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ManageReader frm = new Frm_ManageReader();
            if( frm.ShowDialog() == DialogResult.OK )
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ManageBook frm = new Frm_ManageBook();
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

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ManagePress frm = new Frm_ManagePress();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ManageCollection frm = new Frm_ManageCollection();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ReaderLogin frm = new Frm_ReaderLogin();
            frm.mid = this.mid;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
