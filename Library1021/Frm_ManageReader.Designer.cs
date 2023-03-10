namespace Library1021
{
    partial class Frm_ManageReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_violatenum = new System.Windows.Forms.TextBox();
            this.txt_totalbooknum = new System.Windows.Forms.TextBox();
            this.txt_curbooknum = new System.Windows.Forms.TextBox();
            this.dateTime_valid = new System.Windows.Forms.DateTimePicker();
            this.dateTime_register = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtn_isLost2 = new System.Windows.Forms.RadioButton();
            this.rbtn_isLost1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.cbBox_readertype = new System.Windows.Forms.ComboBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Reader = new System.Windows.Forms.ListView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.ch_rid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_rtid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_rname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_redate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_valdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_curbnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_totbnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_islost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vionum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_remark);
            this.groupBox1.Controls.Add(this.lbl_remark);
            this.groupBox1.Controls.Add(this.lbl_note);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_violatenum);
            this.groupBox1.Controls.Add(this.txt_totalbooknum);
            this.groupBox1.Controls.Add(this.txt_curbooknum);
            this.groupBox1.Controls.Add(this.dateTime_valid);
            this.groupBox1.Controls.Add(this.dateTime_register);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbBox_readertype);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑读者信息  状态：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(735, 169);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(100, 25);
            this.txt_remark.TabIndex = 15;
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(677, 172);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(52, 15);
            this.lbl_remark.TabIndex = 16;
            this.lbl_remark.Text = "备注：";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(384, 248);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(0, 15);
            this.lbl_note.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(414, 186);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 35);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(309, 186);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_violatenum
            // 
            this.txt_violatenum.Enabled = false;
            this.txt_violatenum.Location = new System.Drawing.Point(735, 124);
            this.txt_violatenum.Name = "txt_violatenum";
            this.txt_violatenum.Size = new System.Drawing.Size(100, 25);
            this.txt_violatenum.TabIndex = 14;
            // 
            // txt_totalbooknum
            // 
            this.txt_totalbooknum.Enabled = false;
            this.txt_totalbooknum.Location = new System.Drawing.Point(735, 73);
            this.txt_totalbooknum.Name = "txt_totalbooknum";
            this.txt_totalbooknum.Size = new System.Drawing.Size(100, 25);
            this.txt_totalbooknum.TabIndex = 13;
            // 
            // txt_curbooknum
            // 
            this.txt_curbooknum.Enabled = false;
            this.txt_curbooknum.Location = new System.Drawing.Point(735, 29);
            this.txt_curbooknum.Name = "txt_curbooknum";
            this.txt_curbooknum.Size = new System.Drawing.Size(100, 25);
            this.txt_curbooknum.TabIndex = 12;
            // 
            // dateTime_valid
            // 
            this.dateTime_valid.Location = new System.Drawing.Point(384, 127);
            this.dateTime_valid.Name = "dateTime_valid";
            this.dateTime_valid.Size = new System.Drawing.Size(200, 25);
            this.dateTime_valid.TabIndex = 11;
            // 
            // dateTime_register
            // 
            this.dateTime_register.Location = new System.Drawing.Point(384, 67);
            this.dateTime_register.Name = "dateTime_register";
            this.dateTime_register.Size = new System.Drawing.Size(200, 25);
            this.dateTime_register.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtn_isLost2);
            this.groupBox4.Controls.Add(this.rbtn_isLost1);
            this.groupBox4.Location = new System.Drawing.Point(381, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 49);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // rbtn_isLost2
            // 
            this.rbtn_isLost2.AutoSize = true;
            this.rbtn_isLost2.Location = new System.Drawing.Point(63, 15);
            this.rbtn_isLost2.Name = "rbtn_isLost2";
            this.rbtn_isLost2.Size = new System.Drawing.Size(43, 19);
            this.rbtn_isLost2.TabIndex = 9;
            this.rbtn_isLost2.TabStop = true;
            this.rbtn_isLost2.Text = "否";
            this.rbtn_isLost2.UseVisualStyleBackColor = true;
            // 
            // rbtn_isLost1
            // 
            this.rbtn_isLost1.AutoSize = true;
            this.rbtn_isLost1.Location = new System.Drawing.Point(6, 15);
            this.rbtn_isLost1.Name = "rbtn_isLost1";
            this.rbtn_isLost1.Size = new System.Drawing.Size(43, 19);
            this.rbtn_isLost1.TabIndex = 8;
            this.rbtn_isLost1.TabStop = true;
            this.rbtn_isLost1.Text = "是";
            this.rbtn_isLost1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Sex1);
            this.groupBox3.Controls.Add(this.rbtn_Sex2);
            this.groupBox3.Location = new System.Drawing.Point(110, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 32);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(0, 9);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex1.TabIndex = 3;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(59, 9);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex2.TabIndex = 4;
            this.rbtn_Sex2.TabStop = true;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // cbBox_readertype
            // 
            this.cbBox_readertype.FormattingEnabled = true;
            this.cbBox_readertype.Location = new System.Drawing.Point(110, 151);
            this.cbBox_readertype.Name = "cbBox_readertype";
            this.cbBox_readertype.Size = new System.Drawing.Size(132, 23);
            this.cbBox_readertype.TabIndex = 6;
            this.cbBox_readertype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(110, 105);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(131, 25);
            this.txt_Telephone.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(110, 24);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(132, 25);
            this.txt_Name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "违规次数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "是否挂失：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "累计借书数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "现借图书数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "有效期至：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "登记日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "读者类别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(161, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 15);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "添加";
            this.lbl_Status.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Reader);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息列表";
            // 
            // lv_Reader
            // 
            this.lv_Reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_rid,
            this.ch_rtid,
            this.ch_rname,
            this.ch_sex,
            this.ch_phone,
            this.ch_redate,
            this.ch_valdate,
            this.ch_curbnum,
            this.ch_totbnum,
            this.ch_islost,
            this.ch_vionum,
            this.ch_remark});
            this.lv_Reader.FullRowSelect = true;
            this.lv_Reader.GridLines = true;
            this.lv_Reader.HideSelection = false;
            this.lv_Reader.Location = new System.Drawing.Point(6, 45);
            this.lv_Reader.MultiSelect = false;
            this.lv_Reader.Name = "lv_Reader";
            this.lv_Reader.Size = new System.Drawing.Size(932, 227);
            this.lv_Reader.TabIndex = 1;
            this.lv_Reader.UseCompatibleStateImageBehavior = false;
            this.lv_Reader.View = System.Windows.Forms.View.Details;
            this.lv_Reader.SelectedIndexChanged += new System.EventHandler(this.lv_Reader_SelectedIndexChanged);
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
            // ch_rid
            // 
            this.ch_rid.Text = "RID";
            // 
            // ch_rtid
            // 
            this.ch_rtid.Text = "读者类别";
            this.ch_rtid.Width = 80;
            // 
            // ch_rname
            // 
            this.ch_rname.Text = "姓名";
            this.ch_rname.Width = 71;
            // 
            // ch_sex
            // 
            this.ch_sex.Text = "性别";
            // 
            // ch_phone
            // 
            this.ch_phone.Text = "电话";
            this.ch_phone.Width = 83;
            // 
            // ch_redate
            // 
            this.ch_redate.Text = "注册日期";
            this.ch_redate.Width = 89;
            // 
            // ch_valdate
            // 
            this.ch_valdate.Text = "有效日期";
            this.ch_valdate.Width = 82;
            // 
            // ch_curbnum
            // 
            this.ch_curbnum.Text = "现借书数";
            this.ch_curbnum.Width = 91;
            // 
            // ch_totbnum
            // 
            this.ch_totbnum.Text = "总借书数";
            this.ch_totbnum.Width = 78;
            // 
            // ch_islost
            // 
            this.ch_islost.Text = "是否挂失";
            this.ch_islost.Width = 81;
            // 
            // ch_vionum
            // 
            this.ch_vionum.Text = "违规次数";
            this.ch_vionum.Width = 79;
            // 
            // ch_remark
            // 
            this.ch_remark.Text = "备注";
            // 
            // Frm_ManageReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ManageReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ManageReader_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ManageReader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cbBox_readertype;
        private System.Windows.Forms.TextBox txt_violatenum;
        private System.Windows.Forms.TextBox txt_totalbooknum;
        private System.Windows.Forms.TextBox txt_curbooknum;
        private System.Windows.Forms.DateTimePicker dateTime_valid;
        private System.Windows.Forms.DateTimePicker dateTime_register;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtn_isLost2;
        private System.Windows.Forms.RadioButton rbtn_isLost1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.ListView lv_Reader;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ch_rid;
        private System.Windows.Forms.ColumnHeader ch_rtid;
        private System.Windows.Forms.ColumnHeader ch_rname;
        private System.Windows.Forms.ColumnHeader ch_sex;
        private System.Windows.Forms.ColumnHeader ch_phone;
        private System.Windows.Forms.ColumnHeader ch_redate;
        private System.Windows.Forms.ColumnHeader ch_valdate;
        private System.Windows.Forms.ColumnHeader ch_curbnum;
        private System.Windows.Forms.ColumnHeader ch_totbnum;
        private System.Windows.Forms.ColumnHeader ch_islost;
        private System.Windows.Forms.ColumnHeader ch_vionum;
        private System.Windows.Forms.ColumnHeader ch_remark;
    }
}