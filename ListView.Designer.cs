using System.Windows.Forms;
namespace SubmitWindow
{
    partial class ListView
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
            this.cmbQueQuan = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvDSSV = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.rdbNu = new System.Windows.Forms.CheckBox();
            this.rdbNam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbQueQuan
            // 
            this.cmbQueQuan.FormattingEnabled = true;
            this.cmbQueQuan.Items.AddRange(new object[] {
            "TP HCM",
            "Hà Nội",
            "Bình Dương",
            "Sóc Trăng",
            "Vĩnh Long",
            "Đồng Nai",
            "Tiền Giang",
            "An Giang ",
            "Hậu Giang ",
            "Kiên Giang",
            "Huế",
            "Ninh Bình",
            "Thái Bình",
            "Quảng Nam",
            "Quảng Trị",
            "Quảng Ngãi",
            "Nha Trang",
            "Khánh Hoà"});
            this.cmbQueQuan.Location = new System.Drawing.Point(265, 125);
            this.cmbQueQuan.Name = "cmbQueQuan";
            this.cmbQueQuan.Size = new System.Drawing.Size(182, 33);
            this.cmbQueQuan.TabIndex = 22;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(265, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 31);
            this.txtHoTen.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(646, 445);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(354, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Cấu trúc dữ liệu",
            "Công nghệ phần mềm",
            "Lập trình Windows",
            "Trí tuệ nhân tạo",
            "Kỹ thuật lập trình",
            "Cơ sở dữ liệu"});
            this.clbMonHoc.Location = new System.Drawing.Point(265, 272);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(635, 144);
            this.clbMonHoc.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(717, 53);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(318, 31);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh sách sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giới tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Các môn học yêu thích :";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(586, 53);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(100, 25);
            this.txtNgaySinh.TabIndex = 12;
            this.txtNgaySinh.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quê quán :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ Tên :";
            // 
            // lsvDSSV
            // 
            this.lsvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvDSSV.Location = new System.Drawing.Point(54, 539);
            this.lsvDSSV.Name = "lsvDSSV";
            this.lsvDSSV.Size = new System.Drawing.Size(981, 223);
            this.lsvDSSV.TabIndex = 23;
            this.lsvDSSV.UseCompatibleStateImageBehavior = false;
            this.lsvDSSV.View = System.Windows.Forms.View.Details;
            this.lsvDSSV.SelectedIndexChanged += new System.EventHandler(this.lsvDSSV_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quê quán";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Môn học";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(878, 116);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(62, 29);
            this.rdbNu.TabIndex = 25;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(726, 116);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(76, 29);
            this.rdbNam.TabIndex = 24;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 783);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.lsvDSSV);
            this.Controls.Add(this.cmbQueQuan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListView";
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbQueQuan;
        private TextBox txtHoTen;
       
        private Button btnXoa;
        private Button btnThem;
        private CheckedListBox clbMonHoc;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label txtNgaySinh;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.ListView lsvDSSV;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox rdbNu;
        private System.Windows.Forms.CheckBox rdbNam;
    }
}