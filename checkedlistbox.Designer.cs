using System.Windows.Forms;
namespace SubmitWindow
{
    partial class checkedlistbox
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
            this.clbList1 = new System.Windows.Forms.CheckedListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.clbList2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbList1
            // 
            this.clbList1.FormattingEnabled = true;
            this.clbList1.Items.AddRange(new object[] {
            "CTDL1",
            "CTDL2",
            "LTĐT",
            "CNPM",
            "LTWindows"});
            this.clbList1.Location = new System.Drawing.Point(45, 99);
            this.clbList1.Name = "clbList1";
            this.clbList1.Size = new System.Drawing.Size(180, 144);
            this.clbList1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(301, 60);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(301, 116);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(112, 34);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = ">";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(301, 181);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(112, 34);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // clbList2
            // 
            this.clbList2.FormattingEnabled = true;
            this.clbList2.Location = new System.Drawing.Point(508, 99);
            this.clbList2.Name = "clbList2";
            this.clbList2.Size = new System.Drawing.Size(180, 144);
            this.clbList2.TabIndex = 4;
            // 
            // checkedlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbList2);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.clbList1);
            this.Name = "checkedlistbox";
            this.Text = "checkedlistbox";
            this.Load += new System.EventHandler(this.checkedlistbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox clbList1;
        private Button btnShow;
        private Button btnToRight;
        private Button btnToLeft;
        private CheckedListBox clbList2;
    }
}