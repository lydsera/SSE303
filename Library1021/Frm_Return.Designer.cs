namespace Library1021
{
    partial class Frm_Return
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_borrowed1 = new System.Windows.Forms.Label();
            this.lbl_bday = new System.Windows.Forms.Label();
            this.lbl_bnum = new System.Windows.Forms.Label();
            this.lbl_rid = new System.Windows.Forms.Label();
            this.lbl_borrowed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_re = new System.Windows.Forms.Button();
            this.lv_Borrow = new System.Windows.Forms.ListView();
            this.ch_boid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_mid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_botime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_shouldretime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_renewtimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(354, 487);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 28);
            this.btn_back.TabIndex = 40;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_borrowed1
            // 
            this.lbl_borrowed1.AutoSize = true;
            this.lbl_borrowed1.Location = new System.Drawing.Point(663, 18);
            this.lbl_borrowed1.Name = "lbl_borrowed1";
            this.lbl_borrowed1.Size = new System.Drawing.Size(0, 15);
            this.lbl_borrowed1.TabIndex = 39;
            // 
            // lbl_bday
            // 
            this.lbl_bday.AutoSize = true;
            this.lbl_bday.Location = new System.Drawing.Point(394, 18);
            this.lbl_bday.Name = "lbl_bday";
            this.lbl_bday.Size = new System.Drawing.Size(82, 15);
            this.lbl_bday.TabIndex = 37;
            this.lbl_bday.Text = "可借天数：";
            // 
            // lbl_bnum
            // 
            this.lbl_bnum.AutoSize = true;
            this.lbl_bnum.Location = new System.Drawing.Point(195, 18);
            this.lbl_bnum.Name = "lbl_bnum";
            this.lbl_bnum.Size = new System.Drawing.Size(82, 15);
            this.lbl_bnum.TabIndex = 36;
            this.lbl_bnum.Text = "可借书数：";
            // 
            // lbl_rid
            // 
            this.lbl_rid.AutoSize = true;
            this.lbl_rid.Location = new System.Drawing.Point(31, 18);
            this.lbl_rid.Name = "lbl_rid";
            this.lbl_rid.Size = new System.Drawing.Size(68, 15);
            this.lbl_rid.TabIndex = 35;
            this.lbl_rid.Text = "读者ID：";
            // 
            // lbl_borrowed
            // 
            this.lbl_borrowed.AutoSize = true;
            this.lbl_borrowed.Location = new System.Drawing.Point(585, 18);
            this.lbl_borrowed.Name = "lbl_borrowed";
            this.lbl_borrowed.Size = new System.Drawing.Size(82, 15);
            this.lbl_borrowed.TabIndex = 38;
            this.lbl_borrowed.Text = "已借书数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_re);
            this.groupBox2.Controls.Add(this.lv_Borrow);
            this.groupBox2.Controls.Add(this.btn_Return);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 352);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借阅记录列表";
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(209, 0);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(75, 28);
            this.btn_re.TabIndex = 2;
            this.btn_re.Text = "续借";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.btn_re_Click);
            // 
            // lv_Borrow
            // 
            this.lv_Borrow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_boid,
            this.ch_bid,
            this.ch_isbn,
            this.ch_mid,
            this.ch_botime,
            this.ch_shouldretime,
            this.ch_renewtimes});
            this.lv_Borrow.FullRowSelect = true;
            this.lv_Borrow.GridLines = true;
            this.lv_Borrow.HideSelection = false;
            this.lv_Borrow.Location = new System.Drawing.Point(6, 45);
            this.lv_Borrow.MultiSelect = false;
            this.lv_Borrow.Name = "lv_Borrow";
            this.lv_Borrow.Size = new System.Drawing.Size(770, 299);
            this.lv_Borrow.TabIndex = 1;
            this.lv_Borrow.UseCompatibleStateImageBehavior = false;
            this.lv_Borrow.View = System.Windows.Forms.View.Details;
            this.lv_Borrow.SelectedIndexChanged += new System.EventHandler(this.lv_Borrow_SelectedIndexChanged);
            // 
            // ch_boid
            // 
            this.ch_boid.Text = "BoID";
            this.ch_boid.Width = 80;
            // 
            // ch_bid
            // 
            this.ch_bid.Text = "BID";
            this.ch_bid.Width = 71;
            // 
            // ch_isbn
            // 
            this.ch_isbn.Text = "ISBN";
            this.ch_isbn.Width = 142;
            // 
            // ch_mid
            // 
            this.ch_mid.Text = "MID";
            this.ch_mid.Width = 75;
            // 
            // ch_botime
            // 
            this.ch_botime.Text = "借阅时间";
            this.ch_botime.Width = 149;
            // 
            // ch_shouldretime
            // 
            this.ch_shouldretime.Text = "到期时间";
            this.ch_shouldretime.Width = 145;
            // 
            // ch_renewtimes
            // 
            this.ch_renewtimes.Text = "续借次数";
            this.ch_renewtimes.Width = 92;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(116, 0);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 28);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.Text = "归还";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "超时归还，需罚款（20+15*超时天数）元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "续借一次增加15天，最多两次";
            // 
            // Frm_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_borrowed1);
            this.Controls.Add(this.lbl_bday);
            this.Controls.Add(this.lbl_bnum);
            this.Controls.Add(this.lbl_rid);
            this.Controls.Add(this.lbl_borrowed);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书归还";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Return_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Return_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_borrowed1;
        private System.Windows.Forms.Label lbl_bday;
        private System.Windows.Forms.Label lbl_bnum;
        private System.Windows.Forms.Label lbl_rid;
        private System.Windows.Forms.Label lbl_borrowed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Borrow;
        private System.Windows.Forms.ColumnHeader ch_boid;
        private System.Windows.Forms.ColumnHeader ch_bid;
        private System.Windows.Forms.ColumnHeader ch_isbn;
        private System.Windows.Forms.ColumnHeader ch_mid;
        private System.Windows.Forms.ColumnHeader ch_botime;
        private System.Windows.Forms.ColumnHeader ch_shouldretime;
        private System.Windows.Forms.ColumnHeader ch_renewtimes;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}