namespace Library1021
{
    partial class Frm_Borrow
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
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.ch_outnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_onnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_intro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_pubdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_writer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_press = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Book = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rid = new System.Windows.Forms.Label();
            this.lbl_bnum = new System.Windows.Forms.Label();
            this.lbl_bday = new System.Windows.Forms.Label();
            this.lbl_borrowed = new System.Windows.Forms.Label();
            this.lbl_borrowed1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Location = new System.Drawing.Point(116, 0);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(75, 28);
            this.btn_Borrow.TabIndex = 0;
            this.btn_Borrow.Text = "借阅";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // ch_outnum
            // 
            this.ch_outnum.DisplayIndex = 7;
            this.ch_outnum.Text = "外借数目";
            this.ch_outnum.Width = 72;
            // 
            // ch_onnum
            // 
            this.ch_onnum.DisplayIndex = 6;
            this.ch_onnum.Text = "在架数目";
            this.ch_onnum.Width = 75;
            // 
            // ch_intro
            // 
            this.ch_intro.DisplayIndex = 9;
            this.ch_intro.Text = "简介";
            this.ch_intro.Width = 0;
            // 
            // ch_price
            // 
            this.ch_price.DisplayIndex = 8;
            this.ch_price.Text = "价格";
            // 
            // ch_pubdate
            // 
            this.ch_pubdate.Text = "出版日期";
            this.ch_pubdate.Width = 124;
            // 
            // ch_version
            // 
            this.ch_version.Text = "版本";
            // 
            // ch_writer
            // 
            this.ch_writer.Text = "作者";
            this.ch_writer.Width = 89;
            // 
            // ch_press
            // 
            this.ch_press.Text = "出版社";
            this.ch_press.Width = 142;
            // 
            // ch_name
            // 
            this.ch_name.Text = "书名";
            this.ch_name.Width = 102;
            // 
            // ch_isbn
            // 
            this.ch_isbn.Text = "ISBN";
            this.ch_isbn.Width = 102;
            // 
            // lv_Book
            // 
            this.lv_Book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_isbn,
            this.ch_name,
            this.ch_press,
            this.ch_writer,
            this.ch_version,
            this.ch_pubdate,
            this.ch_price,
            this.ch_intro,
            this.ch_onnum,
            this.ch_outnum});
            this.lv_Book.FullRowSelect = true;
            this.lv_Book.GridLines = true;
            this.lv_Book.HideSelection = false;
            this.lv_Book.Location = new System.Drawing.Point(6, 45);
            this.lv_Book.MultiSelect = false;
            this.lv_Book.Name = "lv_Book";
            this.lv_Book.Size = new System.Drawing.Size(770, 299);
            this.lv_Book.TabIndex = 1;
            this.lv_Book.UseCompatibleStateImageBehavior = false;
            this.lv_Book.View = System.Windows.Forms.View.Details;
            this.lv_Book.SelectedIndexChanged += new System.EventHandler(this.lv_Book_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Book);
            this.groupBox2.Controls.Add(this.btn_Borrow);
            this.groupBox2.Location = new System.Drawing.Point(9, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 352);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_writer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_bname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_isbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 146);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索图书";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(351, 214);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 28);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(566, 98);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(461, 98);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 28);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_writer
            // 
            this.txt_writer.Location = new System.Drawing.Point(456, 40);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(185, 25);
            this.txt_writer.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "作者：";
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(169, 95);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(185, 25);
            this.txt_bname.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "书名：";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(169, 37);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(185, 25);
            this.txt_isbn.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ISBN：";
            // 
            // lbl_rid
            // 
            this.lbl_rid.AutoSize = true;
            this.lbl_rid.Location = new System.Drawing.Point(31, 22);
            this.lbl_rid.Name = "lbl_rid";
            this.lbl_rid.Size = new System.Drawing.Size(68, 15);
            this.lbl_rid.TabIndex = 15;
            this.lbl_rid.Text = "读者ID：";
            // 
            // lbl_bnum
            // 
            this.lbl_bnum.AutoSize = true;
            this.lbl_bnum.Location = new System.Drawing.Point(195, 22);
            this.lbl_bnum.Name = "lbl_bnum";
            this.lbl_bnum.Size = new System.Drawing.Size(82, 15);
            this.lbl_bnum.TabIndex = 16;
            this.lbl_bnum.Text = "可借书数：";
            // 
            // lbl_bday
            // 
            this.lbl_bday.AutoSize = true;
            this.lbl_bday.Location = new System.Drawing.Point(394, 22);
            this.lbl_bday.Name = "lbl_bday";
            this.lbl_bday.Size = new System.Drawing.Size(82, 15);
            this.lbl_bday.TabIndex = 17;
            this.lbl_bday.Text = "可借天数：";
            // 
            // lbl_borrowed
            // 
            this.lbl_borrowed.AutoSize = true;
            this.lbl_borrowed.Location = new System.Drawing.Point(585, 22);
            this.lbl_borrowed.Name = "lbl_borrowed";
            this.lbl_borrowed.Size = new System.Drawing.Size(82, 15);
            this.lbl_borrowed.TabIndex = 18;
            this.lbl_borrowed.Text = "已借书数：";
            // 
            // lbl_borrowed1
            // 
            this.lbl_borrowed1.AutoSize = true;
            this.lbl_borrowed1.Location = new System.Drawing.Point(663, 22);
            this.lbl_borrowed1.Name = "lbl_borrowed1";
            this.lbl_borrowed1.Size = new System.Drawing.Size(0, 15);
            this.lbl_borrowed1.TabIndex = 19;
            // 
            // Frm_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 648);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_borrowed1);
            this.Controls.Add(this.lbl_borrowed);
            this.Controls.Add(this.lbl_bday);
            this.Controls.Add(this.lbl_bnum);
            this.Controls.Add(this.lbl_rid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Borrow_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Borrow_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.ColumnHeader ch_outnum;
        private System.Windows.Forms.ColumnHeader ch_onnum;
        private System.Windows.Forms.ColumnHeader ch_intro;
        private System.Windows.Forms.ColumnHeader ch_price;
        private System.Windows.Forms.ColumnHeader ch_pubdate;
        private System.Windows.Forms.ColumnHeader ch_version;
        private System.Windows.Forms.ColumnHeader ch_writer;
        private System.Windows.Forms.ColumnHeader ch_press;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_isbn;
        private System.Windows.Forms.ListView lv_Book;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_rid;
        private System.Windows.Forms.Label lbl_bnum;
        private System.Windows.Forms.Label lbl_bday;
        private System.Windows.Forms.Label lbl_borrowed;
        private System.Windows.Forms.Label lbl_borrowed1;
    }
}