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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // clbList1
            // 
            this.clbList1.FormattingEnabled = true;
            this.clbList1.Items.AddRange(new object[] { "Paracetamol", "Aspirin", "Antacid", "Betadin", "Omeprazol" });
            this.clbList1.Location = new System.Drawing.Point(49, 31);
            this.clbList1.Margin = new System.Windows.Forms.Padding(2);
            this.clbList1.Name = "clbList1";
            this.clbList1.Size = new System.Drawing.Size(110, 64);
            this.clbList1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(208, 72);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 18);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(208, 101);
            this.btnToRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(67, 18);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = ">";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(208, 135);
            this.btnToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(67, 18);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // clbList2
            // 
            this.clbList2.FormattingEnabled = true;
            this.clbList2.Location = new System.Drawing.Point(49, 137);
            this.clbList2.Margin = new System.Windows.Forms.Padding(2);
            this.clbList2.Name = "clbList2";
            this.clbList2.Size = new System.Drawing.Size(110, 64);
            this.clbList2.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(319, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // checkedlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 252);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.clbList2);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.clbList1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "checkedlistbox";
            this.Text = "checkedlistbox";
            this.Load += new System.EventHandler(this.checkedlistbox_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.MonthCalendar monthCalendar1;

        #endregion

        private System.Windows.Forms.CheckedListBox clbList1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.CheckedListBox clbList2;
    }
}