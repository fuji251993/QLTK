namespace TangGiaoDien
{
    partial class FrTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrTraCuu));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl_TraCuu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.bttracuulai = new DevExpress.XtraEditors.SimpleButton();
            this.bttracuu = new DevExpress.XtraEditors.SimpleButton();
            this.dtngay2 = new System.Windows.Forms.DateTimePicker();
            this.dtngay1 = new System.Windows.Forms.DateTimePicker();
            this.txtloaitietkiem = new System.Windows.Forms.ComboBox();
            this.txttongtien2 = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txttongtien1 = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtkhachhang = new System.Windows.Forms.TextBox();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(259, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRA CỨU THÔNG TIN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tra Cứu Sổ Tiết Kiệm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl_TraCuu);
            this.groupBox2.Location = new System.Drawing.Point(6, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả Tra Cứu";
            // 
            // gridControl_TraCuu
            // 
            this.gridControl_TraCuu.Location = new System.Drawing.Point(6, 27);
            this.gridControl_TraCuu.MainView = this.gridView1;
            this.gridControl_TraCuu.Name = "gridControl_TraCuu";
            this.gridControl_TraCuu.Size = new System.Drawing.Size(914, 262);
            this.gridControl_TraCuu.TabIndex = 0;
            this.gridControl_TraCuu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl_TraCuu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số thứ tự";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã sổ";
            this.gridColumn2.FieldName = "MaSo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên loại tiết kiệm";
            this.gridColumn3.FieldName = "TenLoaiTietKiem";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên khách hàng";
            this.gridColumn4.FieldName = "TenKhachHang";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tổng tiền";
            this.gridColumn5.FieldName = "TongTien";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttinhtrang);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.bttracuulai);
            this.groupBox1.Controls.Add(this.bttracuu);
            this.groupBox1.Controls.Add(this.dtngay2);
            this.groupBox1.Controls.Add(this.dtngay1);
            this.groupBox1.Controls.Add(this.txtloaitietkiem);
            this.groupBox1.Controls.Add(this.txttongtien2);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.txttongtien1);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtkhachhang);
            this.groupBox1.Controls.Add(this.txtmaso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Theo: ";
            // 
            // btthoat
            // 
            this.btthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Appearance.Options.UseFont = true;
            this.btthoat.Location = new System.Drawing.Point(795, 180);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 40);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "THOÁT";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            this.btthoat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btthoat_KeyDown);
            // 
            // bttracuulai
            // 
            this.bttracuulai.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttracuulai.Appearance.Options.UseFont = true;
            this.bttracuulai.Location = new System.Drawing.Point(652, 181);
            this.bttracuulai.Name = "bttracuulai";
            this.bttracuulai.Size = new System.Drawing.Size(111, 40);
            this.bttracuulai.TabIndex = 11;
            this.bttracuulai.Text = "TRA CỨU LẠI";
            this.bttracuulai.Click += new System.EventHandler(this.bttracuulai_Click);
            this.bttracuulai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttracuulai_KeyDown);
            // 
            // bttracuu
            // 
            this.bttracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttracuu.Appearance.Options.UseFont = true;
            this.bttracuu.Location = new System.Drawing.Point(518, 180);
            this.bttracuu.Name = "bttracuu";
            this.bttracuu.Size = new System.Drawing.Size(100, 40);
            this.bttracuu.TabIndex = 10;
            this.bttracuu.Text = "TRA CỨU";
            this.bttracuu.Click += new System.EventHandler(this.bttracuu_Click);
            this.bttracuu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttracuu_KeyDown);
            // 
            // dtngay2
            // 
            this.dtngay2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtngay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngay2.Location = new System.Drawing.Point(358, 193);
            this.dtngay2.Name = "dtngay2";
            this.dtngay2.Size = new System.Drawing.Size(127, 28);
            this.dtngay2.TabIndex = 9;
            this.dtngay2.Visible = false;
            // 
            // dtngay1
            // 
            this.dtngay1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtngay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngay1.Location = new System.Drawing.Point(152, 193);
            this.dtngay1.Name = "dtngay1";
            this.dtngay1.Size = new System.Drawing.Size(150, 28);
            this.dtngay1.TabIndex = 8;
            this.dtngay1.Visible = false;
            // 
            // txtloaitietkiem
            // 
            this.txtloaitietkiem.FormattingEnabled = true;
            this.txtloaitietkiem.Location = new System.Drawing.Point(629, 35);
            this.txtloaitietkiem.Name = "txtloaitietkiem";
            this.txtloaitietkiem.Size = new System.Drawing.Size(123, 29);
            this.txtloaitietkiem.TabIndex = 1;
            // 
            // txttongtien2
            // 
            this.txttongtien2.Location = new System.Drawing.Point(358, 161);
            this.txttongtien2.Name = "txttongtien2";
            this.txttongtien2.Size = new System.Drawing.Size(127, 28);
            this.txttongtien2.TabIndex = 7;
            this.txttongtien2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien2_KeyPress);
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(629, 76);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(123, 28);
            this.txtcmnd.TabIndex = 3;
            // 
            // txttongtien1
            // 
            this.txttongtien1.Location = new System.Drawing.Point(152, 161);
            this.txttongtien1.Name = "txttongtien1";
            this.txttongtien1.Size = new System.Drawing.Size(150, 28);
            this.txttongtien1.TabIndex = 6;
            this.txttongtien1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien1_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(152, 119);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(333, 28);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtkhachhang
            // 
            this.txtkhachhang.Location = new System.Drawing.Point(152, 76);
            this.txtkhachhang.Name = "txtkhachhang";
            this.txtkhachhang.Size = new System.Drawing.Size(333, 28);
            this.txtkhachhang.TabIndex = 2;
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(152, 36);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(333, 28);
            this.txtmaso.TabIndex = 0;
            this.txtmaso.Tag = "0";
            this.txtmaso.TextChanged += new System.EventHandler(this.txtmaso_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(314, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "đến";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(314, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(11, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày Mở Sổ từ";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(11, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tổng Tiền từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(514, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(11, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(514, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(11, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(514, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Tiết Kiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sổ";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.FormattingEnabled = true;
            this.txttinhtrang.Items.AddRange(new object[] {
            "mở",
            "đóng"});
            this.txttinhtrang.Location = new System.Drawing.Point(629, 119);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(123, 29);
            this.txttinhtrang.TabIndex = 13;
            // 
            // FrTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrTraCuu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrTraCuu_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtngay2;
        private System.Windows.Forms.DateTimePicker dtngay1;
        private System.Windows.Forms.ComboBox txtloaitietkiem;
        private System.Windows.Forms.TextBox txttongtien2;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txttongtien1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtkhachhang;
        private System.Windows.Forms.TextBox txtmaso;
        private DevExpress.XtraEditors.SimpleButton btthoat;
        private DevExpress.XtraEditors.SimpleButton bttracuulai;
        private DevExpress.XtraEditors.SimpleButton bttracuu;
        private DevExpress.XtraGrid.GridControl gridControl_TraCuu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.ComboBox txttinhtrang;
    }
}