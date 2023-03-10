namespace Library1021
{
    partial class Frm_ManageCollection
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
            this.lv_Collection = new System.Windows.Forms.ListView();
            this.ch_bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_bcondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_waretime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBox_isbn = new System.Windows.Forms.ComboBox();
            this.dateTime_ware = new System.Windows.Forms.DateTimePicker();
            this.rbtn_out = new System.Windows.Forms.RadioButton();
            this.rbtn_on = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Collection);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 350);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "馆藏信息列表";
            // 
            // lv_Collection
            // 
            this.lv_Collection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_bid,
            this.ch_isbn,
            this.ch_bcondition,
            this.ch_waretime});
            this.lv_Collection.FullRowSelect = true;
            this.lv_Collection.GridLines = true;
            this.lv_Collection.HideSelection = false;
            this.lv_Collection.Location = new System.Drawing.Point(6, 45);
            this.lv_Collection.MultiSelect = false;
            this.lv_Collection.Name = "lv_Collection";
            this.lv_Collection.Size = new System.Drawing.Size(573, 299);
            this.lv_Collection.TabIndex = 1;
            this.lv_Collection.UseCompatibleStateImageBehavior = false;
            this.lv_Collection.View = System.Windows.Forms.View.Details;
            this.lv_Collection.SelectedIndexChanged += new System.EventHandler(this.lv_Collection_SelectedIndexChanged);
            // 
            // ch_bid
            // 
            this.ch_bid.Text = "BID";
            this.ch_bid.Width = 102;
            // 
            // ch_isbn
            // 
            this.ch_isbn.Text = "ISBN";
            this.ch_isbn.Width = 113;
            // 
            // ch_bcondition
            // 
            this.ch_bcondition.Text = "状态";
            this.ch_bcondition.Width = 142;
            // 
            // ch_waretime
            // 
            this.ch_waretime.Text = "入库时间";
            this.ch_waretime.Width = 155;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(126, 0);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 28);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_bid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBox_isbn);
            this.groupBox1.Controls.Add(this.dateTime_ware);
            this.groupBox1.Controls.Add(this.rbtn_out);
            this.groupBox1.Controls.Add(this.rbtn_on);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_note);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑馆藏信息  状态：";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_bid
            // 
            this.txt_bid.Enabled = false;
            this.txt_bid.Location = new System.Drawing.Point(103, 43);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(131, 25);
            this.txt_bid.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "BID：";
            // 
            // cbBox_isbn
            // 
            this.cbBox_isbn.FormattingEnabled = true;
            this.cbBox_isbn.Location = new System.Drawing.Point(359, 45);
            this.cbBox_isbn.Name = "cbBox_isbn";
            this.cbBox_isbn.Size = new System.Drawing.Size(200, 23);
            this.cbBox_isbn.TabIndex = 27;
            // 
            // dateTime_ware
            // 
            this.dateTime_ware.Location = new System.Drawing.Point(359, 95);
            this.dateTime_ware.Name = "dateTime_ware";
            this.dateTime_ware.Size = new System.Drawing.Size(200, 25);
            this.dateTime_ware.TabIndex = 26;
            // 
            // rbtn_out
            // 
            this.rbtn_out.AutoSize = true;
            this.rbtn_out.Enabled = false;
            this.rbtn_out.Location = new System.Drawing.Point(176, 99);
            this.rbtn_out.Name = "rbtn_out";
            this.rbtn_out.Size = new System.Drawing.Size(58, 19);
            this.rbtn_out.TabIndex = 25;
            this.rbtn_out.TabStop = true;
            this.rbtn_out.Text = "外借";
            this.rbtn_out.UseVisualStyleBackColor = true;
            // 
            // rbtn_on
            // 
            this.rbtn_on.AutoSize = true;
            this.rbtn_on.Enabled = false;
            this.rbtn_on.Location = new System.Drawing.Point(103, 99);
            this.rbtn_on.Name = "rbtn_on";
            this.rbtn_on.Size = new System.Drawing.Size(58, 19);
            this.rbtn_on.TabIndex = 24;
            this.rbtn_on.TabStop = true;
            this.rbtn_on.Text = "在架";
            this.rbtn_on.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(211, 206);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(0, 15);
            this.lbl_note.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(242, 156);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 35);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(134, 156);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(77, 35);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "入库时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(164, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 15);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "添加";
            // 
            // Frm_ManageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ManageCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "馆藏信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ManageCollection_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ManageCollection_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Collection;
        private System.Windows.Forms.ColumnHeader ch_bid;
        private System.Windows.Forms.ColumnHeader ch_isbn;
        private System.Windows.Forms.ColumnHeader ch_bcondition;
        private System.Windows.Forms.ColumnHeader ch_waretime;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.DateTimePicker dateTime_ware;
        private System.Windows.Forms.ComboBox cbBox_isbn;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_out;
        private System.Windows.Forms.RadioButton rbtn_on;
        private System.Windows.Forms.Label label7;
    }
}