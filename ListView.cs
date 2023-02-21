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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] {
            txtHoTen.Text,
            dtpNgaySinh.Text,
            cmbQueQuan.Text,
            gioitinh,
            monhoc}, -1);
            lsvDSSV.Items.Add(listViewItem1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lsvDSSV.Items.RemoveAt(lsvDSSV.SelectedIndices[0]);
        }

        private void lsvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
