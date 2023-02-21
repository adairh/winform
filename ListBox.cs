using System;
using System.Windows.Forms;

namespace SubmitWindow
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstListBox.Items.Add(txtItem.Text);
            txtItem.Text = null;
            txtItem.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          
                int index = lstListBox.SelectedIndex;
                lstListBox.Items.RemoveAt(index);
                lstListBox.Focus();
            
        }
    }
}