using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubmitWindow
{
    public partial class checkedlistbox : Form
    {
        public checkedlistbox()
        {
            InitializeComponent();
        }

        private void checkedlistbox_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string tam = "";
            for (int i = 0; i < clbList1.Items.Count; i++)
            {
                if (clbList1.GetItemChecked(i) == true)
                {
                    tam = tam + clbList1.Items[i].ToString() + " , ";
                }
            }
            MessageBox.Show(tam);
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbList1.Items.Count; i++)
            {
                if (clbList1.GetItemChecked(i) == true)
                {
                    clbList2.Items.Add(clbList1.Items[i]);
                    clbList1.Items.Remove(clbList1.Items[i]);
                }
            }

        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbList2.Items.Count; i++)
            {
                if (clbList2.GetItemChecked(i) == true)
                {
                    clbList1.Items.Add(clbList2.Items[i]);
                    clbList2.Items.Remove(clbList2.Items[i]);
                }
            }
        }
    }
}
