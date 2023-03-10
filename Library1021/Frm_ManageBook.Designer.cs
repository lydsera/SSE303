namespace Library1021
{
    partial class Frm_ManageBook
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Book = new System.Windows.Forms.ListView();
            this.ch_isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_press = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_writer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_pubdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_intro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_onnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_outnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_outnum = new System.Windows.Forms.TextBox();
            this.txt_onnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_intro = new System.Windows.Forms.TextBox();
            this.txt_version = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.dateTime_pub = new System.Windows.Forms.DateTimePicker();
            this.cbBox_press = new System.Windows.Forms.ComboBox();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Book);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(23, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 350);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息列表";
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
            // ch_isbn
            // 
            this.ch_isbn.Text = "ISBN";
            this.ch_isbn.Width = 102;
            // 
            // ch_name
            // 
            this.ch_name.Text = "书名";
            this.ch_name.Width = 102;
            // 
            // ch_press
            // 
            this.ch_press.Text = "出版社";
            this.ch_press.Width = 142;
            // 
            // ch_writer
            // 
            this.ch_writer.Text = "作者";
            this.ch_writer.Width = 89;
            // 
            // ch_version
            // 
            this.ch_version.Text = "版本";
            // 
            // ch_pubdate
            // 
            this.ch_pubdate.Text = "出版日期";
            this.ch_pubdate.Width = 124;
            // 
            // ch_price
            // 
            this.ch_price.DisplayIndex = 8;
            this.ch_price.Text = "价格";
            // 
            // ch_intro
            // 
            this.ch_intro.DisplayIndex = 9;
            this.ch_intro.Text = "简介";
            this.ch_intro.Width = 0;
            // 
            // ch_onnum
            // 
            this.ch_onnum.DisplayIndex = 6;
            this.ch_onnum.Text = "在架数目";
            this.ch_onnum.Width = 75;
            // 
            // ch_outnum
            // 
            this.ch_outnum.DisplayIndex = 7;
            this.ch_outnum.Text = "外借数目";
            this.ch_outnum.Width = 72;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(110, 0);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 28);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_outnum);
            this.groupBox1.Controls.Add(this.txt_onnum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_note);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_intro);
            this.groupBox1.Controls.Add(this.txt_version);
            this.groupBox1.Controls.Add(this.txt_bookname);
            this.groupBox1.Controls.Add(this.dateTime_pub);
            this.groupBox1.Controls.Add(this.cbBox_press);
            this.groupBox1.Controls.Add(this.txt_writer);
            this.groupBox1.Controls.Add(this.txt_isbn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑图书信息  状态：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "价格：";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(626, 101);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(131, 25);
            this.txt_price.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_outnum
            // 
            this.txt_outnum.Enabled = false;
            this.txt_outnum.Location = new System.Drawing.Point(626, 63);
            this.txt_outnum.Name = "txt_outnum";
            this.txt_outnum.Size = new System.Drawing.Size(131, 25);
            this.txt_outnum.TabIndex = 19;
            // 
            // txt_onnum
            // 
            this.txt_onnum.Enabled = false;
            this.txt_onnum.Location = new System.Drawing.Point(626, 27);
            this.txt_onnum.Name = "txt_onnum";
            this.txt_onnum.Size = new System.Drawing.Size(131, 25);
            this.txt_onnum.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "外借数目：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "在架数目：";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(320, 228);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(0, 15);
            this.lbl_note.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(312, 165);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 35);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(188, 165);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_intro
            // 
            this.txt_intro.Location = new System.Drawing.Point(626, 143);
            this.txt_intro.Multiline = true;
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_intro.Size = new System.Drawing.Size(131, 97);
            this.txt_intro.TabIndex = 14;
            // 
            // txt_version
            // 
            this.txt_version.Location = new System.Drawing.Point(367, 62);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(139, 25);
            this.txt_version.TabIndex = 13;
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(111, 63);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(131, 25);
            this.txt_bookname.TabIndex = 12;
            // 
            // dateTime_pub
            // 
            this.dateTime_pub.Location = new System.Drawing.Point(366, 103);
            this.dateTime_pub.Name = "dateTime_pub";
            this.dateTime_pub.Size = new System.Drawing.Size(140, 25);
            this.dateTime_pub.TabIndex = 10;
            // 
            // cbBox_press
            // 
            this.cbBox_press.FormattingEnabled = true;
            this.cbBox_press.Location = new System.Drawing.Point(110, 103);
            this.cbBox_press.Name = "cbBox_press";
            this.cbBox_press.Size = new System.Drawing.Size(132, 23);
            this.cbBox_press.TabIndex = 6;
            // 
            // txt_writer
            // 
            this.txt_writer.Location = new System.Drawing.Point(367, 27);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(139, 25);
            this.txt_writer.TabIndex = 5;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(110, 24);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(132, 25);
            this.txt_isbn.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "简介：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "版本：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "书名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "出版社：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(161, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 15);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "添加";
            // 
            // Frm_ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ManageBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ManageBook_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ManageBook_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Book;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.TextBox txt_intro;
        private System.Windows.Forms.TextBox txt_version;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.DateTimePicker dateTime_pub;
        private System.Windows.Forms.ComboBox cbBox_press;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_outnum;
        private System.Windows.Forms.TextBox txt_onnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ch_isbn;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_press;
        private System.Windows.Forms.ColumnHeader ch_writer;
        private System.Windows.Forms.ColumnHeader ch_version;
        private System.Windows.Forms.ColumnHeader ch_pubdate;
        private System.Windows.Forms.ColumnHeader ch_onnum;
        private System.Windows.Forms.ColumnHeader ch_outnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ch_price;
        private System.Windows.Forms.ColumnHeader ch_intro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_price;
    }
}