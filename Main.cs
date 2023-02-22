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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox(); 
            comboBox.ShowDialog();
        }

        private void checkedListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedlistbox form = new checkedlistbox();
            form.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();    
            listBox.ShowDialog();   
        }

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullcontrols dataGridView = new fullcontrols();
            dataGridView.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView listview  = new    ListView();
            listview.ShowDialog();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxx checkBoxx = new CheckBoxx();
            checkBoxx.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView tv = new treeView();
            tv.ShowDialog();
        }
    }
}
