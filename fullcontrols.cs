using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubmitWindow
{
    public partial class fullcontrols : Form
    {
        public fullcontrols()
        {
            InitializeComponent();
        }

        private void fullcontrols_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdbNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";
            string monhoc = "";
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                if (clbMonHoc.GetItemChecked(i) == true)
                {
                    monhoc = monhoc + clbMonHoc.Items[i].ToString() + " , ";
                }
            }
            string[] row = new string[] {txtHoTen.Text, dtpNgaySinh.Text,
            cmbQueQuan.Text, gioitinh, monhoc};
            dgvDSSV.Rows.Add(row);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (this.dgvDSSV.SelectedRows.Count > 0 &&
             this.dgvDSSV.SelectedRows[0].Index !=
             this.dgvDSSV.Rows.Count - 1)
            {
                this.dgvDSSV.Rows.RemoveAt(
                    this.dgvDSSV.SelectedRows[0].Index);
            }
        }

       
    }
}
