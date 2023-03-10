namespace Library1021
{
    partial class Frm_Fine
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Fine = new System.Windows.Forms.ListView();
            this.ch_fid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_mid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_fineprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isfin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_finetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_rid = new System.Windows.Forms.Label();
            this.ch_remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(348, 463);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 28);
            this.btn_back.TabIndex = 42;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Fine);
            this.groupBox2.Controls.Add(this.btn_Return);
            this.groupBox2.Location = new System.Drawing.Point(6, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 369);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "罚款记录列表";
            // 
            // lv_Fine
            // 
            this.lv_Fine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_fid,
            this.ch_bid,
            this.ch_mid,
            this.ch_fineprice,
            this.ch_isfin,
            this.ch_finetime,
            this.ch_remark});
            this.lv_Fine.FullRowSelect = true;
            this.lv_Fine.GridLines = true;
            this.lv_Fine.HideSelection = false;
            this.lv_Fine.Location = new System.Drawing.Point(6, 55);
            this.lv_Fine.MultiSelect = false;
            this.lv_Fine.Name = "lv_Fine";
            this.lv_Fine.Size = new System.Drawing.Size(770, 299);
            this.lv_Fine.TabIndex = 1;
            this.lv_Fine.UseCompatibleStateImageBehavior = false;
            this.lv_Fine.View = System.Windows.Forms.View.Details;
            this.lv_Fine.SelectedIndexChanged += new System.EventHandler(this.lv_Fine_SelectedIndexChanged);
            // 
            // ch_fid
            // 
            this.ch_fid.Text = "FID";
            this.ch_fid.Width = 80;
            // 
            // ch_bid
            // 
            this.ch_bid.Text = "BID";
            this.ch_bid.Width = 90;
            // 
            // ch_mid
            // 
            this.ch_mid.Text = "MID";
            this.ch_mid.Width = 75;
            // 
            // ch_fineprice
            // 
            this.ch_fineprice.Text = "罚款金额";
            this.ch_fineprice.Width = 83;
            // 
            // ch_isfin
            // 
            this.ch_isfin.Text = "是否交纳罚款";
            this.ch_isfin.Width = 106;
            // 
            // ch_finetime
            // 
            this.ch_finetime.Text = "交纳时间";
            this.ch_finetime.Width = 163;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(116, 0);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(91, 39);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.Text = "交纳罚款";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lbl_rid
            // 
            this.lbl_rid.AutoSize = true;
            this.lbl_rid.Location = new System.Drawing.Point(26, 31);
            this.lbl_rid.Name = "lbl_rid";
            this.lbl_rid.Size = new System.Drawing.Size(68, 15);
            this.lbl_rid.TabIndex = 43;
            this.lbl_rid.Text = "读者ID：";
            // 
            // ch_remark
            // 
            this.ch_remark.Text = "备注";
            this.ch_remark.Width = 131;
            // 
            // Frm_Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.lbl_rid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Fine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交纳罚款";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Fine_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Fine_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_Fine;
        private System.Windows.Forms.ColumnHeader ch_fid;
        private System.Windows.Forms.ColumnHeader ch_bid;
        private System.Windows.Forms.ColumnHeader ch_mid;
        private System.Windows.Forms.ColumnHeader ch_fineprice;
        private System.Windows.Forms.ColumnHeader ch_isfin;
        private System.Windows.Forms.ColumnHeader ch_finetime;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_rid;
        private System.Windows.Forms.ColumnHeader ch_remark;
    }
}